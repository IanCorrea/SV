﻿using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Repositories;

namespace ProjetoDDD.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}
