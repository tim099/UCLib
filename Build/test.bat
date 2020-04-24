@echo off
set UnityPath = "Null"
SETLOCAL DisableDelayedExpansion
FOR /F "usebackq delims=" %%a in (`"findstr /n ^^ UnityInstallPath.txt"`) do (
    set "var=%%a"
    SETLOCAL EnableDelayedExpansion
    set "var=!var:*:=!"
    set UnityPath = %var%
    echo !var!
    ENDLOCAL
)
ENDLOCAL
set /p var= <UnityInstallPath.txt
echo %var%
cmd