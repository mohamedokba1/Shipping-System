﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shipping.Entities;

#nullable disable

namespace Shipping.Entities.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230619225539_UpdateOrdersTable")]
    partial class UpdateOrdersTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GovermentSalesRepresentative", b =>
                {
                    b.Property<int>("GovermentsGoverment_Id")
                        .HasColumnType("int");

                    b.Property<long>("SalesRepresentativesSalesRepresentativeId")
                        .HasColumnType("bigint");

                    b.HasKey("GovermentsGoverment_Id", "SalesRepresentativesSalesRepresentativeId");

                    b.HasIndex("SalesRepresentativesSalesRepresentativeId");

                    b.ToTable("GovermentSalesRepresentative");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PrivellgeSalesRepresentative", b =>
                {
                    b.Property<int>("PrivellgesPrivellge_Id")
                        .HasColumnType("int");

                    b.Property<long>("SalesRepresentativesSalesRepresentativeId")
                        .HasColumnType("bigint");

                    b.HasKey("PrivellgesPrivellge_Id", "SalesRepresentativesSalesRepresentativeId");

                    b.HasIndex("SalesRepresentativesSalesRepresentativeId");

                    b.ToTable("PrivellgeSalesRepresentative");
                });

            modelBuilder.Entity("PrivellgeTrader", b =>
                {
                    b.Property<int>("PrivellgesPrivellge_Id")
                        .HasColumnType("int");

                    b.Property<long>("TradersTraderId")
                        .HasColumnType("bigint");

                    b.HasKey("PrivellgesPrivellge_Id", "TradersTraderId");

                    b.HasIndex("TradersTraderId");

                    b.ToTable("PrivellgeTrader");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Identity.ApplicationUserRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<string>("branchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("salesPersonSalesRepresentativeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("salesPersonSalesRepresentativeId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.City", b =>
                {
                    b.Property<int>("City_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("City_Id"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GovermentId")
                        .HasColumnType("int");

                    b.Property<double>("NormalShippingCost")
                        .HasColumnType("float");

                    b.Property<double>("PickupShippingCost")
                        .HasColumnType("float");

                    b.HasKey("City_Id");

                    b.HasIndex("GovermentId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Customer", b =>
                {
                    b.Property<long>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CustomerId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Goverment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone1")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Phone2")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Village")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Employee", b =>
                {
                    b.Property<long>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("EmployeeId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("branchid")
                        .HasColumnType("int");

                    b.Property<int>("privillageid")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("UserId");

                    b.HasIndex("branchid");

                    b.HasIndex("privillageid");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Goverment", b =>
                {
                    b.Property<int>("Goverment_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Goverment_Id"));

                    b.Property<string>("GovermentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.HasKey("Goverment_Id");

                    b.ToTable("Goverments");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Order", b =>
                {
                    b.Property<long>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("OrderId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyBranch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<bool>("DeliveredToVillage")
                        .HasColumnType("bit");

                    b.Property<double>("ExtraWeightCost")
                        .HasColumnType("float");

                    b.Property<string>("Government")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<long?>("SalesRepresentativeId")
                        .HasColumnType("bigint");

                    b.Property<int>("ShippingType")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<double>("TotalCost")
                        .HasColumnType("float");

                    b.Property<int>("TotalWeight")
                        .HasColumnType("int");

                    b.Property<long?>("TraderId")
                        .HasColumnType("bigint");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SalesRepresentativeId");

                    b.HasIndex("TraderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Privellge", b =>
                {
                    b.Property<int>("Privellge_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Privellge_Id"));

                    b.Property<string>("PrivellgeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("Privellge_Id");

                    b.ToTable("Privellges");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Product", b =>
                {
                    b.Property<long>("Product_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Product_Id"));

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Product_Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.SalesRepresentative", b =>
                {
                    b.Property<long>("SalesRepresentativeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("SalesRepresentativeId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CompanyPercentage")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("SalesRepresentativeId");

                    b.HasIndex("UserId");

                    b.ToTable("SalesRepresentatives");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.SpecialPackage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("City_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Goverment_Id")
                        .HasColumnType("int");

                    b.Property<double>("ShippingCost")
                        .HasColumnType("float");

                    b.Property<long?>("TraderId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("City_Id");

                    b.HasIndex("Goverment_Id");

                    b.HasIndex("TraderId");

                    b.ToTable("SpecialPackages");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Trader", b =>
                {
                    b.Property<long>("TraderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TraderId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyBranch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CostPerRefusedOrder")
                        .HasColumnType("float");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TraderId");

                    b.HasIndex("UserId");

                    b.ToTable("Traders");
                });

            modelBuilder.Entity("GovermentSalesRepresentative", b =>
                {
                    b.HasOne("Shipping.Entities.Domain.Models.Goverment", null)
                        .WithMany()
                        .HasForeignKey("GovermentsGoverment_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.Entities.Domain.Models.SalesRepresentative", null)
                        .WithMany()
                        .HasForeignKey("SalesRepresentativesSalesRepresentativeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Shipping.Entities.Domain.Identity.ApplicationUserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Shipping.Entities.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Shipping.Entities.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Shipping.Entities.Domain.Identity.ApplicationUserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.Entities.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Shipping.Entities.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PrivellgeSalesRepresentative", b =>
                {
                    b.HasOne("Shipping.Entities.Domain.Models.Privellge", null)
                        .WithMany()
                        .HasForeignKey("PrivellgesPrivellge_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.Entities.Domain.Models.SalesRepresentative", null)
                        .WithMany()
                        .HasForeignKey("SalesRepresentativesSalesRepresentativeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PrivellgeTrader", b =>
                {
                    b.HasOne("Shipping.Entities.Domain.Models.Privellge", null)
                        .WithMany()
                        .HasForeignKey("PrivellgesPrivellge_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.Entities.Domain.Models.Trader", null)
                        .WithMany()
                        .HasForeignKey("TradersTraderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Branch", b =>
                {
                    b.HasOne("Shipping.Entities.Domain.Models.SalesRepresentative", "salesPerson")
                        .WithMany("Branchs")
                        .HasForeignKey("salesPersonSalesRepresentativeId");

                    b.Navigation("salesPerson");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.City", b =>
                {
                    b.HasOne("Shipping.Entities.Domain.Models.Goverment", "goverment")
                        .WithMany("Cities")
                        .HasForeignKey("GovermentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("goverment");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Employee", b =>
                {
                    b.HasOne("Shipping.Entities.Domain.Identity.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("Shipping.Entities.Domain.Models.Branch", "branch")
                        .WithMany("Employees")
                        .HasForeignKey("branchid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.Entities.Domain.Models.Privellge", "Privillage")
                        .WithMany("Employees")
                        .HasForeignKey("privillageid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Privillage");

                    b.Navigation("User");

                    b.Navigation("branch");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Order", b =>
                {
                    b.HasOne("Shipping.Entities.Domain.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Shipping.Entities.Domain.Models.SalesRepresentative", "SalesRepresentative")
                        .WithMany("Orders")
                        .HasForeignKey("SalesRepresentativeId");

                    b.HasOne("Shipping.Entities.Domain.Models.Trader", "Trader")
                        .WithMany("Orders")
                        .HasForeignKey("TraderId");

                    b.Navigation("Customer");

                    b.Navigation("SalesRepresentative");

                    b.Navigation("Trader");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Product", b =>
                {
                    b.HasOne("Shipping.Entities.Domain.Models.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.SalesRepresentative", b =>
                {
                    b.HasOne("Shipping.Entities.Domain.Identity.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.SpecialPackage", b =>
                {
                    b.HasOne("Shipping.Entities.Domain.Models.City", "city")
                        .WithMany()
                        .HasForeignKey("City_Id");

                    b.HasOne("Shipping.Entities.Domain.Models.Goverment", "goverment")
                        .WithMany()
                        .HasForeignKey("Goverment_Id");

                    b.HasOne("Shipping.Entities.Domain.Models.Trader", "trader")
                        .WithMany()
                        .HasForeignKey("TraderId");

                    b.Navigation("city");

                    b.Navigation("goverment");

                    b.Navigation("trader");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Trader", b =>
                {
                    b.HasOne("Shipping.Entities.Domain.Identity.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Branch", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Goverment", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Order", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Privellge", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.SalesRepresentative", b =>
                {
                    b.Navigation("Branchs");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Shipping.Entities.Domain.Models.Trader", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}