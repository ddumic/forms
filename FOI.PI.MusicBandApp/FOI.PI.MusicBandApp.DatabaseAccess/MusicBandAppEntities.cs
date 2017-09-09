namespace FOI.PI.MusicBandApp.DatabaseAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MusicBandAppEntities : DbContext
    {
        public MusicBandAppEntities()
            : base("name=MusicBandAppEntities")
        {
        }

        public virtual DbSet<Bend> Bend { get; set; }
        public virtual DbSet<Financije> Financije { get; set; }
        public virtual DbSet<Osoba> Osoba { get; set; }
        public virtual DbSet<Pjesma> Pjesma { get; set; }
        public virtual DbSet<PopisOpreme> PopisOpreme { get; set; }
        public virtual DbSet<Rezervacija> Rezervacija { get; set; }
        public virtual DbSet<StatusRezervacije> StatusRezervacije { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipKorisnika> TipKorisnika { get; set; }
        public virtual DbSet<Zanr> Zanr { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bend>()
                .Property(e => e.naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Bend>()
                .Property(e => e.mjesto)
                .IsUnicode(false);

            modelBuilder.Entity<Bend>()
                .Property(e => e.web_stranica)
                .IsUnicode(false);

            modelBuilder.Entity<Bend>()
                .Property(e => e.facebook)
                .IsUnicode(false);

            modelBuilder.Entity<Bend>()
                .Property(e => e.instagram)
                .IsUnicode(false);

            modelBuilder.Entity<Bend>()
                .Property(e => e.kontakt)
                .IsUnicode(false);

            modelBuilder.Entity<Bend>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<Bend>()
                .Property(e => e.lozinka)
                .IsUnicode(false);

            modelBuilder.Entity<Bend>()
                .HasMany(e => e.Financije)
                .WithRequired(e => e.Bend)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bend>()
                .HasMany(e => e.PopisOpreme)
                .WithRequired(e => e.Bend)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bend>()
                .HasMany(e => e.Pjesma)
                .WithOptional(e => e.Bend)
                .HasForeignKey(e => e.autorska);

            modelBuilder.Entity<Bend>()
                .HasMany(e => e.Rezervacija)
                .WithRequired(e => e.Bend)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bend>()
                .HasMany(e => e.Pjesma1)
                .WithMany(e => e.Bend1)
                .Map(m => m.ToTable("Izvodi").MapLeftKey("id_bend").MapRightKey("id_pjesma"));

            modelBuilder.Entity<Financije>()
                .Property(e => e.iznos)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Financije>()
                .Property(e => e.opis)
                .IsUnicode(false);

            modelBuilder.Entity<Osoba>()
                .Property(e => e.ime)
                .IsUnicode(false);

            modelBuilder.Entity<Osoba>()
                .Property(e => e.prezime)
                .IsUnicode(false);

            modelBuilder.Entity<Osoba>()
                .Property(e => e.adresa)
                .IsUnicode(false);

            modelBuilder.Entity<Osoba>()
                .Property(e => e.mjesto)
                .IsUnicode(false);

            modelBuilder.Entity<Osoba>()
                .Property(e => e.spol)
                .IsUnicode(false);

            modelBuilder.Entity<Osoba>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<Osoba>()
                .Property(e => e.lozinka)
                .IsUnicode(false);

            modelBuilder.Entity<Pjesma>()
                .Property(e => e.naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Pjesma>()
                .Property(e => e.izvodac)
                .IsUnicode(false);

            modelBuilder.Entity<Pjesma>()
                .Property(e => e.trajanje)
                .HasPrecision(0);

            modelBuilder.Entity<Pjesma>()
                .Property(e => e.godina_izdanja)
                .IsUnicode(false);

            modelBuilder.Entity<PopisOpreme>()
                .Property(e => e.naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Rezervacija>()
                .Property(e => e.vrijeme)
                .HasPrecision(0);

            modelBuilder.Entity<Rezervacija>()
                .Property(e => e.napomena)
                .IsUnicode(false);

            modelBuilder.Entity<StatusRezervacije>()
                .Property(e => e.opis)
                .IsUnicode(false);

            modelBuilder.Entity<StatusRezervacije>()
                .HasMany(e => e.Rezervacija)
                .WithOptional(e => e.StatusRezervacije)
                .HasForeignKey(e => e.status_rezervacije);

            modelBuilder.Entity<TipKorisnika>()
                .Property(e => e.naziv)
                .IsUnicode(false);

            modelBuilder.Entity<TipKorisnika>()
                .HasMany(e => e.Osoba)
                .WithRequired(e => e.TipKorisnika)
                .HasForeignKey(e => e.tip_korisnika)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Zanr>()
                .Property(e => e.naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Zanr>()
                .Property(e => e.opis)
                .IsUnicode(false);

            modelBuilder.Entity<Zanr>()
                .HasMany(e => e.Pjesma)
                .WithRequired(e => e.Zanr)
                .WillCascadeOnDelete(false);
        }
    }
}
