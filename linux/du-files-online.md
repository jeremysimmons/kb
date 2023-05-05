find largest files
find . -type f -exec du --human {} + | sort --human --reverse | head -n 50 | awk '{sum+=$1} END {print sum}'

find . -type f -exec du -a {} +

find . -type f -print0 | xargs -r0 du -a

Add for totals

| awk '{sum+=$1} END {print sum}'