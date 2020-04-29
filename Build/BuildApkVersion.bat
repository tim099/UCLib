set /p UnityPath= <UnityInstallPath.txt
set "BuildSetting=ApkBuildSetting"

call Build.bat "%UnityPath%" "%BuildSetting%"