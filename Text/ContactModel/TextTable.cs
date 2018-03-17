namespace Text.ContactModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TextTable")]
    public partial class TextTable
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string TickNumber { get; set; }

        public DateTime? FlyingDay { get; set; }

        public DateTime? BirthDay { get; set; }
    }
}
