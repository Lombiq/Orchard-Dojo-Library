# Theme Development


Module: Getting started in theme development
--------------------------------------------
- Structure (i.e. "[Anatomy of a theme](http://docs.orchardproject.net/Documentation/Anatomy-of-a-theme)"):
	- Explaining Theme.txt: BaseTheme and Zones
	- Theme.png
- Command line scaffolding
- Shapes:
	- Notion of shapes, tree of shapes
	- The Layout shape
	- Using Shape Tracing
	- Shape templates and view variables (e.g. WorkContext, Layout, Model), T-strings
	- Alternates and overrides (templates, stylesheets, scripts)
	- Writing editor and display shape templates, explaining Model object usage

Time requirement: 1h 30m

Dependencies: none

Module: Advanced theme development
----------------------------------
- Placement.info
	- Placement: shape name, zone, weight
	- Matching (DisplayType, ContentType, Path)
	- Placement editor on Admin UI (only for reordering)
- Static resources: styles/scripts (how to include/require them) and resource manifests
- Approaches to building a new theme:
	- Top-down: how to convert an existing site build to an Orchard theme
	- Bottom-up: building on top of an existing theme (e.g. TheThemeMachine, Pretty Good Base Theme), using it as the base theme, how to create a new theme from a given design suite
- View engines (Razor, ASPX, PHP)

Time requirement: 1h 30m

Dependencies: Getting started in theme development