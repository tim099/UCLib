set /p UnityPath= <UnityInstallPath.txt
set "BuildSetting=Win64BuildSetting"
call Build.bat "%UnityPath%" "%BuildSetting%"