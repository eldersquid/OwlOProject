﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OwlOProjectA.Models;

namespace OwlOProjectA.Migrations.OwloDB
{
    [DbContext(typeof(OwloDBContext))]
    [Migration("20220216125854_JKModels")]
    partial class JKModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OwlOProjectA.Models.Booking", b =>
                {
                    b.Property<int>("Booking_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("venueID")
                        .HasColumnType("int");

                    b.Property<int>("workshopID")
                        .HasColumnType("int");

                    b.HasKey("Booking_ID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("OwlOProjectA.Models.FAQ", b =>
                {
                    b.Property<string>("FAQ_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FAQ_Author")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FAQ_Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FAQ_DatePublished")
                        .HasColumnType("datetime2");

                    b.Property<string>("FAQ_ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FAQ_Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FAQ_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FAQ_ID");

                    b.ToTable("FAQs");
                });

            modelBuilder.Entity("OwlOProjectA.Models.LuckyDraw", b =>
                {
                    b.Property<string>("LuckyDraw_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LuckyDraw_Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("LuckyDraw_Cost")
                        .HasColumnType("int");

                    b.Property<string>("LuckyDraw_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(3000)")
                        .HasMaxLength(3000);

                    b.Property<DateTime>("LuckyDraw_Expiry")
                        .HasColumnType("datetime2");

                    b.Property<string>("LuckyDraw_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("LuckyDraw_OriginalQuantity")
                        .HasColumnType("int");

                    b.Property<int>("LuckyDraw_Quantity")
                        .HasColumnType("int");

                    b.HasKey("LuckyDraw_ID");

                    b.ToTable("LuckyDraws");
                });

            modelBuilder.Entity("OwlOProjectA.Models.Owlee", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(3000)")
                        .HasMaxLength(3000);

                    b.Property<string>("Citizenship")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.Property<string>("NRIC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<int>("Owl_Points")
                        .HasColumnType("int");

                    b.HasKey("Email");

                    b.ToTable("Owlees");
                });

            modelBuilder.Entity("OwlOProjectA.Models.Venue", b =>
                {
                    b.Property<int>("Venue_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weekdays")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weekends")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Venue_ID");

                    b.ToTable("Venues");
                });

            modelBuilder.Entity("OwlOProjectA.Models.Voucher", b =>
                {
                    b.Property<string>("Vouchers_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("DiscountDeal_Percentage")
                        .HasColumnType("float");

                    b.Property<string>("Inventory_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Super_Deal")
                        .HasColumnType("bit");

                    b.Property<string>("Voucher_Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Voucher_Cost")
                        .HasColumnType("int");

                    b.Property<string>("Voucher_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(3000)")
                        .HasMaxLength(3000);

                    b.Property<DateTime>("Voucher_Expiry")
                        .HasColumnType("datetime2");

                    b.Property<string>("Voucher_ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voucher_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Vouchers_ID");

                    b.ToTable("Vouchers");
                });

            modelBuilder.Entity("OwlOProjectA.Models.VoucherDistribution", b =>
                {
                    b.Property<string>("VoucherDistribution_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("VoucherDistribution_OwnerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VoucherDistribution_VoucherCompany")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("VoucherDistribution_VoucherCost")
                        .HasColumnType("int");

                    b.Property<DateTime>("VoucherDistribution_VoucherExpiry")
                        .HasColumnType("datetime2");

                    b.Property<string>("VoucherDistribution_VoucherID")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("VoucherDistribution_VoucherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("VoucherDistribution_VoucherSuperDeal")
                        .HasColumnType("bit");

                    b.HasKey("VoucherDistribution_ID");

                    b.ToTable("VoucherDistributions");
                });

            modelBuilder.Entity("OwlOProjectA.Models.Workshop", b =>
                {
                    b.Property<int>("Workshop_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Published")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ownerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("venueID")
                        .HasColumnType("int");

                    b.HasKey("Workshop_ID");

                    b.ToTable("Workshop");
                });
#pragma warning restore 612, 618
        }
    }
}