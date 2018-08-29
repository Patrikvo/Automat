Future:

- candidates
- Financial info.

- Form manager (dispatcher)


- send-email-button for contactpersons.

- generate documents

- states (active, on hold, archived)

-- controller per tabpage?

Note: new DB column should be nullable to make migration easier. (prevents the need to alter the SQL insert statements).

Current:

IT_004

features: 
- phases + dates
- dates and info during CBS-process










Fix:

- better migration support.
Migration support  (import older DB)
after changing models and adding to dossierContext (public DbSet<Model.DossierPerson> dossierPersoon { get; set; })
Using Db Browser export database to SQL 
remove migrations (everything)
remove database.db (source map)
apply 'Add-Migration initial' and 'Update-Database'
Using Db Browser import sql to database (issue: need someway to add non-nullable fields)

Log:


20180829  Added initial table Planning (code first), requires a link to phases, milestones.

20180824  fixed bugs: new Dossier resulted in duplication of an existing dossier.
	  	      Moved link to files higher up the form.

20180817  Started IT_004

20180817  Deployed V3 to production

20180817  added W/L/D/ to dossier form and controller. 
	  Removed delegates.
	  Add NAT/EUR, AO and contract type.
	  now dossier is saved when another is selected in the listbox.

20180816  added procedure to Dossier form and controller. (ref 20180406)

20180413  added DisplayErrorMessage to the validators
20180413  added Fluent Validation. second instance added to PersoonController

20180409  added Fluent Validation. First instance added to Dossier, used in OverviewController.SaveDossier.

20180406  Procedure and type added to Model and DossierRules, needs to be added to Overview controller and form.
20180406  added list sorting to dossierList.
20180406  bugfix: tickbutton "isGearchiveerd" scaling problem fixed.

20180329  removed Form1. Application now starts at the OverviewController.

20180315  started IT_003

20180315  deployed V2 to production.

20180226  cleaned up code to conform to Stylecop rules.

20180217  added DB link for persons.

20180216   Added ability to add and remove persons to the dossier. the UI-part is done, DB link needs to be added next.

20180215  added link to files, changed UI.

20180214 add archiving of dossiers.

20180212  figured out migration methode. Sqlite doesn't support much changing of tables, therefor the normal EF core migration doesn't work. (see workaround above).

20180212 concurency works (manual checks for rowversion added, automatic doens't seem to work.)

20180211  added concurencysupport for Dossier, still need to add this for delete and for Person table.

20180208  added client (dossierPersoon) table, controller and form. connection with dossier is not yet implemented.
          added timestamp, concurency not yet working.
	  changed: DB context shouldn't be shared and kept around. for each request: create context, use and dispose.

History:

IT_002

- timestamp (concurency):
https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/handling-concurrency-with-the-entity-framework-in-an-asp-net-mvc-application

- field "Archived" (implemented)

- link to files  (field exist in DB, code needs to be added to the application.)
UI: contains the base directory, needs the part to split up the dossiernummer in year and nummer.
	Important part is to support both new and old dossiers. 
  implemented by extraction year and number from dossiernumber. and store it at first opportunity (when dossiernummer is for first time valid).
editing ability added

- client (name, email, organisation, department)  (person and personDossier tables exist, persons can be added to the DB. Next is adding the link between dossiers and persons. (many-to-many relationship).
added ability to add/remove person to dossier, 


IT_001

20180207 - initial iteration. Basic dossier overview, SQLite DB through Entitity Framework 6. Github account created:
https://github.com/Patrikvo/Automat