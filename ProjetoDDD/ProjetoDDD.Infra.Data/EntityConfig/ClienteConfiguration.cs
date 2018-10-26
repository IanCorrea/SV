
using ProjetoDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoDDD.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Idade)
                .IsRequired();                

            Property(c => c.Telefone)
                .IsRequired()
                .HasMaxLength(20);

            Property(c => c.Cpf)
                .IsRequired()
                .HasMaxLength(14);

            Property(c => c.Email)
                .IsRequired();
        }
    }
}
