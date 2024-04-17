﻿// <auto-generated />
using System;
using FE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FE.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FE.Models.LabelData", b =>
                {
                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnName("content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnName("label")
                        .HasColumnType("nchar(20)")
                        .IsFixedLength(true)
                        .HasMaxLength(20);

                    b.ToTable("label_data");
                });

            modelBuilder.Entity("FE.Models.Log", b =>
                {
                    b.Property<int>("logID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("logID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("dateTime")
                        .HasColumnName("dateTime")
                        .HasColumnType("datetime2")
                        .IsFixedLength(true)
                        .HasMaxLength(20);

                    b.Property<int>("idUser")
                        .HasColumnName("idUser")
                        .HasColumnType("int");

                    b.Property<string>("logContent")
                        .IsRequired()
                        .HasColumnName("logContent")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("logID")
                        .HasName("PK__Log__7839F62D023AD65F");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("FE.Models.Raw", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnName("content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Keywords")
                        .IsRequired()
                        .HasColumnName("keywords")
                        .HasColumnType("nchar(500)")
                        .IsFixedLength(true)
                        .HasMaxLength(500);

                    b.Property<string>("PublishedDate")
                        .IsRequired()
                        .HasColumnName("published_date")
                        .HasColumnType("nchar(100)")
                        .IsFixedLength(true)
                        .HasMaxLength(100);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("nchar(500)")
                        .IsFixedLength(true)
                        .HasMaxLength(500);

                    b.Property<string>("TopImg")
                        .IsRequired()
                        .HasColumnName("top_img")
                        .HasColumnType("nchar(300)")
                        .IsFixedLength(true)
                        .HasMaxLength(300);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnName("url")
                        .HasColumnType("nchar(1000)")
                        .IsFixedLength(true)
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("raw");
                });

            modelBuilder.Entity("FE.Models.Users", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idUser")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdUser")
                        .HasName("PK__Users__3717C98294906179");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
