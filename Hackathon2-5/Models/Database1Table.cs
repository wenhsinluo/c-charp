namespace Hackathon2_5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Database1Table
    {
        [Key]
        [StringLength(50)]
        public string TickNumber { get; set; }

        public DateTime FlyingDay { get; set; }

        public DateTime Birthday { get; set; }
    }
}
