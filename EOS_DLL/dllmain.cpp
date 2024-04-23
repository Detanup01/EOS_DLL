#include "dnne.h"

#ifdef DNNE_WINDOWS
#define WIN32_LEAN_AND_MEAN
// Windows Header Files
#include <windows.h>
#include <iostream>
#include <fstream>
#include <string>
#include <filesystem>
#include "Detours/detours.h"

typedef LONG(WINAPI* WinVerifyTrust_t)(HWND hwnd, GUID* pgActionID, LPVOID pWVTData);

WinVerifyTrust_t oWinVerifyTrust = NULL;


LONG WINAPI DetourWinVerifyTrust(HWND hwnd, GUID* pgActionID, LPVOID pWVTData)
{
    return 0;
}

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
        HMODULE wintrust = GetModuleHandleA("wintrust.dll");
        DetourTransactionBegin();
        DetourUpdateThread(GetCurrentThread());
        oWinVerifyTrust = (decltype(oWinVerifyTrust))GetProcAddress(wintrust, "WinVerifyTrust");
        DetourAttach(&(PVOID&)oWinVerifyTrust, DetourWinVerifyTrust);
        DetourTransactionCommit();
    }
    break;
    case DLL_PROCESS_DETACH:
    {
        DetourTransactionBegin();
        DetourUpdateThread(GetCurrentThread());
        DetourDetach(&(PVOID&)oWinVerifyTrust, DetourWinVerifyTrust);
        DetourTransactionCommit();
    }
    break;
    }
    return TRUE;
}
#elif DNNE_MACOS
DNNE_EXTERN_C
__attribute__((constructor))
/**
 * initializer of the dylib.
 */
static void Initializer(int argc, char** argv, char** envp)
{
    preload_runtime();
}
#elif DNNE_LINUX
// -init elf_init on gcc
int elf_init(void)
{
    preload_runtime();
    return 1;
}
#endif