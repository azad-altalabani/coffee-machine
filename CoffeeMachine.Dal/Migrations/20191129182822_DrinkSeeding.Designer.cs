﻿// <auto-generated />
using System;
using CoffeeMachine.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoffeeMachine.Dal.Migrations
{
    [DbContext(typeof(CoffeMachineDbContext))]
    [Migration("20191129182822_DrinkSeeding")]
    partial class DrinkSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoffeeMachine.Dal.Models.BadgeModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("ID");

                    b.ToTable("Badges");
                });

            modelBuilder.Entity("CoffeeMachine.Dal.Models.DrinkModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("CoffeeMachine.Dal.Models.OrderModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BadgeID")
                        .HasColumnType("int");

                    b.Property<int?>("DrinkID")
                        .HasColumnType("int");

                    b.Property<bool>("HasOwnMug")
                        .HasColumnType("bit");

                    b.Property<int>("SugarLevel")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BadgeID");

                    b.HasIndex("DrinkID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CoffeeMachine.Dal.Models.OrderModel", b =>
                {
                    b.HasOne("CoffeeMachine.Dal.Models.BadgeModel", "Badge")
                        .WithMany("OrderList")
                        .HasForeignKey("BadgeID");

                    b.HasOne("CoffeeMachine.Dal.Models.DrinkModel", "Drink")
                        .WithMany()
                        .HasForeignKey("DrinkID");
                });
#pragma warning restore 612, 618
        }
    }
}
