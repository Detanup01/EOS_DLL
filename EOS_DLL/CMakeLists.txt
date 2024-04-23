cmake_minimum_required(VERSION 3.10.0)

#project name
project (EOS_DLL)

if(X86 AND NOT X64)
  set(CMAKE_SIZEOF_VOID_P "4")
elseif(X64 AND NOT X86)
  set(CMAKE_SIZEOF_VOID_P "8")
else()
  message(FATAL_ERROR "Please define either -DX86=ON or -DX64=ON")
endif()

if(WIN32) # Setup some variables for Windows build
  if(X64)
    set(EPIC_API EOSSDK-Win64-Shipping)
    set(OUT_DIR win64)
    file(GLOB emu_sources
    EOSSDK-Win64-Shipping.cpp
    libs/Detours/creatwth.cpp
    libs/Detours/detours.cpp
    libs/Detours/disasm.cpp
    libs/Detours/disolarm.cpp
    libs/Detours/disolarm64.cpp
    libs/Detours/disolx64.cpp
    libs/Detours/disolx86.cpp
    libs/Detours/image.cpp
    libs/Detours/modules.cpp
    dllmain.cpp
    )
    target_link_libraries(${EPIC_API}
      PRIVATE

      ${CMAKE_SOURCE_DIR}/${EPIC_API}_native.lib
      Shlwapi.lib
    )
  elseif(X86)
    set(EPIC_API EOSSDK-Win32-Shipping)
    set(OUT_DIR win32)
    file(GLOB emu_sources
    EOSSDK-Win32-Shipping_native.cpp
    libs/Detours/creatwth.cpp
    libs/Detours/detours.cpp
    libs/Detours/disasm.cpp
    libs/Detours/disolarm.cpp
    libs/Detours/disolarm64.cpp
    libs/Detours/disolx64.cpp
    libs/Detours/disolx86.cpp
    libs/Detours/image.cpp
    libs/Detours/modules.cpp
    dllmain.cpp
    )
    target_link_libraries(${EPIC_API}
      PRIVATE

      ${CMAKE_SOURCE_DIR}/${EPIC_API}_native.lib
      Shlwapi.lib
    )
  else()
    message(FATAL_ERROR "Arch unknown")
  endif()
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /std:c++latest")

elseif(APPLE)
  if(X64)
	  set(OUT_DIR macosx64)
  elseif(X86)
	  set(OUT_DIR macosx32)
  else()
    message(FATAL_ERROR "Arch unknown")
  endif()

  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -stdlib=libc++")

  set(EPIC_API libEOSSDK-Mac-Shipping)
  file(GLOB emu_sources
  libEOSSDK-Mac-Shipping_native.cpp
  dllmain.cpp
  )
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -std=c++20")
  target_link_libraries(${EPIC_API}
      PRIVATE

      ${CMAKE_SOURCE_DIR}/${EPIC_API}_native.dynlib
    )

elseif(UNIX)
  if(X64)
    set(CMAKE_C_FLAGS             "${CMAKE_C_FLAGS} -m64")
    set(CMAKE_CXX_FLAGS           "${CMAKE_CXX_FLAGS} -m64")
    set(CMAKE_EXE_LINKER_FLAGS    "${CMAKE_EXE_LINKER_FLAGS} -m64")
    set(CMAKE_SHARED_LINKER_FLAGS "${CMAKE_EXE_LINKER_FLAGS} -m64")
	set(OUT_DIR linux64)
  elseif(X86)
    set(CMAKE_C_FLAGS             "${CMAKE_C_FLAGS} -m32")
    set(CMAKE_CXX_FLAGS           "${CMAKE_CXX_FLAGS} -m32")
    set(CMAKE_EXE_LINKER_FLAGS    "${CMAKE_EXE_LINKER_FLAGS} -m32")
    set(CMAKE_SHARED_LINKER_FLAGS "${CMAKE_EXE_LINKER_FLAGS} -m32")
	set(OUT_DIR linux32)
  else()
    message(FATAL_ERROR "Arch unknown")
  endif()
  set(EPIC_API libEOSSDK-Linux-Shipping)
  file(GLOB emu_sources
  libEOSSDK-Linux-Shipping_native.cpp
  dllmain.cpp
  )
    target_link_libraries(${EPIC_API}
      PRIVATE

      ${CMAKE_SOURCE_DIR}/${EPIC_API}_native.so
    )
  else()
    message(FATAL_ERROR "No CMake for other platforms")
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -std=c++20")
endif()





set(CMAKE_BUILD_TYPE "Release" CACHE STRING "Debug or Release")

set(custom_headers
 libs/Detours/
 libs
)

add_library(${EPIC_API}
  SHARED
  ${emu_sources}
)

set_target_properties(${EPIC_API} PROPERTIES
  MSVC_RUNTIME_LIBRARY "MultiThreaded$<$<CONFIG:Debug>:Debug>"
  POSITION_INDEPENDENT_CODE ON
  C_VISIBILITY_PRESET hidden
  CXX_VISIBILITY_PRESET hidden
  VISIBILITY_INLINES_HIDDEN ON
  MACHO_COMPATIBILITY_VERSION 4.26.0
  MACHO_CURRENT_VERSION 1454.72.26
)

if(UNIX)
  set_target_properties(${EPIC_API} PROPERTIES PREFIX "")
endif()


target_include_directories(${EPIC_API}
  PRIVATE
  ${CMAKE_CURRENT_BINARY_DIR}
  
  ${custom_headers}
)

target_compile_options(${EPIC_API}
  PRIVATE
  $<$<AND:$<CONFIG:>,$<BOOL:${MSVC}>>:/Zc:__cplusplus>
  $<$<BOOL:${MSVC}>:/MP>
  $<$<BOOL:${MSVC}>:/bigobj>
)

target_compile_definitions(${EPIC_API}
  PRIVATE
  EOS_BUILDING_SDK=1
  EOS_BUILD_DLL
  STBI_NO_SIMD
  $<$<BOOL:${MSVC}>:_CRT_SECURE_NO_WARNINGS>
  $<$<BOOL:${DISABLE_LOG}>:DISABLE_LOG>
)

target_link_options(${EPIC_API}
  PRIVATE
  $<$<AND:$<NOT:$<BOOL:${APPLE}>>,$<BOOL:${UNIX}>>:-Wl,--exclude-libs,ALL>
  $<$<AND:$<NOT:$<BOOL:${APPLE}>>,$<BOOL:${UNIX}>>:-Wl,--no-undefined>
)

set(CMAKE_INSTALL_PREFIX ${CMAKE_SOURCE_DIR})

if(${CMAKE_BUILD_TYPE} STREQUAL "Debug")
  set(OUT_DIR debug/${OUT_DIR})
else()
  set(OUT_DIR release/${OUT_DIR})
endif()

install(
  TARGETS ${EPIC_API}
  RUNTIME DESTINATION ${OUT_DIR}
  LIBRARY DESTINATION ${OUT_DIR}
)

install(FILES
  $<$<BOOL:${MSVC}>:$<TARGET_PDB_FILE:${EPIC_API}>> DESTINATION ${OUT_DIR}/pdb OPTIONAL
)