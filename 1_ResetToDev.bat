git fetch origin Dev
git reset --hard origin/Dev

git submodule update --init --remote --recursive
git submodule foreach -q --recursive "git checkout Dev;git pull origin Dev"

call A_SubmoduleUpdate.bat