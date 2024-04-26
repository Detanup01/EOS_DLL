#include <stddef.h>
#include <stdint.h>
#ifdef DNNE_COMPILE_AS_SOURCE
#include <dnne.h>
#else
// When used as a header file, the assumption is
// dnne.h will be next to this file.
#include "dnne.h"
#endif // !DNNE_COMPILE_AS_SOURCE

#ifndef DNNE_WINDOWS
__attribute__((constructor))
/**
 * initializer of the dylib.
 */
    static void Initializer(int argc, char** argv, char** envp)
{
    preload_runtime();
}

__attribute__((destructor))
/**
 * It is called when dylib is being unloaded.
 *
 */
    static void Finalizer()
{

}

#endif