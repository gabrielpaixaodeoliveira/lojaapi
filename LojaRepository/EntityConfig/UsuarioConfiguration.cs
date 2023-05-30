using LojaService.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LojaRepository.EntityConfig
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("tb_usuario").HasKey(p => p.IdUsuario);
            builder.Property(p => p.IdUsuario).HasColumnName("Id");
            builder.Property(p => p.Nome).HasColumnName("Nome");
            builder.Property(p => p.Cpf).HasColumnName("Cpf");
            builder.Property(p => p.DtNascimento).HasColumnName("Dt_Nascimento");
            builder.Property(p => p.Login).HasColumnName("Login");
            builder.Property(p => p.Senha).HasColumnName("Senha");
            builder.Property(p => p.Email).HasColumnName("Email");
            builder.Property(p => p.IdPerfil).HasColumnName("id_perfil");
        }
    }
}
