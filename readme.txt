Future:

- Procedure
- phases + dates

- states (active, on hold, archived)

- Form manager (dispatcher)

- list sorting

- dates and info during CBS-process



Current:

IT_002

- timestamp (concurency):
https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/handling-concurrency-with-the-entity-framework-in-an-asp-net-mvc-application

- field "Archived" (implemented)

- link to files  (field exist in DB, code needs to be added to the application.)

- client (name, email, organisation, department)  (person and personDossier tables exist, persons can be added to the DB. Next is adding the link between dossiers and persons. (many-to-many relationship).

- Migration support  (import older DB)
after changing models and adding to dossierContext (public DbSet<Model.DossierPerson> dossierPersoon { get; set; })
Using Db Browser export database to SQL 
remove migrations (everything)
remove database.db (source map)
apply 'Add-Migration initial' and 'Update-Database'
Using Db Browser import sql to database (issue: need someway to add non-nullable fields)

20180214 add archiving of dossiers.

20180212  figured out migration methode. Sqlite doesn't support much changing of tables, therefor the normal EF core migration doesn't work. (see workaround above).

20180212 concurency works (manual checks for rowversion added, automatic doens't seem to work.)

20180211  added concurencysupport for Dossier, still need to add this for delete and for Person table.

20180208  added client (dossierPersoon) table, controller and form. connection with dossier is not yet implemented.
          added timestamp, concurency not yet working.
	  changed: DB context shouldn't be shared and kept around. for each request: create context, use and dispose.

History:

IT_001

20180207 - initial iteration. Basic dossier overview, SQLite DB through Entitity Framework 6. Github account created:
https://github.com/Patrikvo/Automat