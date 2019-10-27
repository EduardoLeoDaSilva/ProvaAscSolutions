﻿// <auto-generated />
using System;
using GestaoApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestaoApp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20191026014718_notasProva")]
    partial class notasProva
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestaoApp.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<int?>("TurmaId");

                    b.HasKey("AlunoId");

                    b.HasIndex("TurmaId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("GestaoApp.Models.Materia", b =>
                {
                    b.Property<int>("MateriaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("MateriaId");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("GestaoApp.Models.MateriaAluno", b =>
                {
                    b.Property<int>("MateriaId");

                    b.Property<int>("AlunoId");

                    b.HasKey("MateriaId", "AlunoId");

                    b.HasIndex("AlunoId");

                    b.ToTable("MateriaAluno");
                });

            modelBuilder.Entity("GestaoApp.Models.Prova", b =>
                {
                    b.Property<int>("ProvaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlunoId");

                    b.Property<int?>("MateriaId");

                    b.Property<string>("Nome");

                    b.Property<double>("Nota");

                    b.Property<double>("Peso");

                    b.HasKey("ProvaId");

                    b.HasIndex("AlunoId");

                    b.HasIndex("MateriaId");

                    b.ToTable("Provas");
                });

            modelBuilder.Entity("GestaoApp.Models.Turma", b =>
                {
                    b.Property<int>("TurmaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("TurmaId");

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("GestaoApp.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("GestaoApp.Models.Aluno", b =>
                {
                    b.HasOne("GestaoApp.Models.Turma", "Turma")
                        .WithMany("Alunos")
                        .HasForeignKey("TurmaId");
                });

            modelBuilder.Entity("GestaoApp.Models.MateriaAluno", b =>
                {
                    b.HasOne("GestaoApp.Models.Aluno", "Aluno")
                        .WithMany("MateriaAluno")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GestaoApp.Models.Materia", "Materia")
                        .WithMany("MateriaAluno")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GestaoApp.Models.Prova", b =>
                {
                    b.HasOne("GestaoApp.Models.Aluno", "Aluno")
                        .WithMany("Provas")
                        .HasForeignKey("AlunoId");

                    b.HasOne("GestaoApp.Models.Materia", "Materia")
                        .WithMany("Provas")
                        .HasForeignKey("MateriaId");
                });
#pragma warning restore 612, 618
        }
    }
}
