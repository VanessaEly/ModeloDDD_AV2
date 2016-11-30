using ModeloDDD_AV2.Domain.Entities;
using ModeloDDD_AV2.Domain.Interfaces.Repositories;
using ModeloDDD_AV2.Domain.Interfaces.Services;

namespace ModeloDDD_AV2.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
    }
}
