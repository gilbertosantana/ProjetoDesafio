using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Maps
{
    public class MarcaMap : IEntityTypeConfiguration<Marca>
    {

        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.ToTable("Marca");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("IdMarca");

            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(50)");
        }
    }
}