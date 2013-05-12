# Naming conventions



- Use the suffix “Base” for abstract classes.
- Suffix [part classes](../Wiki/ContentPart) with "Part", [records](../Wiki/Record) with "Record" and [records of parts](../Wiki/ContentPartRecord) with "PartRecord".
- Name js and css files with the segments of their names delimited by dashes, e.g. my-style.css. It's also advised to prefix names of such resources with the module name, since these names are global, e.g. my-module-my-style.css.
- Resource names declared in [resource manifests](../Wiki/ResourceManifest) are also global so prefix them with the module's name e.g. "MyModule.MyStyle".