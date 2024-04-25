# EOS_DLL
My attempt to make a EOS Emulator.\
Be warned, nothing is ready, and probably just an Experimentation :)\
Because I'm not good at C/C++ I wrote this in C# and use DNNE to create a simple middleware between the generated C/C++ and the C# version.\
(And horrible written c++ stuff for loading the c/c++ side dll to load the C# one)

# Dependecy
This depends on .NET 8.
You also must have a c++ builder (GCC, MSVC, clang?)
Nuget Dependencies:
- JWT (for [fake] auth tokens)
- Newtonsoft.Json (Json)
- L (LLibrary - for logs)
- DNNE (C# to C's lib)
- LiteNetLib (for networking)

# Help
If you wanna help you are feel free to do so.\
Most of the things grabbed from EOSSDK, and 2020's build of nemirtingas. (some code will be explicit convertion from C++ to C# )\
His build helps me a lot about understanding some of it.

# Download
Go to the github actionss download your Main selected build and the CMake one.\
For example you need to have:
- EOSSDK-Win32-Shipping.dll (this to communicate to _native.dll)
- EOSSDK-Win32-Shipping_cs.deps.json (C#)
- EOSSDK-Win32-Shipping_cs.dll (C#)
- EOSSDK-Win32-Shipping_cs.runtimeconfig.json (C#)
- EOSSDK-Win32-Shipping_native.dll (C++ to C# Caller)
- JWT.dll (C#)
- L.dll (C#)
- Newtonsoft.Json.dll (C#)
- LiteNetLib.dll (C#)

# Why? 
Why you need to download 9 file to play a game?\
Well probably because _native isnt starting up nethostfx when inside dllmain. and this could create some issues.\
And also beacuse you cannot embed library inside your library.\
And also my very very limited knowledge for C++. I am so sorry but I  trying my best to understand that.
