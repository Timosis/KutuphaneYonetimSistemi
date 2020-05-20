﻿// <auto-generated />
using System;
using Kys.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kys.Web.Migrations
{
    [DbContext(typeof(KutuphaneDbContext))]
    partial class KutuphaneDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kys.Web.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriKey");

                    b.ToTable("Kategori");
                });

            modelBuilder.Entity("Kys.Web.Models.Kitap", b =>
                {
                    b.Property<int>("KitapKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DemirbasNo")
                        .HasColumnType("int");

                    b.Property<string>("Isbn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KitapDurumKey")
                        .HasColumnType("int");

                    b.Property<string>("KitapHakkindaOzet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SayfaSayisi")
                        .HasColumnType("int");

                    b.Property<int>("YayineviKey")
                        .HasColumnType("int");

                    b.Property<int>("YazarKey")
                        .HasColumnType("int");

                    b.HasKey("KitapKey");

                    b.HasIndex("YayineviKey");

                    b.HasIndex("YazarKey");

                    b.ToTable("Kitap");
                });

            modelBuilder.Entity("Kys.Web.Models.KitapOdunc", b =>
                {
                    b.Property<int>("KitapOduncKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AlisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GetirisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KitapKey")
                        .HasColumnType("int");

                    b.Property<int>("KitapOduncDurum")
                        .HasColumnType("int");

                    b.Property<int>("UyeKey")
                        .HasColumnType("int");

                    b.HasKey("KitapOduncKey");

                    b.HasIndex("KitapKey");

                    b.HasIndex("UyeKey");

                    b.ToTable("KitapOdunc");
                });

            modelBuilder.Entity("Kys.Web.Models.Uye", b =>
                {
                    b.Property<int>("UyeKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KimlikNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UyeKey");

                    b.ToTable("Uye");
                });

            modelBuilder.Entity("Kys.Web.Models.UyeTip", b =>
                {
                    b.Property<int>("UyeTipKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UyeTipKey");

                    b.ToTable("UyeTip");
                });

            modelBuilder.Entity("Kys.Web.Models.Yayinevi", b =>
                {
                    b.Property<int>("YayineviKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YayineviKey");

                    b.ToTable("Yayinevi");
                });

            modelBuilder.Entity("Kys.Web.Models.Yazar", b =>
                {
                    b.Property<int>("YazarKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarHakkinda")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YazarKey");

                    b.ToTable("Yazar");
                });

            modelBuilder.Entity("Kys.Web.Models.Kitap", b =>
                {
                    b.HasOne("Kys.Web.Models.Yayinevi", "Yayinevi")
                        .WithMany()
                        .HasForeignKey("YayineviKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kys.Web.Models.Yazar", "Yazar")
                        .WithMany("Kitaplar")
                        .HasForeignKey("YazarKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Kys.Web.Models.KitapOdunc", b =>
                {
                    b.HasOne("Kys.Web.Models.Kitap", "Kitap")
                        .WithMany()
                        .HasForeignKey("KitapKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kys.Web.Models.Uye", "Uye")
                        .WithMany()
                        .HasForeignKey("UyeKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
