# Resource manifest

A resource manifest is a class implementing the `IResourceManifestProvider` interface though which you can declare your static resources (e.g. stylesheets and scripts) towards Orchard and give them a unique name to be able to easily use them in your templates. Choosing a unique name for each of resources is quite important to avoid name collisions, since static resources are rendered as shapes and thus can be overridden (see [naming conventions](../DevelopmentGuidelines/NamingConventions.md)).
