﻿// <auto-generated />
using System;
using EPVA.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EPVA.Repository.Migrations
{
    [DbContext(typeof(EPVAContext))]
    [Migration("20220924033517_RefactorEntities")]
    partial class RefactorEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EPVA.Domain.GestaoCurso.Aluno", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClasseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClasseId");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("EPVA.Domain.GestaoCurso.Classe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ModuloId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProfessorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ModuloId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Classe");
                });

            modelBuilder.Entity("EPVA.Domain.GestaoCurso.Professor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("EPVA.Domain.PlanoAula.Aula", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ModuloId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ModuloId");

                    b.ToTable("Aula");
                });

            modelBuilder.Entity("EPVA.Domain.PlanoAula.Material", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AulaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Backdrop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ModuloId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AulaId");

                    b.HasIndex("ModuloId");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("EPVA.Domain.PlanoAula.Modulo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Modulo");
                });

            modelBuilder.Entity("EPVA.Domain.GestaoCurso.Aluno", b =>
                {
                    b.HasOne("EPVA.Domain.GestaoCurso.Classe", null)
                        .WithMany("Alunos")
                        .HasForeignKey("ClasseId");

                    b.OwnsOne("EPVA.Domain.GestaoCurso.ValueObject.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("AlunoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Valor")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Email");

                            b1.HasKey("AlunoId");

                            b1.ToTable("Aluno");

                            b1.WithOwner()
                                .HasForeignKey("AlunoId");
                        });

                    b.OwnsOne("EPVA.Domain.GestaoCurso.ValueObject.Password", "Password", b1 =>
                        {
                            b1.Property<Guid>("AlunoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Valor")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Password");

                            b1.HasKey("AlunoId");

                            b1.ToTable("Aluno");

                            b1.WithOwner()
                                .HasForeignKey("AlunoId");
                        });

                    b.Navigation("Email");

                    b.Navigation("Password");
                });

            modelBuilder.Entity("EPVA.Domain.GestaoCurso.Classe", b =>
                {
                    b.HasOne("EPVA.Domain.PlanoAula.Modulo", "Modulo")
                        .WithMany()
                        .HasForeignKey("ModuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EPVA.Domain.GestaoCurso.Professor", "Professor")
                        .WithMany()
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modulo");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("EPVA.Domain.GestaoCurso.Professor", b =>
                {
                    b.OwnsOne("EPVA.Domain.GestaoCurso.ValueObject.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("ProfessorId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Valor")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Email");

                            b1.HasKey("ProfessorId");

                            b1.ToTable("Professor");

                            b1.WithOwner()
                                .HasForeignKey("ProfessorId");
                        });

                    b.OwnsOne("EPVA.Domain.GestaoCurso.ValueObject.Password", "Password", b1 =>
                        {
                            b1.Property<Guid>("ProfessorId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Valor")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Password");

                            b1.HasKey("ProfessorId");

                            b1.ToTable("Professor");

                            b1.WithOwner()
                                .HasForeignKey("ProfessorId");
                        });

                    b.Navigation("Email");

                    b.Navigation("Password");
                });

            modelBuilder.Entity("EPVA.Domain.PlanoAula.Aula", b =>
                {
                    b.HasOne("EPVA.Domain.PlanoAula.Modulo", "Modulo")
                        .WithMany("Aulas")
                        .HasForeignKey("ModuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modulo");
                });

            modelBuilder.Entity("EPVA.Domain.PlanoAula.Material", b =>
                {
                    b.HasOne("EPVA.Domain.PlanoAula.Aula", null)
                        .WithMany("Materiais")
                        .HasForeignKey("AulaId");

                    b.HasOne("EPVA.Domain.PlanoAula.Modulo", null)
                        .WithMany("Materiais")
                        .HasForeignKey("ModuloId");
                });

            modelBuilder.Entity("EPVA.Domain.GestaoCurso.Classe", b =>
                {
                    b.Navigation("Alunos");
                });

            modelBuilder.Entity("EPVA.Domain.PlanoAula.Aula", b =>
                {
                    b.Navigation("Materiais");
                });

            modelBuilder.Entity("EPVA.Domain.PlanoAula.Modulo", b =>
                {
                    b.Navigation("Aulas");

                    b.Navigation("Materiais");
                });
#pragma warning restore 612, 618
        }
    }
}