#!/usr/bin/env bash
set -euo pipefail

# Update local-only ignore rules in .git/info/exclude based on current branch.

START_MARK="# >>> managed-by-IgnoreScript >>>"
END_MARK="# <<< managed-by-IgnoreScript <<<"

REPO_ROOT="$(git rev-parse --show-toplevel 2>/dev/null || true)"
if [[ -z "$REPO_ROOT" ]]; then
	echo "Error: not inside a git repository."
	exit 1
fi

BRANCH="$(git -C "$REPO_ROOT" branch --show-current)"
EXCLUDE_FILE="$REPO_ROOT/.git/info/exclude"
TMP_FILE="$EXCLUDE_FILE.tmp"
SCRIPT_DIR="$(cd "$(dirname "$0")" && pwd)"
RULES_DIR="$SCRIPT_DIR/ignore-rules"

mkdir -p "$(dirname "$EXCLUDE_FILE")"
touch "$EXCLUDE_FILE"

rules_file_for_branch() {
	local branch="$1"
	local candidate="$RULES_DIR/$branch.txt"

	if [[ -f "$candidate" ]]; then
		echo "$candidate"
	else
		echo "$RULES_DIR/default.txt"
	fi
}

# Remove previously managed block, keep everything else untouched.
awk -v s="$START_MARK" -v e="$END_MARK" '
	$0 == s { skip = 1; next }
	$0 == e { skip = 0; next }
	!skip { print }
' "$EXCLUDE_FILE" > "$TMP_FILE"
mv "$TMP_FILE" "$EXCLUDE_FILE"

{
	echo
	echo "$START_MARK"
	echo "# branch: $BRANCH"
	RULE_FILE="$(rules_file_for_branch "$BRANCH")"
	if [[ -f "$RULE_FILE" ]]; then
		cat "$RULE_FILE"
	else
		echo "# no local ignore rules found"
	fi
	echo "$END_MARK"
} >> "$EXCLUDE_FILE"

echo "Updated $EXCLUDE_FILE for branch: $BRANCH"