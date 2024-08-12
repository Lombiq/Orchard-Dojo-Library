# Visual Studio code snippets

To effectively use this collection of VS snippets just point the Snippets Manager to where you cloned or downloaded this folder. To do this go under Tools/Code Snippets Manager/select the C# language/Add and Add the whole folder.

Note that since C# snippets (unlike VB ones) don't support adding namespaces no matter how we wanted this otherwise you'll need to always add namespaces yourself.

Snippets follow [Orchard naming conventions](../../DevelopmentGuidelines/NamingConventions.md).

We've taken care to place the $end$ terminating symbol to a place where one most possibly wants to follow up with coding. Thus if you escape snippets by hitting enter the cursor will be placed where you most likely want to write next.

These snippets are constantly used at [Lombiq](http://lombiq.com) and updated according to our experiences.

## General snippets

- controller: empty ASP.NET MVC controller class
- ctorinject: constructor with an injected dependency and a corresponding private readonly field
- privr: private readonly field
- propv: virtual auto-implemented property

## Orchard snippets

Orchard snippets are prefixed with an "o" for distinction.

- oadminmenu: [admin menu](../../Wiki/AdminMenu.md) (INavigationProvider) skeleton
- oalterpartdefinition: ContentDefinitionManager.AlterPartDefinition() skeleton
- oaltertypedefinition: ContentDefinitionManager.AlterTypeDefinition() skeleton
- obackgroundtask: [background task](../../Wiki/BackgroundTask.md) (IBackgroundTask) skeleton
- ocontrollerfull: Controller class with common Orchard services (IOrchardServices, Localizer, ILogger)
- ocreatecontentpartrecordtable: a SchemaBuilder.CreateTable() shortcut for [part records](../../Wiki/ContentPartRecord.md), to be used in [migrations](../../Wiki/Migrations.md)
- ocreatetable: a simple SchemaBuilder.CreateTable() skeleton for [migrations](../../Wiki/Migrations.md)
- odriver: empty [ContentPartDriver](../../Wiki/Driver.md) skeleton
- odriverfull: a full [driver](../../Wiki/Driver.md), complete with Display, Editor and Exporting/Importing methods
- ofeature: OrchardFeature attribute
- ofielddriver: empty [ContentFieldDriver](../../Wiki/ContentField.md) skeleton
- ohandler: empty [ContentHandler](../../Wiki/Handler.md) skeleton
- ohandlerstorage: [ContentHandler](../../Wiki/Handler.md) with StorageFilter
- ojqueryblock: usable in Razor templates, this snippet adds a Scipt.Foot/Head() javascript block, with a jQuery anonymous function inside it
- olazyfield: LazyField skeleton
- olazyfieldloader: skeleton for having setting the loader of a LazyField in a handler
- omigrations: basic [migration](../../Wiki/Migrations.md) class
- omigrationsusings: common namespace using declarations for migrations; wouldn't be needed if C# snippets could import namespaces
- opart: [content part](../../Wiki/ContentPart.md) without a record
- opartandrecord: [content part](../../Wiki/ContentPart.md)  with a corresponding part record
- opermissions: permission provider skeleton
- oproppart: property for a [content part](../../Wiki/ContentPart.md) for proxying a property from the underlying record
- opropstoreretrieve: property for a content part without a record for storing and retrieving data from the [InfosetPart](../../Wiki/InfosetPart.md)
- oproprecordstoreretrieve: property for a content part with a corresponding record for storing and retrieving data from the InfosetPart while also storing it in the record simultaneously
- oresourcemanifest: [resource manifest](../../Wiki/ResourceManifest.md) skeleton
- oroutes: route provider skeleton
- oroutesfull: route provider pre-filled with a route descriptor
- oscheduledtask: [scheduled task](../../Wiki/ScheduledTask.md) (IScheduledTaskHandler) skeleton
- oscheduledtaskrenewing: renewing [scheduled task](../../Wiki/ScheduledTask.md) (IScheduledTaskHandler) skeleton (requires the module Piedone.HelpfulLibraries)
- otests: unit test class skeleton
- otestsusings: common namespace using declarations for unit tests

Surround with snippets: unfortunately it's a bit more difficult for "surround with" snippets; if we'd just include them among the other snippets it would cause the Snippet Picker to open when you try to surround some piece of code, requiring to click through the hierarchy to select a snippet. This is not very convenient so such snippets are in a separate folder, in SurroundWithVisualStudioSnippets. You have to install these snippets manually by importing them into the Visual C# category through the Snippet Manager (this way you can avoid the Snippet Picker).

- otryfatal: surrounds the block with a try-catch where the catch includes an [exception fatality check](http://english.orchardproject.hu/blog/orchard-gems-exception-fatality-check).
