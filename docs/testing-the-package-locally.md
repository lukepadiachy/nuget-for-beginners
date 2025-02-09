# Testing the Package Locally

Before publishing your NuGet package, it’s important to test it locally to ensure it works as expected. This guide will walk you through setting up a local NuGet feed and testing your package in another project.



## Why Test Locally?
Testing your package locally helps you:
- Catch issues early before publishing.
- Verify that your package works in a real project.
- Avoid breaking changes for users.



## Step 1: Set Up a Local Feed
A local feed is a folder on your computer where you can store and test NuGet packages.

1. Create a folder for your local feed:
   ```bash
   mkdir ~/local-nuget
   ```

2. Add the folder as a NuGet source:
   ```bash
   dotnet nuget add source ~/local-nuget -n LocalFeed
   ```

   - `~/local-nuget`: The folder where your packages will be stored.
   - `LocalFeed`: A name for your local feed (you can use any name).



## Step 2: Copy the Package
After building your package, move the `.nupkg` file to your local feed.

1. Build your package:
   ```bash
   dotnet pack --configuration Release
   ```

2. Locate the `.nupkg` file in the `bin/Release` folder of your project.

3. Move the `.nupkg` file to the `~/local-nuget` folder:
   ```bash
   cp bin/Release/MyFirstPackage.1.0.0.nupkg ~/local-nuget
   ```



## Step 3: Test in Another Project
Now that your package is in the local feed, you can test it in a new project.

1. Create a new console application:
   ```bash
   dotnet new console -o TestApp
   cd TestApp
   ```

2. Install your package from the local feed:
   ```bash
   dotnet add package MyFirstPackage --source ~/local-nuget
   ```

3. Use the package in your code. For example:
   ```csharp
   using MyFirstPackage;

   var calculator = new Calculator();
   Console.WriteLine(calculator.Add(2, 3)); // Output: 5
   ```

4. Run the project to verify everything works:
   ```bash
   dotnet run
   ```



## Tips for Testing
- **Check Dependencies**: If your package depends on other libraries, make sure they’re installed and working correctly.
- **Test Edge Cases**: Try using your package in different scenarios to ensure it behaves as expected.
- **Update and Re-Test**: If you make changes to your package, rebuild it, copy the new `.nupkg` file to the local feed, and update the test project:
   ```bash
   dotnet add package MyFirstPackage --version 1.0.1 --source ~/local-nuget
   ```



## Common Issues
- **Package Not Found**: Ensure the `.nupkg` file is in the correct folder and the local feed is added.
- **Version Conflicts**: If you update your package, make sure to increment the version number in the `.csproj` file.
- **Missing Dependencies**: If your package relies on other libraries, ensure they’re installed in the test project.



## Next Steps

> ➡️ **[Publishing to NuGet.org](publishing-to-nuget-org.md)**
>
> Once you’ve tested your package locally, you’re ready to publish it to NuGet.org and share it with the world.

---

[Back to Main](../README.md#table-of-contents)
