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
        public int id_trosak { get; set; }

        [StringLength(100)]
        public string naziv { get; set; }

        public double? iznos { get; set; }

        [StringLength(100)]
        public string opis { get; set; }
        
        public int id_bend { get; set; }

        public virtual Bend Bend { get; set; }
    }
}
