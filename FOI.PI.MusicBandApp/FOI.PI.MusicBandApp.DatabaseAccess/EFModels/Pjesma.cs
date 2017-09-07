namespace FOI.PI.MusicBandApp.DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pjesma")]
    public partial class Pjesma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pjesma()
        {
            Bend1 = new HashSet<Bend>();
        }

        [Key]
        public int id_pjesma { get; set; }

        [StringLength(45)]
        public string naziv { get; set; }

        [StringLength(45)]
        public string izvodac { get; set; }

        public TimeSpan? trajanje { get; set; }

        [StringLength(45)]
        public string godina_izdanja { get; set; }

        public int? autorska { get; set; }

        public int id_zanr { get; set; }

        public virtual Bend Bend { get; set; }

        public virtual Zanr Zanr { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bend> Bend1 { get; set; }
    }
}
