# Orchard Dojo Library contribution guidelines

The Orchard Dojo Library is fully open source and can be edited by anyone. If you find an error or would like to improve it, you're more than welcome; just submit a pull request!

The Library is stored as Markdown-formatted text files in a repository on [GitHub](https://github.com/Lombiq/Orchard-Dojo-Library). The files can be edited with any text editor, but we recommend [Notepad++](https://notepad-plus-plus.org/), or [VS Code](https://code.visualstudio.com) which offers a live preview for Markdown files.

- Name files and folders with PascalCasing.
- Files named *Index.md* are automatically opened when requesting their folder.
- You can use relative links to link between files; paths are the same online as they are in the repository. Keep in mind that links to folders (when the Index file is opened automatically) must end with a slash (`/`) while links to files shouldn't.
- Add a line break after the title header (line starting with `#`); keep a line break after any sub-headings (line starting with two or more `#`).
- When adding inline code snippets, use the `` `backtick-delimited syntax` ``.
- When adding paths or filenames, emphasize (italicize) them like this: `*C:\path\to\file.txt*` &rarr; *C:\path\to\file.txt*.
- Don't include HTML elements in the Markdown files.
  - Encode HTML entities, e.g. use `&lt;` and `&gt;` for the &lt; and &gt; characters.
  - If you mention an XML or HTML element wrap it with backticks, e.g. `<img>`, so it's not misinterpreted as markup on the page.
