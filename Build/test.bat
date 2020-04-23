@echo off
SETLOCAL DisableDelayedExpansion
FOR /F "usebackq delims=" %%a in (`"findstr /n ^^ UnityInstallPath.txt"`) do (
    set "var=%%a"
    SETLOCAL EnableDelayedExpansion
    set "var=!var:*:=!"
    echo(!var!
    ENDLOCAL
)
ENDLOCAL
cmd