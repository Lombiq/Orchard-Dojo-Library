# Migrations



A migration is special class usually derived from DataMigrationImpl through which you can tell Orchard what kind content parts and content types you wish to create and store in the database, including their, fields and settings. In most cases you want to place a file called Migrations to your project root, but if you have more than one of them (e.g. because you have multiple features with separate migrations) you may want to place them in a solution folder called Migrations to keep your project root clean.