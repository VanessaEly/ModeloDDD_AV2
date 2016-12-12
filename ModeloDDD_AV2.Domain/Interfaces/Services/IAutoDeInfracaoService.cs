using ModeloDDD_AV2.Domain.Entities;

namespace ModeloDDD_AV2.Domain.Interfaces.Services
{
    public interface IAutoDeInfracaoService : IServiceBase<AutoDeInfracao>
    {
        decimal CalcularMulta(AutoDeInfracao autoDeInfracao, Fornecedor fornecedor);
    }
}
