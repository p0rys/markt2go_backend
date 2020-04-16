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
    [Migration("20200415112212_UserDataInReservation")]
    partial class UserDataInReservation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Markt2Go.Model.Item", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<string>("ArticleId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ReservationId")
                        .HasColumnType("bigint")
                        .HasMaxLength(50);

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Markt2Go.Model.Market", b =>
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
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Markets");
                });

            modelBuilder.Entity("Markt2Go.Model.MarketSeller", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CreditCardAccepted")
                        .HasColumnType("bit");

                    b.Property<bool>("DebitCardAccepted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int?>("LastReservationOffset")
                        .HasColumnType("int");

                    b.Property<long>("MarketId")
                        .HasColumnType("bigint");

                    b.Property<string>("Portfolio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SellerId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MarketId");

                    b.HasIndex("SellerId", "MarketId")
                        .IsUnique();

                    b.ToTable("MarketSellers");
                });

            modelBuilder.Entity("Markt2Go.Model.Reservation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Accepted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<long>("MarketSellerId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Packed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("Pickup")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<bool>("RulesAccepted")
                        .HasColumnType("bit");

                    b.Property<string>("SellerComment")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<long?>("SellerId")
                        .HasColumnType("bigint");

                    b.Property<string>("UserComment")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("MarketSellerId");

                    b.HasIndex("SellerId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Markt2Go.Model.Seller", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("Markt2Go.Model.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<long?>("SellerId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Markt2Go.Model.Item", b =>
                {
                    b.HasOne("Markt2Go.Model.Reservation", "Reservation")
                        .WithMany("Items")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Markt2Go.Model.MarketSeller", b =>
                {
                    b.HasOne("Markt2Go.Model.Market", "Market")
                        .WithMany("MarketSellers")
                        .HasForeignKey("MarketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Markt2Go.Model.Seller", "Seller")
                        .WithMany("MarketSellers")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Markt2Go.Model.Reservation", b =>
                {
                    b.HasOne("Markt2Go.Model.MarketSeller", "MarketSeller")
                        .WithMany()
                        .HasForeignKey("MarketSellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Markt2Go.Model.Seller", null)
                        .WithMany("Reservations")
                        .HasForeignKey("SellerId");

                    b.HasOne("Markt2Go.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Markt2Go.Model.User", b =>
                {
                    b.HasOne("Markt2Go.Model.Seller", "Seller")
                        .WithMany("Users")
                        .HasForeignKey("SellerId");
                });
#pragma warning restore 612, 618
        }
    }
}
