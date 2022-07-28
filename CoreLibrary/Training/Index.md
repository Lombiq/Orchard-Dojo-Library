# Orchard Core training guidelines

The following guidelines serve as a base for [Orchard Core trainings](https://orcharddojo.net/orchard-training) and you're welcome to hold your own Orchard Core training using these guidelines.

## Training methodologies

For methodologies for various forms of Orchard training see [training methodologies](TrainingMethodologies).

## Prerequisite knowledge of participants

During courses we routinely touch on various technologies and paradigms used by Orchard. The knowledge of these is thus an advantage though not a necessity, and participants will also have a chance to learn about them in practice. Here are some keywords of some technologies and paradigms used in Orchard Core:

- Fundamentals: Advanced C#, [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview).
- Patterns and paradigms: [Dependency injection](http://en.wikipedia.org/wiki/Dependency_injection), [loose coupling](http://en.wikipedia.org/wiki/Loose_coupling), [document database](https://en.wikipedia.org/wiki/Document-oriented_database) and SQL, [composition over inheritance](http://en.wikipedia.org/wiki/Composition_over_inheritance), [single responsibility principle](http://en.wikipedia.org/wiki/Single_responsibility_principle), [separation of concerns](http://en.wikipedia.org/wiki/Separation_of_concerns), [modular programming](https://en.wikipedia.org/wiki/Modular_programming), [multi-tenancy](https://en.wikipedia.org/wiki/Multitenancy).
- Server-side technologies: [Json.NET](https://www.newtonsoft.com/json), [Razor syntax](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor) and [Liquid templates](https://shopify.github.io/liquid/), [NuGet packages](https://nuget.org/), [GraphQL](https://graphql.org/) and [RESTful](https://restfulapi.net/) APIs.
- Client-side technologies: [Bootstrap](https://getbootstrap.com/), [jQuery](https://jquery.com/), [Sass](https://sass-lang.com/), [NPM packages](https://www.npmjs.com/), [HTML 5](https://en.wikipedia.org/wiki/HTML5).

Overall what we think is roughly what participants should already know about:

- Mandatory: basic usage of Visual Studio, basic knowledge of C#, basic knowledge of client-side web development (HTML, CSS, JS), previous experience in building .NET (web) apps.
- Strongly advised: basic understanding of Git or some other source control system, ASP.NET Core MVC, and strong knowledge of C#.
- Advised: understanding inversion of control containers and dependency injection, usage of the Razor syntax for HTML templates.

## Technical requirements

The following tools are needed for an Orchard training:

- Lab computers or participants' computers:
  - Software listed under "Software to install" in "[Development environment advices](../DevelopmentGuidelines/DevelopmentEnvironment)".
  - Administrative account to install other components if necessary and to avoid permission issues when running Orchard
- Trainer's PC having all of the above and connected to a projector for demonstrations
- A whiteboard or something similar

## Topics

The topics are each divided into individual modules. These modules can, but don't necessarily have dependency on each other.

When conducting a training even before these start with an introduction of yourself, then of the participants to get a general feeling of where everybody is coming from, and what would be interesting for them. Note that the indicated time requirements are more like guidelines on the minimal recommended time. Allocate sufficient time above this for discussions, and in the case of multi-day trainings, for recaps at the beginning of each day.

- [Core concepts and basic usage](CoreConceptsAndBasicUsage/)
- [Theme development](ThemeDevelopment/)
- [Module development and Orchard APIs](ModuleDevelopmentAndApis/)
- [Extended APIs](ExtendedApis/)
- [Web API](WebApi/)
- [Deployment and optimization](DeploymentAndOptimization/)
- [Team training](TeamTraining/) (for development teams)
