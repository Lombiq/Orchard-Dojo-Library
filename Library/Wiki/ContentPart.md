# Content part



# In Orchard 1.x



A content part is a set of separate functionalities and data that can be applied to a [content type](ContentType) by attaching the content part to a content type. Content parts may not store any corresponding data (in this case, they only add functionality by using existing data) in the database or they can even load data from an external data source (like a webservice). [Content fields](ContentField) can be attached to content parts (for the differences between parts and fields, see the fields article).

If your content part stores data in the database, usually it's mapped to a [record class](Record) (the corresponding [content part record](ContentPartRecord)), which is an actual representation of the data you are storing in the database. In most cases, content parts derive from `ContentPart<TRecord>` (where the type parameter is your content part record class), but if the part isn't storing anything in a corresponding record then it can just derive from `ContentPart`.



# In Orchard Core



There is no ContentPartVersionRecord. Content fields and parts still exist, but due to the dynamic nature of Content items in Orchard Core, they only serve as helpers/conventions (thanks to their static typing) for adding properties to a Content item and they behave the same way as in Orchard 1.x, but you can create your own conventions.

Orchard Core introduces Reusable Parts. Reusable part means that you can attach this kind of content part to a content type multiple times. If you would like to attach a reusable part to your content type using the dashboard, you have to click on the 'Add Named Part' button where you have to define the technical name of the part, because that will be a property that helps to identify that part.