# Code review guidelines

Doing static code reviews is a great way to improve code quality and share knowledge in a team.

- Read [this study](https://web.archive.org/web/20190620111040/http://www.ibm.com/developerworks/rational/library/11-proven-practices-for-peer-review/) about code reviews at Cisco; lot of good tips there. Also, [this article](https://www.codeproject.com/Articles/1156196/Code-Review-Checklist) is an ideal and simple checklist that can be used for code review.
- It's best to use a tool for code review where you can give comment for specific lines in the code. E.g. [GitHub](https://github.com/) and [Bitbucket](https://bitbucket.org/) both offer code line commenting for commits and pull requests. Unless the changes are trivial also open the source files in an IDE though, some issues stand out there better.
- When doing code reviews, don't just look at the code lines but also try to understand the whole component you review pieces of. This way you can also give your opinion about higher-level architectural decisions.
- If you want to optimize for a quick review turnaround then you can just look at the change from a user's perspective at first, i.e. you can try out the feature. Then, only when it works well, may you check out the code. Checking the code first and the UI only once you don't see any issues with the code can be a viable approach too.
- Pay attention to pinpoint all kinds of issues: e.g. architectural, logical, styling, maintainability issues all count.
- Don't just look at what's there but also think about what's missing (e.g. validation, error handling, access control...).
- If you see repeated issues with the code (e.g. the same mistake repeated all over the code base) then don't add the same comment multiple times. Either reference the other locations in a single comment (e.g. "This is also repeated in the other controllers here.") or if you're reviewing a bigger piece of code then collect such issues in a shared document (or a comment for the whole codebase if you tool allows it) and just reference them (e.g. "See CodeReview.docx #3").
