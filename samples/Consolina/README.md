# Installing a NuGet Package

This seems like pretty random thing to do , because who doesnt know know how to install a NuGet package? Sometimes the red squigglys handles this for us and we just happen to be `using` that package and installing it with ease. This is just a quick run through on how you can do it via **`Visual Studio Code`** & **`Visual Studio`**

## Visual Studio Code

We'll be installing a NuGet package via the .NET CLI.

### Use case 

Don Capone started a job as a Junior .NET Developer, He needs a package in order to **`Serialize`** a JSON string.

Don heads over to **`nuget.org`** and searches for json. 

[image required](#)

After hitting up all the seniors in his company about this package, Don decides that **`Newtonsoft.Json`** is the one! 

[image required](#)

### Things to consider

- Downloads
- The last update 
- maybe the blue tick ? 
- Versions and support

Don has a project called Consolina , which is basically an object called Fruits which he would like to convert to a json string.

```csharp
public class Fruit
{
    public string? Name { get; set; }
    public string? Color { get; set; }
    public decimal Weight { get; set; }
    public bool IsRipe { get; set; }
}
```

In using Newtonsoft.Json simplifies this process of him manually having to set this up.

There's many ways to score a goal, its just our luck that it's a penalty.

We went with the .NET CLI

- Head over to your terminal
-  Run this command 

```bash
dotnet add package Newtonsoft.Json --version 13.0.3
```

Sucess !

If you happen to be using the Solution Explorer provided by the C# Dev Kit, you can double click on the project which would be your **`.csproj`** and AH HAH ! we got a package!

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net9.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Newtonsoft.Json" Version="13.0.3" />
  </ItemGroup>

</Project>

```

HOW DO WE USE IT DOE ?

There's some docs on NewtonSoft's website which you can find at [Serializing and Deserializing JSON](https://www.newtonsoft.com/json/help/html/SerializingJSON.htm)

Looking at his **`Program.cs`**

```csharp
using Newtonsoft.Json;

Fruit fruit = new()
{
    Name = "Apple",
    Color = "Red",
    Weight = 0.25M,
    IsRipe = true
};

string json = JsonConvert.SerializeObject(fruit, Formatting.Indented);
Console.WriteLine(json);

```

at this point you will have red squigglys saying this does not exisiting ? you can also hover over it and select quick fix which will allow you to add this package through something called **`using`**

A `using` statement in C# lets you access the package's features without typing its full namespace every time. 

HOW DO WE KNOW IT WORKS ??

Fair, CONSOLE LOGGINS !

After saving a couple times you can say:

```bash
dotnet build
```

now 

```bash
dotnet run
```
Then you should see a pretty familiar view in your terminal :)

[image required]()



## Visual Studio

Installing NuGet packages in Visual Studio is easy because it’s fully integrated,just a few clicks and the package is added to your project with all dependencies handled automatically.

To install **Newtonsoft.Json**:  
1. Right-click your project in Solution Explorer.  
2. Select "Manage NuGet Packages."  
3. Search for `Newtonsoft.Json`, select it, and click "Install." Done!



## Q&A: Common Questions About NuGet Packages

### **Technical Questions**

**Q1: What is a NuGet package?**  
A: A NuGet package is a compressed file containing compiled code (DLLs), other files, and metadata that helps integrate the package into your .NET project. It’s like a toolbox you can add to your project to save time and effort.

**Q2: How do I know which version of a package to install?**  
A: Check the package’s documentation or its page on **nuget.org**. Look for the latest stable version, and ensure it’s compatible with your project’s .NET version.

**Q3: What if I get a dependency conflict?**  
A: NuGet usually resolves dependencies automatically. If conflicts arise, try updating all packages to their latest versions or check the package’s documentation for compatibility notes.

**Q4: Can I use NuGet packages in non-.NET projects?**  
A: NuGet is designed for .NET projects. For other languages or frameworks, you’ll need their respective package managers (e.g., npm for JavaScript, pip for Python).

**Q5: How do I update a NuGet package?**  
A: In Visual Studio, go to "Manage NuGet Packages," find the installed package, and select a newer version. In Visual Studio Code, use the .NET CLI: `dotnet add package <PackageName> --version <NewVersion>`.

---

### **Non-Technical Questions**

**Q1: Why should I use NuGet packages?**  
A: NuGet packages save you time by providing pre-built functionality, so you don’t have to write everything from scratch. Think of it as borrowing tools instead of making them yourself.

**Q2: Is it safe to use NuGet packages?**  
A: Generally, yes! Packages on **nuget.org** are publicly vetted, and popular ones (like Newtonsoft.Json) are widely trusted. Always check the package’s downloads, ratings, and reviews.

**Q3: Do I need to pay for NuGet packages?**  
A: Most NuGet packages are free and open-source. Some may have premium versions or require a license, but these are clearly stated on the package’s page.

**Q4: What if I don’t know which package to use?**  
A: Search for keywords on **nuget.org** (e.g., "JSON") and look for popular packages with high download counts and good documentation. Ask your team or the community for recommendations.

**Q5: Can I remove a NuGet package if I don’t need it anymore?**  
A: Yes! In Visual Studio, go to "Manage NuGet Packages," find the package, and click "Uninstall." In Visual Studio Code, remove the `<PackageReference>` from your `.csproj` file.

