﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mission4.Models;

namespace mission4.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20220202043108_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("mission4.Models.Application", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            CategoryID = 1,
                            Director = "Peter Jackson",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Lord of the Rings: The Fellowship of the Ring",
                            Year = (ushort)2001
                        },
                        new
                        {
                            MovieID = 2,
                            CategoryID = 1,
                            Director = "Peter Jackson",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Lord of the Rings: The Two Towers",
                            Year = (ushort)2002
                        },
                        new
                        {
                            MovieID = 3,
                            CategoryID = 1,
                            Director = "Peter Jackson",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Lord of the Rings: The Return of the King",
                            Year = (ushort)2002
                        });
                });

            modelBuilder.Entity("mission4.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("mission4.Models.Application", b =>
                {
                    b.HasOne("mission4.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}