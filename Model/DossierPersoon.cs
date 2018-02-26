/*  Notes:
 *
 * */

namespace Automat.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class DossierPersoon
    {
        [Key]
        public int Id { get; set; }

        public int PersoonId { get; set; }

        public int DossierId { get; set; }

        public bool IsHoofdklant { get; set; }

        public byte[] RowVersion { get; set; }

        public Persoon Persoon { get; set; }

        public Dossier Dossier { get; set; }

        public virtual ICollection<DossierPersoon> DossierPersoons { get; set; }
    }
}
