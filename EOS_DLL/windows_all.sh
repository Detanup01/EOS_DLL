#!/bin/bash
export HOST_ARCH=x86
BUILD_TYPE=Release
OUT=build/win32/${BUILD_TYPE}

cmake_out_dir="$(pwd)/$OUT/cmake_libs"
CMAKE="cmake -G Ninja -Wno-dev -DCMAKE_PREFIX_PATH:PATH=${cmake_out_dir}"

$CMAKE -DX86=ON -DCMAKE_BUILD_TYPE=${BUILD_TYPE} -S . -B "${OUT}"
cmake --build "${OUT}"
cmake --install "${OUT}"


export HOST_ARCH=x64
BUILD_TYPE=Release
OUT=build/win64/${BUILD_TYPE}

cmake_out_dir="$(pwd)/$OUT/cmake_libs"
CMAKE="cmake -G Ninja -Wno-dev -DCMAKE_PREFIX_PATH:PATH=${cmake_out_dir}"

$CMAKE -DX64=ON -DCMAKE_BUILD_TYPE=${BUILD_TYPE} -S . -B "${OUT}"
cmake --build "${OUT}"
cmake --install "${OUT}"