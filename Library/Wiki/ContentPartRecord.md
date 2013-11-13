# Content part record



Content part records are [record classes](Record) that store [content part](ContentPart) data in the database.

Unversioned content part records should derive from the ContentPartRecord class, versioned ones from ContentPartVersionRecord. The latter means that if the content part's data will be saved in the form of a new version (new database row) when the corresponding content item is published. A ContentPartRecord can be migrated to ContentPartVersionRecord as described [here](http://stackoverflow.com/questions/16611692/how-to-change-inheritance-from-contentpartrecord-to-contentpartversionrecord).