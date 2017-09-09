namespace FOI.PI.MusicBandApp.DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatusRezervacije")]
    public partial class StatusRezervacije
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StatusRezervacije()
        {
            Rezervacija = new HashSet<Rezervacija>();
        }

        [Key]
        public int id_status_rezervacije { get; set; }

        [StringLength(100)]
        public string opis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
    }
}
