namespace FOI.PI.MusicBandApp.DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Financije")]
    public partial class Financije
    {
        [Key]
        [Column(Order = 0)]
        public int id_trosak { get; set; }

        public double? naziv { get; set; }

        public decimal? iznos { get; set; }

        [StringLength(100)]
        public string opis { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_bend { get; set; }

        public virtual Bend Bend { get; set; }
    }
}
