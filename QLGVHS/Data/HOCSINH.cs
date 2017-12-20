namespace QLGVHS.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOCSINH")]
    public partial class HOCSINH
    {
        public int ID { get; set; }

        public string MASV { get; set; }

        public string TEN { get; set; }

        public DateTime? NGAYSINH { get; set; }

        public int? GIOITINH { get; set; }

        public string QUEQUAN { get; set; }

        public string SDT { get; set; }

        public int? LOPHOCID { get; set; }

        public virtual LOPHOC LOPHOC { get; set; }
    }
}
