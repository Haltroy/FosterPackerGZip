# FosterPackerGZip

This package adds GZip algorithm support to Foster.

# Usage

1. Install this package from NuGet or clone this repository and add Project Reference to your project.
2. In your project's starting void (mostly Program.cs Main() void) add `new Foster.Modules.FosterPackerGZip.Register();`
3. You can now use Foster with GZip compression.

# Build
To build this package, .NET SDK must be installed. To build from command-line: `dotnet build`