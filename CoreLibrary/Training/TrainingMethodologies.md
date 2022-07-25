# Training methodologies

Following are methodologies for various forms of Orchard Core trainings.

- Remember that it's a good thing to have regular breaks within every hour.
- Keep the time between explaining something new and demonstrating it short; i.e. if you explain something, show it.
- After a session (lesson, tutorial video...) do a quick recap of what was covered: click through what was explained and briefly mention again if there is something to emphasize.
- Utilize the [Visual Studio snippets](../../CoreLibrary/Utilities/VisualStudioSnippets/) to write code quickly instead of typing out everything. Use the [Utility Scripts](https://github.com/Lombiq/Utility-Scripts) to speed up common tasks like creating an Orchard Visual Studio solution.
- We've created a demo module for the purpose of teaching all the topics here with well explained examples, the [Orchard Training Demo module](https://github.com/Lombiq/Orchard-Training-Demo-Module). The training topics loosely follow the Training Demo. If you want to use the Training Demo as a reference when giving a training, even copy-pasting from it then the [Comment Remover](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.CommentRemover) Visual Studio extension can come handy: You can remove the Training Demo's comments so they're not clutter while you explain the same thing.
- Suggest further resources and reading materials for attendees, e.g.:
  - [Official docs](https://docs.orchardcore.net/)
  - [Orchard Dojo Library](https://orcharddojo.net/orchard-resources/CoreLibrary/), especially [Software development guidelines](https://orcharddojo.net/orchard-resources/CoreLibrary/DevelopmentGuidelines/) and [Development utilities](https://orcharddojo.net/orchard-resources/CoreLibrary/Utilities/) (including Visual Studio code snippets and the Utility Scripts project)
  - [Lombiq Training Demo module](https://github.com/Lombiq/Orchard-Training-Demo-Module)

## University course

### Class work and examination

#### Lesson structure

Every lesson begins with a short warm-up task incorporating the topics of the previous lesson.

Lessons generally have repeated cycles of the following form:

1. Presentation: the course leader explains the current topic (10-15 minutes), if the content is practical (like doing some dashboard work) students follow individually
2. Group work
 - After hearing the presentation about how to solve a certain problem students are encouraged to try out the new techniques for given tasks in form of a group work. The task either
  - consists of the topic demonstrated before
  - or is something slightly new that can be derived from the demonstration or learned by reading a short documentation.
 The former one is a good choice if there is enough time, the latter one is efficient if there's only limited time available.
 - Groups of 2-3-4 try to solve a problem while the course leader is helping their work and is available for questions
3. Evaluation of the group work: discussing common questions and issues

#### Examination

The course has no special examination, instead students should create and finish and Orchard-based web application project.

- Students form teams of arbitrary size (it’s also possible to work alone)
- Every team’s task is to create a real-world Orchard-based web application
- There are no limitations or obligations to that, although the groups are encouraged to develop one custom module that uses existing Orchard features in a creative way but doesn’t replicate any built-in functionality
- One student gives a presentation of the project after completing it with a maximal length of 5 minutes. The presentation should be a live demonstration of the web application. After the presentations the course leader has very brief code review sections with all of the other students were the students present a section of their software, demonstrating their understanding.

### Schedule

Additional is the time needed for student presentations (depends on the number of attendees) since the course’s final lesson consists of student presentations and code reviews.

## Intensive course

Since intensive courses should be tailored to the participants' needs the following points are just outlines and tips. Time constraint is also a factor that determines how in-depth the training can be, how many demonstrations can be carried out and how big is the part of the API that's only shown.

- Live demonstration of the usage of Orchard APIs.
- Live demonstration of some inner workings with t.he debugger (e.g. demonstrating how the tree of shapes is built up)
- Showing aspects of the Orchard API without running them just so participants can get to know what piece of API to look for when they want to achieve something (e.g. `IMediaFileStore` is a good candidate: it's easy to use but one needs to know about it).
- Few hour-long hackathon with a certain aim (e.g. to develop a module that's needed by the participants)
- Code review: participants write some code on their own, then the trainer checks them and comments on them line by line with code review tools. Common mistakes can be discussed with the whole group.

If the course is online:

- Record the sessions if the client would like it.
- Break days can be added too, with no training taking place: That way participants can catch up with their daily activities, have a chance to digest what was learned, are encouraged to try out everything themselves, and come back with questions for the next occasion.
- It's easier to keep the meeting running for short breaks. When participants come back they can signal that they're present with the "raise hand" feature many webmeeting tools have.
