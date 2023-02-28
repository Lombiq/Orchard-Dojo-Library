# Source control best practices

The following advice applies to the Git source control system.

## Committing

- Try to only include changes corresponding to a single task in a commit. Discrete changes should go into discrete changesets. Try to avoid having multiple logical changes in the same commit as this will make it difficult to back out of certain changes if necessary.
- Push your commits often if you're working in a team.
- Use descriptive commit messages.
- Don't store assets (i.e. files generated from the source) in source control if possible, e.g. the `bin` and `obj` folder should be excluded.
- Commit often if you have finished something. If you have something working, or a section done, commit it. It will make much easier to track changes instead of having one big changeset. If your code is not affecting anybody else's work (because you're working in your own branch that won't be merged for a while) then the only criterion a commit must meet is that it should compile properly. This is to encourage frequent commits. If your code change affects somebody else's work too then of course you should take more care and test it.
- If your repository uses submodules: When you did some change to a submodule then always commit the submodule change into the main repo too in the end. The point is that everybody pulling the main repo will also get the current version of all submodules too. This doesn't mean that you have to make a main repo commit for each submodule commits (commits in the submodule can very well be more frequent), but once you're done with a batch of work, commit that to the main repo too. Because of the same reason never push to the submodule alone but rather push the main repo.

## Branching

- If you use an issue tracker then have issues open for every non-trivial task. Then, having issues created, somehow reference the issue from source control, like with conventional branch names.
- If you use branches for developing features prefix the branch names with something and use a pattern like "feature/[branch name]" to make those branches distinguishable from other branches.
- Try to avoid merging branches with themselves. If you committed to a branch locally but meanwhile somebody else did the same first then rebase instead.
- When doing work in a branch separated from the main line of development merge frequently from the main branch. Frequent, small merges are easier and less error-prone than big merges and also you'll be able to integrate your changes with the work done by others.
