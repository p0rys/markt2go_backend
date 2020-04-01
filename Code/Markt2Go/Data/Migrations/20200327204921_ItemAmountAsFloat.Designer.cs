﻿// <auto-generated />
using System;
using Markt2Go.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Markt2Go.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200327204921_ItemAmountAsFloat")]
    partial class ItemAmountAsFloat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Markt2Go.Models.Item", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ReservationId")
                        .HasColumnType("bigint");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Markt2Go.Models.Market", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.HasKey("Id");

                    b.ToTable("Markets");
                });

            modelBuilder.Entity("Markt2Go.Models.MarketSeller", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("MarketId")
                        .HasColumnType("bigint");

                    b.Property<string>("Portfolio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SellerId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MarketId");

                    b.HasIndex("SellerId", "MarketId")
                        .IsUnique();

                    b.ToTable("MarketSellers");
                });

            modelBuilder.Entity("Markt2Go.Models.Reservation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Accepted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("MarketSellerId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Packed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("Pickup")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("SellerComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("SellerId")
                        .HasColumnType("bigint");

                    b.Property<string>("UserComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("MarketSellerId");

                    b.HasIndex("SellerId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Markt2Go.Models.Seller", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("Markt2Go.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsValidated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("SellerId")
                        .HasColumnType("bigint");

                    b.Property<string>("Town")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Markt2Go.Models.Item", b =>
                {
                    b.HasOne("Markt2Go.Models.Reservation", "Reservation")
                        .WithMany("Items")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Markt2Go.Models.MarketSeller", b =>
                {
                    b.HasOne("Markt2Go.Models.Market", "Market")
                        .WithMany("MarketSellers")
                        .HasForeignKey("MarketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Markt2Go.Models.Seller", "Seller")
                        .WithMany("MarketSellers")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Markt2Go.Models.Reservation", b =>
                {
                    b.HasOne("Markt2Go.Models.MarketSeller", "MarketSeller")
                        .WithMany()
                        .HasForeignKey("MarketSellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Markt2Go.Models.Seller", null)
                        .WithMany("Reservations")
                        .HasForeignKey("SellerId");

                    b.HasOne("Markt2Go.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Markt2Go.Models.User", b =>
                {
                    b.HasOne("Markt2Go.Models.Seller", "Seller")
                        .WithMany("Users")
                        .HasForeignKey("SellerId");
                });
#pragma warning restore 612, 618
        }
    }
}
