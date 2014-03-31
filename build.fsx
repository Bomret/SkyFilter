#r @"FAKE\tools\FakeLib.dll"
open Fake
open Fake.AssemblyInfoFile

RestorePackages()

let buildDir = "./build"
let net451Dir = buildDir + "/net451"
let net45Dir = buildDir + "/net45"

let testDir = "./test"
let packagingDir = "./package"
let testAssemblies = !! (testDir + "/*.Tests.dll")
let version = 
    match buildServer with
        | TeamCity -> buildVersion
        | _ -> "0.8"

Target "Clean" (fun _ -> CleanDirs [buildDir; testDir; packagingDir])

Target "BuildLib" (fun _ -> 
    CreateCSharpAssemblyInfo "SkyFilter.Azure/Properties/AssemblyInfo.cs"
        [Attribute.Title "SkyFilter"
         Attribute.Description "Easy creation and fluent combination of Microsoft Azure table filters."
         Attribute.Guid "7fcdf4e2-7bdd-4d22-ab1f-f326179cd022"
         Attribute.Product "SkyFilter"
         Attribute.Version version
         Attribute.FileVersion version]

    !! "SkyFilter.Azure/**/*.csproj"
    |> MSBuild net451Dir "Build" ["Configuration","Net451"]
    |> Log "Build output: "

    !! "SkyFilter.Azure/**/*.csproj"
    |> MSBuild net45Dir "Build" ["Configuration","Net45"]
    |> Log "Build output: "
)

Target "BuildTests" (fun _ -> 
    !! "SkyFilter.Azure.Tests/**/*.csproj"
    |> MSBuildDebug testDir "Build"
    |> Log "Test build output: "
)

Target "Test" (fun _ ->
    testAssemblies
        |> MSpec (fun p -> {p with HtmlOutputDir = testDir})
)

Target "CreatePackage" (fun _ ->
  CreateDir "package/lib/net451"
  CreateDir "package/lib/net45"

  CopyFile "package/lib/net451/SkyFilter.Azure.dll" "build/net451/SkyFilter.Azure.dll"
  CopyFile "package/lib/net45/SkyFilter.Azure.dll" "build/net45/SkyFilter.Azure.dll"

  NuGet (fun p ->
    {p with
        WorkingDir = packagingDir
        OutputPath = packagingDir
        Version = version
        Publish = false
            })
            "SkyFilter.Azure.nuspec"
)

"Clean"
    ==> "BuildLib"
    ==> "BuildTests"
    ==> "Test"
    ==> "CreatePackage"

RunTargetOrDefault "Test"