using CrediLocal.Domain.Entities;
using CrediLocal.Domain.Interfaces;
using CrediLocal.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace CrediLocal.Domain.Services
{
   public class ProdutoService:ServiceBase<Produto>,IProdutoService
    {
       private readonly IProdutoRepository _produtoRepository;
       public ProdutoService(IProdutoRepository produtoRepository)
           :base(produtoRepository)
       {
           _produtoRepository = produtoRepository;
       }
        public IEnumerable<Produto> BuscaPorNome(string nome)
        {
            return _produtoRepository.BuscaPorNome(nome);
        }
    }
}
