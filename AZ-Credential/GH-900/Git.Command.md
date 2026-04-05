# Git CommandLine

## Git Status

```bash
git status <Options>
```

```bash
Changes not staged for commit:
  (use "git add/rm <file>..." to update what will be committed)
  (use "git restore <file>..." to discard changes in working directory)
        deleted:    HZ-Credential/GH-100/Git.md
        modified:   HZ-Credential/GH-100/READMD.md

Untracked files:
  (use "git add <file>..." to include in what will be committed)
        HZ-Credential/GH-900/
```

## Git Add

```bash
git Add <Options>
```

## Git Commit

```bash
git Commit <Options>
```

## Git Log

```bash
git log <Options>
```

```bash
commit ec01e5fcc865de28f34b5bd5437f926ad0ce98dc (HEAD -> GH, origin/GH)
Author: Harin <gunwoo8873@outlook.kr>
Date:   Tue Mar 24 21:56:00 2026 +0900

    Rename Directory

commit b89f90d799e14452cad23fb0e3204c843584c9a7
Author: Harin <gunwoo8873@outlook.kr>
Date:   Mon Mar 23 23:16:17 2026 +0900

    Add Git terminology section to documentation
```

## Git Help

```bash
git help
```

```bash
usage: git [-v | --version] [-h | --help] [-C <path>] [-c <name>=<value>]
           [--exec-path[=<path>]] [--html-path] [--man-path] [--info-path]        
           [-p | --paginate | -P | --no-pager] [--no-replace-objects] [--no-lazy-fetch]
           [--no-optional-locks] [--no-advice] [--bare] [--git-dir=<path>]        
           [--work-tree=<path>] [--namespace=<name>] [--config-env=<name>=<envvar>]
           <command> [<args>]

These are common Git commands used in various situations:

start a working area (see also: git help tutorial)
   clone      Clone a repository into a new directory
   init       Create an empty Git repository or reinitialize an existing one      

work on the current change (see also: git help everyday)
   add        Add file contents to the index
   mv         Move or rename a file, a directory, or a symlink
   restore    Restore working tree files
   rm         Remove files from the working tree and from the index

examine the history and state (see also: git help revisions)
   bisect     Use binary search to find the commit that introduced a bug
   diff       Show changes between commits, commit and working tree, etc
   grep       Print lines matching a pattern
   log        Show commit logs
   show       Show various types of objects
   status     Show the working tree status

grow, mark and tweak your common history
   backfill   Download missing objects in a partial clone
   branch     List, create, or delete branches
   commit     Record changes to the repository
   merge      Join two or more development histories together
   rebase     Reapply commits on top of another base tip
   reset      Set `HEAD` or the index to a known state
   switch     Switch branches
   tag        Create, list, delete or verify tags

collaborate (see also: git help workflows)
   fetch      Download objects and refs from another repository
   pull       Fetch from and integrate with another repository or a local branch  
   push       Update remote refs along with associated objects

'git help -a' and 'git help -g' list available subcommands and some
concept guides. See 'git help <command>' or 'git help <concept>'
to read about a specific subcommand or concept.
See 'git help git' for an overview of the system.
```