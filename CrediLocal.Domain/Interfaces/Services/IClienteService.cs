using CrediLocal.Domain.Entities;
using System.Collections.Generic;

namespace CrediLocal.Domain.Interfaces.Services
{
    public interface IClienteService:IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> cliente);
    }
}
