# Core



We mean several things as "core" so initially this may be confusing:

- [Core modules](http://docs.orchardproject.net/Documentation/Builtin-Features#Coremodules): these are the [modules](Module) that reside in Orchard's Core. They are always installed and always enabled, so your modules can safely depend on them. Examples include Content (basic content management features like admin content lists) or Navigation.
- [The Orchard Framework](http://docs.orchardproject.net/Documentation/Source-code-organization#OrchardFrameworkProject): Orchard is a powerful web development framework. This framework is contained in the Orchard.Framework class library. Being in the center of Orchard it's also often called "core".
- [Non-core modules](http://docs.orchardproject.net/Documentation/Builtin-Features#Noncoremodules) that are developed by The Orchard Team and maintained in the [Orchard repository](https://orchard.codeplex.com/SourceControl/BrowseLatest) are also often dubbed "core modules" but technically they aren't.