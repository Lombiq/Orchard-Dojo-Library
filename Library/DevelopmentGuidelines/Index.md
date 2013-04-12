# Software Development Guidelines

If something’s not specified, general C# guidelines apply: [C# Coding Conventions](http://msdn.microsoft.com/en-us/library/vstudio/ff926074.aspx) and [General Naming Conventions](http://msdn.microsoft.com/en-us/library/vstudio/ms229045%28v=vs.100%29.aspx). Also see [Orchard Code Conventions](http://docs.orchardproject.net/Documentation/Code-conventions). The talk [How To Design A Good API And Why It Matters](http://www.youtube.com/watch?v=aAb7hSCtvGw) is an evergreen.


## Best practices
- When returning a collection, always return an empty collection if there are no elements, but never null
- Keep interfaces as short as possible so it’s relatively simple to provide alternative implementation for them (even when doing unit testing). If a method would serve just as a shortcut for multiple method calls on the same interface, use extension methods. Whether or not to use an extension method should be decided on a case-by case basis as future-aware as possible: ide példák (ellenpélda: GetMany(params int[] ids) pl. ne legyen extension method, mert sok Get(int id)-t okoz és a megvalósítás más is lehet; jó példa is)
- Maximal number of arguments on a method: 3
- Always return an interface type and return the most generic one making sense for the typical consuming code.
- The “empty” pattern (String/QueryHints.Empty)
- Orchard:
	- Always do part shape-related heavy work in shape factories: this way if the shape is not displayed (i.e. not specified in or hidden from Placement.info) no work will be done.
	- If a template uses a static resource (stylesheet or script) always include/require it there even if the template is part of a bigger layout where those resoruces are already referenced.
	- For improving client-side performance by preventing blocking script loads always include scripts in the foot if they’re not required immediately on page load. Also consider using the async attribute on scripts (by setting it with SetAttribute() at the time of inclusion) if the order in which they’re executed is indifferent.
- JavaScript:
	- Prefix jQuery objects with the dollar sign ($)
- Source control:
	- Try to only include changes corresponding to a single task in a commit.
	- Use descriptive commit messages. If a commit corresponds to an issue tracker ticket start the message with the ticket number.
	- When you rename a file tell the source control system that you’ve renamed the file, there’s not a removed and an added one. This makes possible to maintain file history.

## Code styling
- If there length of the parameter list for a method is too long to read conveniently in terms of line length (due to the 3-argument rule this should rarely happen for methods but constructors with dependency injection) break it into multiple lines parameter by parameter.
- Keep logical blocks of codes separated by multiple line breaks, forming logical “islands”.
- Brace styling
- Order of members: private, public, static (const), inner class
- If an expression is short, omit line breaks when applicable (e.g. with short properties, short if-clauses).

## Naming conventions
One addition: use the suffix “Base” for abstract classes

## Rules of thumb for refactoring (consider refactoring in these cases)
- When a class’s net length is above 300 lines
- If the number of injected dependencies (services) exceeds 5

## Documentation guidelines
- Don’t overdo documentation as it can do more harm than use when going out of date, what it tends to do.
- Always document complex pieces of logic by briefly explain what the code does and why.
- Always document unusual solutions, hacks or workarounds and explain why they are necessary.
It’s adviced to document interfaces, best with usage samples.