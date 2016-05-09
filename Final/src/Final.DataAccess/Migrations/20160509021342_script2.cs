using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Final.DataAccess.Migrations
{
    public partial class script2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaModificacion = table.Column<DateTime>(nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    FlagAnulado = table.Column<bool>(nullable: false),
                    NombreCategoria = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.IdCategoria);
                });
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apellido = table.Column<int>(nullable: false),
                    Correo = table.Column<int>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    FlagAnulado = table.Column<bool>(nullable: false),
                    NombreCliente = table.Column<string>(nullable: false),
                    Telefono = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
                });
            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    IdEstado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaModificacion = table.Column<DateTime>(nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    FlagAnulado = table.Column<bool>(nullable: false),
                    IdEstado1 = table.Column<string>(nullable: false),
                    NombreEstado = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.IdEstado);
                    table.UniqueConstraint("AK_Estado_IdEstado1", x => x.IdEstado1);
                });
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    IdProducto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: false),
                    Existencia = table.Column<int>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    FlagAnulado = table.Column<bool>(nullable: false),
                    IdCategoria = table.Column<int>(nullable: false),
                    NombreProducto = table.Column<string>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.IdProducto);
                    table.ForeignKey(
                        name: "FK_Producto_Categoria_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categoria",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    IdPedido = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    FormaPago = table.Column<string>(nullable: true),
                    IdCliente = table.Column<int>(nullable: false),
                    IdEstado = table.Column<string>(nullable: true),
                    NumeroPedido = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.IdPedido);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedido_Estado_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "Estado",
                        principalColumn: "IdEstado1",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "Detalle",
                columns: table => new
                {
                    IdPedido = table.Column<int>(nullable: false),
                    IdProducto = table.Column<int>(nullable: false),
                    Cantidad = table.Column<decimal>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle", x => new { x.IdPedido, x.IdProducto });
                    table.ForeignKey(
                        name: "FK_Detalle_Pedido_IdPedido",
                        column: x => x.IdPedido,
                        principalTable: "Pedido",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detalle_Producto_IdProducto",
                        column: x => x.IdProducto,
                        principalTable: "Producto",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Detalle");
            migrationBuilder.DropTable("Pedido");
            migrationBuilder.DropTable("Producto");
            migrationBuilder.DropTable("Cliente");
            migrationBuilder.DropTable("Estado");
            migrationBuilder.DropTable("Categoria");
        }
    }
}
