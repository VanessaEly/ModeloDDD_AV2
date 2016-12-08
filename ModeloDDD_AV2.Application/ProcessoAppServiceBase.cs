using ModeloDDD_AV2.Application.Interface;
using ModeloDDD_AV2.Domain.Entities;
using ModeloDDD_AV2.Domain.Interfaces.Services;

namespace ModeloDDD_AV2.Application
{
    public class ProcessoAppService : AppServiceBase<Processo>, IProcessoAppService
    {
        private readonly IProcessoService _ProcessoService;

        public ProcessoAppService(IProcessoService ProcessoService) : base(ProcessoService)
        {
            _ProcessoService = ProcessoService;
        }
    }
}
