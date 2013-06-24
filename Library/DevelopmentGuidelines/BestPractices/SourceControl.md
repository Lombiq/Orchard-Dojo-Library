# Source control best practices



The following advices apply to the Mercurial source control system and assume the usage of the TortoiseHg client. See the [Mercurial Kick Start](http://mercurial.aragost.com/kick-start/en/) for a more holistic tutorial.


## Committing

- Try to only include changes corresponding to a single task in a commit.
- Use descriptive commit messages. If a commit corresponds to an issue tracker ticket start the message with the ticket number.
- When you rename a file tell Mercurial that you’ve renamed the file (you can use, there’s not a removed and an added one. This makes possible to maintain file history. You can also [let TortoiseHg automatically detect renames](http://tortoisehg.bitbucket.org/manual/2.0/guess.html).
- If you use an issue tracker then have issues open for every non-trivial task. Then, having issues created, prefix commit messages with the issue ID, e.g. "#11: Fixing title" or somehow reference issues. If you don't use an issue tracker or commit something not related to an issue but your code base is large and consists of multiple distinct sections then prefix your messages with the section name, e.g. "Media Management: Fixed image upload". You can even use the two technique at the same time.
- Discrete changes should go into discrete changesets. Try to avoid having multiple logical changes in the same commit as this will make it difficult to back out of certain changes if necessary.
- Commit often if you have finished something. If you have something working, or a section done, commit it. It will make much easier to track changes instead of having one big changeset. If you don't want to clutter everybody else's code base with half-ready changes then commit them to a feature branch. The only criterion a commit must meet is that it should compile properly.


## Branching

- If you use branches for developing features prefix the branch names with something and use a pattern like "features/[branch name]" to make those branches distinguishable from other branches.
- Try to avoid merging branches with themselves. If you committed to a branch locally but meanwhile somebody else did the same first, after pulling do the following: instead of merging the two changesets rebase your changeset on top of the remote head. (See the [Rebase documentation](http://mercurial.selenic.com/wiki/RebaseExtension) and the [TortoiseHg Workbench documentation](http://tortoisehg.bitbucket.org/manual/2.0/workbench.html).)
- When doing work in a temporal branch and want to merge the changes back to another branch and close the branch do it in the following order: close then merge and NOT merge then close as this will result in an unnecessary dangling head. See [this SO post](http://stackoverflow.com/a/9173483/220230) for more details.
- When doing work in a branch separated from the main line of development merge frequently from the main branch. Frequent, small merges are easier and less error-prone than big merges and also you'll be able to integrate your changes with the work done by others.
- See the excellent "[A Guide to Branching in Mercurial](http://stevelosh.com/blog/2009/08/a-guide-to-branching-in-mercurial/)".