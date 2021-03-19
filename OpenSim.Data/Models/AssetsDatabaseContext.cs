using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class AssetsDatabaseContext : DbContext
    {
        public AssetsDatabaseContext()
        {
        }

        public AssetsDatabaseContext(DbContextOptions<AssetsDatabaseContext> options)
            : base(options)
        {
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     var connectionString = ConfigurationManager.ConnectionStrings["OpenSimDatabase"].ConnectionString;
        //     optionsBuilder.UseMySQL(connectionString);
        // }

        public virtual DbSet<Asset> Assets { get; set; }

        public virtual DbSet<Fsasset> Fsassets { get; set; }
 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asset>(entity =>
            {
                entity.ToTable("assets");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'")
                    .IsFixedLength(true);

                entity.Property(e => e.AccessTime)
                    .HasColumnName("access_time")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AssetFlags).HasColumnName("asset_flags");

                entity.Property(e => e.AssetType).HasColumnName("assetType");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatorId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("CreatorID")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnType("longblob")
                    .HasColumnName("data");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("description");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.Temporary).HasColumnName("temporary");
            });

            modelBuilder.Entity<Fsasset>(entity =>
            {
                entity.ToTable("fsassets");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id")
                    .IsFixedLength(true);

                entity.Property(e => e.AccessTime).HasColumnName("access_time");

                entity.Property(e => e.AssetFlags).HasColumnName("asset_flags");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("description")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Hash)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("hash")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
