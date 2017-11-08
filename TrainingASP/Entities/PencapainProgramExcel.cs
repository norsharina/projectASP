namespace TrainingASP.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PencapainProgramExcel")]
    public partial class PencapainProgramExcel
    {
        public int Id { get; set; }

        [StringLength(500)]
        public string KodProgram { get; set; }

        public string TarikhProgram { get; set; }

        public string BilanganHari { get; set; }

        public string Lulus { get; set; }

        public int? IdMuatNaikExcel { get; set; }

        [StringLength(500)]
        public string Ralat { get; set; }

        public string TarikhImport { get; set; }

        public virtual MuatNaikExcel MuatNaikExcel { get; set; }
    }
}
