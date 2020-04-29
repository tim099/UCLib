set /p UnityPath= <UnityInstallPath.txt
set /p BuildSetting= <BuildSetting.txt


call Build.bat "%UnityPath%" "%BuildSetting%"