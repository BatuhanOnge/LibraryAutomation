namespace Kutuphane.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KUTUPHANE.KRT_KITAP")]
    public partial class KRT_KITAP
    {
        [Key]
        [StringLength(20)]
        public string ISBN { get; set; }

        [StringLength(15)]
        public string BARKOD { get; set; }

        [StringLength(50)]
        public string KITAP_ADI { get; set; }

        [StringLength(30)]
        public string YAZARI { get; set; }

        [StringLength(15)]
        public string YAYINEVI { get; set; }

        public DateTime? YAYIN_TARIHI { get; set; }

        public int? BASKI { get; set; }

        [StringLength(15)]
        public string TUR { get; set; }

        public int? SAYFA_SAYISI { get; set; }

        [StringLength(10)]
        public string EBAT { get; set; }

        [StringLength(10)]
        public string DIL { get; set; }
    }
}
