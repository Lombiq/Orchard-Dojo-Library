# Development environment advices



Some advices on how to set up your development environment for Orchard Core development.


## Software to install

Below you can find pieces of software that you should install for the best Orchard Core developer experience. Also check out [the official documentation](https://docs.orchardcore.net/en/dev/docs/resources/development-tools/).

- Visual Studio 2022 (any edition) or later installed with "ASP.NET and web development" tools and the following extensions:
    - [Productivity Power Tools 2022](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.ProductivityPowerPack2022) but the following individual extensions are the only ones recommended:
      - [Fix Mixed Tabs 2022](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.FixMixedTabs2022)
      - [Match Margin 2022](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.MatchMargin2022) if you're not using the map mode for the vertical scroll bar.
      - [Shrink Empty Lines 2022](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.SyntacticLineCompression2022)
      [Time Stamp Margin 2022](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.TimeStampMargin2022)
    - [Code Cleanup On Save](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.CodeCleanupOnSave) to run [code cleanup profiles](https://docs.microsoft.com/en-us/visualstudio/ide/code-styles-and-code-cleanup?view=vs-2022#apply-code-styles) on save.
    - [Editor Guidelines](https://marketplace.visualstudio.com/items?itemName=PaulHarrington.EditorGuidelinesPreview) to add visual guides to specific line lengths.
    - [Debug Attach Manager](https://marketplace.visualstudio.com/items?itemName=ViktarKarpach.DebugAttachManager2022) helps with the same thing: If you select to attach a process for a given app then it'll remember it and select the suitable process the next time automatically, even after a VS restart (especially handy for .NET Core apps with their *dotnet.exe* processes).
    - [SQLite/SQL Server Compact Toolbox](https://marketplace.visualstudio.com/items?itemName=ErikEJ.SQLServerCompactSQLiteToolbox) for browsing Orchard's SQLite databases, or alternatively [SQLite Browser](https://sqlitebrowser.org/dl/) (this has support to nicely format JSON documents).
    - [Lombiq Orchard Visual Studio Extension](https://marketplace.visualstudio.com/items?itemName=LombiqVisualStudioExtension.LombiqOrchardVisualStudioExtension) with various Orchard-related features.
    - [Visual Studio Spell Checker (VS2022 and Later)](https://marketplace.visualstudio.com/items?itemName=EWoodruff.VisualStudioSpellCheckerVS2022andLater) for avoiding typos in comments and other texts.
    - [Markdown Editor v2](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.MarkdownEditor2) to be able to edit Markdown files with a preview window (which can also be used to easily browse Markdown-formatted documentation files locally).
    - [Rewrap](https://marketplace.visualstudio.com/items?itemName=stkb.Rewrap-18980) to reformat code comments and other text to a given line length.
- Local IIS and SQL Server (as well as SQL Server Management Studio) set up as per the following article: "[How-to: running Orchard locally through IIS using SQL Server](http://orcharddojo.net/blog/how-to-running-orchard-locally-through-iis-using-sql-server)"
- An up-to-date browser with developer-aiding tools. Recommended is Chrome with the [JavaScript Errors Notifier](https://chrome.google.com/webstore/detail/javascript-errors-notifie/jafmfknfnkoekkdocjiaipcnmkklaajd?hl=en) extension to get notified of client-side errors easily (it's a bit like the Orchard Error Log Watcher feature of the Lombiq Orchard Visual Studio Extension).
- [Fiddler](http://www.telerik.com/fiddler) for inspecting any HTTP traffic. 


## Visual Studio tips

- Use [code snippets](http://msdn.microsoft.com/en-us/library/ms165392%28v=vs.80%29.aspx); try out [the ones in this package](../Utilities/VisualStudioSnippets/) too that specifically aid Orchard Core development.
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
- To speed things up by not running a virus scan all the time on your development environment exclude the following processes from Windows Security: *devenv.exe*, *dotnet.exe*, *MSBuild.exe*.
- When you start the app with the debugger attached (i.e. with F5) then by default a new browser window will open, and if you move that under an existing window as a tab the debugger will detach. To mitigate this you need to uncheck Tools → Options → Projects and Solutions → Web Projects → "Stop debugger when browser window is closed, close browser when debugging stops".