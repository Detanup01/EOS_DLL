#include <stddef.h>
#include <stdint.h>
#ifdef DNNE_COMPILE_AS_SOURCE
#include <dnne.h>
#else
// When used as a header file, the assumption is
// dnne.h will be next to this file.
#include "dnne.h"
#endif // !DNNE_COMPILE_AS_SOURCE

#ifdef DNNE_WINDOWS
#define WIN32_LEAN_AND_MEAN
#include <Windows.h>
BOOL APIENTRY DllMain(HMODULE hModule,
    DWORD  ul_reason_for_call,
    LPVOID lpReserved
)
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    {
        preload_runtime();
    }
    break;
    }
    return TRUE;
}
#endif