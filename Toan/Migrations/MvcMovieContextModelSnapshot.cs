﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Data;

#nullable disable

namespace Toan.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    partial class MvcMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("Toan.Models.Sinhvien", b =>
                {
                    b.Property<string>("Masinhvien")
                        .HasColumnType("TEXT");

                    b.Property<string>("Hoten")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Malop")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Masinhvien");

                    b.ToTable("Sinhvien");
                });
#pragma warning restore 612, 618
        }
    }
}
