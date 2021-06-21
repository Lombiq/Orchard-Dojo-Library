# Orchard examples



This list helps to find where to look if you need an example of something in Orchard, so you can look at it when you need to roll out your own similar solution. This is a selection only, not a full list (e.g. many modules contain content parts).

Project links are only included if the module/theme is not bundled with the Orchard source (then the links point to the source file with the example, when applicable). The Training Demo module is not linked every time, it's [under its own repository](https://github.com/Lombiq/Orchard-Training-Demo-Module).


## Modules

- Content item management:
	- Content field: Training Demo
	- Content manager usage from code: Orchard.Core.Contents (/Controllers), Training Demo
	- Content part: Training Demo
	- Content type migration: Orchard.Pages, Training Demo
	- Content type/content part settings: Orchard.Core.Common (/Settings)
	- Editor groups (with site settings): Combinator (metadata in [handler](https://github.com/Lombiq/Combinator/blob/master/Handlers/CombinatorSettingsPartHandler.css), grouping in [driver](https://github.com/Lombiq/Combinator/blob/master/Drivers/CombinatorSettingsPartDriver.cs))
- Events: Training Demo
- File handling: Orchard.Media, Training Demo
- Permissions:
	- Static: Orchard.Comments, Training Demo
	- Dynamic: Orchard.Core.Contents (DynamicPermissions)
- Projector providers:
	- Filter: Orchard.Projections, [Helpful Extensions]([https://github.com/Lombiq/Helpful-Extensions/tree/master/Extensions/Projections](https://github.com/Lombiq/Helpful-Extensions/tree/master/Extensions/Projections))
	- Layout: Orchard.Projections
	- Sort criteria: Orchard.Projections
- Records (low-level database access): Training Demo
- Resources (static resources: css, js files, resource manifests and resource inclusions): Orchard.jQuery, Training Demo
- Search services from code: [Associativy Core](https://github.com/Lombiq/Associativy-Core/blob/master/Services/StandardNodeManager.cs) (also see [NodeIndexingService](https://github.com/Lombiq/Associativy-Core/blob/master/Services/NodeIndexingService.cs))
- Site settings: [SH.GoogleAnalytics](https://github.com/ScharfHoldings/SH.GoogleAnalytics), Training Demo. With new menu item under Settings: Orchard.Comments, Orchard.Users.
- Token provider: Training Demo, Orchard.Tokens, [Helpful Extensions](https://github.com/Lombiq/Helpful-Extensions/tree/master/Extensions/Tokens)
- Unit tests: Training Demo, Orchard.Tests.Modules.Tags
- Using the Content Picker popup for custom content item selection: [Orchard Scripting Extensions](https://github.com/Lombiq/Orchard-Scripting-Extensions/blob/master/Views/ScriptPicker.cshtml)
- Using symmetric encryption: [External Pages](https://github.com/Lombiq/Orchard-External-Pages/blob/master/Models/BitbucketRepositoryDataRecord.cs) (look for SetPasswordEncrypted() and GetDecodedPassword())
- Workflows Activity: Training Demo