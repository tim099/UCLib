set "TargetPath=%cd%\"
set /p SubmodulePath=Please Enter SubmodulePath:


git submodule deinit "%SubmodulePath%"
git rm --cached "%SubmodulePath%"
git commit -am "Remove submodule %SubmodulePath%" 
cmd