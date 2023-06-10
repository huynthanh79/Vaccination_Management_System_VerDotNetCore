using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Vaccination_Management_System_VerDotNetCore.Models.Entities
{
    public partial class HETHONGTIEMCHUNGContext : DbContext
    {
        public HETHONGTIEMCHUNGContext()
        {
        }

        public HETHONGTIEMCHUNGContext(DbContextOptions<HETHONGTIEMCHUNGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Chitietpdh> Chitietpdhs { get; set; }
        public virtual DbSet<Dotthanhtoan> Dotthanhtoans { get; set; }
        public virtual DbSet<Giaychidinhtiemchung> Giaychidinhtiemchungs { get; set; }
        public virtual DbSet<Goithuocphieu> Goithuocphieus { get; set; }
        public virtual DbSet<Goivacxin> Goivacxins { get; set; }
        public virtual DbSet<Hoadonthanhtoan> Hoadonthanhtoans { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Khochua> Khochuas { get; set; }
        public virtual DbSet<Lichphancong> Lichphancongs { get; set; }
        public virtual DbSet<Nguoigiamho> Nguoigiamhos { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<Phieudangkytiem> Phieudangkytiems { get; set; }
        public virtual DbSet<Phieudathang> Phieudathangs { get; set; }
        public virtual DbSet<PhieudatmuacuaKh> PhieudatmuacuaKhs { get; set; }
        public virtual DbSet<Thongtintiemchung> Thongtintiemchungs { get; set; }
        public virtual DbSet<Trungtamtiemchung> Trungtamtiemchungs { get; set; }
        public virtual DbSet<Vacxin> Vacxins { get; set; }
        public virtual DbSet<Vacxinkhdatmua> Vacxinkhdatmuas { get; set; }
        public virtual DbSet<Vacxinthuocgoi> Vacxinthuocgois { get; set; }
        public virtual DbSet<Vacxinthuocphieu> Vacxinthuocphieus { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=HETHONGTIEMCHUNG;Integrated Security=True");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .IsClustered(false);

                entity.ToTable("ACCOUNT");

                entity.HasIndex(e => e.Manv, "RELATIONSHIP_24_FK");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Manv).HasColumnName("MANV");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.Manv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACCOUNT_RELATIONS_NHANVIEN");
            });

            modelBuilder.Entity<Chitietpdh>(entity =>
            {
                entity.HasKey(e => new { e.Mavc, e.Mapdh });

                entity.ToTable("CHITIETPDH");

                entity.HasIndex(e => e.Mapdh, "CHITIETPDH2_FK");

                entity.HasIndex(e => e.Mavc, "CHITIETPDH_FK");

                entity.Property(e => e.Mavc).HasColumnName("MAVC");

                entity.Property(e => e.Mapdh).HasColumnName("MAPDH");

                entity.Property(e => e.Nhacungcap)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NHACUNGCAP");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.HasOne(d => d.MapdhNavigation)
                    .WithMany(p => p.Chitietpdhs)
                    .HasForeignKey(d => d.Mapdh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CHITIETP_CHITIETPD_PHIEUDAT");

                entity.HasOne(d => d.MavcNavigation)
                    .WithMany(p => p.Chitietpdhs)
                    .HasForeignKey(d => d.Mavc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CHITIETP_CHITIETPD_VACXIN");
            });

            modelBuilder.Entity<Dotthanhtoan>(entity =>
            {
                entity.HasKey(e => new { e.Mahd, e.Stt })
                    .IsClustered(false);

                entity.ToTable("DOTTHANHTOAN");

                entity.HasIndex(e => e.Mahd, "CUA_FK");

                entity.Property(e => e.Mahd).HasColumnName("MAHD");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Ngaythanhtoan)
                    .HasColumnType("date")
                    .HasColumnName("NGAYTHANHTOAN");

                entity.Property(e => e.Sotientt).HasColumnName("SOTIENTT");

                entity.HasOne(d => d.MahdNavigation)
                    .WithMany(p => p.Dotthanhtoans)
                    .HasForeignKey(d => d.Mahd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOTTHANH_CUA_HOADONTH");
            });

            modelBuilder.Entity<Giaychidinhtiemchung>(entity =>
            {
                entity.HasKey(e => e.Magcd)
                    .IsClustered(false);

                entity.ToTable("GIAYCHIDINHTIEMCHUNG");

                entity.HasIndex(e => e.Mavc, "RELATIONSHIP_14_FK");

                entity.HasIndex(e => e.Manv, "RELATIONSHIP_16_FK");

                entity.HasIndex(e => e.Makh, "RELATIONSHIP_6_FK");

                entity.Property(e => e.Magcd).HasColumnName("MAGCD");

                entity.Property(e => e.Makh).HasColumnName("MAKH");

                entity.Property(e => e.Manv).HasColumnName("MANV");

                entity.Property(e => e.Mavc).HasColumnName("MAVC");

                entity.Property(e => e.Mota)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOTA");

                entity.Property(e => e.Ngaytiem)
                    .HasColumnType("date")
                    .HasColumnName("NGAYTIEM");

                entity.Property(e => e.SttTiem).HasColumnName("STT_TIEM");

                entity.Property(e => e.Trangthaichidinh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANGTHAICHIDINH");

                entity.HasOne(d => d.MakhNavigation)
                    .WithMany(p => p.Giaychidinhtiemchungs)
                    .HasForeignKey(d => d.Makh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GIAYCHID_RELATIONS_KHACHHAN");

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Giaychidinhtiemchungs)
                    .HasForeignKey(d => d.Manv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GIAYCHID_RELATIONS_NHANVIEN");

                entity.HasOne(d => d.MavcNavigation)
                    .WithMany(p => p.Giaychidinhtiemchungs)
                    .HasForeignKey(d => d.Mavc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GIAYCHID_RELATIONS_VACXIN");
            });

            modelBuilder.Entity<Goithuocphieu>(entity =>
            {
                entity.HasKey(e => new { e.Magoi, e.Mapdkt });

                entity.ToTable("GOITHUOCPHIEU");

                entity.HasIndex(e => e.Mapdkt, "GOM2_FK");

                entity.HasIndex(e => e.Magoi, "GOM_FK");

                entity.Property(e => e.Magoi).HasColumnName("MAGOI");

                entity.Property(e => e.Mapdkt).HasColumnName("MAPDKT");

                entity.HasOne(d => d.MagoiNavigation)
                    .WithMany(p => p.Goithuocphieus)
                    .HasForeignKey(d => d.Magoi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GOITHUOC_GOM_GOIVACXI");

                entity.HasOne(d => d.MapdktNavigation)
                    .WithMany(p => p.Goithuocphieus)
                    .HasForeignKey(d => d.Mapdkt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GOITHUOC_GOM2_PHIEUDAN");
            });

            modelBuilder.Entity<Goivacxin>(entity =>
            {
                entity.HasKey(e => e.Magoi)
                    .IsClustered(false);

                entity.ToTable("GOIVACXIN");

                entity.Property(e => e.Magoi).HasColumnName("MAGOI");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GHICHU");

                entity.Property(e => e.Tengoi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TENGOI");
            });

            modelBuilder.Entity<Hoadonthanhtoan>(entity =>
            {
                entity.HasKey(e => e.Mahd)
                    .IsClustered(false);

                entity.ToTable("HOADONTHANHTOAN");

                entity.HasIndex(e => e.Manv, "RELATIONSHIP_19_FK");

                entity.HasIndex(e => e.Mapdkt, "RELATIONSHIP_21_FK");

                entity.HasIndex(e => e.Makh, "RELATIONSHIP_7_FK");

                entity.Property(e => e.Mahd).HasColumnName("MAHD");

                entity.Property(e => e.Hinhthuctt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HINHTHUCTT");

                entity.Property(e => e.Makh).HasColumnName("MAKH");

                entity.Property(e => e.Manv).HasColumnName("MANV");

                entity.Property(e => e.Mapdkt).HasColumnName("MAPDKT");

                entity.Property(e => e.Ngaylap)
                    .HasColumnType("date")
                    .HasColumnName("NGAYLAP");

                entity.Property(e => e.Sotiendatt).HasColumnName("SOTIENDATT");

                entity.Property(e => e.Tongtien).HasColumnName("TONGTIEN");

                entity.HasOne(d => d.MakhNavigation)
                    .WithMany(p => p.Hoadonthanhtoans)
                    .HasForeignKey(d => d.Makh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOADONTH_RELATIONS_KHACHHAN");

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Hoadonthanhtoans)
                    .HasForeignKey(d => d.Manv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOADONTH_RELATIONS_NHANVIEN");

                entity.HasOne(d => d.MapdktNavigation)
                    .WithMany(p => p.Hoadonthanhtoans)
                    .HasForeignKey(d => d.Mapdkt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOADONTH_RELATIONS_PHIEUDAN");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.Makh)
                    .IsClustered(false);

                entity.ToTable("KHACHHANG");

                entity.HasIndex(e => e.Mangh, "GIAM_HO_FK");

                entity.Property(e => e.Makh).HasColumnName("MAKH");

                entity.Property(e => e.Cmnd)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMND");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DIACHI");

                entity.Property(e => e.Hotenkh)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HOTENKH");

                entity.Property(e => e.Mangh).HasColumnName("MANGH");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT")
                    .IsFixedLength(true);

                entity.HasOne(d => d.ManghNavigation)
                    .WithMany(p => p.Khachhangs)
                    .HasForeignKey(d => d.Mangh)
                    .HasConstraintName("FK_KHACHHAN_GIAM_HO_NGUOIGIA");
            });

            modelBuilder.Entity<Khochua>(entity =>
            {
                entity.HasKey(e => new { e.Mavc, e.Matt });

                entity.ToTable("KHOCHUA");

                entity.HasIndex(e => e.Matt, "KHOCHUA2_FK");

                entity.HasIndex(e => e.Mavc, "KHOCHUA_FK");

                entity.Property(e => e.Mavc).HasColumnName("MAVC");

                entity.Property(e => e.Matt).HasColumnName("MATT");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.HasOne(d => d.MattNavigation)
                    .WithMany(p => p.Khochuas)
                    .HasForeignKey(d => d.Matt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KHOCHUA_KHOCHUA2_TRUNGTAM");

                entity.HasOne(d => d.MavcNavigation)
                    .WithMany(p => p.Khochuas)
                    .HasForeignKey(d => d.Mavc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KHOCHUA_KHOCHUA_VACXIN");
            });

            modelBuilder.Entity<Lichphancong>(entity =>
            {
                entity.HasKey(e => new { e.Manv, e.Calam, e.Ngaylam })
                    .IsClustered(false);

                entity.ToTable("LICHPHANCONG");

                entity.HasIndex(e => e.Manv, "RELATIONSHIP_15_FK");

                entity.Property(e => e.Manv).HasColumnName("MANV");

                entity.Property(e => e.Calam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CALAM");

                entity.Property(e => e.Ngaylam)
                    .HasColumnType("date")
                    .HasColumnName("NGAYLAM");

                entity.Property(e => e.Vitri)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VITRI");

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Lichphancongs)
                    .HasForeignKey(d => d.Manv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LICHPHAN_RELATIONS_NHANVIEN");
            });

            modelBuilder.Entity<Nguoigiamho>(entity =>
            {
                entity.HasKey(e => e.Mangh)
                    .IsClustered(false);

                entity.ToTable("NGUOIGIAMHO");

                entity.Property(e => e.Mangh).HasColumnName("MANGH");

                entity.Property(e => e.CmndNgh)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMND_NGH");

                entity.Property(e => e.Diachingh)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DIACHINGH");

                entity.Property(e => e.Hotenngh)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HOTENNGH");

                entity.Property(e => e.Sdtngh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDTNGH")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.Manv)
                    .IsClustered(false);

                entity.ToTable("NHANVIEN");

                entity.HasIndex(e => e.Matt, "RELATIONSHIP_23_FK");

                entity.Property(e => e.Manv).HasColumnName("MANV");

                entity.Property(e => e.Cmnd)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CMND");

                entity.Property(e => e.Diachinv)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DIACHINV");

                entity.Property(e => e.Gioitinh)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("GIOITINH");

                entity.Property(e => e.Hotennv)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HOTENNV");

                entity.Property(e => e.Loainv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOAINV");

                entity.Property(e => e.Matt).HasColumnName("MATT");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("date")
                    .HasColumnName("NGAYSINH");

                entity.Property(e => e.Sdtnv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDTNV")
                    .IsFixedLength(true);

                entity.HasOne(d => d.MattNavigation)
                    .WithMany(p => p.Nhanviens)
                    .HasForeignKey(d => d.Matt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NHANVIEN_RELATIONS_TRUNGTAM");
            });

            modelBuilder.Entity<Phieudangkytiem>(entity =>
            {
                entity.HasKey(e => e.Mapdkt)
                    .IsClustered(false);

                entity.ToTable("PHIEUDANGKYTIEM");

                entity.HasIndex(e => e.Manv, "RELATIONSHIP_18_FK");

                entity.HasIndex(e => e.Matt, "RELATIONSHIP_20_FK");

                entity.HasIndex(e => e.Makh, "RELATIONSHIP_4_FK");

                entity.Property(e => e.Mapdkt).HasColumnName("MAPDKT");

                entity.Property(e => e.Dangkychobanthan).HasColumnName("DANGKYCHOBANTHAN");

                entity.Property(e => e.Hinhthuctiem)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HINHTHUCTIEM");

                entity.Property(e => e.Makh).HasColumnName("MAKH");

                entity.Property(e => e.Manv).HasColumnName("MANV");

                entity.Property(e => e.Matt).HasColumnName("MATT");

                entity.Property(e => e.Ngaylap)
                    .HasColumnType("date")
                    .HasColumnName("NGAYLAP");

                entity.HasOne(d => d.MakhNavigation)
                    .WithMany(p => p.Phieudangkytiems)
                    .HasForeignKey(d => d.Makh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHIEUDAN_RELATIONS_KHACHHAN");

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Phieudangkytiems)
                    .HasForeignKey(d => d.Manv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHIEUDAN_RELATIONS_NHANVIEN");

                entity.HasOne(d => d.MattNavigation)
                    .WithMany(p => p.Phieudangkytiems)
                    .HasForeignKey(d => d.Matt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHIEUDAN_RELATIONS_TRUNGTAM");
            });

            modelBuilder.Entity<Phieudathang>(entity =>
            {
                entity.HasKey(e => e.Mapdh)
                    .IsClustered(false);

                entity.ToTable("PHIEUDATHANG");

                entity.HasIndex(e => e.Manv, "RELATIONSHIP_22_FK");

                entity.Property(e => e.Mapdh).HasColumnName("MAPDH");

                entity.Property(e => e.Manv).HasColumnName("MANV");

                entity.Property(e => e.Ngaydat)
                    .HasColumnType("date")
                    .HasColumnName("NGAYDAT");

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Phieudathangs)
                    .HasForeignKey(d => d.Manv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHIEUDAT_RELATIONS_NHANVIEN");
            });

            modelBuilder.Entity<PhieudatmuacuaKh>(entity =>
            {
                entity.HasKey(e => e.Mapdmkh)
                    .IsClustered(false);

                entity.ToTable("PHIEUDATMUACUA_KH");

                entity.HasIndex(e => e.Makh, "RELATIONSHIP_8_FK");

                entity.Property(e => e.Mapdmkh).HasColumnName("MAPDMKH");

                entity.Property(e => e.Makh).HasColumnName("MAKH");

                entity.Property(e => e.Ngaydukiennhan)
                    .HasColumnType("date")
                    .HasColumnName("NGAYDUKIENNHAN");

                entity.Property(e => e.Ngaylap)
                    .HasColumnType("date")
                    .HasColumnName("NGAYLAP");

                entity.HasOne(d => d.MakhNavigation)
                    .WithMany(p => p.PhieudatmuacuaKhs)
                    .HasForeignKey(d => d.Makh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHIEUDAT_RELATIONS_KHACHHAN");
            });

            modelBuilder.Entity<Thongtintiemchung>(entity =>
            {
                entity.HasKey(e => e.Mathongtin)
                    .IsClustered(false);

                entity.ToTable("THONGTINTIEMCHUNG");

                //entity.HasIndex(e => e.Mavc, "RELATIONSHIP_13_FK");

                //entity.HasIndex(e => e.Manv, "RELATIONSHIP_17_FK");

                //entity.HasIndex(e => e.Makh, "RELATIONSHIP_5_FK");

                entity.Property(e => e.Mathongtin).HasColumnName("MATHONGTIN");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GHICHU");

                entity.Property(e => e.Makh).HasColumnName("MAKH");

                entity.Property(e => e.Manv).HasColumnName("MANV");

                entity.Property(e => e.Mavc).HasColumnName("MAVC");

                entity.Property(e => e.Ngaytiem)
                    .HasColumnType("date")
                    .HasColumnName("NGAYTIEM");

                entity.Property(e => e.Ngaytiemtieptheo)
                    .HasColumnType("date")
                    .HasColumnName("NGAYTIEMTIEPTHEO");

                entity.Property(e => e.Tinhtrangbn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TINHTRANGBN");

                //entity.HasOne(d => d.MakhNavigation)
                //    .WithMany(p => p.Thongtintiemchungs)
                //    .HasForeignKey(d => d.Makh)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_THONGTIN_RELATIONS_KHACHHAN");

                //entity.HasOne(d => d.ManvNavigation)
                //    .WithMany(p => p.Thongtintiemchungs)
                //    .HasForeignKey(d => d.Manv)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_THONGTIN_RELATIONS_NHANVIEN");

                //entity.HasOne(d => d.MavcNavigation)
                //    .WithMany(p => p.Thongtintiemchungs)
                //    .HasForeignKey(d => d.Mavc)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_THONGTIN_RELATIONS_VACXIN");
            });

            modelBuilder.Entity<Trungtamtiemchung>(entity =>
            {
                entity.HasKey(e => e.Matt)
                    .IsClustered(false);

                entity.ToTable("TRUNGTAMTIEMCHUNG");

                entity.Property(e => e.Matt).HasColumnName("MATT");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DIACHI");

                entity.Property(e => e.Tentt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TENTT");
            });

            modelBuilder.Entity<Vacxin>(entity =>
            {
                entity.HasKey(e => e.Mavc)
                    .IsClustered(false);

                entity.ToTable("VACXIN");

                entity.Property(e => e.Mavc).HasColumnName("MAVC");

                entity.Property(e => e.Mota)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOTA");

                entity.Property(e => e.Tenvc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TENVC");
            });

            modelBuilder.Entity<Vacxinkhdatmua>(entity =>
            {
                entity.HasKey(e => new { e.Mapdmkh, e.Mavc });

                entity.ToTable("VACXINKHDATMUA");

                entity.HasIndex(e => e.Mavc, "VACXINKHDATMUA2_FK");

                entity.HasIndex(e => e.Mapdmkh, "VACXINKHDATMUA_FK");

                entity.Property(e => e.Mapdmkh).HasColumnName("MAPDMKH");

                entity.Property(e => e.Mavc).HasColumnName("MAVC");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.HasOne(d => d.MapdmkhNavigation)
                    .WithMany(p => p.Vacxinkhdatmuas)
                    .HasForeignKey(d => d.Mapdmkh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VACXINKH_VACXINKHD_PHIEUDAT");

                entity.HasOne(d => d.MavcNavigation)
                    .WithMany(p => p.Vacxinkhdatmuas)
                    .HasForeignKey(d => d.Mavc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VACXINKH_VACXINKHD_VACXIN");
            });

            modelBuilder.Entity<Vacxinthuocgoi>(entity =>
            {
                entity.HasKey(e => new { e.Magoi, e.Mavc });

                entity.ToTable("VACXINTHUOCGOI");

                entity.HasIndex(e => e.Mavc, "RELATIONSHIP_10_FK");

                entity.HasIndex(e => e.Magoi, "RELATIONSHIP_9_FK");

                entity.Property(e => e.Magoi).HasColumnName("MAGOI");

                entity.Property(e => e.Mavc).HasColumnName("MAVC");

                entity.HasOne(d => d.MagoiNavigation)
                    .WithMany(p => p.Vacxinthuocgois)
                    .HasForeignKey(d => d.Magoi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VACXINTH_RELATIONS_GOIVACXI");

                entity.HasOne(d => d.MavcNavigation)
                    .WithMany(p => p.Vacxinthuocgois)
                    .HasForeignKey(d => d.Mavc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VACXINTH_RELATIONS_VACXIN");
            });

            modelBuilder.Entity<Vacxinthuocphieu>(entity =>
            {
                entity.HasKey(e => new { e.Mapdkt, e.Mavc });

                entity.ToTable("VACXINTHUOCPHIEU");

                entity.HasIndex(e => e.Mapdkt, "RELATIONSHIP_11_FK");

                entity.HasIndex(e => e.Mavc, "RELATIONSHIP_12_FK");

                entity.Property(e => e.Mapdkt).HasColumnName("MAPDKT");

                entity.Property(e => e.Mavc).HasColumnName("MAVC");

                entity.HasOne(d => d.MapdktNavigation)
                    .WithMany(p => p.Vacxinthuocphieus)
                    .HasForeignKey(d => d.Mapdkt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VACXINTH_RELATIONS_PHIEUDAN");

                entity.HasOne(d => d.MavcNavigation)
                    .WithMany(p => p.Vacxinthuocphieus)
                    .HasForeignKey(d => d.Mavc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VACXINTH_RELATIONS_VACXIN2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
