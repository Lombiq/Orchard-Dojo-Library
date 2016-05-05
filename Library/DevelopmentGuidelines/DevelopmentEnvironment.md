# Development environment advices



Some advices on how to set up your development environment for Orchard Development.


## Software to install

Below you can find pieces of software that you should install for the best Orchard developer experience.

- Visual Studio 2015 with the following plug-ins (where no download link is supplied you can install the extension from within VS via Extensions and Updates):
	- [Web Compiler](https://visualstudiogallery.msdn.microsoft.com/3b329021-cd7a-4a01-86fc-714c2d05bb6c) for better client-side development tooling.
	- [ASP.NET and Web Tools](https://visualstudiogallery.msdn.microsoft.com/c94a02e9-f2e9-4bad-a952-a63a967e3935) also for better client-side development tooling
	- [TestDriven.Net](http://www.testdriven.net/download.aspx) or [NUnit Test Adapter](http://nunit.org/index.php?p=vsTestAdapter&r=2.6.2) for running unit tests (beware with NUnit Test Adapter that you have to build the solution while Test Explorer is open to get tests discovered; then use "Group By -> Project" to see better).
	- [Productivity Power Tools 2015](https://visualstudiogallery.msdn.microsoft.com/34ebc6a2-2777-421d-8914-e29c1dfa7f5d)  mostly for the feature of being able to clean-up unneeded using statements and for re-opening files just closed.
	- [AttachToAny](https://visualstudiogallery.msdn.microsoft.com/83f369cf-9fac-4430-addf-fedacc0af919) for quickly attaching the debugger to an IIS (Express) process.
	- [SQL Server Compact & SQLite Toolbox](https://visualstudiogallery.msdn.microsoft.com/0e313dfd-be80-4afb-b5e9-6e74d369f7a1) for browsing an SQL CE database.
	- [Code Maid](http://www.codemaid.net/) for various goodies, including progress indicator for builds.
- [Web Platform Installer](http://www.microsoft.com/web/downloads/platform.aspx) for installing any necessary local developer tool or SDK. Install WebMatrix for simply browsing local SQL CE databases if you don't use the SQL Server Compact & SQLite Toolbox VS extension linked above.
- Local IIS and SQL Server (as well as SQL Server Management Studio) set up as per the following article: "[How-to: running Orchard locally through IIS using SQL Server](http://orcharddojo.net/blog/how-to-running-orchard-locally-through-iis-using-sql-server)"
- Firefox with the [Firebug](https://getfirebug.com/), [Web Developer](https://addons.mozilla.org/en-US/firefox/addon/web-developer/) and [HttpRequester](https://addons.mozilla.org/En-us/firefox/addon/httprequester/) (or [REST Easy](https://addons.mozilla.org/en-US/firefox/addon/rest-easy/)) extensions installed (or any other browser with similar developer-aiding tools).
- [Fiddler](http://www.telerik.com/fiddler) for inspecting any HTTP traffic. 


## Visual Studio tips

- Use [code snippets](http://msdn.microsoft.com/en-us/library/ms165392%28v=vs.80%29.aspx); try out [the ones in this package](../Utilities/VisualStudioSnippets/) too that specifically aid Orchard development.
- Use keyboard shortcuts. The most useful ones are:
	- F5: start with debugging
	- Ctrl+F5: start without debugging
	- F6: build
	- F10: run to the next line, when debugging
	- F11: step into the code on the current line (e.g. if the current line is a method call this will forward you to the body of the method), when debugging
	- Ctrl+F10: run to the cursor, when debugging
	- Ctrl+.: opens the [Smart Tag](http://haacked.com/archive/2008/06/23/visual-studio-smart-tag-expansion-tip.aspx)
	- Ctrl+Shift+Enter: adds a new line below the current line
	- F9: places a breakpoint on the current line
	- Ctrl+K, Ctrl+D: format document
	- Ctrl+K, Ctrl+C: comment selection
	- Ctrl+K, Ctrl+U: uncomment selection
	- Ctrl+,: opens the Navigate To windows (i.e. search for types or members)
	- Ctrl+D, Ctrl+E or Ctrl+Alt+E: opens the Exceptions configuration page. Tick Common Language Runtime Exceptions - Thrown to see all exceptions, even if they're caught.
	- Ctrl+Q to access the Quick Launch bar
	- Shift+Del: delete line
	- You may want to set up Ctrl+W for closing the current file for the File.Close command and Ctrl+Shift+T for Edit.UndoClose (only available if PowerCommands is installed).
- You may want to [always run VS as an administrator](http://stackoverflow.com/a/12859334/220230). This will simplify debugging web apps running in IIS since you can only attach a debugger to the IIS worker process if VS is run as an administrator.


## Mercurial and TortoiseHg tips

- Interact with Mercurial through the TortoiseHg Workbench. You can add a cloned repository to the Workbench by opening it from the repository folder: right click on the folder and select the Workbench.
- Use groups in the Repository Registry to group your repositories.
- See the [mercurial.ini in file in this package](Attachments/mercurial.ini) that you can use to initialize your Mercurial instance quickly with some useful settings. You can open your mercurial.ini file quickly from inside TortoiseHg by going to File/Settings/Edit File.
- .hgignore files (drop into the repositories' folders and rename to .hgignore):
	- [For Orchard modules and themes](Attachments/extensions.hgignore)
	- [For a complete Orchard solution](Attachments/solution.hgignore)