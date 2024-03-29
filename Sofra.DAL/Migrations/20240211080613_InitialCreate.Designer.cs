﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sofra.DAL.EntityFramework.Context;

#nullable disable

namespace Sofra.DAL.Migrations
{
    [DbContext(typeof(SofraContext))]
    [Migration("20240211080613_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ReservationTable", b =>
                {
                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<int>("TablesId")
                        .HasColumnType("int");

                    b.HasKey("ReservationId", "TablesId");

                    b.HasIndex("TablesId");

                    b.ToTable("ReservationTable");
                });

            modelBuilder.Entity("Sofra.Data.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("TableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "Admin",
                            CreatedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6208),
                            Email = "johnDoe@mail.com",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "Admin",
                            ModifiedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6218),
                            Name = "John Doe",
                            Phone = "1234567890"
                        });
                });

            modelBuilder.Entity("Sofra.Data.Domain.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerCount")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Sofra.Data.Domain.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 4,
                            CreatedByName = "Admin",
                            CreatedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6546),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "Admin",
                            ModifiedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6547)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 6,
                            CreatedByName = "Admin",
                            CreatedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6551),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "Admin",
                            ModifiedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6551)
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 4,
                            CreatedByName = "Admin",
                            CreatedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6552),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "Admin",
                            ModifiedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6552)
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 6,
                            CreatedByName = "Admin",
                            CreatedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6553),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "Admin",
                            ModifiedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6554)
                        },
                        new
                        {
                            Id = 5,
                            Capacity = 5,
                            CreatedByName = "Admin",
                            CreatedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6555),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "Admin",
                            ModifiedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6555)
                        },
                        new
                        {
                            Id = 6,
                            Capacity = 4,
                            CreatedByName = "Admin",
                            CreatedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6556),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "Admin",
                            ModifiedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6556)
                        },
                        new
                        {
                            Id = 7,
                            Capacity = 4,
                            CreatedByName = "Admin",
                            CreatedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6557),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "Admin",
                            ModifiedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6557)
                        },
                        new
                        {
                            Id = 8,
                            Capacity = 3,
                            CreatedByName = "Admin",
                            CreatedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6558),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "Admin",
                            ModifiedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6558)
                        },
                        new
                        {
                            Id = 9,
                            Capacity = 2,
                            CreatedByName = "Admin",
                            CreatedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6559),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "Admin",
                            ModifiedDate = new DateTime(2024, 2, 11, 11, 6, 13, 439, DateTimeKind.Local).AddTicks(6560)
                        });
                });

            modelBuilder.Entity("ReservationTable", b =>
                {
                    b.HasOne("Sofra.Data.Domain.Reservation", null)
                        .WithMany()
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sofra.Data.Domain.Table", null)
                        .WithMany()
                        .HasForeignKey("TablesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sofra.Data.Domain.Customer", b =>
                {
                    b.HasOne("Sofra.Data.Domain.Table", null)
                        .WithMany("Customer")
                        .HasForeignKey("TableId");
                });

            modelBuilder.Entity("Sofra.Data.Domain.Reservation", b =>
                {
                    b.HasOne("Sofra.Data.Domain.Customer", "Customer")
                        .WithMany("Reservation")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Sofra.Data.Domain.Customer", b =>
                {
                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Sofra.Data.Domain.Table", b =>
                {
                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
