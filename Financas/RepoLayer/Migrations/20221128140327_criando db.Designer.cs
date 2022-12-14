// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepoLayer.Context;

#nullable disable

namespace RepoLayer.Migrations
{
    [DbContext(typeof(FinancasContext))]
    [Migration("20221128140327_criando db")]
    partial class criandodb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Models.CartaoDeCredito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bandeira")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Emissor")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("Fechamento")
                        .HasColumnType("datetime");

                    b.Property<int>("IdConta")
                        .HasColumnType("int");

                    b.Property<decimal>("Limite")
                        .HasColumnType("money");

                    b.Property<decimal>("Total")
                        .HasColumnType("money");

                    b.Property<DateTime>("Vencimento")
                        .HasColumnType("datetime");

                    b.Property<int>("contaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("contaId");

                    b.ToTable("CartoesDeCredito");
                });

            modelBuilder.Entity("EntityLayer.Models.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Banco")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("money");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("EntityLayer.Models.Despesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CartaoDeCreditoId")
                        .HasColumnType("int");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("datetime");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Foto")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("IdCartaoDeCredito")
                        .HasColumnType("int");

                    b.Property<int>("IdConta")
                        .HasColumnType("int");

                    b.Property<bool>("Pago")
                        .HasColumnType("bit");

                    b.Property<decimal>("Valor")
                        .HasColumnType("money");

                    b.Property<DateTime>("Vencimento")
                        .HasColumnType("datetime");

                    b.Property<int>("contaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartaoDeCreditoId");

                    b.HasIndex("contaId");

                    b.ToTable("Despesas");
                });

            modelBuilder.Entity("EntityLayer.Models.Receita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("datetime");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Foto")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdConta")
                        .HasColumnType("int");

                    b.Property<bool>("Recebido")
                        .HasColumnType("bit");

                    b.Property<decimal>("Valor")
                        .HasColumnType("money");

                    b.Property<int>("contaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("contaId");

                    b.ToTable("Receitas");
                });

            modelBuilder.Entity("EntityLayer.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .IsUnicode(false)
                        .HasColumnType("varchar(70)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(70)
                        .IsUnicode(false)
                        .HasColumnType("varchar(70)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("EntityLayer.Models.CartaoDeCredito", b =>
                {
                    b.HasOne("EntityLayer.Models.Conta", "conta")
                        .WithMany()
                        .HasForeignKey("contaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("conta");
                });

            modelBuilder.Entity("EntityLayer.Models.Conta", b =>
                {
                    b.HasOne("EntityLayer.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("EntityLayer.Models.Despesa", b =>
                {
                    b.HasOne("EntityLayer.Models.CartaoDeCredito", "CartaoDeCredito")
                        .WithMany()
                        .HasForeignKey("CartaoDeCreditoId");

                    b.HasOne("EntityLayer.Models.Conta", "conta")
                        .WithMany()
                        .HasForeignKey("contaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CartaoDeCredito");

                    b.Navigation("conta");
                });

            modelBuilder.Entity("EntityLayer.Models.Receita", b =>
                {
                    b.HasOne("EntityLayer.Models.Conta", "conta")
                        .WithMany()
                        .HasForeignKey("contaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("conta");
                });
#pragma warning restore 612, 618
        }
    }
}
