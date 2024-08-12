# Rules of thumb for refactoring

Consider [refactoring](http://en.wikipedia.org/wiki/Refactoring) in these cases:

- When a class’s net length is above 300 lines
- If the number of injected dependencies (services) exceeds 5
- If the number of arguments for a method exceeds 3
- It adds invaluable safety if you have unit tests for the code being refactored. If you don't have unit tests for a piece of code, before heavy refactoring is probably the good time to create them.
- Try not to over-engineer things. A typical and simple to detect sign of an over-complicated system is if you have classes that are almost exclusively proxying calls to other classes.

## Renaming a project

You should do the following steps to rename an existing .NET project (including an Orchard Core [module](../Wiki/Module.md) or [theme](../Wiki/Theme.md)).

1. Make a backup or commit to source control before attempting the rename.
2. Rename the project from inside Visual Studio. This will change the project's name in a lot of manifest files.
3. Search and replace the project's name in all files of the project or even of the solution (if you project's name is not a unique text be careful). This will rename all namespaces too.
4. Rename the project's folder (if it has one) to match the project's names. You'll have to re-add the project file under its new location to the solution as well as to other projects' references (if any).
