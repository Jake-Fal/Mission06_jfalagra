﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_jfalagra.Models;

namespace Mission06_jfalagra.Migrations
{
    [DbContext(typeof(MovieDBContext))]
    partial class MovieDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_jfalagra.Models.AddMovieModel", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GenresCategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent_To")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("GenresCategoryID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryID = 1,
                            Director = "Andy Muschietti",
                            Edited = true,
                            Rating = "R",
                            Title = "IT",
                            Year = (ushort)2017
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryID = 2,
                            Director = "Adam McKay",
                            Edited = true,
                            Rating = "PG-13",
                            Title = "Anchorman",
                            Year = (ushort)2004
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryID = 3,
                            Director = "Tony Scott",
                            Edited = true,
                            Rating = "PG",
                            Title = "Top Gun",
                            Year = (ushort)1986
                        });
                });

            modelBuilder.Entity("Mission06_jfalagra.Models.Genre", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("genres");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Action"
                        });
                });

            modelBuilder.Entity("Mission06_jfalagra.Models.AddMovieModel", b =>
                {
                    b.HasOne("Mission06_jfalagra.Models.Genre", "Genres")
                        .WithMany()
                        .HasForeignKey("GenresCategoryID");
                });
#pragma warning restore 612, 618
        }
    }
}
