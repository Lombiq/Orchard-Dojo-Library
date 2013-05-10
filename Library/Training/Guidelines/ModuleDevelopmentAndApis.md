# Module Development and Orchard APIs



The below topics are the core of what an Orchard developer should know. Other, less important items are listed under [Extended APIs](ExtendedApis).

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
	- Creating a dependency: difference between IDependency, ITransientDependency and ISingletonDependency
	- Ways of injection:
		- Single dependency
		- IEnumerable<TDependency>
		- Lazy injection: `Work<T>` and `Lazy<T>`
- Data storage:
	- Records and repositories, record migrations
	- Content manager:
		- Content querying, updating and removal
		- Joins and QueryHints for optimization
	- Abstracted file storage with IStorageProvider
- Exception handling:
	- OrchardException
	- IsFatal()
- Ad-hoc shape creation
- OrchardFeature attribute
- Content part development
	- Parts and part records, versioning (LazyField)
	- Content type migrations
	- Drivers: display and edit methods, export/import
	- Editor and display shapes
	- Handlers and filters
	- Placement
- Content field development
- Custom routes
- Navigation providers: implementing an admin menu (with corresponding admin controller)
- Filters: result and action filters, FilterProvider
- Event bus and event handlers
- Permissions and authorization
- Background tasks
- Ways of storing settings
	- Site settings
	- Content type settings (e.g. Indexing)
	- Content part settings: part-level and type-level settings
- Caching:
	- ICacheManager for instance-level caching
	- ICacheService for farm-wide caching
- Recipes inside modules
- Optional: writing unit tests
	- Mocking and using stubs for services (including existing stubs for Orchard services)
	- Database-enabled tests
	- Running unit tests with TestDriven.Net
- Releasing to the Gallery

Most of this comes from [Sipke Schoorstra’s Orchard Harvest session](http://www.youtube.com/watch?v=MH9mcodTX-U) content (APIs, content part development).

We've created a demo module for the purpose of teaching all the topics here with well explained examples. See the [Orchard Training Demo module](http://orchardtrainingdemo.codeplex.com/).

The [Orchard Cheat Sheet](http://sebastienros.github.com/CheatSheet/) by Sebastien Ros is a great small API reference.

Corresponding [demos and exercises](ModuleDevelopmentAndApisDemosAndExercises)