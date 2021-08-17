using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Kutuphane.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<HRK_ODUNC> HRK_ODUNC { get; set; }
        public virtual DbSet<KRT_KITAP> KRT_KITAP { get; set; }
        public virtual DbSet<KRT_UYE> KRT_UYE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HRK_ODUNC>()
                .Property(e => e.ALINAN_KITAP_ISBN)
                .IsUnicode(false);

            modelBuilder.Entity<HRK_ODUNC>()
                .Property(e => e.TESLIM_EDILDI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KRT_KITAP>()
                .Property(e => e.ISBN)
                .IsUnicode(false);

            modelBuilder.Entity<KRT_KITAP>()
                .Property(e => e.BARKOD)
                .IsUnicode(false);

            modelBuilder.Entity<KRT_KITAP>()
                .Property(e => e.KITAP_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<KRT_KITAP>()
                .Property(e => e.YAZARI)
                .IsUnicode(false);

            modelBuilder.Entity<KRT_KITAP>()
                .Property(e => e.YAYINEVI)
                .IsUnicode(false);

            modelBuilder.Entity<KRT_KITAP>()
                .Property(e => e.TUR)
                .IsUnicode(false);

            modelBuilder.Entity<KRT_KITAP>()
                .Property(e => e.EBAT)
                .IsUnicode(false);

            modelBuilder.Entity<KRT_KITAP>()
                .Property(e => e.DIL)
                .IsUnicode(false);

            modelBuilder.Entity<KRT_UYE>()
                .Property(e => e.TC)
                .IsUnicode(false);

            modelBuilder.Entity<KRT_UYE>()
                .Property(e => e.CINSIYET)
                .IsUnicode(false);

            modelBuilder.Entity<KRT_UYE>()
                .Property(e => e.AD)
                .IsUnicode(false);

            modelBuilder.Entity<KRT_UYE>()
                .Property(e => e.SOYAD)
                .IsUnicode(false);

            modelBuilder.Entity<KRT_UYE>()
                .Property(e => e.DOGUM_YERI)
                .IsUnicode(false);

            modelBuilder.Entity<KRT_UYE>()
                .Property(e => e.MESLEK)
                .IsUnicode(false);

            modelBuilder.Entity<KRT_UYE>()
                .Property(e => e.MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<KRT_UYE>()
                .Property(e => e.TELEFON)
                .IsUnicode(false);

            modelBuilder.Entity<KRT_UYE>()
                .Property(e => e.ADRES)
                .IsUnicode(false);
        }
    }
}
