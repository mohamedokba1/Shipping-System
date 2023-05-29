﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shipping.Entities;

#nullable disable

namespace Shipping.Entities.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CustomerOrder", b =>
                {
                    b.Property<Guid>("CustomersCustomer_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrdersOrder_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CustomersCustomer_Id", "OrdersOrder_Id");

                    b.HasIndex("OrdersOrder_Id");

                    b.ToTable("CustomerOrder");
                });

            modelBuilder.Entity("EmployeePrivellge", b =>
                {
                    b.Property<Guid>("EmployeesEmployee_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PrivillagesPrivellge_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EmployeesEmployee_Id", "PrivillagesPrivellge_Id");

                    b.HasIndex("PrivillagesPrivellge_Id");

                    b.ToTable("EmployeePrivellge");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<Guid>("OrdersOrder_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductsProduct_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrdersOrder_Id", "ProductsProduct_Id");

                    b.HasIndex("ProductsProduct_Id");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("PrivellgeSalesRepresentative", b =>
                {
                    b.Property<Guid>("PrivellgesPrivellge_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SalesRepresentativesSalesRepresentative_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PrivellgesPrivellge_Id", "SalesRepresentativesSalesRepresentative_Id");

                    b.HasIndex("SalesRepresentativesSalesRepresentative_Id");

                    b.ToTable("PrivellgeSalesRepresentative");
                });

            modelBuilder.Entity("PrivellgeTrader", b =>
                {
                    b.Property<Guid>("PrivellgesPrivellge_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TradersTrader_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PrivellgesPrivellge_Id", "TradersTrader_Id");

                    b.HasIndex("TradersTrader_Id");

                    b.ToTable("PrivellgeTrader");
                });

            modelBuilder.Entity("Shipping.Entities.Models.City", b =>
                {
                    b.Property<int>("City_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("City_Id"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Goverment_Id")
                        .HasColumnType("int");

                    b.Property<double>("NormalShippingCost")
                        .HasColumnType("float");

                    b.HasKey("City_Id");

                    b.HasIndex("Goverment_Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Shipping.Entities.Models.Customer", b =>
                {
                    b.Property<Guid>("Customer_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

                    b.HasKey("Customer_Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Shipping.Entities.Models.Employee", b =>
                {
                    b.Property<Guid>("Employee_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Employee_Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Shipping.Entities.Models.Goverment", b =>
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

            modelBuilder.Entity("Shipping.Entities.Models.Order", b =>
                {
                    b.Property<Guid>("Order_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyBranch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DefaultCost")
                        .HasColumnType("float");

                    b.Property<double>("ExtraWeightCost")
                        .HasColumnType("float");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<Guid>("salesRepresentativeIdSalesRepresentative_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("shipping_type")
                        .HasColumnType("int");

                    b.Property<Guid>("traderIdTrader_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Order_Id");

                    b.HasIndex("salesRepresentativeIdSalesRepresentative_Id");

                    b.HasIndex("traderIdTrader_Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Shipping.Entities.Models.Privellge", b =>
                {
                    b.Property<Guid>("Privellge_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PrivellgeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Privellge_Id");

                    b.ToTable("Privellges");
                });

            modelBuilder.Entity("Shipping.Entities.Models.Product", b =>
                {
                    b.Property<Guid>("Product_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Product_Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Shipping.Entities.Models.SalesRepresentative", b =>
                {
                    b.Property<Guid>("SalesRepresentative_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CompanyPercentage")
                        .HasColumnType("float");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Goverment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalesRepresentative_Id");

                    b.ToTable("SalesRepresentatives");
                });

            modelBuilder.Entity("Shipping.Entities.Models.Trader", b =>
                {
                    b.Property<Guid>("Trader_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyBranch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<double>("CostPerRefusedOrder")
                        .HasColumnType("float");

                    b.Property<string>("Email")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TraderName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Trader_Id");

                    b.ToTable("Traders");
                });

            modelBuilder.Entity("CustomerOrder", b =>
                {
                    b.HasOne("Shipping.Entities.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersCustomer_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.Entities.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersOrder_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeePrivellge", b =>
                {
                    b.HasOne("Shipping.Entities.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployee_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.Entities.Models.Privellge", null)
                        .WithMany()
                        .HasForeignKey("PrivillagesPrivellge_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("Shipping.Entities.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersOrder_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.Entities.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProduct_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PrivellgeSalesRepresentative", b =>
                {
                    b.HasOne("Shipping.Entities.Models.Privellge", null)
                        .WithMany()
                        .HasForeignKey("PrivellgesPrivellge_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.Entities.Models.SalesRepresentative", null)
                        .WithMany()
                        .HasForeignKey("SalesRepresentativesSalesRepresentative_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PrivellgeTrader", b =>
                {
                    b.HasOne("Shipping.Entities.Models.Privellge", null)
                        .WithMany()
                        .HasForeignKey("PrivellgesPrivellge_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.Entities.Models.Trader", null)
                        .WithMany()
                        .HasForeignKey("TradersTrader_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shipping.Entities.Models.City", b =>
                {
                    b.HasOne("Shipping.Entities.Models.Goverment", "goverment")
                        .WithMany("Cities")
                        .HasForeignKey("Goverment_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("goverment");
                });

            modelBuilder.Entity("Shipping.Entities.Models.Order", b =>
                {
                    b.HasOne("Shipping.Entities.Models.SalesRepresentative", "salesRepresentativeId")
                        .WithMany("Orders")
                        .HasForeignKey("salesRepresentativeIdSalesRepresentative_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shipping.Entities.Models.Trader", "traderId")
                        .WithMany("Orders")
                        .HasForeignKey("traderIdTrader_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("salesRepresentativeId");

                    b.Navigation("traderId");
                });

            modelBuilder.Entity("Shipping.Entities.Models.Goverment", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Shipping.Entities.Models.SalesRepresentative", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Shipping.Entities.Models.Trader", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
