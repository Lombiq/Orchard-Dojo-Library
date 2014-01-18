# The InfosetPart content part



`InfosetPart` is one of Orchard's built-in [content part](ContentPart)s. It's always automatically attached to every content item of every content type. It represents (and provides access to) the so called infoset of the content item.

The infoset is a simple XML document that is stored along the content item in its `ContentItemRecord` or if [versioned](Versioning), in the `ContentItemVersionRecord`. It can store arbitrary data and is commonly used to save [content fields'](ContentField) data or data for content parts that needn't be queried. Since the `ContentItemRecord` and/or `ContentItemVersionRecord` is always loaded for a content item the infoset is also loaded at all times. Thus anything stored in the infoset can be retrieved quickly, without any subsequent database calls.


## Importance for content parts

If a content part needs to store data in the database one of the solutions would be to use a [content part record](ContentPartRecord). However such records, if not specifically set for eager-loading, are lazily loaded one by one when using the content item. To overcome this performance issue `InfosetPart` can be used to store the part's data, eliminating the need for further database queries.

However data stored in the `InfosetPart` can't be simply queried (i.e. filtered or ordered) using the database engine. By storing data both in the infoset and in the record, however, one can have the best of both worlds: querying is possible using the records but for any other database interaction the records are not loaded.

Orchard contains helper methods to ease the usage of the infoset.

Bertrand Le Roy has written [an extensive blogpost](http://weblogs.asp.net/bleroy/archive/2013/11/04/the-shift-how-orchard-painlessly-shifted-to-document-storage-and-how-it-ll-affect-you.aspx) about the way and implications of using the `InfosetPart`.