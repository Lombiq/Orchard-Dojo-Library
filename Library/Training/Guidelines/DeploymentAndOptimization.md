# Deployment and optimization



## Module: Optimization

- Installing performance-tuning modules:
	- Enterprise-level caching with Orchard.Caching
	- Output caching with the [Contrib.Cache](https://gallery.orchardproject.net/List/Modules/Orchard.Module.Contrib.Cache) module
	- Resource bundling and minification with [Combinator](https://gallery.orchardproject.net/List/Modules/Orchard.Module.Piedone.Combinator)
	- Second level NHibernate caching with SysCache
- Clayless shape generation (1.x branch in the source code, integrating to 1.7)
- Profiling with [Orchard MVC Mini Profiler](http://orchardprofiler.codeplex.com/)

Time requirement: 0h 45m

Dependencies: Basic techniques in module development


## Module: Manual deployment

- Choosing the right build target
- Web.config transformation and settings
- Deploying to Azure Websites
	- Creating an AWS
	- Deploying from Visual Studio using a publish profile
	- Deploying from WebMatrix using a publish profile
- Deploying to an Azure Virtual Machine
	- Creating an AVM
	- Setting up IIS on the AVM
	- Deploying Orchard from Visual Studio

Time requirement: 0h 45m

Dependencies: Getting started in module development


## Module: Automated deployment and continous integration/delivery

- Installing TeamCity
- Setting up a build configuration in TC
	- Installing necessary tools (e.g. Mercurial)
	- Adding a Version Control System root
	- Adding build steps to the process
		- Pull the source code and build the solution
		- Deploy to IIS
	- Dependencies, triggers, environment variables

Time requirement: 1h 0m

Dependencies: Manual Deployment