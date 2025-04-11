var target = Argument("target", "Default");

Task("Clean")
    .Does(() =>
{
    var folders = new [] {
        "./Hello-worldTooling/bin",
        "./Hello-worldTooling/obj",
        "./Hello-worldTooling.Tests/bin",
        "./Hello-worldTooling.Tests/obj",
        "./_site"
    };

    foreach (var folder in folders)
    {
        if (DirectoryExists(folder))
        {
            Information("Cleaning {0}", folder);
            try
            {
                CleanDirectory(folder);
            }
            catch (Exception ex)
            {
                Warning("Skipping {0}: {1}", folder, ex.Message);
            }
        }
    }
});

Task("Build")
    .Does(() =>
{
    DotNetBuild("./Hello-worldTooling/Hello-worldTooling.csproj");
});

Task("Test")
    .Does(() =>
{
    DotNetTest("./Hello-worldTooling.Tests/Hello-worldTooling.Tests.csproj");
});
Task("DocFX")
    .Does(() =>
{
    // Run DocFX metadata and build
    StartProcess("docfx", "metadata");
    StartProcess("docfx", "build");
});


Task("Default")
    .IsDependentOn("Clean")
    .IsDependentOn("Build")
    .IsDependentOn("Test")
    .IsDependentOn("DocFX");
    

RunTarget(target);
