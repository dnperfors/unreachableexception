# UnreachableException for .NET 6 and .NET Framework

![GitHub](https://img.shields.io/github/license/dnperfors/unreachableexception) ![GitHub Workflow Status](https://img.shields.io/github/workflow/status/dnperfors/unreachableexception/CI) ![Nuget](https://img.shields.io/nuget/v/Perfors.UnreachableException)

.NET 7.0 introduces the System.Diagnostics.UnreachableException, however it is usefull to be able to use this exception before .NET 7, especially when you are in the process of migrating to the newer versions.
This library contains a drop in replacement for System.Diagnostics.UnreachableException.

## How to install

UnreachableException is released as a NuGet packages and can be installed via the NuGet manager in VisualStudio or by running the following command on the command line:
```
dotnet add package Perfors.UnreachableException
```

## How to use UnreachableException

```csharp
throw new System.Diagnostics.UnreachableException();
```

## Supported .NET versions

The Perfors.UnreachableException class is currently compiled against:
- .NET Standard 1.0
- .NET Standard 2.0
- .NET Standatd 2.1

And tested against:
- .NET Framework 4.6.2
- .NET Framework 4.7
- .NET Framework 4.8
- .NET 6.0
- .NET 7.0 (for reference)

## Contributing

If you found a bug, please provide a bug report and/or a PR.

## Versioning

This project uses [SemVer](http://semver.org/) for versioning.

## Authors

* **David Perfors** - [dnperfors](https://github.com/dnperfors)

## License

This project is released under the MIT license, see [LICENSE.md](LICENSE.md) for more information.

## Acknowledgments

This is basically a copy of the [original source code](https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/Diagnostics/UnreachableException.cs)