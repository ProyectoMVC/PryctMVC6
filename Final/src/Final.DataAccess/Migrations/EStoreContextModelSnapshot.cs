using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Final.DataAccess;

namespace Final.DataAccess.Migrations
{
    [DbContext(typeof(EStoreContext))]
    partial class EStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Final.Entities.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("FechaModificacion");

                    b.Property<DateTime>("FechaRegistro");

                    b.Property<bool>("FlagAnulado");

                    b.Property<string>("NombreCategoria")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 20);

                    b.HasKey("IdCategoria");
                });

            modelBuilder.Entity("Final.Entities.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Apellido")
                        .HasAnnotation("MaxLength", 25);

                    b.Property<int>("Correo")
                        .HasAnnotation("MaxLength", 60);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<DateTime?>("FechaModificacion");

                    b.Property<DateTime>("FechaRegistro");

                    b.Property<bool>("FlagAnulado");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 25);

                    b.Property<int>("Telefono")
                        .HasAnnotation("MaxLength", 8);

                    b.HasKey("IdCliente");
                });

            modelBuilder.Entity("Final.Entities.Detalle", b =>
                {
                    b.Property<int>("IdPedido");

                    b.Property<int>("IdProducto");

                    b.Property<decimal>("Cantidad");

                    b.Property<decimal>("Precio");

                    b.HasKey("IdPedido", "IdProducto");
                });

            modelBuilder.Entity("Final.Entities.Estado", b =>
                {
                    b.Property<int>("IdEstado")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("FechaModificacion");

                    b.Property<DateTime>("FechaRegistro");

                    b.Property<bool>("FlagAnulado");

                    b.Property<string>("IdEstado1")
                        .IsRequired();

                    b.Property<string>("NombreEstado")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 20);

                    b.HasKey("IdEstado");
                });

            modelBuilder.Entity("Final.Entities.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("FechaRegistro");

                    b.Property<string>("FormaPago");

                    b.Property<int>("IdCliente");

                    b.Property<string>("IdEstado");

                    b.Property<int>("NumeroPedido");

                    b.HasKey("IdPedido");
                });

            modelBuilder.Entity("Final.Entities.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<int>("Existencia");

                    b.Property<DateTime?>("FechaModificacion");

                    b.Property<DateTime>("FechaRegistro");

                    b.Property<bool>("FlagAnulado");

                    b.Property<int>("IdCategoria");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 25);

                    b.Property<decimal>("Precio");

                    b.HasKey("IdProducto");
                });

            modelBuilder.Entity("Final.Entities.Detalle", b =>
                {
                    b.HasOne("Final.Entities.Pedido")
                        .WithMany()
                        .HasForeignKey("IdPedido");

                    b.HasOne("Final.Entities.Producto")
                        .WithMany()
                        .HasForeignKey("IdProducto");
                });

            modelBuilder.Entity("Final.Entities.Pedido", b =>
                {
                    b.HasOne("Final.Entities.Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente");

                    b.HasOne("Final.Entities.Estado")
                        .WithMany()
                        .HasForeignKey("IdEstado")
                        .HasPrincipalKey("IdEstado1");
                });

            modelBuilder.Entity("Final.Entities.Producto", b =>
                {
                    b.HasOne("Final.Entities.Categoria")
                        .WithMany()
                        .HasForeignKey("IdCategoria");
                });
        }
    }
}
