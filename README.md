## Frameworks supported
- .NET 3.5 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [RestSharp] (https://www.nuget.org/packages/RestSharp)
- [Json.NET] (https://www.nuget.org/packages/Newtonsoft.Json/)


NOTE: The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

## Setting up Nuget
- Download Nuget.exe from https://nuget.org/nuget.exe and make sure it's on your path
- Set our API key: ```nuget setApiKey xxxxxxx```

## Publishing to Nuget
- Update version number in ```Properties/AssemblyInfo.cs```
- Make sure the latest release DLL is built to ```bin/SquiggleApi.dll``` 
- Run these commands in the root of the repo (using correct version numbers for the nupkg file):
  ```
  nuget pack SquiggleApi.csproj
  nuget push SquiggleApi.x.x.x.x.nupkg
  ```