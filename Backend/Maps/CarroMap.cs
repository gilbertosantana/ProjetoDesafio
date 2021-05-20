using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Maps
{
    public class CarroMap : IEntityTypeConfiguration<Carro>
    {
        public void Configure(EntityTypeBuilder<Carro> builder)
        {
            builder.ToTable("Carro");
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id)
                .HasColumnName("IdCarro")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(20)");
            
            builder.Property(x => x.Modelo)
                .HasColumnName("Modelo")
                .HasColumnType("varchar(20)");

            builder.Property(x => x.AnoFabricacao)
                .HasColumnName("AnoFabricacao")
                .HasColumnType("varchar(20)");

            builder.Property(x => x.Cor)
                .HasColumnName("Cor")
                .HasColumnType("varchar(20)");

            builder.Property(x => x.Placa)
                .HasColumnName("Placa")
                .HasColumnType("varchar(20)");

            builder.HasIndex(x => x.Placa)
                .IsUnique();

            builder.HasOne(x => x.Marca).
                WithMany(x => x.Carro)
                .OnDelete(DeleteBehavior.SetNull); 

        }
    }
}
