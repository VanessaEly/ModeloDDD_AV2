using ModeloDDD_AV2.Application.Interface;
using ModeloDDD_AV2.Domain.Entities;
using ModeloDDD_AV2.Domain.Interfaces.Services;

namespace ModeloDDD_AV2.Application
{
    public class AutoDeInfracaoAppService : AppServiceBase<AutoDeInfracao>, IAutoDeInfracaoAppService
    {
        private readonly IAutoDeInfracaoService _AutoDeInfracaoService;

        public AutoDeInfracaoAppService(IAutoDeInfracaoService AutoDeInfracaoService) : base(AutoDeInfracaoService)
        {
            _AutoDeInfracaoService = AutoDeInfracaoService;
        }

        public decimal CalcularMulta(AutoDeInfracao autoDeInfracao, Fornecedor fornecedor)
        {
            return autoDeInfracao.CalculoMulta(autoDeInfracao, fornecedor);
        }
    }
}
