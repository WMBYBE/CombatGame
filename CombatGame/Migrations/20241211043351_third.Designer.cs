﻿// <auto-generated />
using System;
using CombatGame.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CombatGame.Migrations
{
    [DbContext(typeof(CharacterDbContext))]
    [Migration("20241211043351_third")]
    partial class third
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CombatGame.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterId"), 1L, 1);

                    b.Property<int>("Agility")
                        .HasColumnType("int");

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.Property<int>("HP")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("moveId")
                        .HasColumnType("int");

                    b.HasKey("CharacterId");

                    b.HasIndex("TeamId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            Agility = 10,
                            Defense = 10,
                            HP = 10,
                            Intelligence = 7,
                            Name = "Dave",
                            Strength = 20,
                            moveId = 1
                        },
                        new
                        {
                            CharacterId = 2,
                            Agility = 8,
                            Defense = 10,
                            HP = 5,
                            Intelligence = 25,
                            Name = "Tony",
                            Strength = 5,
                            moveId = 1
                        },
                        new
                        {
                            CharacterId = 3,
                            Agility = 25,
                            Defense = 10,
                            HP = 5,
                            Intelligence = 5,
                            Name = "Peter Griffin",
                            Strength = 5,
                            moveId = 1
                        },
                        new
                        {
                            CharacterId = 4,
                            Agility = 10,
                            Defense = 10,
                            HP = 10,
                            Intelligence = 20,
                            Name = "Kyle",
                            Strength = 7,
                            moveId = 1
                        },
                        new
                        {
                            CharacterId = 5,
                            Agility = 8,
                            Defense = 10,
                            HP = 5,
                            Intelligence = 5,
                            Name = "Terry",
                            Strength = 25,
                            moveId = 1
                        },
                        new
                        {
                            CharacterId = 6,
                            Agility = 25,
                            Defense = 10,
                            HP = 5,
                            Intelligence = 5,
                            Name = "Matt",
                            Strength = 8,
                            moveId = 1
                        });
                });

            modelBuilder.Entity("CombatGame.Models.Moves", b =>
                {
                    b.Property<int>("MoveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MoveId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Power")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("speed")
                        .HasColumnType("int");

                    b.HasKey("MoveId");

                    b.ToTable("Moves");

                    b.HasData(
                        new
                        {
                            MoveId = 1,
                            Description = "Basic attack",
                            Name = "Attack",
                            Power = 1.0,
                            Type = "Physical",
                            speed = 1
                        });
                });

            modelBuilder.Entity("CombatGame.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalWins")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TeamId");

                    b.HasIndex("UserId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            TeamId = 1,
                            Name = "Boston Beaters",
                            TotalWins = 0,
                            UserId = 1
                        },
                        new
                        {
                            TeamId = 2,
                            Name = "Das Boyyen",
                            TotalWins = 10,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("CombatGame.Models.TeamMembers", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("TeamMembers");

                    b.HasData(
                        new
                        {
                            id = 1,
                            CharacterId = 1,
                            TeamId = 1
                        },
                        new
                        {
                            id = 2,
                            CharacterId = 2,
                            TeamId = 1
                        },
                        new
                        {
                            id = 3,
                            CharacterId = 3,
                            TeamId = 1
                        },
                        new
                        {
                            id = 4,
                            CharacterId = 4,
                            TeamId = 2
                        },
                        new
                        {
                            id = 5,
                            CharacterId = 5,
                            TeamId = 2
                        },
                        new
                        {
                            id = 6,
                            CharacterId = 6,
                            TeamId = 2
                        });
                });

            modelBuilder.Entity("CombatGame.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalWins")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Password = "321",
                            TotalWins = 0,
                            UserName = "NYnumb1"
                        },
                        new
                        {
                            UserId = 2,
                            Password = "123",
                            TotalWins = 10,
                            UserName = "GERno1"
                        });
                });

            modelBuilder.Entity("CombatGame.Models.Character", b =>
                {
                    b.HasOne("CombatGame.Models.Team", null)
                        .WithMany("Characters")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("CombatGame.Models.Team", b =>
                {
                    b.HasOne("CombatGame.Models.User", "User")
                        .WithMany("Teams")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CombatGame.Models.Team", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("CombatGame.Models.User", b =>
                {
                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
