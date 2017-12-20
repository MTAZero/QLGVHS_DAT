namespace QLGVHS.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHANCONG")]
    public partial class PHANCONG
    {
        public int ID { get; set; }

        public int? LOPHOCID { get; set; }

        public int? MONHOCID { get; set; }

        public int? GIAOVIENID { get; set; }

        public virtual GIAOVIEN GIAOVIEN { get; set; }

        public virtual LOPHOC LOPHOC { get; set; }

        public virtual MONHOC MONHOC { get; set; }
    }
}
