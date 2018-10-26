namespace ProjetoDDD.Infra.Data.Migrations
{
    using Domain.Entities;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.ProjetoDDDContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.ProjetoDDDContext context)
        {
            //context.Clientes.AddOrUpdate(c => c.ClienteId,
            //    new Cliente() { ClienteId = 1, Nome = "Ian Correa", Idade = 24, Telefone = "(12) 98204-8556", Cpf = "394.483.968-48", Email = "ian_cbs@hotmail.com" },
            //    new Cliente() { ClienteId = 2, Nome = "Daniel Stocker", Idade = 23, Telefone = "(12) 95478-6589", Cpf = "258.546.987-50", Email = "daniel.stocker@gmail.com" },
            //    new Cliente() { ClienteId = 3, Nome = "Felipe Silva", Idade = 21, Telefone = "(11) 98155-6518", Cpf = "187.698.248-47", Email = "felipe.silva@yahoo.com" }
            //);

            //context.Colaboradores.AddOrUpdate(c => c.ColaboradorId,
            //    new Colaborador() { ColaboradorId = 1, Nome = "Joao", Idade = 35, Apelido = "Jk", Sexo = "M" },
            //    new Colaborador() { ColaboradorId = 2, Nome = "Fernanda", Idade = 28, Apelido = "Feh", Sexo = "F" },
            //    new Colaborador() { ColaboradorId = 3, Nome = "Carlos", Idade = 31, Apelido = "Carlinhos", Sexo = "M" }
            //);

            //context.Vendas.AddOrUpdate(v => v.VendaId,
            //    new Venda() { VendaId = 1, Pedido = 1, ValorTotal = 300, ClienteId = 1, ColaboradorId = 2 },
            //    new Venda() { VendaId = 2, Pedido = 2, ValorTotal = 1500, ClienteId = 2, ColaboradorId = 2 },
            //    new Venda() { VendaId = 3, Pedido = 3, ValorTotal = 3200, ClienteId = 3, ColaboradorId = 3 },
            //    new Venda() { VendaId = 4, Pedido = 4, ValorTotal = 250, ClienteId = 1, ColaboradorId = 1 },
            //    new Venda() { VendaId = 5, Pedido = 5, ValorTotal = 5000, ClienteId = 3, ColaboradorId = 1 }
            //);

            //context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
