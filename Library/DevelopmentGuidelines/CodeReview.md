# Code review guidelines



Doing static code reviews is a great way to improve code quality and share knowledge in a team.

- Read [this study](http://www.ibm.com/developerworks/rational/library/11-proven-practices-for-peer-review/) about code reviews at Cisco; lot of good tips there.
- It's best to use a tool for code review where you can give comment for specific lines in the code. [Bitbucket](https://bitbucket.org/) and [GitHub](https://github.com/) both offer code line commenting for commits and pull requests. On Bitbucket you can "approve" commits and you can use this feauture during code reviews: when you reviewed a commit and found everything all right, then just approve it; otherwise, make comments on the code lines or the whole commit. Then later when all of your comments were addressed, you can approve that commit too. This way approval marks always show which commits shouldn't be dealt with any more.
- When doing code review, not just look at the code lines but also try to understand the whole component you review pieces of. This way you can also give you opinion about higher-level architectural decisions.
- If you see repeated issues with the code (e.g. the same mistake repeated all over the code base) then don't add the same comment multiple times. Either reference the other locations in a single comment (e.g. "This is also repeated in the other controllers here.") or if you're reviewing a bigger piece of code then collect such issues in a shared document and just reference them (e.g. "See CodeReview.docx #3").
- If you want to make remarks for something that is repeated all over the codebase but it wouldn't make sense to point out for every relevant line of code  or is generally relevant (e.g. some general code styling issue) then add it to a common location (again this can be a shared document, or a comment for the whole codebase if you tool allows it).
- During the core review you can find issues of high importance, such as critical security problems. Apart from adding these to the affected piece of code also separately collect them to make them apparent.