using ModeloDDD_AV2.Domain.Entities;

namespace ModeloDDD_AV2.Domain.Interfaces.Services
{
    public interface IFornecedorService : IServiceBase<Fornecedor>
    {
        Fornecedor BuscarPorCnpj(string cnpj);
    }
}
