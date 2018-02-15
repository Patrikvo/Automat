using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Automat.Model
{
    public class Persoon
    {
        public Persoon()
        {
            
        }


        [Key]
        public int Id { get; set; }

        [Required]
        public string naam { get; set; }

        public string email { get; set; }

        public string organisatie { get; set; }
        public string departement { get; set; }

       // [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual ICollection<Persoon> personen { get; set; }
    }
}
