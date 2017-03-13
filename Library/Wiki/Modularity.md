# Modularity in Orchard Core



The main goal with creating `*.Abstractions` projects is that for instance you do not have to refer the `Orchard.ResourceManagement` project to your module, you need to add the `Orchard.ResourceManagemenet.Abstractions` project that is a collection of an interfaces. Than you do not need the services to be referenced from the `Orchard.ResourceManagement` project.

At the solution of Orchard Core you can find three different kind of ASP.NET Core Web Application based projects:

-  OrchardCore.Nancy is using [Nancy](http://nancyfx.org/ "Nancy"), a lightweight framework for building websites / services without getting in your way. Nancy does not force you to adhere to the model-view-controller pattern, or any other pattern. It’s nothing more than a service endpoint responding to HTTP verbs. Making it ideal for building Websites, Web Services and APIs. That doesn’t mean you can’t apply the MVC pattern to Nancy. You can define Views and put them in a Views folder, create Models to return from your endpoints, and map requests to Models, just like you currently do with ASP.NET MVC.
-  OrchardCore.Mvc loads all MVC/ASP.NET components (controllers, views, etc.) from modules. This project will only provide one tenant, the default tenant (because in this case you do not have Multitenancy enabled). This setup is a single tenant service, its only load the `Orchard Host`. The host will get the Shell for this tenant using the `ShellContextFactory`. By using this host you can enable only the modules that you will need to run your ASP.NET MVC application, instead of the modules that are responsible for the content management.
-  OrchardCore.Cms is enable the content management modules as well to be able to use every features of the Orchard CMS by initializing and running the `OrchardHost` and enabling the default features: `Orchard.Mvc`, `Orchard.Settings`, `Orchard.Setup`, `Orchard.Recipes`, `Orchard.Commons` and every module inside the OrchardCore.Module.Cms folder. Than you can do Multitenancy and Theming as well.
