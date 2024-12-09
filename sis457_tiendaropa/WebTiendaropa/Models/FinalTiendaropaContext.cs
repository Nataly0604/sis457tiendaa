using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebTiendaropa.Models;

public partial class FinalTiendaropaContext : DbContext
{
    public FinalTiendaropaContext()
    {
    }

    public FinalTiendaropaContext(DbContextOptions<FinalTiendaropaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<DetalleCompra> DetalleCompras { get; set; }

    public virtual DbSet<DetalleVentum> DetalleVenta { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<HistorialCompra> HistorialCompras { get; set; }

    public virtual DbSet<HistorialVentum> HistorialVenta { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Ventum> Venta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=FinalTiendaropa;User ID=usrtiendaropa;Password=123456");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3213E83FFE8EB353");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cliente__3213E83F30C6B449");

            entity.ToTable("Cliente");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Email)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreCompleto");
            entity.Property(e => e.Telefono)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Compra__3213E83F52D18590");

            entity.ToTable("Compra");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdProveedor).HasColumnName("idProveedor");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.MontoTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("montoTotal");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numeroDocumento");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipoDocumento");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Compras)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Compra_Proveedor");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Compras)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Compra_Usuario");
        });

        modelBuilder.Entity<DetalleCompra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DetalleC__3213E83F93850AB0");

            entity.ToTable("DetalleCompra");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdCompra).HasColumnName("idCompra");
            entity.Property(e => e.IdProducto).HasColumnName("idProducto");
            entity.Property(e => e.PrecioCompra)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precioCompra");
            entity.Property(e => e.PrecioVenta)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precioVenta");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdCompraNavigation).WithMany(p => p.DetalleCompras)
                .HasForeignKey(d => d.IdCompra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_DetalleCompra_Compra");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleCompras)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_DetalleCompra_Producto");
        });

        modelBuilder.Entity<DetalleVentum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DetalleV__3213E83FE077D2ED");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdProducto).HasColumnName("idProducto");
            entity.Property(e => e.IdVenta).HasColumnName("idVenta");
            entity.Property(e => e.PrecioVenta)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precioVenta");
            entity.Property(e => e.SubTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subTotal");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_DetalleVenta_Producto");

            entity.HasOne(d => d.IdVentaNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_DetalleVenta_Venta");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Empleado__3213E83F67EA2FD6");

            entity.ToTable("Empleado");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cargo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cargo");
            entity.Property(e => e.CedulaIdentidad)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("cedulaIdentidad");
            entity.Property(e => e.Celular).HasColumnName("celular");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Nombres)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("primerApellido");
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("segundoApellido");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
        });

        modelBuilder.Entity<HistorialCompra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Historia__3213E83FE8FA9F02");

            entity.ToTable("HistorialCompra");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdProducto).HasColumnName("idProducto");
            entity.Property(e => e.PrecioCompra)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precioCompra");
            entity.Property(e => e.PrecioVenta)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precioVenta");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.HistorialCompras)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_HistorialCompra_Producto");
        });

        modelBuilder.Entity<HistorialVentum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Historia__3213E83F4E98105A");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdProducto).HasColumnName("idProducto");
            entity.Property(e => e.PrecioVenta)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precioVenta");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.HistorialVenta)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_HistorialVenta_Producto");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producto__3213E83F3D88CA95");

            entity.ToTable("Producto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.PrecioVenta)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precioVenta");
            entity.Property(e => e.Stock).HasColumnName("stock");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Producto_Categoria");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Proveedo__3213E83FC9498688");

            entity.ToTable("Proveedor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Email)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("razonSocial");
            entity.Property(e => e.Telefono)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3213E83F73A44DF1");

            entity.ToTable("Usuario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Clave)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("usuario");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Usuario_Empleado");
        });

        modelBuilder.Entity<Ventum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Venta__3213E83F9143EF95");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DocumentoCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("documentoCliente");
            entity.Property(e => e.Estado)
                .HasDefaultValue((short)1)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.MontoCambio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("montoCambio");
            entity.Property(e => e.MontoPago)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("montoPago");
            entity.Property(e => e.MontoTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("montoTotal");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombreCliente");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numeroDocumento");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipoDocumento");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
