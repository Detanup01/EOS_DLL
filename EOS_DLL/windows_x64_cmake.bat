@echo off
rem Windows64
set BUILD_TYPE=Release
set OUT=build\win64\Release
set cmake_out_dir=!cd!\!OUT!\cmake_libs
  
set CMAKE=cmake -G "Visual Studio 17 2022" -A x64 -Wno-dev -DCMAKE_PREFIX_PATH:PATH=!cmake_out_dir!
  
!CMAKE! -DX64=ON -DCMAKE_BUILD_TYPE=!BUILD_TYPE! -S . -B !OUT!
cmake --build "!OUT!" --config !BUILD_TYPE!
cmake --install "!OUT!" --config !BUILD_TYPE!