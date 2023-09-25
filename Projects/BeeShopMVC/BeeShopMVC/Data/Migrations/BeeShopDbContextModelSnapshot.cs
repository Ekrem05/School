﻿// <auto-generated />
using BeeShopMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BeeShopMVC.Data.Migrations
{
    [DbContext(typeof(BeeShopDbContext))]
    partial class BeeShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BeeShopMVC.Data.Models.Honey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Honey");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "blablablabllbalabalbla",
                            Name = "Български златен нектар",
                            Price = 15.289999999999999
                        },
                        new
                        {
                            Id = 2,
                            Description = "blablablabllbalabalbla",
                            Name = "Манов мед",
                            Price = 17.289999999999999
                        },
                        new
                        {
                            Id = 3,
                            Description = "blablablabllbalabalbla",
                            Name = "Мед от манаука",
                            Price = 25.289999999999999
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
