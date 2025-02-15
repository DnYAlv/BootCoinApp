﻿// <auto-generated />
using System;
using BootCoinApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BootCoinApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230212140635_CompleteMigration")]
    partial class CompleteMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BootCoinApp.Models.AddCoinCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddCoinCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequiredCoin")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AddCoinCategories");
                });

            modelBuilder.Entity("BootCoinApp.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("BootCoinApp.Models.CategoryReward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CategoryRewards");
                });

            modelBuilder.Entity("BootCoinApp.Models.DetailTransactionAddCoinGroup", b =>
                {
                    b.Property<int>("TransactionAddCoinGroupId")
                        .HasColumnType("int");

                    b.Property<int>("AddCoinId")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.HasKey("TransactionAddCoinGroupId", "AddCoinId", "GroupId");

                    b.HasIndex("AddCoinId");

                    b.HasIndex("GroupId");

                    b.ToTable("DetailTransactionAddCoinGroups");
                });

            modelBuilder.Entity("BootCoinApp.Models.DetailTransactionAddCoinUser", b =>
                {
                    b.Property<int>("TransactionAddCoinUserId")
                        .HasColumnType("int");

                    b.Property<int>("AddCoinId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TransactionAddCoinUserId", "AddCoinId", "UserId");

                    b.HasIndex("AddCoinId");

                    b.HasIndex("UserId");

                    b.ToTable("DetailTransactionAddCoinUsers");
                });

            modelBuilder.Entity("BootCoinApp.Models.GroupUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Bootcoin")
                        .HasColumnType("int");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GroupUsers");
                });

            modelBuilder.Entity("BootCoinApp.Models.HeaderTransactionAddCoinGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("HeaderTransactionAddCoinGroups");
                });

            modelBuilder.Entity("BootCoinApp.Models.HeaderTransactionAddCoinUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("HeaderTransactionAddCoinUsers");
                });

            modelBuilder.Entity("BootCoinApp.Models.Reward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequiredCoin")
                        .HasColumnType("int");

                    b.Property<string>("RewardDescription")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("RewardName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Rewards");
                });

            modelBuilder.Entity("BootCoinApp.Models.TransactionReward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("RewardId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("RewardId");

                    b.HasIndex("UserId");

                    b.ToTable("TransactionRewards");
                });

            modelBuilder.Entity("BootCoinApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Bootcoin")
                        .HasColumnType("int");

                    b.Property<string>("Divisi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BootCoinApp.Models.DetailTransactionAddCoinGroup", b =>
                {
                    b.HasOne("BootCoinApp.Models.AddCoinCategory", "AddCoinCategory")
                        .WithMany("DetailTransactionAddCoinGroups")
                        .HasForeignKey("AddCoinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BootCoinApp.Models.GroupUser", "GroupUser")
                        .WithMany("DetailTransactionAddCoinGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BootCoinApp.Models.HeaderTransactionAddCoinGroup", "HeaderTransactionAddCoinGroup")
                        .WithMany("DetailTransactionAddCoinGroups")
                        .HasForeignKey("TransactionAddCoinGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddCoinCategory");

                    b.Navigation("GroupUser");

                    b.Navigation("HeaderTransactionAddCoinGroup");
                });

            modelBuilder.Entity("BootCoinApp.Models.DetailTransactionAddCoinUser", b =>
                {
                    b.HasOne("BootCoinApp.Models.AddCoinCategory", "AddCoinCategory")
                        .WithMany("DetailTransactionAddCoinUsers")
                        .HasForeignKey("AddCoinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BootCoinApp.Models.HeaderTransactionAddCoinUser", "HeaderTransactionAddCoinUser")
                        .WithMany("DetailTransactionAddCoinUsers")
                        .HasForeignKey("TransactionAddCoinUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BootCoinApp.Models.User", "User")
                        .WithMany("DetailTransactionAddCoinUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddCoinCategory");

                    b.Navigation("HeaderTransactionAddCoinUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BootCoinApp.Models.HeaderTransactionAddCoinGroup", b =>
                {
                    b.HasOne("BootCoinApp.Models.Admin", "Admin")
                        .WithMany("HeaderTransactionAddCoinGroups")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("BootCoinApp.Models.HeaderTransactionAddCoinUser", b =>
                {
                    b.HasOne("BootCoinApp.Models.Admin", "Admin")
                        .WithMany("HeaderTransactionAddCoinUsers")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("BootCoinApp.Models.Reward", b =>
                {
                    b.HasOne("BootCoinApp.Models.CategoryReward", "CategoryReward")
                        .WithMany("Rewards")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryReward");
                });

            modelBuilder.Entity("BootCoinApp.Models.TransactionReward", b =>
                {
                    b.HasOne("BootCoinApp.Models.Admin", "Admin")
                        .WithMany("TransactionRewards")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BootCoinApp.Models.Reward", "Reward")
                        .WithMany("TransactionRewards")
                        .HasForeignKey("RewardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BootCoinApp.Models.User", "User")
                        .WithMany("TransactionRewards")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Reward");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BootCoinApp.Models.User", b =>
                {
                    b.HasOne("BootCoinApp.Models.GroupUser", "GroupUser")
                        .WithMany("Users")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupUser");
                });

            modelBuilder.Entity("BootCoinApp.Models.AddCoinCategory", b =>
                {
                    b.Navigation("DetailTransactionAddCoinGroups");

                    b.Navigation("DetailTransactionAddCoinUsers");
                });

            modelBuilder.Entity("BootCoinApp.Models.Admin", b =>
                {
                    b.Navigation("HeaderTransactionAddCoinGroups");

                    b.Navigation("HeaderTransactionAddCoinUsers");

                    b.Navigation("TransactionRewards");
                });

            modelBuilder.Entity("BootCoinApp.Models.CategoryReward", b =>
                {
                    b.Navigation("Rewards");
                });

            modelBuilder.Entity("BootCoinApp.Models.GroupUser", b =>
                {
                    b.Navigation("DetailTransactionAddCoinGroups");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("BootCoinApp.Models.HeaderTransactionAddCoinGroup", b =>
                {
                    b.Navigation("DetailTransactionAddCoinGroups");
                });

            modelBuilder.Entity("BootCoinApp.Models.HeaderTransactionAddCoinUser", b =>
                {
                    b.Navigation("DetailTransactionAddCoinUsers");
                });

            modelBuilder.Entity("BootCoinApp.Models.Reward", b =>
                {
                    b.Navigation("TransactionRewards");
                });

            modelBuilder.Entity("BootCoinApp.Models.User", b =>
                {
                    b.Navigation("DetailTransactionAddCoinUsers");

                    b.Navigation("TransactionRewards");
                });
#pragma warning restore 612, 618
        }
    }
}
