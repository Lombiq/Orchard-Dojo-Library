# Visual Studio code snippets



To effectively use this collection of VS snippets just point the Snippets Manager to where you cloned or downloaded this folder. To do this go under Tools/Code Snippets Manager/Add and Add the whole folder.

Note that since C# snippets (unlike VB ones) don't support adding namespaces no matter how we wanted this otherwise you'll need to always add namespaces yourself.

Snippets follow [Orchard naming conventions](../../DevelopmentGuidelines/NamingConventions).

We've taken care to place the $end$ terminating symbol to a place where one most possibly wants to follow up with coding. Thus if you escape snippets by hitting enter the cursor will be placed where you most likely want to write next.

These snippets are constantly used at [Lombiq](http://lombiq.com) and updated according to our experiences.


## General snippets

- controller: empty ASP.NET MVC controller class
- ctorinject: constructor with an injected dependency and a corresponding private readonly field
- privr: private readonly field
- propv: virtual auto-implemented property


## Orchard snippets

Orchard snippets are prefixed with an "o" for distinction.

- oadminmenu: [admin menu](../../Wiki/AdminMenu) (INavigationProvider) skeleton
- oalterpartdefinition: ContentDefinitionManager.AlterPartDefinition() skeleton
- oaltertypedefinition: ContentDefinitionManager.AlterTypeDefinition() skeleton
- ocontrollerfull: Controller class with common Orchard services (IOrchardServices, Localizer, ILogger)
- ocreatecontentpartrecordtable: a SchemaBuilder.CreateTable() shortcut for [part records](../../Wiki/ContentPartRecord), to be used in [migrations](../../Wiki/Migrations)
- ocreatetable: a simple SchemaBuilder.CreateTable() skeleton for [migrations](../../Wiki/Migrations)
- odriver: empty [ContentPartDriver](../../Wiki/Driver) skeleton
- odriverfull: a full [driver](../../Wiki/Driver), complete with Display, Editor and Exporting/Importing methods
- ofeature: OrchardFeature attribute
- ofielddriver: empty [ContentFieldDriver](../../Wiki/ContentField) skeleton
- ohandler: empty [ContentHandler](../../Wiki/Handler) skeleton
- ohandlerstorage: [ContentHandler](../../Wiki/Handler) with StorageFilter
- olazyfield: LazyField skeleton
- olazyfieldloader: skeleton for having setting the loader of a LazyField in a handler
- omigrations: basic [migration](../../Wiki/Migrations) class
- omigrationsusings: common namespace using declarations for migrations; wouldn't be needed if C# snippets could import namespaces
- opart: [content part](../../Wiki/ContentPart) without a record
- opartandrecord: [content part](../../Wiki/ContentPart)  with a corresponding part record
- oproppart: property for a [content part](../../Wiki/ContentPart)  for proxying a property from the underlying record
- oresourcemanifest: [resource manifest](../../Wiki/ResourceManifest) skeleton
- oroutes: route provider skeleton
- oroutesfull: route provider pre-filled with a route descriptor