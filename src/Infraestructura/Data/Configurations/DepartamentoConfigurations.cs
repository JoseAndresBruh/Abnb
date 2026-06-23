using Dominio.Departamentos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Data.Configurations;

internal sealed class DepartamentoConfigurations : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
        builder.ToTable("departamentos");
        builder.HasKey(d => d.Id);

        // Mapeo de Value Objects
        builder.OwnsOne(d => d.Nombre, nb => nb.Property(n => n.Valor).HasColumnName("nombre"));
        builder.OwnsOne(d => d.Descripcion, dc => dc.Property(d => d.Valor).HasColumnName("descripcion"));
        builder.OwnsOne(d => d.Direccion, dir =>
        {
            dir.Property(d => d.Pais).HasColumnName("pais");
            dir.Property(d => d.Ciudad).HasColumnName("ciudad");
            dir.Property(d => d.Calle).HasColumnName("calle");
        });
        
        // Mapeo de dinero (asumiendo que tiene monto y moneda)
        builder.OwnsOne(d => d.Precio, p =>
        {
            p.Property(d => d.Monto).HasColumnName("precio_monto");
            p.Property(d => d.Moneda).HasColumnName("precio_moneda");
        });
    }
}