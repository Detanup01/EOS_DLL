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

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
        case DLL_PROCESS_ATTACH:
        {
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