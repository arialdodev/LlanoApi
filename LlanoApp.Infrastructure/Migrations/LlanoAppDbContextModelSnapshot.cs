﻿// <auto-generated />
using System;
using LlanoApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LlanoApp.Infrastructure.Migrations
{
    [DbContext(typeof(LlanoAppDbContext))]
    partial class LlanoAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LlanoApp.Domain.AggregateModel.ResourceAggregate.MessageHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResourcesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ResourcesId");

                    b.ToTable("MessageHistories");
                });

            modelBuilder.Entity("LlanoApp.Domain.AggregateModel.ResourceAggregate.ResourceStates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ResourceStates");
                });

            modelBuilder.Entity("LlanoApp.Domain.AggregateModel.ResourceAggregate.ResourceTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ResourceTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 7, 22, 9, 5, 3, 424, DateTimeKind.Local).AddTicks(7954),
                            TypeName = "Leyenda",
                            UpdateDate = new DateTime(2024, 7, 22, 9, 5, 3, 424, DateTimeKind.Local).AddTicks(7933)
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 7, 22, 9, 5, 3, 424, DateTimeKind.Local).AddTicks(7959),
                            TypeName = "Palabras",
                            UpdateDate = new DateTime(2024, 7, 22, 9, 5, 3, 424, DateTimeKind.Local).AddTicks(7958)
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 7, 22, 9, 5, 3, 424, DateTimeKind.Local).AddTicks(7961),
                            TypeName = "Coplas",
                            UpdateDate = new DateTime(2024, 7, 22, 9, 5, 3, 424, DateTimeKind.Local).AddTicks(7960)
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2024, 7, 22, 9, 5, 3, 424, DateTimeKind.Local).AddTicks(7963),
                            TypeName = "Refranes",
                            UpdateDate = new DateTime(2024, 7, 22, 9, 5, 3, 424, DateTimeKind.Local).AddTicks(7962)
                        });
                });

            modelBuilder.Entity("LlanoApp.Domain.AggregateModel.ResourceAggregate.Resources", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResourceStatesId")
                        .HasColumnType("int");

                    b.Property<int>("ResourceTypesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ResourceStatesId");

                    b.HasIndex("ResourceTypesId");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("LlanoApp.Domain.AggregateModel.ResourceAggregate.MessageHistory", b =>
                {
                    b.HasOne("LlanoApp.Domain.AggregateModel.ResourceAggregate.Resources", "Resources")
                        .WithMany("MessageHistory")
                        .HasForeignKey("ResourcesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resources");
                });

            modelBuilder.Entity("LlanoApp.Domain.AggregateModel.ResourceAggregate.Resources", b =>
                {
                    b.HasOne("LlanoApp.Domain.AggregateModel.ResourceAggregate.ResourceStates", "ResourceStates")
                        .WithMany("Resources")
                        .HasForeignKey("ResourceStatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LlanoApp.Domain.AggregateModel.ResourceAggregate.ResourceTypes", "ResourceTypes")
                        .WithMany("Resources")
                        .HasForeignKey("ResourceTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ResourceStates");

                    b.Navigation("ResourceTypes");
                });

            modelBuilder.Entity("LlanoApp.Domain.AggregateModel.ResourceAggregate.ResourceStates", b =>
                {
                    b.Navigation("Resources");
                });

            modelBuilder.Entity("LlanoApp.Domain.AggregateModel.ResourceAggregate.ResourceTypes", b =>
                {
                    b.Navigation("Resources");
                });

            modelBuilder.Entity("LlanoApp.Domain.AggregateModel.ResourceAggregate.Resources", b =>
                {
                    b.Navigation("MessageHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
