using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OnlineMusic.EF
{
    public partial class OnlineMusicDB : DbContext
    {
        public OnlineMusicDB()
            : base("name=OnlineMusic1")
        {
        }

        public virtual DbSet<CASI> CASIs { get; set; }
        public virtual DbSet<DANHMUC> DANHMUCs { get; set; }
        public virtual DbSet<DANHMUCSANPHAM> DANHMUCSANPHAMs { get; set; }
        public virtual DbSet<NEWS> NEWS { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<SLIDE> SLIDEs { get; set; }
    
        public virtual DbSet<USER> USERs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
<<<<<<< HEAD
            modelBuilder.Entity<CASI>()
                .Property(e => e.Meta)
                .IsFixedLength();

            modelBuilder.Entity<CASI>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<CASI>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<DANHMUC>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<DANHMUCSANPHAM>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<NEWS>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<NEWS>()
                .Property(e => e.MetaTitle)
=======
            modelBuilder.Entity<ABOUT>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            
            modelBuilder.Entity<CASI>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            
            modelBuilder.Entity<DANHMUC>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);


            modelBuilder.Entity<DANHMUCSANPHAM>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);


            modelBuilder.Entity<FOOTER>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<NEWS>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);


            modelBuilder.Entity<NEWSTAG>()
                .Property(e => e.TagID)
>>>>>>> c48b6d3a532f2bfe31f5ed3b9c8977663fad31a9
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.PromotionPrice)
                .HasPrecision(18, 0);

<<<<<<< HEAD
=======

            modelBuilder.Entity<TAG>()
                .Property(e => e.ID)
                .IsUnicode(false);

>>>>>>> c48b6d3a532f2bfe31f5ed3b9c8977663fad31a9
            modelBuilder.Entity<USER>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
