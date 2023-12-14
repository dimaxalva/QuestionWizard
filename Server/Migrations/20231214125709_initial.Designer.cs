﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Data;

#nullable disable

namespace Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231214125709_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Models.QuestionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ControlType")
                        .HasColumnType("int");

                    b.Property<int?>("SectionModelId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SectionModelId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Core.Models.QuestionOptionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("QuestionModelId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionModelId");

                    b.ToTable("QuestionOptions");
                });

            modelBuilder.Entity("Core.Models.SectionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SurveyModelId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SurveyModelId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("Core.Models.SurveyModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("Core.Models.QuestionModel", b =>
                {
                    b.HasOne("Core.Models.SectionModel", null)
                        .WithMany("Questions")
                        .HasForeignKey("SectionModelId");
                });

            modelBuilder.Entity("Core.Models.QuestionOptionModel", b =>
                {
                    b.HasOne("Core.Models.QuestionModel", null)
                        .WithMany("Options")
                        .HasForeignKey("QuestionModelId");
                });

            modelBuilder.Entity("Core.Models.SectionModel", b =>
                {
                    b.HasOne("Core.Models.SurveyModel", null)
                        .WithMany("Sections")
                        .HasForeignKey("SurveyModelId");
                });

            modelBuilder.Entity("Core.Models.QuestionModel", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("Core.Models.SectionModel", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Core.Models.SurveyModel", b =>
                {
                    b.Navigation("Sections");
                });
#pragma warning restore 612, 618
        }
    }
}
