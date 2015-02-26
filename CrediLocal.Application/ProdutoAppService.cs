using CrediLocal.Application.Interfaces;
using CrediLocal.Domain.Entities;
using CrediLocal.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace CrediLocal.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;
        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscaPorNome(string nome)
        {
            return _produtoService.BuscaPorNome(nome);
        }
    }
}
