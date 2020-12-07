using JRShop.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JRShop.Infra.Mapeamentos
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("Id_Usuario")
                .HasColumnType("Varchar(40)")
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasColumnName("Nome_Usuario")
                .HasColumnType("varchar(40)")
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnName("Email_Usuario")
                .HasColumnType("varchar(40)")
                .IsRequired();

            builder.Property(x => x.Senha)
                .HasColumnName("Senha_Usuario")
                .HasColumnType("varchar(40)")
                .IsRequired();
        }
    }
}
