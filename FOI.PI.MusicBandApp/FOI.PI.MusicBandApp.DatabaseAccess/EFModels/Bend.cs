namespace FOI.PI.MusicBandApp.DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bend")]
    public partial class Bend
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bend()
        {
            Financije = new HashSet<Financije>();
            PopisOpreme = new HashSet<PopisOpreme>();
            Osoba = new HashSet<Osoba>();
            Pjesma = new HashSet<Pjesma>();
            Rezervacija = new HashSet<Rezervacija>();
            Pjesma1 = new HashSet<Pjesma>();
        }

        [Key]
        public int id_bend { get; set; }

        [StringLength(45)]
        public string naziv { get; set; }

        public int? broj_clanova { get; set; }

        [StringLength(45)]
        public string mjesto { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datum_osnivanja { get; set; }

        [StringLength(45)]
        public string web_stranica { get; set; }

        [StringLength(45)]
        public string facebook { get; set; }

        [StringLength(45)]
        public string instagram { get; set; }

        [StringLength(15)]
        public string kontakt { get; set; }

        [Column("e-mail")]
        [StringLength(45)]
        public string e_mail { get; set; }

        public byte[] slika { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Financije> Financije { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PopisOpreme> PopisOpreme { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Osoba> Osoba { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pjesma> Pjesma { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervacija> Rezervacija { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pjesma> Pjesma1 { get; set; }
    }
}
