set /p UnityPath= <UnityInstallPath.txt
set "BuildSetting=AOCWin64BuildSetting"

call Build.bat "%UnityPath%" "%BuildSetting%"