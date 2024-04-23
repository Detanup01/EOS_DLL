#!/bin/bash

OSX_ARCHITECTURE=x86_64
export OSXCROSS_HOST=${OSX_ARCHITECTURE}-apple-${OSXCROSS_TARGET}
BUILD_TYPE=Release
OUT=build/macosx64/${BUILD_TYPE}

cmake_out_dir="$(pwd)/$OUT/cmake_libs"
CMAKE="cmake -G Ninja -Wno-dev -DCMAKE_PREFIX_PATH:PATH=${cmake_out_dir} -DCMAKE_OSX_ARCHITECTURES=${OSX_ARCHITECTURE}"

$CMAKE -DX64=ON -DCMAKE_BUILD_TYPE=${BUILD_TYPE} -S . -B "${OUT}"
cmake --build "${OUT}"
cmake --install "${OUT}"