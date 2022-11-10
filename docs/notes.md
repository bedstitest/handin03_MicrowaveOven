## Notes for git commands

### Tags
Add tags on features for milestones such as:
1. When the solution can compile
2. Partial features
3. Addition of tests
WHERE IT MAKES SENSE :)

Remember to commit before tag
1. `git add -A`
2. `git commit -m "[nameOfCommit]` (no square brackets)
3. `git tag -a [tagID] -m "[tagMessage]` (no square brackets)


### Rebase features before merge.
Commands for rebasing:

1. `git switch feature/[featureName]`
2. `git rebase main`
3. `git switch main`
4. `git merge feature/[featureName]`


