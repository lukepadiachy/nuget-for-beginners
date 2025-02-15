# Prerequisites

Before creating your first NuGet package, make sure you have the following tools and skills ready:

---

## Required Tools

1. **.NET SDK**  
   - Download the latest LTS (Long-Term Support) version from [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).  
   - Verify installation:  
     ```bash
     dotnet --version
     ```

2. **Code Editor**  
   - Use **Visual Studio 2022** (Community, Professional, or Enterprise) or **Visual Studio Code** with the C# extension.  
   - Visual Studio Download: [visualstudio.microsoft.com](https://visualstudio.microsoft.com/)  
   - VS Code Download: [code.visualstudio.com](https://code.visualstudio.com/)  

3. **NuGet CLI**  
   - The NuGet CLI is included with the .NET SDK, so no separate installation is needed.  
   - Verify it’s available:  
     ```bash
     dotnet nuget --version
     ```

---

## Optional Tools

1. **NuGet Package Explorer**  
   - A graphical tool to inspect, edit, and create NuGet packages.  
   - Download: [NuGet Package Explorer](https://github.com/NuGetPackageExplorer/NuGetPackageExplorer)  

2. **NuGet.org Account**  
   - Required only if you plan to publish your package to the public NuGet gallery.  
   - Sign up: [NuGet.org](https://www.nuget.org/)  

---

## Skills

To get started, you should have:
- **Basic C# Knowledge**: Familiarity with writing and compiling C# code.  
- **Understanding of .NET Project Structure**: Know how .NET projects are organized (e.g., `.csproj` files, folders, and references).  
- **Command Line Basics**: Comfort with running commands in a terminal (e.g., `dotnet`, `cd`, `dir`/`ls`).  

---

## Quick Start

If you’re ready to dive in, here’s what you’ll need to do:
1. Install the .NET SDK and a code editor.  
2. Open a terminal and verify your tools are installed:  
   ```bash
   dotnet --version
   dotnet nuget --version
   ```
3. Create a new class library project:  
   ```bash
   dotnet new classlib -o MyFirstPackage
   ```

---

### .NET Standard vs. .NET Framework vs. NuGet Packages in Context

When you're working with NuGet, If you're **creating** or **consuming** packages, understanding the target framework matters. Here's how the different frameworks fit in:

#### 1. **.NET Standard in NuGet**

- **Creating a Package**:  
  When you create a NuGet package targeting **.NET Standard**, you're ensuring that your package can be **used across multiple .NET implementations**. That means your package will be compatible with **.NET Core**, **.NET Framework**, **Xamarin**, and others that support the version of .NET Standard you target.
  - **Example**: If you want your library to be usable by both .NET Framework and .NET Core developers, you'd target .NET Standard.
  
- **Consuming a Package**:  
  If you're consuming a **.NET Standard**-based package, it can work on any platform that supports **that version of .NET Standard**. It provides great flexibility for cross-platform development.
  - **Example**: If you use a NuGet package that targets .NET Standard 2.0, you can use it in your **.NET Framework 4.6.1** or **.NET Core 3.1** application.

#### 2. **.NET Framework in NuGet**

- **Creating a Package**:  
  A **.NET Framework**-targeted package is meant to be used only within the **.NET Framework** environment. It's not cross-platform. So if you're working on a package meant to run only on Windows, targeting .NET Framework makes sense.
  - **Example**: If you're building a Windows desktop application library that uses **Windows Forms** or **WPF**, you'll create a NuGet package targeting **.NET Framework**.

- **Consuming a Package**:  
  If you're consuming a **.NET Framework**-targeted NuGet package, you're limited to **.NET Framework** projects (e.g., Windows apps). It won't work with **.NET Core** or **Xamarin** without modification.
  - **Example**: You’re working on a legacy Windows application, and you consume a package specifically built for **.NET Framework**.

#### 3. **NuGet Packages (General)**

- **Creating a NuGet Package**:  
  Regardless of whether you're targeting **.NET Standard**, **.NET Framework**, or **.NET Core**, the NuGet packaging process remains similar. You wrap your compiled code, metadata, and any dependencies into a `.nupkg` file and upload it to a repository like **NuGet Gallery**.
  - **Example**: You may want to create a package that targets **.NET Core 3.1** for web applications or a **.NET Standard** package for libraries.

- **Consuming a NuGet Package**:  
  The way you consume a package depends on the framework your project is using. NuGet handles resolving dependencies, so if you're using **.NET Core** and you want a package targeting **.NET Framework**, NuGet will warn you about compatibility issues.
  - **Example**: You might install a **.NET Standard** package into a **.NET Core** project, but a **.NET Framework**-specific package won’t be usable in a **.NET Core** project.

- **.NET Standard** is designed to be **cross-platform**—great for reusable libraries across different .NET frameworks.
- **.NET Framework** packages are **Windows-only** and won't work across other platforms (like .NET Core or Xamarin).
- NuGet packages are the **containers** (the `.nupkg` file) for libraries, and you can target different .NET platforms to make them usable across specific projects.

---

## Next Steps

> ➡️ **[Creating a NuGet Package](creating-a-nuget-package.md)**
>
> Learn how to structure your project and define package metadata.


---

[Back to Main](../README.md#table-of-contents)
