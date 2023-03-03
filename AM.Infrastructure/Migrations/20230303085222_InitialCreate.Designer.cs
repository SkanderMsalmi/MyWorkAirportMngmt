﻿// <auto-generated />
using System;
using AM.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    [DbContext(typeof(AMContext))]
    [Migration("20230303085222_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AM.ApplicationCore.Domain.Flight", b =>
                {
                    b.Property<int>("flightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("flightId"), 1L, 1);

                    b.Property<string>("departure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("effectiveArrival")
                        .HasColumnType("datetime2");

                    b.Property<int>("estimatedDuration")
                        .HasColumnType("int");

                    b.Property<DateTime>("flightDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("planeId")
                        .HasColumnType("int");

                    b.HasKey("flightId");

                    b.HasIndex("planeId");

                    b.ToTable("flights");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Passenger", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("emailAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("passeportNumber")
                        .HasColumnType("int");

                    b.Property<int>("telNumber")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("passengers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Passenger");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Plane", b =>
                {
                    b.Property<int>("planeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("planeId"), 1L, 1);

                    b.Property<int>("capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("manufactureDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("planeType")
                        .HasColumnType("int");

                    b.HasKey("planeId");

                    b.ToTable("planes");
                });

            modelBuilder.Entity("FlightPassenger", b =>
                {
                    b.Property<int>("flightsflightId")
                        .HasColumnType("int");

                    b.Property<int>("peseengersid")
                        .HasColumnType("int");

                    b.HasKey("flightsflightId", "peseengersid");

                    b.HasIndex("peseengersid");

                    b.ToTable("FlightPassenger");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Staff", b =>
                {
                    b.HasBaseType("AM.ApplicationCore.Domain.Passenger");

                    b.Property<DateTime>("employementDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("function")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("salary")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("Staff");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Traveller", b =>
                {
                    b.HasBaseType("AM.ApplicationCore.Domain.Passenger");

                    b.Property<string>("healthInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Traveller");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Flight", b =>
                {
                    b.HasOne("AM.ApplicationCore.Domain.Plane", "plane")
                        .WithMany("flights")
                        .HasForeignKey("planeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("plane");
                });

            modelBuilder.Entity("FlightPassenger", b =>
                {
                    b.HasOne("AM.ApplicationCore.Domain.Flight", null)
                        .WithMany()
                        .HasForeignKey("flightsflightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AM.ApplicationCore.Domain.Passenger", null)
                        .WithMany()
                        .HasForeignKey("peseengersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Plane", b =>
                {
                    b.Navigation("flights");
                });
#pragma warning restore 612, 618
        }
    }
}
