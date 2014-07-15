#r @"FAKE\tools\FakeLib.dll"
open Fake

RestorePackages()

let name = "SkyFilter"
let solution = name + ".sln"
let builtAssembly = name + ".Azure.dll"
let publishDir = "./publish"
let buildDir = "./build"
let testDir = "./test"

let version = 
    match buildServer with
        | TeamCity -> buildVersion
        | _ -> "0.5.0"

Target "Clean" (fun _ -> CleanDirs [buildDir; testDir; publishDir])

Target "Build Library" (fun _ ->
    MSBuildRelease buildDir "Build" [solution]
    |> Log "Building app: "
)

Target "Build Tests" (fun _ -> 
    !! "*.Tests/**/*.csproj"
    |> MSBuildDebug testDir "Build"
    |> Log "Building tests: "
)

Target "Test" (fun _ ->
    !! (testDir @@ "*.Tests.dll")
    |> MSpec (fun p -> {p with HtmlOutputDir = testDir})
)

Target "Create NuGet Package" (fun _ ->
    CopyFiles publishDir !! (buildDir @@ builtAssembly)

    NuGet (fun p -> 
        {p with                               
            OutputPath = publishDir
            WorkingDir = publishDir
            Version = version
            Files = [builtAssembly, Some "lib/portable-net40+sl50+win+WindowsPhoneApp81+wp80", None] }) 
            "package.nuspec"
)

"Clean"
    ==> "Build Library"
    ==> "Build Tests"
    ==> "Test"
    ==> "Create NuGet Package"

RunTargetOrDefault "Test"