# Visual Studio code snippets



To effectively use this collection of VS snippets just point the Snippets Manager to where you cloned or downloaded this folder. To do this go under Tools/Code Snippets Manager/select the C# language/Add and Add the whole folder.

Note that since C# snippets (unlike VB ones) don't support adding namespaces no matter how we wanted this otherwise you'll need to always add namespaces yourself.

Snippets follow [Orchard naming conventions](../../DevelopmentGuidelines/NamingConventions).

We've taken care to place the $end$ terminating symbol to a place where one most possibly wants to follow up with coding. Thus if you escape snippets by hitting enter the cursor will be placed where you most likely want to write next.

These snippets are constantly used at [Lombiq](https://lombiq.com) and updated according to our experiences.


## General snippets

- controller: empty ASP.NET MVC controller class
- ctorinject: constructor with an injected dependency and a corresponding private readonly field
- pbcon: public constant field that returns its own name
- privr: private readonly field
- propv: virtual auto-implemented property


## Orchard Core snippets

Orchard Core snippets are prefixed with "oc" for distinction.

- We'll start adding snippets soon!