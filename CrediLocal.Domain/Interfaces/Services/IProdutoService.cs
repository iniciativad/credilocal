using CrediLocal.Domain.Entities;
using System.Collections.Generic;

namespace CrediLocal.Domain.Interfaces.Services
{
   public interface IProdutoService:IServiceBase<Produto>
    {
       IEnumerable<Produto> BuscaPorNome(string nome);
    }
}
