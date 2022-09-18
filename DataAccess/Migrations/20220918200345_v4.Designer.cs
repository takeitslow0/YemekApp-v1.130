﻿// <auto-generated />
using System;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(YemekAppContext))]
    [Migration("20220918200345_v4")]
    partial class v4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataAccess.Entities.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciAdi")
                        .IsUnique();

                    b.HasIndex("RolId");

                    b.ToTable("YemekAppKullanicilar", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.KullaniciDetayi", b =>
                {
                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int>("Cinsiyet")
                        .HasColumnType("int");

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("SehirId")
                        .HasColumnType("int");

                    b.Property<int>("UlkeId")
                        .HasColumnType("int");

                    b.HasKey("KullaniciId");

                    b.HasIndex("Eposta")
                        .IsUnique();

                    b.HasIndex("SehirId");

                    b.HasIndex("UlkeId");

                    b.ToTable("YemekAppKullaniciDetaylari", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Malzeme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("YemekAppMalzemeler", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("YemekAppRoller", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Sehir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UlkeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UlkeId");

                    b.ToTable("YemekAppSehirler", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Ulke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("YemekAppUlkeler", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.YemekTarifi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MalzemeId")
                        .HasColumnType("int");

                    b.Property<string>("Tarif")
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Adi");

                    b.HasIndex("MalzemeId");

                    b.ToTable("YemekAppTarifler", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Kullanici", b =>
                {
                    b.HasOne("DataAccess.Entities.Rol", "Rol")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("DataAccess.Entities.KullaniciDetayi", b =>
                {
                    b.HasOne("DataAccess.Entities.Kullanici", "Kullanici")
                        .WithOne("KullaniciDetayi")
                        .HasForeignKey("DataAccess.Entities.KullaniciDetayi", "KullaniciId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Sehir", "Sehir")
                        .WithMany("KullaniciDetaylari")
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Ulke", "Ulke")
                        .WithMany("KullaniciDetaylari")
                        .HasForeignKey("UlkeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Kullanici");

                    b.Navigation("Sehir");

                    b.Navigation("Ulke");
                });

            modelBuilder.Entity("DataAccess.Entities.Sehir", b =>
                {
                    b.HasOne("DataAccess.Entities.Ulke", "Ulke")
                        .WithMany("Sehirler")
                        .HasForeignKey("UlkeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Ulke");
                });

            modelBuilder.Entity("DataAccess.Entities.YemekTarifi", b =>
                {
                    b.HasOne("DataAccess.Entities.Malzeme", "Malzemeler")
                        .WithMany("YemekTarifleri")
                        .HasForeignKey("MalzemeId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Malzemeler");
                });

            modelBuilder.Entity("DataAccess.Entities.Kullanici", b =>
                {
                    b.Navigation("KullaniciDetayi");
                });

            modelBuilder.Entity("DataAccess.Entities.Malzeme", b =>
                {
                    b.Navigation("YemekTarifleri");
                });

            modelBuilder.Entity("DataAccess.Entities.Rol", b =>
                {
                    b.Navigation("Kullanicilar");
                });

            modelBuilder.Entity("DataAccess.Entities.Sehir", b =>
                {
                    b.Navigation("KullaniciDetaylari");
                });

            modelBuilder.Entity("DataAccess.Entities.Ulke", b =>
                {
                    b.Navigation("KullaniciDetaylari");

                    b.Navigation("Sehirler");
                });
#pragma warning restore 612, 618
        }
    }
}
