rem git submodule foreach -q --recursive 'git checkout $(git config -f $toplevel/.gitmodules submodule.$name.branch || echo master)'
rem git submodule foreach -q --recursive 'branch="$(git config -f <path>.gitmodules submodule.$name.branch)"; git checkout $branch'

git submodule update --init --remote --recursive
git submodule foreach -q --recursive "git checkout Dev;git pull origin Dev"

cmd