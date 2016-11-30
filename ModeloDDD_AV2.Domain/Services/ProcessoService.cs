using ModeloDDD_AV2.Domain.Entities;
using ModeloDDD_AV2.Domain.Interfaces.Repositories;
using ModeloDDD_AV2.Domain.Interfaces.Services;

namespace ModeloDDD_AV2.Domain.Services
{
    public class ProcessoService : ServiceBase<Processo>, IProcessoService
    {
        private readonly IProcessoRepository _processoRepository;

        public ProcessoService(IProcessoRepository processoRepository) : base(processoRepository)
        {
            _processoRepository = processoRepository;
        }
    }
}
