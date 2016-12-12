using ModeloDDD_AV2.Domain.Entities;
using ModeloDDD_AV2.Domain.Interfaces.Repositories;
using ModeloDDD_AV2.Domain.Interfaces.Services;

namespace ModeloDDD_AV2.Domain.Services
{
    public class AutoDeInfracaoService : ServiceBase<AutoDeInfracao>, IAutoDeInfracaoService
    {
        private  IAutoDeInfracaoRepository _autoDeInfracaoRepository;

        public AutoDeInfracaoService(IAutoDeInfracaoRepository autoDeInfracaoRepository) : base(autoDeInfracaoRepository)
        {
            _autoDeInfracaoRepository = autoDeInfracaoRepository;
        }

        public decimal CalcularMulta(AutoDeInfracao autoDeInfracao, Fornecedor fornecedor)
        {
            return autoDeInfracao.CalculoMulta(autoDeInfracao, fornecedor);
        }
    }
}
