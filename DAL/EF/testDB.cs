namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("testDB")]
    public partial class testDB
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateofbirth { get; set; }

        [Required]
        [StringLength(50)]
        public string country { get; set; }

        public int age { get; set; }
    }
}
