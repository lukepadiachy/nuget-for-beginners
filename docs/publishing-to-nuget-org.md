# Publishing to NuGet.org

Publishing your NuGet package to NuGet.org makes it available for anyone to use. Here’s a step-by-step guide to get your package published, along with best practices to ensure your package is well-structured and easy to use.

Sidenote: This is a basic way to upload to nuget for beginners, but there is more to the story Ill be adding :).

---

## Step 1: Create an Account
1. Go to [NuGet.org](https://www.nuget.org/).
2. Click **Sign Up** and create an account using your email or GitHub/Microsoft account.
3. Verify your email address to complete the registration.

---

## Step 2: Get an API Key
To publish your package, you’ll need an API key. Here’s how to get one:
1. Log in to your NuGet.org account.
2. Click on your profile picture in the top-right corner and select **API Keys**.
3. Click **Create** to generate a new key.
   - **Key Name**: Give your key a descriptive name (e.g., “MyFirstPackage”).
   - **Package Scopes**: Leave this blank to allow the key to publish any package under your account.
4. Click **Create** and copy the API key. **Save it somewhere safe**, you won’t be able to see it again after leaving the page.

---

## Step 3: Publish the Package
Once you have your API key, you can publish your package using the .NET CLI.

1. Navigate to your project folder where the `.nupkg` file is located (usually in `bin/Release`).
2. Run the following command:
   ```bash
   dotnet nuget push bin/Release/MyFirstPackage.1.0.0.nupkg --api-key YOUR_API_KEY --source https://api.nuget.org/v3/index.json
   ```
   Replace `YOUR_API_KEY` with the API key you copied earlier.

3. Wait for the upload to complete. If successful, you’ll see a message like:
   ```
   Your package was pushed.
   ```

---

## What Happens Next?
- **Validation**: NuGet.org will validate your package to ensure it meets all requirements. This usually takes a few minutes.
- **Public Listing**: Once validated, your package will be publicly available on NuGet.org. You can search for it and view its page.

---

## Best Practices for Publishing NuGet Packages

Following best practices ensures your package is reliable, easy to use, and maintainable. Here are some key tips:

### 1. **Versioning**
- Use [Semantic Versioning (SemVer)](https://semver.org/) to manage your package versions (e.g., `1.0.0`, `1.0.1`, `2.0.0-beta`).
- Each package version must be unique. If you try to publish a package with the same version as an existing one, the upload will fail.

### 2. **Package Metadata**
Ensure your `.csproj` file includes all required metadata to make your package informative and discoverable:
```xml
<PropertyGroup>
  <PackageId>MyFirstPackage</PackageId>
  <Version>1.0.0</Version>
  <Authors>YourName</Authors>
  <Description>A simple utility for JSON serialization.</Description>
  <PackageTags>json, utility, serialization</PackageTags>
</PropertyGroup>
```

### 3. **Testing Locally**
Before publishing, test your package locally using a local NuGet feed. This ensures everything works as expected and avoids issues for users.

### 4. **Dependencies**
- Clearly define and minimize dependencies to avoid bloating your package.
- Ensure all dependencies are compatible with your target frameworks.

### 5. **Documentation**
- Include a `README.md` file in your package to provide usage instructions and examples.
- Add XML documentation comments to your code to generate IntelliSense-friendly documentation.

### 6. **Unlisting a Package**
If you make a mistake or want to hide a package, you can **unlist** it from NuGet.org. This removes it from search results but keeps it available for projects already using it.

For more detailed guidance, check out Microsoft’s official documentation:  
[**NuGet Package Authoring Best Practices**](https://learn.microsoft.com/en-us/nuget/create-packages/package-authoring-best-practices)

---

## Common Issues
- **Invalid API Key**: Double-check that you’ve entered the correct API key.
- **Duplicate Version**: Ensure the version number in your `.csproj` file is unique.
- **Missing Metadata**: Make sure your `.csproj` file includes all required fields like `PackageId`, `Version`, and `Description`.

---

## Next Steps

> ➡️ **[Tips and Common Issues](tips-and-common-issues.md)**
>
> Learn about versioning, dependencies, and troubleshooting common problems.

---

[Back to Main](../README.md#table-of-contents)

---

## Additional Resources
For beginners, check out this playlist on NuGet best practices and publishing:  
[**NuGet Beginner Videos**](https://youtu.be/R2Smy3bi_rM?si=V4S-HdCV-BOCBker)
