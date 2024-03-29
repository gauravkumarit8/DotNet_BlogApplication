﻿// <auto-generated />
using Blog.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240112054921_build")]
    partial class build
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blog.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Excerpt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "GRV",
                            Excerpt = "This is first",
                            Title = "Post1"
                        },
                        new
                        {
                            Id = 2,
                            Author = "VSK",
                            Excerpt = "This is second",
                            Title = "Post2"
                        },
                        new
                        {
                            Id = 3,
                            Author = "AKT",
                            Excerpt = "This is third",
                            Title = "Post3"
                        },
                        new
                        {
                            Id = 4,
                            Author = "SRV",
                            Excerpt = "This is forth",
                            Title = "Post4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
