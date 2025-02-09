# NuGet Package Creation Guide

## Step 1: Create a Class Library
To start, create a new class library project. Open your terminal and run the following commands:
```bash
dotnet new classlib -o MyFirstPackage
cd MyFirstPackage
```

## Step 2: Add Code
Next, you need to add some code to your library. Create a new class file named `Calculator.cs` in the project directory and add the following code:
```csharp
public class Calculator
{
    public int Add(int a, int b) => a + b;
}
```

## Step 3: Configure the Package
To configure your NuGet package, you need to edit the `.csproj` file. Open the `.csproj` file and include the following metadata:
```xml
<PropertyGroup>
  <PackageId>MyFirstPackage</PackageId>
  <Version>1.0.0</Version>
  <Authors>YourName</Authors>
  <Description>A simple calculator library.</Description>
</PropertyGroup>
```

## Step 4: Build the Package
Once your package is configured, you can build it. Run the following command in your terminal:
```bash
dotnet pack --configuration Release
```
This command will create a `.nupkg` file in the `bin/Release` folder of your project.

## Next Steps

> ➡️ **[Testing the Package Locally](testing-the-package-locally.md)**
>
> Set up a local feed and test your package in a real project environment.


[Back to Main](../README.md#table-of-contents)