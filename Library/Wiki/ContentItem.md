# Content item

Content items are instances of [content types](ContentType), just like objects are instances of classes. Content items are the heart and soul of Orchard: they store all the data you need to handle and display.

Content items are always [versioned](Versioning) every time you modify any data on them and are never hard-deleted to keep the integrity of your database. From code they can be interacted with through the [Content Manager service](ContentManager).
