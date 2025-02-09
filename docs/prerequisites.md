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

## Next Steps

> ➡️ **[Creating a NuGet Package](creating-a-nuget-package.md)**
>
> Learn how to structure your project and define package metadata.


---

[Back to Main](../README.md#table-of-contents)
