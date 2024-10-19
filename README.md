# EOS_DLL
My attempt to make a EOS Emulator.\
Be warned, nothing is ready, and probably just an Experimentation :)\
Because I'm not good at C/C++ I wrote this in C# and use NativeAOT to make it into a normal DLL.

# Dependecy
This depends on .NET 8.
You also must have a c++ builder (GCC, MSVC, clang?)
Nuget Dependencies:
- LitJWT (for [fake] auth tokens)
- L (LLibrary - for logs)
- LiteNetLib (for networking)

# Help
If you wanna help you are feel free to do so.\
Most of the things grabbed from EOSSDK, and 2020's build of nemirtingas. (some code will be explicit convertion from C++ to C# )\
His build helps me a lot about understanding some of it.

# Download
Go to the github actions download your Main selected build.\
You might need to host Broadcast_Server for multiplayer games.

# Compilation
## Windows
### CLI
- Install .Net 8
- Download MSCV Tools for Visual Studio (?)
- Run this in cmd: `dotnet publish EOS_SDK/EOS_SDK.csproj -c Release -r win-x64 -o DLLs -p:Platform=x64`
### Visual Studio
- Select the Visual Studio Installer and click Modify.
- Select .NET Desktop development, Desktop development for C++.
- Presss Install while downloading.
- Open up the .sln project.
- Right Click on the EOS_SDK project, Select Publishing.
- Select your desired publishing platform. (Win64, Linux64, and soon more)
- Press publish.
## Linux
- Install .NET 8
- Note: Linux already has GCC installed.
- Run this command: `dotnet publish EOS_SDK/EOS_SDK.csproj -c Release -r linux-x64 -o DLLs -p:Platform=x64`
