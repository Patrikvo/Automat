/*  Notes:
 * https://docs.microsoft.com/en-us/ef/core/providers/sqlite/limitations
    You can workaround some of these limitations by manually writing code in your migrations to
    perform a table rebuild. A table rebuild involves renaming the existing table, creating a new
    table, copying data to the new table, and dropping the old table.
    You will need to use the Sql(string) method to perform some of these steps.
 * */

namespace Automat.Database
{
    using Microsoft.EntityFrameworkCore;

    public class DossierContext : DbContext
    {
        public DossierContext()
        {
        }

        public DbSet<Model.Dossier> Dossiers { get; set; }

        public DbSet<Model.Persoon> Personen { get; set; }

        public DbSet<Model.DossierPersoon> DossierPersoon { get; set; }

        public static bool ByteArrayCompare(byte[] a1, byte[] a2)
        {
            if (a1 == null && a2 == null)
            {
                return true;
            }

            if ((a1 == null && a2 != null) ||
                (a1 != null && a2 == null))
            {
                return false;
            }

            if (a1.Length != a2.Length)
            {
                return false;
            }

            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] != a2[i])
                {
                    return false;
                }
            }

            return true;
        }

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
