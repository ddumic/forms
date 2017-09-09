namespace FOI.PI.MusicBandApp.DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rezervacija")]
    public partial class Rezervacija
    {
        [Key]
        public int id_rezervacija { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datum { get; set; }

        public TimeSpan? vrijeme { get; set; }

        public double? cijena { get; set; }

        [StringLength(100)]
        public string napomena { get; set; }

        public int id_bend { get; set; }

        public int? id_osoba { get; set; }

        public int? status_rezervacije { get; set; }

        public DateTime? datum_od { get; set; }

        public DateTime? datum_do { get; set; }

        public virtual Bend Bend { get; set; }

        public virtual Osoba Osoba { get; set; }

        public virtual StatusRezervacije StatusRezervacije { get; set; }
    }
}
