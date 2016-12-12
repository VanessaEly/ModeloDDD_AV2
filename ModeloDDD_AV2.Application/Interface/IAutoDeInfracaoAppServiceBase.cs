using ModeloDDD_AV2.Domain.Entities;

namespace ModeloDDD_AV2.Application.Interface
{
    public interface IAutoDeInfracaoAppService : IAppServiceBase<AutoDeInfracao>
    {
        decimal CalcularMulta(AutoDeInfracao autoDeInfracao, Fornecedor fornecedor);
    }
}
