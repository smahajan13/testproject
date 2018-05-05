﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SalesMarket.Repo;
using System;

namespace SalesMarket.Repo.Migrations
{
    [DbContext(typeof(SalesDbContext))]
    [Migration("20180429122956_initialDataBase")]
    partial class initialDataBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SalesMakert.Data.Model.Parties", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Address");

                    b.Property<decimal>("DiscountPercentage");

                    b.Property<string>("Email");

                    b.Property<string>("GSTNumber")
                        .IsRequired();

                    b.Property<string>("IPAddress");

                    b.Property<DateTime>("LastUpdate");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("MobileNumber")
                        .IsRequired();

                    b.Property<string>("PartyName")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<int>("Pincode");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.Property<string>("UniqueCode");

                    b.HasKey("Id");

                    b.ToTable("Parties");
                });

            modelBuilder.Entity("SalesMakert.Data.Model.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<decimal>("CGST");

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.Property<string>("DistributerId");

                    b.Property<string>("DistributerName");

                    b.Property<DateTime>("ExpiryDate");

                    b.Property<string>("GSTNumber")
                        .IsRequired();

                    b.Property<string>("IPAddress");

                    b.Property<DateTime>("LastUpdate");

                    b.Property<DateTime>("ManufacturingDate");

                    b.Property<decimal>("MarketPrize");

                    b.Property<string>("ProductName")
                        .IsRequired();

                    b.Property<decimal>("SGST");

                    b.Property<int>("StockCount");

                    b.Property<decimal>("StockPrize");

                    b.Property<string>("Type");

                    b.Property<string>("UniqueCode")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SalesMakert.Data.Model.Tokens", b =>
                {
                    b.Property<string>("userName")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("password")
                        .IsRequired();

                    b.HasKey("userName");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("SalesMakert.Data.Model.TokensData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<DateTime>("ExpiryRefreshToken");

                    b.Property<DateTime>("ExpiryToken");

                    b.Property<string>("IPAddress");

                    b.Property<DateTime>("LastUpdate");

                    b.Property<string>("RefreshToken")
                        .IsRequired();

                    b.Property<string>("Token")
                        .IsRequired();

                    b.Property<int>("UsersId");

                    b.HasKey("Id");

                    b.HasIndex("UsersId")
                        .IsUnique();

                    b.ToTable("TokensData");
                });

            modelBuilder.Entity("SalesMakert.Data.Model.UserProfile", b =>
                {
                    b.Property<int>("Id");

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("IPAddress");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("LastUpdate");

                    b.Property<string>("MobileNumeber");

                    b.HasKey("Id");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("SalesMakert.Data.Model.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("IPAddress");

                    b.Property<DateTime>("LastUpdate");

                    b.Property<string>("Password");

                    b.Property<string>("Role");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SalesMakert.Data.Model.TokensData", b =>
                {
                    b.HasOne("SalesMakert.Data.Model.Users", "Users")
                        .WithOne("TokensData")
                        .HasForeignKey("SalesMakert.Data.Model.TokensData", "UsersId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesMakert.Data.Model.UserProfile", b =>
                {
                    b.HasOne("SalesMakert.Data.Model.Users", "Users")
                        .WithOne("UserProfile")
                        .HasForeignKey("SalesMakert.Data.Model.UserProfile", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
