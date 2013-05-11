# Content part



A content part is a set of separate functionalities and data that can be applied to a content type by attaching the content part to a content type. Content parts can store data through containing content fields.

If your content part stores data, it must be mapped to a record class, which is an actual representation of the data you are storing in the database (visit Migrations to know about how the table is created). In most cases, content parts derive from ContentPartRecord<> (where the generic type is your record class), but in case you want to save a new version of your data when the content part is changed, it should derive from ContentPartVersionRecord<>.