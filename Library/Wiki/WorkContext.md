# Work Context



`WorkContext` is one of the most important types in Orchard. It's more or less a generalization of the idea of an HttpContext. It contains a lot of (mostly Orchard-specific) contextual information like the basic site settings, the current theme or user and the HttpContext itself.

The work context is an important aspect of Orchard's dependency framework too. A `WorkContext` object lives as long as its work context scope lives, what is a dependency injection scope (`IDependency` implementations live as long as their work context lives): when such a scope is created through `IWorkContextAccessor` (what you can also use to access the current `WorkContext`) also the `WorkContext` is created. Correspondingly there are also methods on the `WorkContext` class to resolve dependencies (you can use this instead of constructor injection if you want to lazily resolve dependencies).

An HTTP request in Orchard, as well as background tasks are wrapped into an ambient work context. Since work contexts are not tied to an http context you can have multiple work contexts per request and you can have a work context independently of a request too (this happens in background tasks).

Thus such work contexts are externally managed contexts and because of this somehow have to "travel" along with their scope until the latter is terminated: in Orchard the work context is either carried in the `HttpContext` or in a thread static field (what also causes [some limitations](https://orchard.codeplex.com/workitem/20509)).

A work context scope is the lowest dependency scope commonly used. It also has a parent, the shell's scope: this is the shell context (or more precisely, its lifetime scope). You can access a shell's (what is most of the time equal to a tenant) context through `IOrchardHost.GetShellContext()`. Work context scopes are actually created from the shell context's lifetime scope. Furthermore this also has a parent that is the application-wide HostContainer.

Most of the time you don't have to manage the work context yourself since the ambient work context around requests and background tasks are managed for you.

`IWorkContextAccessor` is also passed into `RouteData.DataTokens`. This way the `WorkContext` (and thus, Orchard services) can be accessed from code that is not under dependency injection like HTML helpers and attributes. See [Sipke's tutorial](http://skywalkersoftwaredevelopment.net/blog/orchard-webapi-global-actionfilters-and-dependency-injection) on taking advantage of this.