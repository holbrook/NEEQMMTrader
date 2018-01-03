#!/bin/bash
set -e
# gitbook install
# gitbook build
# cp assets/static/images/favicon.ico _book/gitbook/images/favicon.ico
cd _book
# echo 'holbrook.github.io' > CNAME
# rm -rf README.md
git init
git add .
git commit -m "update gitbook from master branch docs"
git push --force --quiet git@github.com:holbrook/MonoTrader.git master:gh-pages
