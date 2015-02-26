using CrediLocal.Domain.Entities;
using System.Collections.Generic;

namespace CrediLocal.Application.Interfaces
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscaPorNome(string nome);
    }
}
