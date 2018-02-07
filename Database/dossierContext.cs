using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Automat.Database
{
    public class DossierContext : DbContext
    {
        public DbSet<Model.Dossier> dossiers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=dossiers.db");
        }


    }
}



/*
https://docs.microsoft.com/en-us/ef/core/providers/sqlite/limitations

You can workaround some of these limitations by manually writing code in your migrations to 
perform a table rebuild. A table rebuild involves renaming the existing table, creating a new 
table, copying data to the new table, and dropping the old table. 
You will need to use the Sql(string) method to perform some of these steps.
 
 
 */
