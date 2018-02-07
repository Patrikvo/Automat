﻿// <auto-generated />
using Automat.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace Automat.Migrations
{
    [DbContext(typeof(DossierContext))]
    [Migration("20180202125319_InitalMigration")]
    partial class InitalMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Automat.Model.Dossier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DossierId");

                    b.Property<string>("dossierNummer")
                        .IsRequired();

                    b.Property<string>("dossierStandvanzaken");

                    b.Property<string>("dossierTitel");

                    b.HasKey("Id");

                    b.HasIndex("DossierId");

                    b.ToTable("dossiers");
                });

            modelBuilder.Entity("Automat.Model.Dossier", b =>
                {
                    b.HasOne("Automat.Model.Dossier")
                        .WithMany("dossiers")
                        .HasForeignKey("DossierId");
                });
#pragma warning restore 612, 618
        }
    }
}
