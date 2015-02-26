﻿using CrediLocal.Domain.Entities;
using CrediLocal.Domain.Interfaces;
using CrediLocal.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace CrediLocal.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>,IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
            :base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }



        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> cliente)
        {
            return cliente.Where(c => c.ClienteEspecial(c));
        }
    }
}
