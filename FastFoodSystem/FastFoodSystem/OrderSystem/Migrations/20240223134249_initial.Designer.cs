﻿// <auto-generated />
using System;
using CompleteSystem.OrdersSystem.Enteties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CompleteSystem.Migrations
{
    [DbContext(typeof(OrderDbContext))]
    [Migration("20240223134249_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CompleteSystem.OrdersSystem.Enteties.IngridientEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ItemEntityId")
                        .HasColumnType("int");

                    b.Property<double>("Kg")
                        .HasColumnType("double");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ItemEntityId");

                    b.ToTable("Ingridients");
                });

            modelBuilder.Entity("CompleteSystem.OrdersSystem.Enteties.ItemEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PoruchkaId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("PoruchkaId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("CompleteSystem.OrdersSystem.Enteties.PoruchkaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Poruchki");
                });

            modelBuilder.Entity("CompleteSystem.OrdersSystem.Enteties.IngridientEntity", b =>
                {
                    b.HasOne("CompleteSystem.OrdersSystem.Enteties.ItemEntity", null)
                        .WithMany("Ingridients")
                        .HasForeignKey("ItemEntityId");
                });

            modelBuilder.Entity("CompleteSystem.OrdersSystem.Enteties.ItemEntity", b =>
                {
                    b.HasOne("CompleteSystem.OrdersSystem.Enteties.PoruchkaEntity", "PoruchkaEntity")
                        .WithMany("Items")
                        .HasForeignKey("PoruchkaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PoruchkaEntity");
                });

            modelBuilder.Entity("CompleteSystem.OrdersSystem.Enteties.ItemEntity", b =>
                {
                    b.Navigation("Ingridients");
                });

            modelBuilder.Entity("CompleteSystem.OrdersSystem.Enteties.PoruchkaEntity", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}