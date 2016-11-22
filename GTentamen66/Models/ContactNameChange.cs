namespace GTentamen66.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactNameChange")]
    public partial class ContactNameChange
    {
        public int ContactNameChangeID { get; set; }

        [Required]
        [StringLength(5)]
        public string CustomerID { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [StringLength(30)]
        public string OldContactName { get; set; }

        [StringLength(30)]
        public string NewContactName { get; set; }

        public DateTime ChangedDate { get; set; }
    }
}
