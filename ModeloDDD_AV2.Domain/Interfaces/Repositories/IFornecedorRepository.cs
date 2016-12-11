using ModeloDDD_AV2.Domain.Entities;
using System.Collections.Generic;

namespace ModeloDDD_AV2.Domain.Interfaces.Repositories
{
    public interface IFornecedorRepository : IRepositoryBase<Fornecedor>
    {
        IEnumerable<Fornecedor> BuscarPorRazaoSocial(string razaoSocial);

        Fornecedor BuscarPorCnpj(string cnpj);
    }
}
