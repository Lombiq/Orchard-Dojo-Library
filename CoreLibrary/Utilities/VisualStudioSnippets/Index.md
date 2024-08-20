# Visual Studio code snippets

You can use these [code snippets](https://docs.microsoft.com/en-us/visualstudio/ide/code-snippets) to quickly generate code in some common scenarios during Orchard Core module and theme development. The snippets follow [Orchard naming conventions](../../DevelopmentGuidelines/NamingConventions.md). Check out [this demo video](https://www.youtube.com/watch?v=5L95C0qxrA0) for a quick overview of our snippets.

To effectively use this collection of VS snippets just point the Snippets Manager to where you cloned or downloaded this repository (<https://github.com/Lombiq/Orchard-Dojo-Library>). To do this go under Tools → Code Snippets Manager → select the C# language → Add and Add the whole folder. For Razor snippets to also work select the HTML Language and do the same. Do note that Razor snippets will only be suggested when you hit Ctrl + space first.

The snippets also automatically add the necessary namespaces.

We've taken care to place the `$end$` terminating symbol to a place where one most possibly wants to follow up with coding. Thus if you exit snippets by hitting enter the cursor will be placed where you most likely want to write next.

These snippets are constantly used at [Lombiq](https://lombiq.com) and updated according to our experiences.

## General snippets

- controller: Empty ASP.NET MVC controller class.
- ctorinject: Constructor with an injected dependency and a corresponding `private readonly` field.
- pbcon: Public constant field that returns its own name.
- privr: Private `readonly` field.
- propv: Virtual auto-implemented property.
- servsc: Scoped service registration.

## Orchard Core snippets

Orchard Core snippets are prefixed with "oc" for distinction.

- ocadminmenu: Admin `INavigationProvider` implementation.
- ocalterpartdefinition: `AlterPartDefinition()` call.
- ocaltertable: `AlterTable()` call.
- ocaltertablecreateindex: `AlterTable()` call and a CreateIndex() inside.
- ocaltertypedefinition: `AlterTypeDefinition()` call.
- ocbackgroundtask: `IBackgroundTask` implementation.
- occontentmigrations: Migrations class that configures content types or content parts.
- occreatemapindex: `CreateMapIndexTable()` call.
- ocfield: Empty content field.
- ocfielddriver: `ContentFieldDisplayDriver` implementation.
- ocfielddriverfull: Full `ContentFieldDisplayDriver` implementation with display/edit/update methods.
- ocfieldindexhandler: `ContentFieldIndexHandler` implementation.
- ocjqueryblock: Razor script block for jQuery-using JS code.
- ocmapindex: `MapIndex` and its `IndexProvider`.
- ocmigrations: Simple `Migrations` class.
- ocpart: Empty content part.
- ocpartdriver: `ContentPartDisplayDriver` implementation.
- ocpartdriverfull: Full `ContentPartDisplayDriver` implementation with display/edit/update methods.
- ocparthandler: `ContentPartHandler` implementation.
- ocpartindexhandler: `ContentPartIndexHandler` implementation.
- ocpermissions: `IPermissionProvider` implementation
- ocresourcemanagementoptionsconfiguration: `IConfigureOptions<ResourceManagementOptions>` implementation.
- ocshapetableprovider: `IShapeTableProvider` implementation.
- ocstartup: `Startup` class for an extension's feature.
