using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RadioDatabase
{
    public partial class RadioContext : DbContext
    {
        public RadioContext()
        {
        }

        public RadioContext(DbContextOptions<RadioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PlayList> PlayLists { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Radio;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");


            modelBuilder.Entity<PlayList>(entity =>
            {
                entity.ToTable("PlayList");

                entity.Property(e => e.PlayListId).HasColumnName("PlayListID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2021-05-11')");

                entity.Property(e => e.Genre).HasColumnName("Genre")
                .IsRequired(false)
                .IsUnicode(false)
                .HasMaxLength(30);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MercyTunes')");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlayLists)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__PlayList__Create__5441852A");
            });

            modelBuilder.Entity<Track>(entity =>
            {
                //entity.HasNoKey();

                entity.Property(e => e.Artist)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('KingKay')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Salida')");

                entity.Property(e => e.TrackID).HasColumnName("TrackID");

                entity.Property(d => d.Genre)
                    .IsRequired(false)
                    .IsUnicode(false)
                    .HasMaxLength(30);
                    

                entity.HasOne(d => d.PlayList)
                    .WithMany()
                    .HasForeignKey(d => d.PlayListId)
                    .HasConstraintName("FK__Tracks__PlayList__5CD6CB2B");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.DateJoined)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2021-05-11')");

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('bongiluwe777@gmail.com')");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Bongani')");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Luwemba')");

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('qwertyuiop')");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('bongiboy777')");
            });

           

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
