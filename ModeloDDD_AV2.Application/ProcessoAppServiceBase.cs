using ModeloDDD_AV2.Application.Interface;
using ModeloDDD_AV2.Domain.Entities;
using ModeloDDD_AV2.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
