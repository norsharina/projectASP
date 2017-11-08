namespace TrainingASP.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Database")
        {
        }

        public virtual DbSet<MuatNaikExcel> MuatNaikExcels { get; set; }
        public virtual DbSet<PencapainProgramExcel> PencapainProgramExcels { get; set; }
        public virtual DbSet<PencapianProgram> PencapianPrograms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MuatNaikExcel>()
                .Property(e => e.NamaAsal)
                .IsUnicode(false);

            modelBuilder.Entity<MuatNaikExcel>()
                .Property(e => e.NamaBaru)
                .IsUnicode(false);

            modelBuilder.Entity<MuatNaikExcel>()
                .Property(e => e.Lokasi)
                .IsUnicode(false);

            modelBuilder.Entity<MuatNaikExcel>()
                .HasMany(e => e.PencapainProgramExcels)
                .WithOptional(e => e.MuatNaikExcel)
                .HasForeignKey(e => e.IdMuatNaikExcel);

            modelBuilder.Entity<PencapainProgramExcel>()
                .Property(e => e.KodProgram)
                .IsUnicode(false);

            modelBuilder.Entity<PencapainProgramExcel>()
                .Property(e => e.TarikhProgram)
                .IsUnicode(false);

            modelBuilder.Entity<PencapainProgramExcel>()
                .Property(e => e.BilanganHari)
                .IsUnicode(false);

            modelBuilder.Entity<PencapainProgramExcel>()
                .Property(e => e.Lulus)
                .IsUnicode(false);

            modelBuilder.Entity<PencapainProgramExcel>()
                .Property(e => e.Ralat)
                .IsUnicode(false);

            modelBuilder.Entity<PencapainProgramExcel>()
                .Property(e => e.TarikhImport)
                .IsUnicode(false);

            modelBuilder.Entity<PencapianProgram>()
                .Property(e => e.KodProgram)
                .IsUnicode(false);

            modelBuilder.Entity<PencapianProgram>()
                .Property(e => e.JenisKemasukan)
                .IsUnicode(false);
        }
    }
}
