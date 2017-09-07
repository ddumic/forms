namespace FOI.PI.MusicBandApp.DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Zanr")]
    public partial class Zanr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zanr()
        {
            Pjesma = new HashSet<Pjesma>();
        }

        [Key]
        public int id_zanr { get; set; }

        [StringLength(45)]
        public string naziv { get; set; }

        [StringLength(45)]
        public string opis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pjesma> Pjesma { get; set; }
    }
}
