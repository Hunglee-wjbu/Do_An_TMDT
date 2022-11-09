﻿// <auto-generated />
using System;
using Do_an_TMDT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Do_an_TMDT.Migrations
{
    [DbContext(typeof(WEBBANGIAYContext))]
    partial class WEBBANGIAYContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Do_an_TMDT.Models.ChiTietDonHang", b =>
                {
                    b.Property<int>("MaChiTietDonHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaDonHang")
                        .HasColumnType("int");

                    b.Property<decimal>("Gia")
                        .HasColumnType("numeric(18,0)");

                    b.Property<int>("MaMatHang")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaChiTietDonHang", "MaDonHang")
                        .HasName("PK_ChiTietDonHang_1");

                    b.HasIndex(new[] { "MaDonHang" }, "IX_ChiTietDonHang_MaDonHang");

                    b.HasIndex(new[] { "MaMatHang" }, "IX_ChiTietDonHang_MaMatHang");

                    b.ToTable("ChiTietDonHang");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.ChiTietGioHang", b =>
                {
                    b.Property<int>("MaGioHang")
                        .HasColumnType("int");

                    b.Property<int>("MaMatHang")
                        .HasColumnType("int");

                    b.Property<int>("Gia")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaGioHang", "MaMatHang");

                    b.HasIndex(new[] { "MaGioHang" }, "AK_ChiTietGioHang_MaGioHang")
                        .IsUnique();

                    b.HasIndex(new[] { "MaMatHang" }, "IX_ChiTietGioHang_MaMatHang");

                    b.HasIndex(new[] { "MaGioHang" }, "UQ_ChiTietGioHang")
                        .IsUnique();

                    b.ToTable("ChiTietGioHang");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.DanhGia", b =>
                {
                    b.Property<int>("MaDanhGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaDonHang")
                        .HasColumnType("int");

                    b.Property<int>("MaMatHang")
                        .HasColumnType("int");

                    b.Property<int>("MaNguoiDung")
                        .HasColumnType("int");

                    b.Property<string>("NoiDung")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<double>("SoSao")
                        .HasColumnType("float");

                    b.HasKey("MaDanhGia");

                    b.HasIndex(new[] { "MaDonHang" }, "IX_DanhGia_MaDonHang");

                    b.HasIndex(new[] { "MaMatHang" }, "IX_DanhGia_MaMatHang");

                    b.HasIndex(new[] { "MaNguoiDung" }, "IX_DanhGia_MaNguoiDung");

                    b.ToTable("DanhGia");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.DanhMuc", b =>
                {
                    b.Property<int>("MaDanhMuc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TenDanhMuc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaDanhMuc")
                        .HasName("PK__DanhMuc__B375088709613860");

                    b.HasIndex(new[] { "Slug" }, "UQ_Slug")
                        .IsUnique();

                    b.ToTable("DanhMuc");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.DonHang", b =>
                {
                    b.Property<int>("MaDonHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("DaThanhToan")
                        .HasColumnType("bit");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MaNguoiDung")
                        .HasColumnType("int");

                    b.Property<int?>("MaNguoiGiaoHang")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayXuatDonHang")
                        .HasColumnType("datetime");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("SDT")
                        .IsFixedLength(true);

                    b.Property<string>("TinhTrang")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("numeric(18,0)");

                    b.HasKey("MaDonHang")
                        .HasName("PK_DonHang_1");

                    b.HasIndex(new[] { "MaNguoiDung" }, "IX_DonHang_MaNguoiDung");

                    b.HasIndex(new[] { "MaNguoiGiaoHang" }, "IX_DonHang_MaNguoiGiaoHang");

                    b.ToTable("DonHang");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.GioHang", b =>
                {
                    b.Property<int>("MaGioHang")
                        .HasColumnType("int");

                    b.Property<int>("MaNguoiDung")
                        .HasColumnType("int");

                    b.HasKey("MaGioHang")
                        .HasName("PK_GioHang_1");

                    b.HasIndex(new[] { "MaNguoiDung" }, "UQ_GioHang")
                        .IsUnique();

                    b.ToTable("GioHang");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.KichCo", b =>
                {
                    b.Property<int>("MaKichCo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("KichCo1")
                        .IsRequired()
                        .HasColumnType("float")
                        .HasColumnName("KichCo");

                    b.HasKey("MaKichCo");

                    b.ToTable("KichCo");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.LoaiNguoiDung", b =>
                {
                    b.Property<string>("MaLoaiNguoiDung")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenLoaiNguoiDung")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaLoaiNguoiDung");

                    b.ToTable("LoaiNguoiDung");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.MatHang", b =>
                {
                    b.Property<int>("MaMatHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("DangDuocBan")
                        .HasColumnType("bit");

                    b.Property<bool>("DangDuocHienThi")
                        .HasColumnType("bit");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("numeric(18,0)");

                    b.Property<int>("MaDanhMuc")
                        .HasColumnType("int");

                    b.Property<int?>("MaKichCo")
                        .HasColumnType("int");

                    b.Property<int?>("MaMauSac")
                        .HasColumnType("int");

                    b.Property<int>("MaNhaCungCap")
                        .HasColumnType("int");

                    b.Property<int>("MaThuongHieu")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("SoLuong")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("SoLuongDaBan")
                        .HasColumnType("int");

                    b.Property<double>("SoSao")
                        .HasColumnType("float");

                    b.Property<string>("TenMatHang")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("MaMatHang")
                        .HasName("PK__MatHang__A92254E571897811");

                    b.HasIndex(new[] { "MaDanhMuc" }, "IX_MatHang_MaDanhMuc");

                    b.HasIndex(new[] { "MaKichCo" }, "IX_MatHang_MaKichCo");

                    b.HasIndex(new[] { "MaMauSac" }, "IX_MatHang_MaMauSac");

                    b.HasIndex(new[] { "MaNhaCungCap" }, "IX_MatHang_MaNhaCungCap");

                    b.HasIndex(new[] { "MaThuongHieu" }, "IX_MatHang_MaThuongHieu");

                    b.ToTable("MatHang");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.MatHangAnh", b =>
                {
                    b.Property<int>("MaMatHang")
                        .HasColumnType("int");

                    b.Property<int>("MaAnh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Anh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaMatHang", "MaAnh");

                    b.ToTable("MatHang_Anh");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.MauSac", b =>
                {
                    b.Property<int>("MaMauSac")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenMauSac")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true);

                    b.HasKey("MaMauSac");

                    b.ToTable("MauSac");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.NguoiDung", b =>
                {
                    b.Property<int>("MaNguoiDung")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnhDaiDien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("MaLoaiNguoiDung")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MatKhauHash")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("SDT")
                        .IsFixedLength(true);

                    b.Property<string>("TenDangNhap")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TenNguoiDung")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("ViDienTu")
                        .HasColumnType("numeric(18,0)");

                    b.HasKey("MaNguoiDung")
                        .HasName("PK__NguoiDun__C539D762078210E6");

                    b.HasIndex(new[] { "MaLoaiNguoiDung" }, "IX_NguoiDung_MaLoaiNguoiDung");

                    b.ToTable("NguoiDung");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.NguoiDungDiaChi", b =>
                {
                    b.Property<int>("MaDiaChi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaNguoiDung")
                        .HasColumnType("int");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("(N'')");

                    b.HasKey("MaDiaChi", "MaNguoiDung")
                        .HasName("PK__NguoiDun__7C39CE6E46E6A4D8");

                    b.HasIndex(new[] { "MaNguoiDung" }, "IX_NguoiDung_DiaChi_MaNguoiDung");

                    b.ToTable("NguoiDung_DiaChi");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.NhaCungCap", b =>
                {
                    b.Property<int>("MaNhaCungCap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Std")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("STD")
                        .IsFixedLength(true);

                    b.Property<string>("TenNhaCungCap")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaNhaCungCap")
                        .HasName("PK__NhaCungC__53DA92056B8D20D9");

                    b.ToTable("NhaCungCap");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.TheoDoi", b =>
                {
                    b.Property<int>("MaTheoDoi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaNguoiDung")
                        .HasColumnType("int");

                    b.Property<int>("MaMatHang")
                        .HasColumnType("int");

                    b.HasKey("MaTheoDoi", "MaNguoiDung", "MaMatHang")
                        .HasName("PK__TheoDoi__3156C07993ADD5B7");

                    b.HasIndex(new[] { "MaMatHang" }, "IX_TheoDoi_MaMatHang");

                    b.HasIndex(new[] { "MaNguoiDung", "MaMatHang" }, "UQ__TheoDoi__8FABF22D99F1F197")
                        .IsUnique();

                    b.ToTable("TheoDoi");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.ThuongHieu", b =>
                {
                    b.Property<int>("MaThuongHieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenThuongHieu")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaThuongHieu")
                        .HasName("PK__ThuongHi__A3733E2CCDB502B5");

                    b.ToTable("ThuongHieu");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.ChiTietDonHang", b =>
                {
                    b.HasOne("Do_an_TMDT.Models.DonHang", "MaDonHangNavigation")
                        .WithMany("ChiTietDonHangs")
                        .HasForeignKey("MaDonHang")
                        .HasConstraintName("FK_ChiTietDonHang_DonHang1")
                        .IsRequired();

                    b.HasOne("Do_an_TMDT.Models.MatHang", "MaMatHangNavigation")
                        .WithMany("ChiTietDonHangs")
                        .HasForeignKey("MaMatHang")
                        .HasConstraintName("FK__ChiTietDo__MaMat__5FB337D6")
                        .IsRequired();

                    b.Navigation("MaDonHangNavigation");

                    b.Navigation("MaMatHangNavigation");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.ChiTietGioHang", b =>
                {
                    b.HasOne("Do_an_TMDT.Models.GioHang", "MaGioHangNavigation")
                        .WithOne("ChiTietGioHang")
                        .HasForeignKey("Do_an_TMDT.Models.ChiTietGioHang", "MaGioHang")
                        .HasConstraintName("FK_ChiTietGioHang_GioHang")
                        .IsRequired();

                    b.HasOne("Do_an_TMDT.Models.MatHang", "MaMatHangNavigation")
                        .WithMany("ChiTietGioHangs")
                        .HasForeignKey("MaMatHang")
                        .HasConstraintName("FK__ChiTietGi__MaMat__48CFD27E")
                        .IsRequired();

                    b.Navigation("MaGioHangNavigation");

                    b.Navigation("MaMatHangNavigation");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.DanhGia", b =>
                {
                    b.HasOne("Do_an_TMDT.Models.DonHang", "MaDonHangNavigation")
                        .WithMany("DanhGia")
                        .HasForeignKey("MaDonHang")
                        .HasConstraintName("FK_DanhGia_DonHang1")
                        .IsRequired();

                    b.HasOne("Do_an_TMDT.Models.MatHang", "MaMatHangNavigation")
                        .WithMany("DanhGia")
                        .HasForeignKey("MaMatHang")
                        .HasConstraintName("FK__DanhGia__MaMatHa__5629CD9C")
                        .IsRequired();

                    b.HasOne("Do_an_TMDT.Models.NguoiDung", "MaNguoiDungNavigation")
                        .WithMany("DanhGia")
                        .HasForeignKey("MaNguoiDung")
                        .HasConstraintName("FK_DanhGia_NguoiDung")
                        .IsRequired();

                    b.Navigation("MaDonHangNavigation");

                    b.Navigation("MaMatHangNavigation");

                    b.Navigation("MaNguoiDungNavigation");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.DonHang", b =>
                {
                    b.HasOne("Do_an_TMDT.Models.NguoiDung", "MaNguoiDungNavigation")
                        .WithMany("DonHangMaNguoiDungNavigations")
                        .HasForeignKey("MaNguoiDung")
                        .HasConstraintName("FK_DonHang_NguoiDung")
                        .IsRequired();

                    b.HasOne("Do_an_TMDT.Models.NguoiDung", "MaNguoiGiaoHangNavigation")
                        .WithMany("DonHangMaNguoiGiaoHangNavigations")
                        .HasForeignKey("MaNguoiGiaoHang")
                        .HasConstraintName("FK_DonHang_NguoiDung1");

                    b.Navigation("MaNguoiDungNavigation");

                    b.Navigation("MaNguoiGiaoHangNavigation");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.GioHang", b =>
                {
                    b.HasOne("Do_an_TMDT.Models.NguoiDung", "MaNguoiDungNavigation")
                        .WithOne("GioHang")
                        .HasForeignKey("Do_an_TMDT.Models.GioHang", "MaNguoiDung")
                        .HasConstraintName("FK_GioHang_NguoiDung")
                        .IsRequired();

                    b.Navigation("MaNguoiDungNavigation");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.MatHang", b =>
                {
                    b.HasOne("Do_an_TMDT.Models.DanhMuc", "MaDanhMucNavigation")
                        .WithMany("MatHangs")
                        .HasForeignKey("MaDanhMuc")
                        .HasConstraintName("FK__MatHang__MaDanhM__300424B4")
                        .IsRequired();

                    b.HasOne("Do_an_TMDT.Models.KichCo", "MaKichCoNavigation")
                        .WithMany("MatHangs")
                        .HasForeignKey("MaKichCo")
                        .HasConstraintName("FK_MatHang_KichCo");

                    b.HasOne("Do_an_TMDT.Models.MauSac", "MaMauSacNavigation")
                        .WithMany("MatHangs")
                        .HasForeignKey("MaMauSac")
                        .HasConstraintName("FK_MatHang_MauSac");

                    b.HasOne("Do_an_TMDT.Models.NhaCungCap", "MaNhaCungCapNavigation")
                        .WithMany("MatHangs")
                        .HasForeignKey("MaNhaCungCap")
                        .HasConstraintName("FK__MatHang__MaNhaCu__2E1BDC42")
                        .IsRequired();

                    b.HasOne("Do_an_TMDT.Models.ThuongHieu", "MaThuongHieuNavigation")
                        .WithMany("MatHangs")
                        .HasForeignKey("MaThuongHieu")
                        .HasConstraintName("FK__MatHang__MaThuon__2F10007B")
                        .IsRequired();

                    b.Navigation("MaDanhMucNavigation");

                    b.Navigation("MaKichCoNavigation");

                    b.Navigation("MaMauSacNavigation");

                    b.Navigation("MaNhaCungCapNavigation");

                    b.Navigation("MaThuongHieuNavigation");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.MatHangAnh", b =>
                {
                    b.HasOne("Do_an_TMDT.Models.MatHang", "MaMatHangNavigation")
                        .WithMany("MatHangAnhs")
                        .HasForeignKey("MaMatHang")
                        .HasConstraintName("FK__MatHang_A__MaMat__5070F446")
                        .IsRequired();

                    b.Navigation("MaMatHangNavigation");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.NguoiDung", b =>
                {
                    b.HasOne("Do_an_TMDT.Models.LoaiNguoiDung", "MaLoaiNguoiDungNavigation")
                        .WithMany("NguoiDungs")
                        .HasForeignKey("MaLoaiNguoiDung")
                        .HasConstraintName("FK_NguoiDung_LoaiNguoiDung")
                        .IsRequired();

                    b.Navigation("MaLoaiNguoiDungNavigation");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.NguoiDungDiaChi", b =>
                {
                    b.HasOne("Do_an_TMDT.Models.NguoiDung", "MaNguoiDungNavigation")
                        .WithMany("NguoiDungDiaChis")
                        .HasForeignKey("MaNguoiDung")
                        .HasConstraintName("FK__NguoiDung__MaNgu__534D60F1")
                        .IsRequired();

                    b.Navigation("MaNguoiDungNavigation");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.TheoDoi", b =>
                {
                    b.HasOne("Do_an_TMDT.Models.MatHang", "MaMatHangNavigation")
                        .WithMany("TheoDois")
                        .HasForeignKey("MaMatHang")
                        .HasConstraintName("FK__TheoDoi__MaMatHa__4D94879B")
                        .IsRequired();

                    b.HasOne("Do_an_TMDT.Models.NguoiDung", "MaNguoiDungNavigation")
                        .WithMany("TheoDois")
                        .HasForeignKey("MaNguoiDung")
                        .HasConstraintName("FK__TheoDoi__MaNguoi__4CA06362")
                        .IsRequired();

                    b.Navigation("MaMatHangNavigation");

                    b.Navigation("MaNguoiDungNavigation");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.DanhMuc", b =>
                {
                    b.Navigation("MatHangs");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.DonHang", b =>
                {
                    b.Navigation("ChiTietDonHangs");

                    b.Navigation("DanhGia");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.GioHang", b =>
                {
                    b.Navigation("ChiTietGioHang");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.KichCo", b =>
                {
                    b.Navigation("MatHangs");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.LoaiNguoiDung", b =>
                {
                    b.Navigation("NguoiDungs");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.MatHang", b =>
                {
                    b.Navigation("ChiTietDonHangs");

                    b.Navigation("ChiTietGioHangs");

                    b.Navigation("DanhGia");

                    b.Navigation("MatHangAnhs");

                    b.Navigation("TheoDois");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.MauSac", b =>
                {
                    b.Navigation("MatHangs");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.NguoiDung", b =>
                {
                    b.Navigation("DanhGia");

                    b.Navigation("DonHangMaNguoiDungNavigations");

                    b.Navigation("DonHangMaNguoiGiaoHangNavigations");

                    b.Navigation("GioHang");

                    b.Navigation("NguoiDungDiaChis");

                    b.Navigation("TheoDois");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.NhaCungCap", b =>
                {
                    b.Navigation("MatHangs");
                });

            modelBuilder.Entity("Do_an_TMDT.Models.ThuongHieu", b =>
                {
                    b.Navigation("MatHangs");
                });
#pragma warning restore 612, 618
        }
    }
}
