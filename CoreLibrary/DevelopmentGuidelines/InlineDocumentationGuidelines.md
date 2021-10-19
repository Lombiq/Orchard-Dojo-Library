# Inline documentation guidelines



- Don’t overdo documentation as it can do more harm than use when going out of date, what it tends to do.
- Always document complex pieces of logic by briefly explaining what the code does and why.
- Always document unusual solutions, hacks or workarounds and explain why they are necessary.
- It’s advised to document interfaces, best with usage samples. This is especially true for services: Always document services, as these are commonly used by other developers too.
- Never use comments for mental notes (like "TODO"). Such notes should go into more appropriate places like an issue tracker, some common documentation or something else.
- Documentation should be as close to what it documents as possible to avoid going out of date.
- It's good to document what the aim of a type (mostly class or interface) is. This is to be able to quickly understand what a type does without having to understand its code.
- Write documentation as you write code: Use correct grammar and punctuation (remember that comments are sentences), adhere to style conventions.
- Follow [C# XML comment guidelines](https://docs.microsoft.com/en-us/dotnet/csharp/codedoc).
  - C# keywords referenced in XML comments like `true` should be wrapped into a `see` block, e.g.:

    /// &lt;returns&gt;Returns &lt;see langword="true"/&gt; on success, &lt;see langword="false"/&gt; otherwise.&lt;/returns&gt;
  - In comments reference generic types in the format of `<see cref="ILookup{TKey, TValue}"/>`.
- [Use ASCII art](https://blog.regehr.org/archives/1653) to visualize something in 2D.
- There are some great tips in [this blog post](https://buttondown.email/hillelwayne/archive/comment-the-why-and-the-what/).