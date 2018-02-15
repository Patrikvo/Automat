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
        public DbSet<Model.Persoon> personen { get; set; }
        public DbSet<Model.DossierPersoon> dossierPersoon { get; set; }

        public DossierContext()
        {
            
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=dossiers.db");
            
        }


        public static bool ByteArrayCompare(byte[] a1, byte[] a2)
        {
            if (a1 == null && a2 == null)
            {
                return true;
            }
            if (
                (a1 == null && a2 != null) ||
                (a1 != null && a2 == null)
                )
            {
                return false;
            }


            if (a1.Length != a2.Length)
                return false;

            for (int i = 0; i < a1.Length; i++)
                if (a1[i] != a2[i])
                    return false;

            return true;
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
