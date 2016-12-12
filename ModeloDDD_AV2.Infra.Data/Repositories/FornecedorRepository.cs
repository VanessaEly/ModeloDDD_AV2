using ModeloDDD_AV2.Domain.Entities;
using ModeloDDD_AV2.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ModeloDDD_AV2.Infra.Data.Repositories
{
    public class FornecedorRepository : RepositoryBase<Fornecedor>, IFornecedorRepository
    {
        public IEnumerable<Fornecedor> BuscarPorRazaoSocial(string razaoSocial)
        {
            return Db.Fornecedores.Where(p => p.RazaoSocial == razaoSocial);
        }

        public Fornecedor BuscarPorCnpj(string cnpj)
        {
            IEnumerable<Fornecedor> fornecedorList = Db.Fornecedores.Where(p => p.Cnpj == cnpj);

            if (fornecedorList.Count() > 0)
                return fornecedorList.First();
            else
                return null;
        }
    }
}
