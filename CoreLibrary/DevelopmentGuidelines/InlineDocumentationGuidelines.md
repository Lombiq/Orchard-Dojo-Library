# Inline documentation guidelines



- Don’t overdo documentation as it can do more harm than use when going out of date, which it tends to do.
- Always document complex pieces of logic by briefly explaining what the code does and why.
- Always document unusual solutions, hacks or workarounds, and explain why they are necessary.
- It's advised to document interfaces, best with usage samples. This is especially true for services: Always document services, as these are commonly used by other developers too.
- Never use comments for mental notes (like "TODO"). Such notes should go into more appropriate places like an issue tracker, some common documentation or something else.
- Documentation should be as close to what it documents as possible to avoid going out of date.
- It's good to document what the aim of a type (mostly class or interface) is. This is to be able to quickly understand what a type does without having to understand its code.
- Write documentation just like you write code: Use correct grammar and punctuation (remember that comments are sentences), adhere to style conventions.
- Follow [C# XML comment guidelines](https://docs.microsoft.com/en-us/dotnet/csharp/codedoc):
  - C# keywords like `true`, referenced in XML comments, should be wrapped into a `see` element as follows: `/// <returns><see langword="true"/> on success, <see langword="false"/> otherwise.</returns>`
  - Generic types should be referenced as follows: `<see cref="ILookup{TKey, TValue}"/>`
  - As seen in the above examples, don't add a space before self-closing elements in XML comments. This is due to the way automatic tooling generates those elements, as it would be cumbersome to change every such instance.
- [Use ASCII art](https://blog.regehr.org/archives/1653) to visualize something in 2D.
- There are some great tips in [this blog post](https://buttondown.email/hillelwayne/archive/comment-the-why-and-the-what/).
