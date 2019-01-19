﻿// <auto-generated />
using System;
using FilmReleases.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FilmReleases.Migrations
{
    [DbContext(typeof(FilmsDbContext))]
    partial class FilmsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FilmReleases.Data.Entities.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdDuration");

                    b.Property<string>("Distributor");

                    b.Property<int>("Duration");

                    b.Property<int>("MinimumAge");

                    b.Property<string>("Name");

                    b.Property<DateTime>("Release");

                    b.HasKey("Id");

                    b.ToTable("Films");
                });
#pragma warning restore 612, 618
        }
    }
}
