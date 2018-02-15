using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Automat.Model
{
    public class DossierPersoon
    {
        
        [Key]
        public int Id { get; set; }

        public int persoonId { get; set; }

        public int dossierId { get; set; }

        public bool IsHoofdklant { get; set; }

        public byte[] RowVersion { get; set; }

		public Persoon persoon {get ;set;}
		public Dossier dossier {get; set; }
		
        public virtual ICollection<DossierPersoon> DossierPersoons { get; set; }
    }
}
