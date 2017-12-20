namespace QLGVHS.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        public int ID { get; set; }

        public string TEN { get; set; }

        public string MATKHAU { get; set; }

        public int? QUYEN { get; set; }
    }
}
