using CrediLocal.Domain.Entities;
using System.Collections.Generic;

namespace CrediLocal.Application.Interfaces
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
