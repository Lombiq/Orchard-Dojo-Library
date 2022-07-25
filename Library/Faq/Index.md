# Orchard FAQ

## How to configure how many characters are displayed for the Body summary?

You'll need to override the Parts.Body.Summary shape template in your theme or in a module. See [Bertrand Le Roy's tutorial](http://weblogs.asp.net/bleroy/archive/2012/07/01/my-body-summary-template-for-orchard.aspx) on the topic.

## Where to place modules and themes?

- Physically modules are located under src/Orchard.Web/Modules and Themes under src/Orchard.Web/Themes. You should create a corresponding folder for modules and themes (this is only necessary if you install them by copying their source from somewhere, like cloning their repository; it's not necessary if you install them from the Gallery) and the folder should be named the same as the module/theme's **ID**. This ID name of the module/theme's project file (e.g. "Orchard.Alias"). If the theme doesn't have a project file then its folder can be named anything: now the name of the folder becomes the ID.
- In the solution, although not mandatory, it's advised that you place your modules in the "Modules" solution folder (or in your own, custom module folder) and Themes in the "Themes" folder.

## How to run and debug Orchard locally?

The easiest way to run Orchard is through Visual Studio's built-in Cassini devserver. Just open the Orchard solution and hit Ctrl+F5 (starting without debugging: much faster than starting with debugging with F5).

After the site is started you can attach the debugger to the devserver: Debug/Attach to Process/select WebDev. It's useful to enable breaking when an exception is thrown, even if it's swallowed somewhere: Debug/Exceptions/tick Thrown at CLR Exceptions.

See more tips on setting up your dev environment under the [Development Guidelines](../DevelopmentGuidelines/DevelopmentEnvironment).

## Where are the log files?

If you experience issues in a production environment the best way to start investigating the issue is by taking a look at the log files. These are under App_Data/Logs in the deployed site's folder or under src/Orchard.Web/App_Data/Logs if you're running from the full source code locally.

## How can I test SSL locally?

If you're running your Orchard instance through the auto-configured IIS Express (i.e. by hitting Ctrl + F5) you can access the site through SSL by changing the protocol to https and using the port 44300. This is useful if you want to test e.g. if you've configured the Secure Sockets Layer module correctly.
