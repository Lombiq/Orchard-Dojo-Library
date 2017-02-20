# Tag helpers



# In Orchard Core



Tag helpers are a new feature that has been introduced in ASP.NET Core MVC and are C# classes that
transform HTML elements in a view. Common uses for tag helpers include generating URLs for forms using
the application’s routing configuration, ensuring that elements of a specific type are styled consistently, and
replacing custom shorthand elements with commonly used fragments of content. Tag helpers are classes that manipulate HTML elements, either to change
them in some way, to supplement them with additional content, or to replace
them entirely with new content.

To provide IntelliSense in your modules, where you want to provide IntelliSense for your [shapes](Shape) or for your [themes](Theme), you have to create a class which is inherited from the TagHelper class, which is a base class in ASP.NET MVC. This way you can optionally document the shapes just by creating a class that the tooling will understand.

Orchard Core has different types of tag helpers, like:

- Resource Manager tag helpers (Link tag helper, Meta tag helper, Resources tag helper, Script tag helper, Style tag helper)
- Zone tag helper
- Shape tag helper
- ContentLink tag helper
- Validation Message tag helper