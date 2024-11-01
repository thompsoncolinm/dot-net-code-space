# .NET

## Environment setup

```
cd <Web Application Folder>
dotnet run
```

## Add packages to your .NET project

- Installing packages: Use the `dotnet add package <package name>` command to install a package, or use the .NET Core CLI to install packages.
- Finding packages: Packages can be found in the NuGet registry, or by visiting the package's dedicated <a href="https://www.nuget.org/packages/">website</a>.
- Managing dependencies: Use the `dotnet list package` command to view installed packages, and `dotnet remove package <name of dependency>` to remove unused packages.
- Restoring dependencies: Dependencies are restored automatically when you run commands like `new`, `build`, and `run`, but can be manually restored with the `dotnet restore` command.
- Find and update outdated packages: Use the `dotnet list package --outdated` command to list outdated packages and update them as needed.
- Read more on <a href="https://learn.microsoft.com/en-ca/training/modules/dotnet-dependencies/4-dependency-management">managing dependencies</a>

## Project Directory

```
-| bin/
---| Debug/
------| net3.1
--------| <files included in the dependency>
```

## Installing Bootstrap

Step 1: Install LibMan CLI
Open the Integrated Terminal in Visual Studio Code and run: `dotnet tool install -g Microsoft.Web.LibraryManager.Cli`

Step 2: Ensure .dotnet/tools is in Your PATH
Verify Installation Path

The global tools are typically installed in %USERPROFILE%\.dotnet\tools. Ensure this path is included in your system's PATH environment variable.

Add to PATH (if not already added)

Windows 10/11:
Press Win + X and select System.
Click on Advanced system settings.
Click Environment Variables.
Under User variables or System variables, find and select Path, then click Edit.
Click New and add %USERPROFILE%\.dotnet\tools.
Click OK to close all dialogs.
Step 3: Restart Visual Studio Code
After updating the PATH, restart Visual Studio Code to ensure the changes take effect.

Step 4: Verify LibMan Installation
In the Integrated Terminal, run: `libman --version`

Step 5: Install Bootstrap 4 Using LibMan
Open the Integrated Terminal in Visual Studio Code and run: `libman install bootstrap@4.6.0 -p cdnjs -d wwwroot/lib/bootstrap`

Step 6: Reference Bootstrap in Your Layout
Add the following lines to your _Layout.cshtml file within the <head> and before the closing </body> tag:

```
<!-- In the <head> section -->
<link rel="stylesheet" href="~/lib/bootstrap/css/bootstrap.min.css" />

<!-- Before </body> -->
<script src="~/lib/bootstrap/js/bootstrap.bundle.min.js"></script>
```

Step 7: Verify Installation
Rebuild and run your application: `dotnet run`