﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransportServices.Data;

namespace TransportServices.Migrations.TransportDb
{
    [DbContext(typeof(TransportDbContext))]
    [Migration("20190602114123_addVehicleEntery")]
    partial class addVehicleEntery
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TransportServices.Data.AdminDbModels.VehicleModel", b =>
                {
                    b.Property<string>("VehicleNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("vehicleNo");

                    b.Property<string>("BiltyNo")
                        .HasColumnName("biltyNo");

                    b.Property<long>("DriverContact")
                        .HasColumnName("driverContact");

                    b.Property<string>("DriverName")
                        .HasColumnName("driverName");

                    b.Property<string>("InvoiceNo")
                        .HasColumnName("invoiceNo");

                    b.Property<int>("QuantityPMT")
                        .HasColumnName("quantity_pmt");

                    b.Property<string>("Remark")
                        .HasColumnName("remark");

                    b.Property<string>("Status")
                        .HasColumnName("status");

                    b.Property<int>("TotalTime")
                        .HasColumnName("TotalTime");

                    b.Property<string>("TransportName")
                        .HasColumnName("transportName");

                    b.Property<string>("TransporterName")
                        .HasColumnName("transporterName");

                    b.Property<DateTime>("VeheicleOutDate")
                        .HasColumnName("veheicleOutDate");

                    b.Property<DateTime>("VehicleInDate")
                        .HasColumnName("vehicleInDate");

                    b.HasKey("VehicleNo");

                    b.ToTable("vehicle_entry");
                });
#pragma warning restore 612, 618
        }
    }
}
