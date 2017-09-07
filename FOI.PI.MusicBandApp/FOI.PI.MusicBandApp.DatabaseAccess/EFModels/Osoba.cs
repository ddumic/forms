namespace FOI.PI.MusicBandApp.DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Osoba")]
    public partial class Osoba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Osoba()
        {
            Rezervacija = new HashSet<Rezervacija>();
        }

        [Key]
        public int id_osoba { get; set; }

        [StringLength(45)]
        public string ime { get; set; }

        [StringLength(45)]
        public string prezime { get; set; }

        [StringLength(45)]
        public string adresa { get; set; }

        [StringLength(45)]
        public string mjesto { get; set; }

        [StringLength(45)]
        public string spol { get; set; }

        public int? id_bend { get; set; }

        [Required]
        [StringLength(100)]
        public string mail { get; set; }

        [StringLength(100)]
        public string lozinka { get; set; }

        public int? tip_korisnika { get; set; }

        public virtual Bend Bend { get; set; }

        public virtual TipKorisnika TipKorisnika { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
    }
}
