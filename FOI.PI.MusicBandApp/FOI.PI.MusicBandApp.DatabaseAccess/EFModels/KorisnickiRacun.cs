namespace FOI.PI.MusicBandApp.DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KorisnickiRacun")]
    public partial class KorisnickiRacun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KorisnickiRacun()
        {
            Rezervacija = new HashSet<Rezervacija>();
        }

        [Key]
        public int id_korisnik { get; set; }

        [StringLength(45)]
        public string korisnicko_ime { get; set; }

        [StringLength(40)]
        public string lozinka { get; set; }

        public int id_osoba { get; set; }

        public int id_bend { get; set; }

        public int id_tip_korisnika { get; set; }

        public virtual Osoba Osoba { get; set; }

        public virtual TipKorisnika TipKorisnika { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
    }
}
