cd UCL_Core
call "GitUpdate.bat"
cd..

cd UCL_Modules
set "ModulesPath=%cd%\"

for /d %%i in (%ModulesPath%*) do (
cd "%%i" 
call "GitUpdate.bat"
cd..
) 

git fetch --all
git reset --hard origin/Dev
git submodule update --recursive

cmd