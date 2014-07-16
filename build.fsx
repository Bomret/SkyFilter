#r @"FAKE\tools\FakeLib.dll"
open Fake
open Fake.AssemblyInfoFile

RestorePackages()

let name ="SkyFilter.Azure"
let description = "Easy creation and fluent combination of Microsoft Azure table filters."
let id = "63221f4d-32e7-4be9-98c0-65c61ea0cf27"
let authors = ["Stefan Reichel"]
let tags = "microsoft, windows, azure, cloud, table, filter, fluent"

let solution = "SkyFilter.sln"
let builtAssembly = name + ".dll"
let publishDir = "./publish"
let buildDir = "./build"
let testDir = "./test"

let version =
    match buildServer with
        | TeamCity -> buildVersion
        | _ -> "0.5.0"

Target "Clean" (fun _ -> CleanDirs [buildDir; testDir; publishDir])

Target "BuildLibrary" (fun _ ->
    CreateCSharpAssemblyInfo ("./" + name + "/Properties/AssemblyInfo.cs")
        [Attribute.Title name
         Attribute.Description description
         Attribute.Guid id
         Attribute.Product name
         Attribute.Version version
         Attribute.FileVersion version]

    MSBuildRelease buildDir "Build" [solution]
    |> Log "Building lib: "
)

Target "BuildTests" (fun _ ->
    !! "*.Tests/**/*.csproj"
    |> MSBuildDebug testDir "Build"
    |> Log "Building tests: "
)

Target "Test" (fun _ ->
    !! (testDir @@ "*.Tests.dll")
    |> MSpec (fun p -> {p with HtmlOutputDir = testDir})
)

Target "Package" (fun _ ->
    CopyFiles publishDir !! (buildDir @@ builtAssembly)

    NuGet (fun p ->
        {p with
            Project = name
            Authors = authors
            Description = description
            Tags = tags
            Version = version
            OutputPath = publishDir
            WorkingDir = publishDir
            Files = [builtAssembly, Some "lib/portable-net40+sl50+win+wpa81+wp80", None] })
            "package.nuspec"
)

"Clean"
    ==> "BuildLibrary"
    ==> "BuildTests"
    ==> "Test"
    ==> "Package"

RunTargetOrDefault "Test"
