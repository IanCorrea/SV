
using ProjetoDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoDDD.Infra.Data.EntityConfig
{
    public class VendaConfiguration : EntityTypeConfiguration<Venda>
    {
        public VendaConfiguration()
        {
            HasKey(p => p.VendaId);

            Property(p => p.DataCadastro)
                .IsRequired();

            Property(p => p.Pedido)
                .IsRequired();

            Property(p => p.ValorTotal)
                .IsRequired();

            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);

            HasRequired(p => p.Colaborador)
                .WithMany()
                .HasForeignKey(p => p.ColaboradorId);

        }
    }
}
