# Module

Orchard modules are types of [extensions](Extension.md). They are designed to extend Orchard's functionality in any way you can imagine.

Modules can have multiple features: features can be independently switched on or off (you have to decorate classes corresponding to a specific feature with the `OrchardFeature` attribute). Actually what you can enable or disable from the admin UI are features, not modules. However, each module has at least one feature, what has the same ID as the module itself (i.e. the .csproj file's name).

Features can depend on each other (not just on features of the same module but also on features of other modules); this dependency is declared in the Module.txt file (more info about it [in the Docs](https://docs.orchardproject.net/en/latest/Documentation/Manifest-files/)), the manifest of the module. You can only enable a feature if all of its dependencies are installed (and if they are not already enabled, they will be when you enable the feature depending on them).
