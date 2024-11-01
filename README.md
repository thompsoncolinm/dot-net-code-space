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

## Project Directory

```
-| bin/
---| Debug/
------| net3.1
--------| <files included in the dependency>
```