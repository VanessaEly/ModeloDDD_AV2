using ModeloDDD_AV2.Domain.Entities;
using ModeloDDD_AV2.Domain.Interfaces.Repositories;
using ModeloDDD_AV2.Domain.Interfaces.Services;

namespace ModeloDDD_AV2.Domain.Services
{
    public class AutoDeInfracaoService : ServiceBase<AutoDeInfracao>, IAutoDeInfracaoService
    {
        private readonly IAutoDeInfracaoRepository _autoDeInfracaoRepository;

        public AutoDeInfracaoService(IAutoDeInfracaoRepository autoDeInfracaoRepository) : base(autoDeInfracaoRepository)
        {
            _autoDeInfracaoRepository = autoDeInfracaoRepository;
        }
    }
}
