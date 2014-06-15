# Development environment advices



Some advices on how to set up your development environment for Orchard Development.


## Software to install

Below you can find pieces of software that you should install for the best Orchard developer experience.

- Visual Studio 2012 or 2013 (preferably non-Express) with the following plug-ins (where no download link is supplied you can install the extension from within VS via Extensions and Updates):
	- [Web Essentials](http://vswebessentials.com/) for better client-side development tooling.
	- [ASP.NET and Web Tools](http://www.asp.net/vnext/overview/latest) also for better client-side development tooling
	- [TestDriven.Net](http://www.testdriven.net/dow.nload.aspx) or [NUnit Test Adapter](http://nunit.org/index.php?p=vsTestAdapter&r=2.6.2) for running unit tests.
	- [Productivity Power Tools 2013](http://visualstudiogallery.msdn.microsoft.com/dbcb8670-889e-4a54-a226-a48a15e4cace) ([Productivity Power Tools 2012](http://visualstudiogallery.msdn.microsoft.com/3a96a4dc-ba9c-4589-92c5-640e07332afd) for VS 2012) mostly for the feature of being able to clean-up unneeded using statements and for re-opening files just closed.
	- [AttachToAny](http://visualstudiogallery.msdn.microsoft.com/81677d17-6e81-4f14-87cc-4ccee2fd2589) ([AttachTo](http://visualstudiogallery.msdn.microsoft.com/d0265ab0-df51-4100-8e10-1f84403c4cd0) for VS 2012) for quickly attaching the debugger to an IIS (Express) process.
	- [Code Maid](http://www.codemaid.net/) for various goodies, including progress indicator for builds.
- [Web Platform Installer](http://www.microsoft.com/web/downloads/platform.aspx) for installing any necessary local developer tool or SDK. Install WebMatrix for simply browsing local SQL CE databases.
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


## Mercurial and TortoiseHg tips

- Interact with Mercurial through the TortoiseHg Workbench. You can add a cloned repository to the Workbench by opening it from the repository folder: right click on the folder and select the Workbench.
- Use groups in the Repository Registry to group your repositories.
- See the [mercurial.ini in file in this package](Attachments/mercurial.ini) that you can use to initialize your Mercurial instance quickly with some useful settings.
- .hgignore files (drop into the repositories' folders and rename to .hgignore):
	- [For Orchard modules and themes](Attachments/extensions.hgignore)
	- [For a complete Orchard solution](Attachments/solution.hgignore)