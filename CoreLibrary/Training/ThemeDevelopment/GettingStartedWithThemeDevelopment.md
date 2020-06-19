# Getting started with theme development



- Structure
	- Explaining the Manifest (BaseTheme), Startup class
	- Usual folders
	- Razor vs Liquid, tag helpers
- Code generation templates
- Shapes
	- Notion of shapes, hierarchical rendering of shapes (demonstrate it with the call stack using the debugger, e.g. with `MenuItem.cshml`, also explaining shape caching)
	- The notion and use of the Layout shape, checking it out with the debugger
	- Alternates and overrides (the [basic ones](https://docs.orchardcore.net/en/dev/docs/reference/modules/Templates/#available-templates) and examples of others like [for the menu](https://docs.orchardcore.net/en/dev/docs/reference/modules/Menu/#menu-alternates)). You can vverride TitlePart.cshtml as an example.
	- Shape templates and important view variables (e.g. `Context`, `Title`, `Model`, `User`), T-strings
	- Writing editor and display shape templates, explaining Model object usage
	- Ad-hoc shapes
- Static resources: styles/scripts (how to include/require them) and resource manifests

Time requirement: 2h 0m

Dependencies: none

Parent topic: [Theme development](./)