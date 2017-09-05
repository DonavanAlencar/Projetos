using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TorredeHanoi.Infra.Data.Extensions;
using TorredeHanoi.Models;
using Microsoft.EntityFrameworkCore;

namespace TorredeHanoi.Infra.Data.Mappings
{
    public class LogMap : EntityTypeConfiguration<Log>
    {
        public override void Map(EntityTypeBuilder<Log> builder)
        {
            builder.HasKey(c => c.Indexador);

            builder.Property(c => c.Disk)
                .HasColumnName("Disk");

            builder.Property(c => c.FromPole)
                .HasColumnName("FromPole");

            builder.Property(c => c.ToPole)
                .HasColumnName("ToPole");

            builder.Property(c => c.Mensagem)
                .HasColumnType("varchar(1000)")
                .HasMaxLength(1000)
                .IsRequired();

            builder.Property(c => c.Data)
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .IsRequired();
        }
    }
}
