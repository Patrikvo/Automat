using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Automat.Model
{
    public class Dossier
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string dossierNummer { get; set; }
        public string dossierTitel { get; set; }
        public string dossierStandvanzaken { get; set; }

        public virtual List<Dossier> dossiers { get; set; }


        [NotMapped]
        public string Name
        {
            get
            {
                return dossierNummer + " - " + dossierTitel;
            }
        }
    }
}
