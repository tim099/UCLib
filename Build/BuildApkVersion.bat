set "UnityPath=C:\Program Files\Unity\Hub\Editor\2019.2.17f1\Editor\Unity.exe"
set "TargetPath=%cd%\"

@echo off
call :GetDirParentN ProjectPath "%TargetPath%" ".."
echo ProjectPath:            "%ProjectPath%"
@echo on

"%UnityPath%" -projectPath "%ProjectPath%" -quit -batchmode -executeMethod UCL.BuildLib.UCL_BuildSetting.BuildBySetting -output "%TargetPath%" -logFile build.log -buildsetting ApkBuildSetting

cmd


:GetFileBaseDir
    :: sets the value to dirFileBase variable
    set "%~1=%~dp2"
    exit /b 0

:GetFileBaseDirWithoutEndSlash
    set "dirWithBackSlash=%~dp2"
    REM substring from the start to the end minus 1 char from the end
    set "%~1=%dirWithBackSlash:~0,-1%"
    exit /b 0

:GetDirParentN
    for %%I in ("%~2\%~3") do set "%~1=%%~fI"
    exit /b 0