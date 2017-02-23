# Content item



# In Orchard 1.x



Content items are instances of [content types](ContentType), just like objects are instances of classes. Content items are the heart and soul of Orchard: they store all the data you need to handle and display.

Content items are always [versioned](Versioning) every time you modify any data on them and are never hard-deleted to keep the integrity of your database. From code they can be interacted with through the [Content Manager service](ContentManager).



# In Orchard Core



The ContentItem is a limitless JSON object tree with dynamic bindings, but you can access the properties statically too. The full content item is a JSON document, where the content type will just be what is in the 'ContentType' property. In this example, the "MyPart" could be anything, it does not have to be a [content part](ContentPart), its just some data.

    { "ContentType" : 
        "MyPart" : {
            "MyField" : {
            },
            "IHaveSomeData" : {
            }
        }
    }

In Orchard 1.x, ContentItem.Content is a dynamic property that will get the statically typed representation of a Field/Part using reflection. In Orchard Core, ContentItem.Content will access an internal field of the type JObject (which is the deserialized tree of data of the content item). Modifying content elements is different from Orchard 1.x, because modifications to a property in a reference of a content part automatically updates the content item. In Orchard Core you need to weld (Weld of T) back the modified content element to the content item or alter the content item (Alter of T) and define the changes in an action.

    myContentItem.Alter<MyPart>(x => x.Text= "test");

There is no ContentItemRecord. The ContentItem object now is the document which is stored in the ContentStorage and every version is a content item instance. It has an 'Id', which is the database ID of this version and it has a ContentItemId, which is the logical ID for the content item itself. ContentItemId is a base32 string, which is unique. It means if you have 5 versions of the same content item, you have 5 content item instances in the database and they will all have the same 'ContentItemId'.
