echo yey
echo %~dp0
call %~dp0/build_win_set_env.bat 64
call rc.exe /v /l 0 /g 0 /nologo /n /fo "%~dp0file.res" "%~dp0file.rc" 