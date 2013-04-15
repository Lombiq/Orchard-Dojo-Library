# Source Control Best Practices



The following advices apply to the Mercurial source control system and assume the usage of the TortoiseHg client. See the [Mercurial Kick Start](http://mercurial.aragost.com/kick-start/en/) for a more holistic tutorial.

- Try to only include changes corresponding to a single task in a commit.
- Use descriptive commit messages. If a commit corresponds to an issue tracker ticket start the message with the ticket number.
- When you rename a file tell Mercurial that you’ve renamed the file (you can use, there’s not a removed and an added one. This makes possible to maintain file history. You can also [let TortoiseHg automatically detect renames](http://tortoisehg.bitbucket.org/manual/2.0/guess.html).
- If you use branches for developing features prefix the branch names with something and use a pattern like "features/[branch name]" to make those branches distinguishable from other branches.
- Try to avoid merging branches with themselves. If you committed to a branch locally but meanwhile somebody else did the same first, after pulling do the following: instead of merging the two changesets rebase your changeset on top of the remote head. (See the [TortoiseHg Workbench documentation](http://tortoisehg.bitbucket.org/manual/2.0/workbench.html).)
- If you use an issue tracker then have issues open for every task. Then, having issues created, prefix commit messages with the issue ID, e.g. "#11: Fixing title". If you don't use an issue tracker or commit something not related to an issue but your code base is large and consists of multiple distinct sections then prefix your messages with the section name, e.g. "Media Management: Fixed image upload".