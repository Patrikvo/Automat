namespace Automat.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Persoon
    {
        public Persoon()
        {
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Naam { get; set; }

        public string Email { get; set; }

        public string Organisatie { get; set; }

        public string Departement { get; set; }

       // [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual ICollection<Persoon> Personen { get; set; }
    }
}
