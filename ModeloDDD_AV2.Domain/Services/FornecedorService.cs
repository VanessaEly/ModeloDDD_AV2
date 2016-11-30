using ModeloDDD_AV2.Domain.Entities;
using ModeloDDD_AV2.Domain.Interfaces.Repositories;
using ModeloDDD_AV2.Domain.Interfaces.Services;

namespace ModeloDDD_AV2.Domain.Services
{
    public class FornecedorService : ServiceBase<Fornecedor>, IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository) : base(fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }
    }
}
