namespace TrainingASP.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PencapianProgram")]
    public partial class PencapianProgram
    {
        public int Id { get; set; }

        public string KodProgram { get; set; }

        public DateTime? TarikhProgram { get; set; }

        public int? BilanganHari { get; set; }

        public bool? Lulus { get; set; }

        [StringLength(50)]
        public string JenisKemasukan { get; set; }

        public bool Terhapus { get; set; }
    }
}
