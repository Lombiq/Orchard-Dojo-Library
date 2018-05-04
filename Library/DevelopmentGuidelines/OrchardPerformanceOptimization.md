# Orchard performance optimization guidelines



## Orchard performance checklist

When optimizing an Orchard site's performance (or just putting it into production) check these points for the most obvious ways for a boost.

- Debug is set to false in Web.config
- Compiled in Release mode and deployed preferably with the Precompiled build target
- Make sure you read [Optimizing IIS Performance](https://msdn.microsoft.com/en-us/library/ee377050(v=bts.10).aspx)
- Output caching (starting with the built-in OutputCache module), 2nd level caching (e.g. Syscache) is used when possible
- [Combinator](https://orchard.codeplex.com/workitem/18793) is installed for bundling and minifying static resources to enhance client-side performance
- Cookie-less domain or CDN is used for static resources (including Media files)
- It’s possible to opt out of sessions completely in Orchard (if you don’t use it anywhere else) which [is told](https://orchard.codeplex.com/workitem/18793) to give massive performance improvements. Session state can be switched off for whole modules with the “SessionState: disabled” option in the Module.txt. Beware though that TempData, widely used in Orchard (for notifications and also elsewhere like in Comments) depends on sessions. You could try non-session TempData providers to overcome this (e.g. with [a cookie-based one](https://github.com/NuGet/NuGetGallery/blob/master/src/NuGetGallery/Infrastructure/CookieTempDataProvider.cs)).
- When doing I/O tasks, use async APIs. Not blocking threads to wait for an I/O task to complete increases the throughput of the server.
- If your application is under heavy load memory usage will inherently increase. If you have more than 4GB of memory and you're on a 64b machine don't be afraid to use a 64b application pool: this will also increase memory usage but the site will be able to use more than what is available for it from the 32b address space. You can set up an application pool to run a 64b worker process simply by setting "Enable 32-Bit Applications" to False (under advanced settings of the AppPool).
- Disable IIS Logging or too chatty Failed Request Tracing.
- Set DB IsolationLevel.ReadUncommitted if you [know what are you doing](http://stackoverflow.com/questions/2471055/why-use-a-read-uncommitted-isolation-level) because it can give a huge performance boost.
- In menus use Custom Links to display links to single content items instead of Content Menu Items. Custom Links store the URL while Content Menu Items need to do multiple database queries to fetch the URL, thus they're significantly slower (and the convencience of usage doesn't justify this most of the times).


## Detecting performance bottlenecks

[Mini Profiler](https://orchardprofiler.codeplex.com/) is an easy to use Orchard module for pinpointing (mostly DB-related) bottlenecks quickly, even on a production machine.