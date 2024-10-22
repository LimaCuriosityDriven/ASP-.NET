﻿// <auto-generated />
using System;
using GestaoDeResiduos.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace GestaoDeResiduos.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240627090925_AddEstadoTable")]
    partial class AddEstadoTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestaoDeResiduos.Models.StateModel", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID")
                        .HasDefaultValueSql("ESTADOS_SEQ.NEXTVAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NAME");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("NVARCHAR2(2)")
                        .HasColumnName("UF");

                    b.HasKey("Id");

                    b.ToTable("ESTADOS", (string)null);
                });

            modelBuilder.Entity("GestaoDeResiduos.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID")
                        .HasDefaultValueSql("USERS_SEQ.NEXTVAL");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("BIRTH_DATE");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NAME");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("PASSWORD");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("ROLE");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("IDX_EMAIL");

                    b.ToTable("USERS", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
