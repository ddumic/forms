namespace FOI.PI.MusicBandApp.DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PopisOpreme")]
    public partial class PopisOpreme
    {
        [Key]
        [Column(Order = 0)]
        public int id_oprema { get; set; }

        [StringLength(45)]
        public string naziv { get; set; }

        public double? cijena { get; set; }

        public double? vrijednost { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_bend { get; set; }

        public virtual Bend Bend { get; set; }
    }
}
