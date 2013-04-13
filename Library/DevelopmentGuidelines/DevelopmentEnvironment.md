# Development Environment



Some advices on how to set up your development environment for Orchard Development.


## Software to install

- Visual Studio 2012 (preferable non-Express) with the following plug-ins:
	- [Web Essentials](http://visualstudiogallery.msdn.microsoft.com/07d54d12-7133-4e15-becb-6f451ea3bea6) for better client-side development tooling
	- [ASP.NET and Web Tools](http://www.asp.net/vnext/overview/latest) also for better client-side development tooling
	- [TestDriven.Net](http://www.testdriven.net/download.aspx) for running unit tests
	- [PowerCommands for Visual Studio](http://visualstudiogallery.msdn.microsoft.com/e5f41ad9-4edc-4912-bca3-91147db95b99) mostly for the feature of being able to clean-up unneeded using statements and for re-opening files just closed
	- [Debug Attach Manager 2012](http://visualstudiogallery.msdn.microsoft.com/19951adf-722a-4d92-a73a-6d7a3d70cfc4) and/or [AttachTo](http://visualstudiogallery.msdn.microsoft.com/d0265ab0-df51-4100-8e10-1f84403c4cd0)
- Local IIS and SQL Server set up as per the following article
- Firefox with the [Firebug](https://getfirebug.com/) developer plugin installed or something similar for aiding client-side development


## Visual Studio tips

- Use [code snippets](http://msdn.microsoft.com/en-us/library/ms165392%28v=vs.80%29.aspx); try out the ones in this package too that specifically aid Orchard development.
- Use keyboard shortcuts. The most useful ones are:
	- F5: start with debugging
	- Ctrl+F5: start without debugging
	- F6: build
	- F10: run to the next line, when debugging
	- F11: step into the code on the current line (e.g. if the current line is a method call this will forward you to the body of the method), when debugging
	- Ctrl+.: opens the [Smart Tag](http://haacked.com/archive/2008/06/23/visual-studio-smart-tag-expansion-tip.aspx)
	- Ctrl+Shift+Enter: adds a new line below the current line
	- F9: places a breakpoint on the current line
	- Ctrl+K, Ctrl+D: format document
	- Ctrl+K, Ctrl+C: comment selection
	- Ctrl+K, Ctrl+U: uncomment selection
	- Ctrl+D, Ctrl+E or Ctrl+Alt+E: opens the Exceptions configuration page. Tick Common Language Runtime Exceptions - Thrown to see all exceptions, even if they're caught.
	- Ctrl+Q to access the Quick Launch bar
	- You may want to set up Ctrl+W for closing the current file for the File.Close command and Ctrl+Shift+T for Edit.UndoClose (only available if PowerCommands is installed).


## Mercurial and TortoiseHg tips

- Interact with Mercurial through the TortoiseHg Workbench. You can add a cloned repository to the Workbench by opening it from the repository folder: right click on the folder and select the Workbench.
- Use groups in the Repository Registry to group your repositories.
- When doing work in a temporal branch and want to merge the changes back to another branch and close the branch do it in the following order: close then merge and NOT merge then close as this will result in an unnecessary dangling head.
- See the [mercurial.ini in file in this package](Files/mercurial.ini) that you can use to initialize your Mercurial instance quickly with some useful settings.