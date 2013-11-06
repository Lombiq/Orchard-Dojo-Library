# Record



Records are simple classes that represent a piece of data that is stored in the database as a row in a table. The only special thing about record classes is that their public properties (that correspond to columns in the said table) should be public.

The tables corresponding to records are created and also modified if necessary by [migrations](Migrations).

Orchard uses the [NHibernate](http://nhforge.org/) ORM library as the database abstraction layer.