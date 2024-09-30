using CQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CQRS.Infrastructure.Configurations
{
    internal class SomeEntityConfiguration: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Usuario", schema: "Seguridad");
            builder.HasKey(e => e.IdUsuario);
            //builder.Property(e => e.Usuario).IsRequired().HasMaxLength(20);
            // Otras configuraciones de la entidad.
        }
    }
}
