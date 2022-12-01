using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepoLayer.Migrations
{
    /// <inheritdoc />
    public partial class criandodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: false),
                    Email = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: false),
                    Senha = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Banco = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Tipo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Saldo = table.Column<decimal>(type: "money", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartoesDeCredito",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bandeira = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Emissor = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Vencimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Fechamento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Total = table.Column<decimal>(type: "money", nullable: false),
                    Limite = table.Column<decimal>(type: "money", nullable: false),
                    IdConta = table.Column<int>(type: "int", nullable: false),
                    contaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartoesDeCredito", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartoesDeCredito_Contas_contaId",
                        column: x => x.contaId,
                        principalTable: "Contas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recebido = table.Column<bool>(type: "bit", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Valor = table.Column<decimal>(type: "money", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Categoria = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Foto = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdConta = table.Column<int>(type: "int", nullable: false),
                    contaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receitas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receitas_Contas_contaId",
                        column: x => x.contaId,
                        principalTable: "Contas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Despesas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pago = table.Column<bool>(type: "bit", nullable: false),
                    Vencimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdCartaoDeCredito = table.Column<int>(type: "int", nullable: true),
                    CartaoDeCreditoId = table.Column<int>(type: "int", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Valor = table.Column<decimal>(type: "money", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Categoria = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Foto = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdConta = table.Column<int>(type: "int", nullable: false),
                    contaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despesas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Despesas_CartoesDeCredito_CartaoDeCreditoId",
                        column: x => x.CartaoDeCreditoId,
                        principalTable: "CartoesDeCredito",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Despesas_Contas_contaId",
                        column: x => x.contaId,
                        principalTable: "Contas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartoesDeCredito_contaId",
                table: "CartoesDeCredito",
                column: "contaId");

            migrationBuilder.CreateIndex(
                name: "IX_Contas_UsuarioId",
                table: "Contas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Despesas_CartaoDeCreditoId",
                table: "Despesas",
                column: "CartaoDeCreditoId");

            migrationBuilder.CreateIndex(
                name: "IX_Despesas_contaId",
                table: "Despesas",
                column: "contaId");

            migrationBuilder.CreateIndex(
                name: "IX_Receitas_contaId",
                table: "Receitas",
                column: "contaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Despesas");

            migrationBuilder.DropTable(
                name: "Receitas");

            migrationBuilder.DropTable(
                name: "CartoesDeCredito");

            migrationBuilder.DropTable(
                name: "Contas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
