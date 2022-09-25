﻿// <auto-generated />
using System;
using Controller.AppRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Controller.Migrations
{
    [DbContext(typeof(MyAppContext))]
    partial class MyAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Model.entities.Colegio", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ciudad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nit")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("razonSocial")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Colegios");
                });

            modelBuilder.Entity("Model.entities.Deportista", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("apellidos")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("documento")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("eps")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("equipoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombres")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("residencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rh")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("equipoID");

                    b.ToTable("Deportistas");
                });

            modelBuilder.Entity("Model.entities.Entrenador", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("apellidos")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("documento")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("equipoId")
                        .HasColumnType("int");

                    b.Property<string>("genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nacionalidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombres")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("id");

                    b.HasIndex("equipoId")
                        .IsUnique();

                    b.ToTable("Entrenadores");
                });

            modelBuilder.Entity("Model.entities.Equipo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("categoria")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("disciplina")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int>("patrocinadorId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("patrocinadorId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Model.entities.Escenario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("capacidad")
                        .HasColumnType("int");

                    b.Property<string>("disciplina")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("instalacionId")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("id");

                    b.HasIndex("instalacionId");

                    b.ToTable("Escenarios");
                });

            modelBuilder.Entity("Model.entities.Instalacion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("capacidad")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("torneoId")
                        .HasColumnType("int");

                    b.Property<string>("ubicacion")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("id");

                    b.HasIndex("torneoId");

                    b.ToTable("Instalaciones");
                });

            modelBuilder.Entity("Model.entities.Juez", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("apellidos")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("colegioId")
                        .HasColumnType("int");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("documento")
                        .IsRequired()
                        .HasMaxLength(19)
                        .HasColumnType("nvarchar(19)");

                    b.Property<string>("genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombres")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("torneoId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("colegioId");

                    b.HasIndex("torneoId");

                    b.ToTable("Jueces");
                });

            modelBuilder.Entity("Model.entities.Municipio", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("secretaria")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("id");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("Model.entities.Patrocinador", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("documento")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoPersona")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("id");

                    b.ToTable("Patrocinadores");
                });

            modelBuilder.Entity("Model.entities.Torneo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("categoria")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("disciplina")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("fechaFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaInicial")
                        .HasColumnType("datetime2");

                    b.Property<int>("municipioId")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.HasIndex("municipioId");

                    b.ToTable("Torneos");
                });

            modelBuilder.Entity("Model.entities.TorneoEquipo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("equipoId")
                        .HasColumnType("int");

                    b.Property<int>("torneoId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("equipoId");

                    b.HasIndex("torneoId");

                    b.ToTable("TorneosEquipos");
                });

            modelBuilder.Entity("Model.entities.Deportista", b =>
                {
                    b.HasOne("Model.entities.Equipo", null)
                        .WithMany("deportista")
                        .HasForeignKey("equipoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.entities.Entrenador", b =>
                {
                    b.HasOne("Model.entities.Equipo", null)
                        .WithOne("entrenador")
                        .HasForeignKey("Model.entities.Entrenador", "equipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.entities.Equipo", b =>
                {
                    b.HasOne("Model.entities.Patrocinador", null)
                        .WithMany("equipos")
                        .HasForeignKey("patrocinadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.entities.Escenario", b =>
                {
                    b.HasOne("Model.entities.Instalacion", null)
                        .WithMany("escenarios")
                        .HasForeignKey("instalacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.entities.Instalacion", b =>
                {
                    b.HasOne("Model.entities.Torneo", null)
                        .WithMany("instalaciones")
                        .HasForeignKey("torneoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.entities.Juez", b =>
                {
                    b.HasOne("Model.entities.Colegio", null)
                        .WithMany("jueces")
                        .HasForeignKey("colegioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.entities.Torneo", null)
                        .WithMany("jueces")
                        .HasForeignKey("torneoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.entities.Torneo", b =>
                {
                    b.HasOne("Model.entities.Municipio", null)
                        .WithMany("torneos")
                        .HasForeignKey("municipioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.entities.TorneoEquipo", b =>
                {
                    b.HasOne("Model.entities.Equipo", "equipo")
                        .WithMany("torneoEquipo")
                        .HasForeignKey("equipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.entities.Torneo", "torneo")
                        .WithMany("TorneoEquipo")
                        .HasForeignKey("torneoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("equipo");

                    b.Navigation("torneo");
                });

            modelBuilder.Entity("Model.entities.Colegio", b =>
                {
                    b.Navigation("jueces");
                });

            modelBuilder.Entity("Model.entities.Equipo", b =>
                {
                    b.Navigation("deportista");

                    b.Navigation("entrenador");

                    b.Navigation("torneoEquipo");
                });

            modelBuilder.Entity("Model.entities.Instalacion", b =>
                {
                    b.Navigation("escenarios");
                });

            modelBuilder.Entity("Model.entities.Municipio", b =>
                {
                    b.Navigation("torneos");
                });

            modelBuilder.Entity("Model.entities.Patrocinador", b =>
                {
                    b.Navigation("equipos");
                });

            modelBuilder.Entity("Model.entities.Torneo", b =>
                {
                    b.Navigation("instalaciones");

                    b.Navigation("jueces");

                    b.Navigation("TorneoEquipo");
                });
#pragma warning restore 612, 618
        }
    }
}
