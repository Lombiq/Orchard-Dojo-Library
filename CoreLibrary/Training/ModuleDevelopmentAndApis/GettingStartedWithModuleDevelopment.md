# Getting started in module development



- Orchard structural overview:
	- Contents of the Orchard folder (libraries, source, App_Data, module/theme folders...)
	- Solution overview
- Module structure:
	- Module.txt: features and dependencies
	- Scripts, Styles, Views folder
	- Other folders
- Command line scaffolding
- Integrating with the current theme
- Dependency injection and basic services
	- Notifier
	- Localizer
	- Logger
	- Work Context
	- Creating a dependency: difference between `IDependency`, `ITransientDependency` and `ISingletonDependency`
	- Ways of injection:
		- Single dependency
		- `IEnumerable<TDependency>`
		- Lazy injection: `Work<T>` and `Lazy<T>`

Time requirement: 1h 30m

Dependencies: none

Parent topic: [Module development and APIs](./)