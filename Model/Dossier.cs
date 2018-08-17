/*  Notes:
 *
 * */

namespace Automat.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Dossier
    {
        public Dossier()
        {
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string DossierNummer { get; set; }

        public string DossierTitel { get; set; }

        public string DossierStandvanzaken { get; set; }

        public string DossierLinkToFiles { get; set; }

        public bool IsGearchiveerd { get; set; }

        public int DossierProcedure { get; set; }

        public int DossierType { get; set; }

        public bool IsEuropeanPublished { get; set; }

        public int TypeOfContract { get; set; }

        public int ProcuringEnity { get; set; }

       // [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual List<Dossier> Dossiers { get; set; }

        [NotMapped]
        public string Name
        {
            get
            {
                return this.DossierNummer + " - " + this.DossierTitel;
            }
        }
    }
}
