
using ProjetoDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoDDD.Infra.Data.EntityConfig
{
    public class ColaboradorConfiguration : EntityTypeConfiguration<Colaborador>
    {
        public ColaboradorConfiguration()
        {
            HasKey(c => c.ColaboradorId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Idade)
                .IsRequired();

            Property(c => c.Apelido)
                .IsRequired();

            Property(c => c.Sexo)
                .IsRequired()
                .HasMaxLength(1);
        }
    }
}
