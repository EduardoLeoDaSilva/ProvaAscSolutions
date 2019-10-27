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
    [Migration("20191024181856_EntidadeProvaAdded")]
    partial class EntidadeProvaAdded
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

                    b.Property<int?>("AlunoId");

                    b.Property<string>("Nome");

                    b.HasKey("MateriaId");

                    b.HasIndex("AlunoId");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("GestaoApp.Models.Prova", b =>
                {
                    b.Property<int>("ProvaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MateriaId");

                    b.Property<string>("Nome");

                    b.Property<double>("Peso");

                    b.HasKey("ProvaId");

                    b.HasIndex("MateriaId");

                    b.ToTable("Provas");
                });

            modelBuilder.Entity("GestaoApp.Models.Turma", b =>
                {
                    b.Property<int>("TurmaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("GestaoApp.Models.Materia", b =>
                {
                    b.HasOne("GestaoApp.Models.Aluno")
                        .WithMany("Materias")
                        .HasForeignKey("AlunoId");
                });

            modelBuilder.Entity("GestaoApp.Models.Prova", b =>
                {
                    b.HasOne("GestaoApp.Models.Materia", "Materia")
                        .WithMany("Provas")
                        .HasForeignKey("MateriaId");
                });
#pragma warning restore 612, 618
        }
    }
}
