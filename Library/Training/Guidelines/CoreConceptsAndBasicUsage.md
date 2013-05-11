# Core concepts and basic usage


## Module: Introduction

- Orchard ecosystem:
	- [Orchard home page](http://orchardproject.net) and the [documentation](http://docs.orchardproject.net)
	- [Orchard project page](http://orchard.codeplex.com) (downloads, discussion boards, issue tracker, source)
	- Websites of local communities
	- [Orchard Marketplace](http://orchardmarket.net)
- Architectural overview
	- ASP.NET -> ASP.NET MVC -> Orchard
	- Contains open-source projects (eg. NHibernate, jQuery)
	- Modularized architecture (modules, themes)
- Installing Orchard:
	- Choosing a database engine (SQL CE, SQL Server, MySQL)
- Basic site settings
- Demo: installing and basic settings

Time requirement: 0h 45m

Dependencies: none


## Module: Basic site management

- Content model and content management:
	- Content types, parts and fields
	- Creating and editing content items and content types
	- Versioning: drafts and published versions
	- Demo: basic content types (Blog, BlogPost, Page)
	- Demo: creating a content type
	- Demo: editing and versioning a content item
	- Exercise: creating a content type with fields and parts and creating items based on instructions
- Comments
- Themes and modules:
	- Enabling/disabling features and themes
	- Installing new modules and themes
	- Dependencies
- User management and roles, permissions
	- Users: allowing new registrations, user list, settings
	- Roles: editing existing roles, creating new roles, permissions (content type and content item)
	- Demo: users and roles admin pages
	- Exercise: creating a role with selected permissions; enabling registration, registering a new user and assigning it to the newly created role

Time requirement: 1h 15m

Dependencies: none


## Module: Intermediate content management

- Widgets
	- Layers and layer rules, zones (theme anathomy)
	- Demo: creating a new layer and an HTML Widget
	- Exercise: creating NotTheHomepage layer and a HTML Widget in the AsideSecond zone in that layer
- Navigation
	- Creating and editing a menu
		- Adding and editing custom links and content item links
		- Editing link hierarchy
	- Navigation Widget
	- ContentItemPermission for MenuItem
	- Exercise: creating a menu with all kinds of items
- Search and indexing
	- Enabling Search engine and an Indexing service
		- What is an indexing service (eg. Lucene)
	- Enabling a content type for indexing (content type editor)
	- Selecting content types to be indexed and rebuilding index
	- Adding Search widget to the layout
- Media management
	- MediaPicker
	- Media management admin page

Time requirement: 1h 30m

Dependencies: Basic site management


## Module: Advanced content management

- Custom Forms
	- Tokens overview
	- Rules overview
	- Demo: creating a contact form
- Importing and exporting:
	- Using the Import/Export module
	- The importance of having an identity-providing part (AutoroutePart, IdentityPart)
- Projector
	- Queries: example for filtering, ordering and layouts
	- Projection Widget, Projection Page
	- Query Link (Navigation)

Time requirement: 2h 0m

Dependencies: Intermediate content management


## Module: Customization features

- Multi-tenancy
- Command line
	- "help" command
	- Running multiple commands in a batch (from file, with @filename)
- Writing recipes:
	- Installing and enabling themes/features
	- Command line commands
- Optional: localization
	- Installing a .po package with [Vandelay.TranslationManager](https://gallery.orchardproject.net/List/Modules/Orchard.Module.Vandelay.Industries)
	- Setting up locales

Time requirement: 0h 45m

Dependencies: none


## Module: Basic maintenance

- Troubleshooting:
	- Enabling the display of all thrown exception
	- Understanding log files (see sample) and viewing them with the [Error Log Viewer](https://gallery.orchardproject.net/List/Modules/Orchard.Module.Laughlin.ErrorLog) module
	- Contacting module authors and filing reproducible, meaningful bug reports
- Useful 3rd-party modules
	- [Orchard Forums](http://orchardprojectforum.azurewebsites.net/) by Nicholas Mayne
	- [SEO](http://onestopseo.codeplex.com/) by Onestop
	- [Error Log Viewer](http://gallery.orchardproject.net/List/Modules/Orchard.Module.Laughlin.ErrorLog)
	- [Module Profiles](http://gallery.orchardproject.net/List/Modules/Orchard.Module.OrchardHUN.ModuleProfiles)
	- [External Pages](http://gallery.orchardproject.net/List/Modules/Orchard.Module.OrchardHUN.ExternalPages)
	- [Shoutbox](http://gallery.orchardproject.net/List/Modules/Orchard.Module.OrchardHUN.Shoutbox)

Time requirement: 0h 30m

Dependencies: none

Corresponding [demos and exercises](CoreConceptsAndBasicUsageDemosAndExercises)
-------------------------------------------------------------------------------