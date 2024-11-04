# .NET

## Environment setup

```bash
cd <Web Application Folder>
dotnet run
```

## Add packages to your .NET project

- **Installing packages**: Use the `dotnet add package <package name>` command to install a package, or use the .NET Core CLI to install packages.
- **Finding packages**: Packages can be found in the NuGet registry, or by visiting the package's dedicated [website](https://www.nuget.org/packages/).
- **Managing dependencies**: Use the `dotnet list package` command to view installed packages, and `dotnet remove package <name of dependency>` to remove unused packages.
- **Restoring dependencies**: Dependencies are restored automatically when you run commands like `new`, `build`, and `run`, but can be manually restored with the `dotnet restore` command.
- **Find and update outdated packages**: Use the `dotnet list package --outdated` command to list outdated packages and update them as needed.
- **Read more on** [managing dependencies](https://learn.microsoft.com/en-ca/training/modules/dotnet-dependencies/4-dependency-management)

## Project Directory

```plaintext
-| bin/
---| Debug/
------| net3.1
--------| <files included in the dependency>
```

## Installing Bootstrap

### Step 1: Install LibMan CLI

Open the Integrated Terminal in Visual Studio Code and run:

```bash
dotnet tool install -g Microsoft.Web.LibraryManager.Cli
```

### Step 2: Ensure .dotnet/tools is in Your PATH

Verify Installation Path

The global tools are typically installed in `%USERPROFILE%\.dotnet\tools`. Ensure this path is included in your system's PATH environment variable.

#### Add to PATH (if not already added)

**Windows 10/11:**

1. Press `Win + X` and select **System**.
2. Click on **Advanced system settings**.
3. Click **Environment Variables**.
4. Under **User variables** or **System variables**, find and select **Path**, then click **Edit**.
5. Click **New** and add `%USERPROFILE%\.dotnet\tools`.
6. Click **OK** to close all dialogs.

### Step 3: Restart Visual Studio Code

After updating the PATH, restart Visual Studio Code to ensure the changes take effect.

### Step 4: Verify LibMan Installation

In the Integrated Terminal, run:

```bash
libman --version
```

### Step 5: Install Bootstrap 4 Using LibMan

Open the Integrated Terminal in Visual Studio Code and run:

```bash
libman install bootstrap@4.6.0 -p cdnjs -d wwwroot/lib/bootstrap
```

### Step 6: Reference Bootstrap in Your Layout

Add the following lines to your `_Layout.cshtml` file within the `<head>` and before the closing `</body>` tag:

```html
<!-- In the <head> section -->
<link rel="stylesheet" href="~/lib/bootstrap/css/bootstrap.min.css" />

<!-- Before </body> -->
<script src="~/lib/bootstrap/js/bootstrap.bundle.min.js"></script>
```

### Step 7: Verify Installation

Rebuild and run your application:

```bash
dotnet run
```

## Deploy on Azure

### Step 1: Install Azure CLI

If you haven't installed the Azure CLI yet, download and install it from [here](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli).

### Step 2: Log in to Azure

Open PowerShell or Command Prompt and log in to your Azure account:

```bash
az login
```

A browser window will open for you to authenticate. After successful login, you’ll see a list of your Azure subscriptions.

### Step 3: Navigate to Your Project Directory

Use the terminal to navigate to the root directory of your ASP.NET Core project:

```bash
cd path\to\your\project\WebApplication1
```

Replace `path\to\your\project\WebApplication1` with the actual path to your project.

### Step 4: Deploy the zip file with the command line arguments:

```
dotnet restore
dotnet build
dotnet publish -c Release -o ./publish
Compress-Archive -Path .\publish\* -DestinationPath .\publish.zip
az webapp deploy --resource-group TestGroup --name yourappname --src-path ".\publish.zip" --type zip
```

The URL with this name example would then be: `https://yourappname.azurewebsites.net`


### Alternatively: Deploy Using `az webapp up` (potentially unreliable)

The `az webapp up` command simplifies the deployment process by creating necessary Azure resources if they don't exist and deploying your application.

**Parameters:**

- `--name`: A unique name for your web app. This will be part of your app’s URL (e.g., `yourappname.azurewebsites.net`).
- `--resource-group`: Name of the Azure Resource Group. If it doesn't exist, it will be created.
- `--runtime`: Specifies the runtime stack. For .NET 8, use `"DOTNET|8.0"`.
- `--location`: Azure region where you want to deploy (e.g., "Central US", "East US", etc.).

**Example:**

```bash
az webapp up --name yourappname --resource-group yourresourcegroup --runtime "DOTNET|8.0" --location "Central US"
```

### Step 5: Verify Deployment

Once the deployment completes, Azure CLI will provide the URL of your deployed web app. Open your browser and navigate to:

```plaintext
https://yourappname.azurewebsites.net
```

Your application should now be live and accessible.

### Step 6: (Optional) Configure Continuous Deployment

For automatic deployments on code changes, consider linking your Azure App Service to a GitHub repository.

**In the Azure Portal:**

1. Navigate to your Web App.
2. Select **Deployment Center**.
3. Follow the prompts to connect to your GitHub repository and branch.

Every push to the connected branch will trigger a deployment automatically.

### Alternative: Deploy Using Visual Studio Code Azure Extension

If you prefer a graphical interface, use the Azure App Service extension in Visual Studio Code.

#### Install the Extension:

1. Go to the Extensions view (`Ctrl+Shift+X`).
2. Search for **Azure App Service** and install it.

#### Sign in to Azure:

1. Click on the Azure icon in the Activity Bar.
2. Sign in to your Azure account.

#### Deploy Your App:

1. Right-click on your project folder in the Explorer.
2. Select **Deploy to Web App**.
3. Follow the prompts to create a new Web App or select an existing one.

### Deploy the zip file with the command line arguments:

```
dotnet restore
dotnet build
dotnet publish -c Release -o ./publish
Compress-Archive -Path .\publish\* -DestinationPath .\publish.zip
az webapp deploy --resource-group TestGroup --name yourappname --src-path ".\publish.zip" --type zip
```

The URL with this name example would then be: `https://yourappname.azurewebsites.net`

### Additional Resources

- [Deploy an ASP.NET Core app to Azure](https://docs.microsoft.com/en-us/azure/app-service/quickstart-dotnetcore)
- [Azure App Service Documentation](https://docs.microsoft.com/en-us/azure/app-service/)