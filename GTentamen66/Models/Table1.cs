namespace GTentamen66.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Nummer { get; set; }
    }
}
