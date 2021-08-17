namespace Kutuphane.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KUTUPHANE.KRT_UYE")]
    public partial class KRT_UYE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UYE_NO { get; set; }

        [StringLength(11)]
        public string TC { get; set; }

        [StringLength(1)]
        public string CINSIYET { get; set; }

        [StringLength(20)]
        public string AD { get; set; }

        [StringLength(15)]
        public string SOYAD { get; set; }

        public DateTime? DOGUM_TARIHI { get; set; }

        [StringLength(20)]
        public string DOGUM_YERI { get; set; }

        [StringLength(15)]
        public string MESLEK { get; set; }

        [StringLength(30)]
        public string MAIL { get; set; }

        [StringLength(12)]
        public string TELEFON { get; set; }

        [StringLength(50)]
        public string ADRES { get; set; }

        public DateTime? KAYIT_TARIHI { get; set; }
    }
}
