using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EntityTest.Models
{
    public partial class MSContext : DbContext
    {
        public MSContext()
        {
        }

        public MSContext(DbContextOptions<MSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bolme> Bolmes { get; set; }
        public virtual DbSet<Degree> Degrees { get; set; }
        public virtual DbSet<Ex> ices { get; set; }
        public virtual DbSet<Icaze> Icazes { get; set; }
        public virtual DbSet<Ixtisa> Ixtisas { get; set; }
        public virtual DbSet<Mentor> Mentors { get; set; }
        public virtual DbSet<Movzu> Movzus { get; set; }
        public virtual DbSet<Odeni> Odenis { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Paketler> Paketlers { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Profession> Professions { get; set; }
        public virtual DbSet<Qeydiyyat> Qeydiyyats { get; set; }
        public virtual DbSet<Qeydiyyat1> Qeydiyyat1s { get; set; }
        public virtual DbSet<Qrup> Qrups { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Telebe> Telebes { get; set; }
        public virtual DbSet<Telebe1> Telebe1s { get; set; }
        public virtual DbSet<Telimci> Telimcis { get; set; }
        public virtual DbSet<Telimci1> Telimci1s { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<Universitet> Universitets { get; set; }
        public virtual DbSet<University> Universities { get; set; }
        public virtual DbSet<Video> Videos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-FRFBIAD\n;Database=MS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Bolme>(entity =>
            {
                entity.ToTable("Bolme");

                entity.Property(e => e.BolmeAd).HasMaxLength(20);
            });

            modelBuilder.Entity<Degree>(entity =>
            {
                entity.ToTable("Degree");

                entity.Property(e => e.Degree1).HasColumnName("Degree");
            });

            modelBuilder.Entity<Ex>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ex");

                entity.Property(e => e.MuqavileTarix).HasColumnType("date");

                entity.Property(e => e.TelebeAd).HasMaxLength(20);
            });

            modelBuilder.Entity<Icaze>(entity =>
            {
                entity.ToTable("icaze");

                entity.HasOne(d => d.Telebe)
                    .WithMany(p => p.Icazes)
                    .HasForeignKey(d => d.TelebeId)
                    .HasConstraintName("FK__icaze__TelebeId__2BFE89A6");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.Icazes)
                    .HasForeignKey(d => d.VideoId)
                    .HasConstraintName("FK__icaze__VideoId__2CF2ADDF");
            });

            modelBuilder.Entity<Ixtisa>(entity =>
            {
                entity.Property(e => e.IxtisasAd).HasMaxLength(20);
            });

            modelBuilder.Entity<Mentor>(entity =>
            {
                entity.ToTable("mentor");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasMaxLength(20)
                    .HasColumnName("ad");

                entity.HasOne(d => d.MentorStatusNavigation)
                    .WithMany(p => p.Mentors)
                    .HasForeignKey(d => d.MentorStatus)
                    .HasConstraintName("FK__mentor__MentorSt__0D7A0286");
            });

            modelBuilder.Entity<Movzu>(entity =>
            {
                entity.ToTable("Movzu");

                entity.Property(e => e.MovzuAd).HasMaxLength(20);
            });

            modelBuilder.Entity<Odeni>(entity =>
            {
                entity.Property(e => e.Mebleg).HasColumnType("money");

                entity.Property(e => e.Tarix).HasColumnType("date");

                entity.HasOne(d => d.Qeydiyyat)
                    .WithMany(p => p.Odenis)
                    .HasForeignKey(d => d.QeydiyyatId)
                    .HasConstraintName("FK__Odenis__Qeydiyya__36B12243");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.ToTable("package");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PackageName)
                    .HasMaxLength(25)
                    .HasColumnName("Package_name");
            });

            modelBuilder.Entity<Paketler>(entity =>
            {
                entity.ToTable("Paketler");

                entity.Property(e => e.PaketAd).HasMaxLength(20);
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("position");

                entity.Property(e => e.PositionName)
                    .HasMaxLength(30)
                    .HasColumnName("Position_name");
            });

            modelBuilder.Entity<Profession>(entity =>
            {
                entity.ToTable("profession");

                entity.HasIndex(e => e.Name, "U_ProfessionName")
                    .IsUnique();

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Qeydiyyat>(entity =>
            {
                entity.ToTable("Qeydiyyat");

                entity.Property(e => e.MuqavileTarix).HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Paket)
                    .WithMany(p => p.Qeydiyyats)
                    .HasForeignKey(d => d.PaketId)
                    .HasConstraintName("FK__Qeydiyyat__Paket__32E0915F");

                entity.HasOne(d => d.Telebe)
                    .WithMany(p => p.Qeydiyyats)
                    .HasForeignKey(d => d.TelebeId)
                    .HasConstraintName("FK__Qeydiyyat__Teleb__31EC6D26");

                entity.HasOne(d => d.Telimci)
                    .WithMany(p => p.Qeydiyyats)
                    .HasForeignKey(d => d.TelimciId)
                    .HasConstraintName("FK__Qeydiyyat__Telim__33D4B598");
            });

            modelBuilder.Entity<Qeydiyyat1>(entity =>
            {
                entity.ToTable("qeydiyyat1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.Mentor)
                    .WithMany(p => p.Qeydiyyat1s)
                    .HasForeignKey(d => d.MentorId)
                    .HasConstraintName("FK__qeydiyyat__Mento__14270015");

                entity.HasOne(d => d.Telebe)
                    .WithMany(p => p.Qeydiyyat1s)
                    .HasForeignKey(d => d.TelebeId)
                    .HasConstraintName("FK__qeydiyyat__Teleb__151B244E");

                entity.HasOne(d => d.Telimci)
                    .WithMany(p => p.Qeydiyyat1s)
                    .HasForeignKey(d => d.TelimciId)
                    .HasConstraintName("FK__qeydiyyat__Telim__1332DBDC");
            });

            modelBuilder.Entity<Qrup>(entity =>
            {
                entity.ToTable("Qrup");

                entity.Property(e => e.QrupNomre).HasMaxLength(20);
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasKey(e => e.İd)
                    .HasName("PK__Registra__32120B66DEE73FB2");

                entity.ToTable("Registration");

                entity.Property(e => e.ContractTime)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiscountAzn).HasColumnName("Discount_azn");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Package");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student");

                entity.HasOne(d => d.Trainer)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(d => d.TrainerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Trainer");
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.ToTable("section");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasMaxLength(20)
                    .HasColumnName("ad");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("students");

                entity.HasIndex(e => e.Pin, "UQ__students__C5705903C1019DAA")
                    .IsUnique();

                entity.HasIndex(e => e.Pin, "U_StudentsPin")
                    .IsUnique();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Father_name");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Pin)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Degree)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.DegreeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_students_Degree");

                entity.HasOne(d => d.Profession)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ProfessionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_students_proffession");

                entity.HasOne(d => d.University)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.UniversityId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_students_University");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("tasks");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__tasks__PackageId__00200768");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__tasks__SectionId__01142BA1");

                entity.HasOne(d => d.Topics)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.TopicsId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_tasksTopics");

                entity.HasOne(d => d.Trainer)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.TrainerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__tasks__TrainerId__02084FDA");
            });

            modelBuilder.Entity<Telebe>(entity =>
            {
                entity.ToTable("Telebe");

                entity.Property(e => e.TelebeAd).HasMaxLength(20);

                entity.Property(e => e.TelebeAtaAdi)
                    .HasMaxLength(20)
                    .HasColumnName("Telebe_Ata_adi");

                entity.Property(e => e.TelebeElaqeNomre)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Telebe_Elaqe_nomre")
                    .IsFixedLength(true);

                entity.Property(e => e.TelebeFin).HasMaxLength(10);

                entity.Property(e => e.TelebeGmail).HasMaxLength(50);

                entity.Property(e => e.TelebeSoyad).HasMaxLength(50);

                entity.Property(e => e.TelebeUnvan).HasMaxLength(50);

                entity.HasOne(d => d.Ixtisas)
                    .WithMany(p => p.Telebes)
                    .HasForeignKey(d => d.IxtisasId)
                    .HasConstraintName("FK__Telebe__IxtisasI__2F10007B");

                entity.HasOne(d => d.TelebeUniversitet)
                    .WithMany(p => p.Telebes)
                    .HasForeignKey(d => d.TelebeUniversitetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Telebe__TelebeUn__4CA06362");
            });

            modelBuilder.Entity<Telebe1>(entity =>
            {
                entity.ToTable("telebe1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasMaxLength(20)
                    .HasColumnName("ad");

                entity.HasOne(d => d.TelebeStatusNavigation)
                    .WithMany(p => p.Telebe1s)
                    .HasForeignKey(d => d.TelebeStatus)
                    .HasConstraintName("FK__telebe1__TelebeS__10566F31");
            });

            modelBuilder.Entity<Telimci>(entity =>
            {
                entity.ToTable("Telimci");

                entity.Property(e => e.TelimciAd).HasMaxLength(20);

                entity.Property(e => e.TelimciAtaAdi)
                    .HasMaxLength(20)
                    .HasColumnName("Telimci_Ata_adi");

                entity.Property(e => e.TelimciFin).HasMaxLength(10);

                entity.Property(e => e.TelimciSoyad).HasMaxLength(50);

                entity.HasOne(d => d.Ixtisas)
                    .WithMany(p => p.Telimcis)
                    .HasForeignKey(d => d.IxtisasId)
                    .HasConstraintName("FK__Telimci__Ixtisas__267ABA7A");
            });

            modelBuilder.Entity<Telimci1>(entity =>
            {
                entity.ToTable("telimci1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasMaxLength(20)
                    .HasColumnName("ad");

                entity.HasOne(d => d.TelimciStatusNavigation)
                    .WithMany(p => p.Telimci1s)
                    .HasForeignKey(d => d.TelimciStatus)
                    .HasConstraintName("FK__telimci1__Telimc__0A9D95DB");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.HasKey(e => e.İd)
                    .HasName("PK__topics__32120B660E0F695B");

                entity.ToTable("topics");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.ToTable("trainer");

                entity.HasIndex(e => e.Pin, "U_TrainerPin")
                    .IsUnique();

                entity.Property(e => e.Birth).HasColumnType("date");

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Father_name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Pin)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Trainers)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Position");

                entity.HasOne(d => d.Profession)
                    .WithMany(p => p.Trainers)
                    .HasForeignKey(d => d.ProfessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Profession");
            });

            modelBuilder.Entity<Universitet>(entity =>
            {
                entity.ToTable("Universitet");

                entity.Property(e => e.UniAd).HasMaxLength(100);
            });

            modelBuilder.Entity<University>(entity =>
            {
                entity.ToTable("University");

                entity.HasIndex(e => e.Name, "U_UniversityName")
                    .IsUnique();

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.ToTable("video");

                entity.HasOne(d => d.Bolme)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.BolmeId)
                    .HasConstraintName("FK__video__BolmeId__3B75D760");

                entity.HasOne(d => d.Movzu)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.MovzuId)
                    .HasConstraintName("FK__video__MovzuId__3C69FB99");

                entity.HasOne(d => d.Paket)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.PaketId)
                    .HasConstraintName("FK__video__PaketId__3A81B327");

                entity.HasOne(d => d.Telimci)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.TelimciId)
                    .HasConstraintName("FK__video__TelimciId__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
