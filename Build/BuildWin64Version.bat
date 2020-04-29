set /p UnityPath= <UnityInstallPath.txt
set "TargetPath=%cd%\"
call Build.bat "%UnityPath%" "%BuildSetting%"