# Content field



Content fields are bits of information that can store basic data, like the common .NET classes, e.g. strings, integers and dates.

Content fields can be attached to a [content part](ContentPart) in any quantity you like (either by code - in a migration or on the Admin UI), just make sure every field has a unique name. That means that unlike with parts, you can have a specific type of field attached multiple times.

In case you are attaching a content field to a content type on the Admin UI, the fields are attached to a ghost-content part with the same as the [content type](ContentType) (if the content type doesn't already have a content part with the same name).

Differences between content parts and content fields:

- Parts can (but not necessarily should) correspond to database tables, i.e. a part can store its data in a table.
- A field's data is stored along the content item's ContentItemVersionRecord in a serialized XML format (and is thus performing worse because of serialization but also better because of not having to join in or lazily load other tables; concrete performance difference depends on the usage).
- Because of the storage difference parts' properties can be directly queried and used for filtering or ordering while fields can't be queried. The Projector module overcomes this by creating indices for fields.
- While a part can be attached to a content type once, a field can be attached multiple times.
- Parts are attached to a content type while technically fields are attached to a part (when you attach fields to a content type from the admin UI in reality an invisible part, having the same name as the type, will be created).