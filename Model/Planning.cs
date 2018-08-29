/*  Notes:
 *
 * */

namespace Automat.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Planning : IComparable
    {
        public Planning()
        {
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int DossierId { get; set; }

        public string Description { get; set; }

        public int Responsible { get; set; }

        public System.DateTime Deadline { get; set; }

        public byte[] RowVersion { get; set; }

        public System.DateTime Created { get; set; }

        public virtual List<Planning> PlanningItems { get; set; }

        public int CompareTo(object obj)
        {
            return this.Deadline.CompareTo(obj);
        }
    }
}
