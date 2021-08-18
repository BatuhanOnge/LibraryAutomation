namespace Kutuphane.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KUTUPHANE.HRK_ODUNC")]
    public partial class HRK_ODUNC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HRK_NO { get; set; }

        public DateTime? HRK_TARIH { get; set; }

        public int? ALAN_UYE_NO { get; set; }

        [StringLength(20)]
        public string ALINAN_KITAP_ISBN { get; set; }

        public int? ODUNC_SURE { get; set; }

        public DateTime? TESLIM_TARIH { get; set; }

        public DateTime? TESLIM_EDILMIS_TARIH { get; set; }

        [StringLength(1)]
        public string TESLIM_EDILDI { get; set; }
    }
}
