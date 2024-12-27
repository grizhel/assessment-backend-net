﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pigeon_crud_service.Models;

#nullable disable

namespace pigeon_crud_service.Migrations
{
    [DbContext(typeof(PigeonDBContext))]
    [Migration("20241225204015_location_update")]
    partial class location_update
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("general")
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("pigeon_crud_service.Models.DBModels.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("FirmId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(63)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("varchar(63)");

                    b.HasKey("Id");

                    b.HasIndex("FirmId");

                    b.ToTable("Contact", "general");
                });

            modelBuilder.Entity("pigeon_crud_service.Models.DBModels.ContactInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("uuid");

                    b.Property<int>("ContactType")
                        .HasColumnType("integer");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("ContactInfo", "general");
                });

            modelBuilder.Entity("pigeon_crud_service.Models.DBModels.Firm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Firm", "general");
                });

            modelBuilder.Entity("pigeon_crud_service.Models.DBModels.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NVIAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(63)");

                    b.HasKey("Id");

                    b.ToTable("Location", "general");
                });

            modelBuilder.Entity("pigeon_crud_service.Models.DBModels.Contact", b =>
                {
                    b.HasOne("pigeon_crud_service.Models.DBModels.Firm", "Firm")
                        .WithMany("Contacts")
                        .HasForeignKey("FirmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Firm");
                });

            modelBuilder.Entity("pigeon_crud_service.Models.DBModels.ContactInfo", b =>
                {
                    b.HasOne("pigeon_crud_service.Models.DBModels.Contact", "Contact")
                        .WithMany("ContactInformations")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("pigeon_crud_service.Models.DBModels.Firm", b =>
                {
                    b.HasOne("pigeon_crud_service.Models.DBModels.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("pigeon_crud_service.Models.DBModels.Contact", b =>
                {
                    b.Navigation("ContactInformations");
                });

            modelBuilder.Entity("pigeon_crud_service.Models.DBModels.Firm", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
