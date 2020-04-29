set /p UnityPath= <UnityInstallPath.txt
set "BuildSetting=AABBuildSetting"

call Build.bat "%UnityPath%" "%BuildSetting%"