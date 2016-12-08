using ModeloDDD_AV2.Application.Interface;
using ModeloDDD_AV2.Domain.Entities;
using ModeloDDD_AV2.Domain.Interfaces.Services;

namespace ModeloDDD_AV2.Application
{
    public class EnderecoAppService : AppServiceBase<Endereco>, IEnderecoAppService
    {
        private readonly IEnderecoService _EnderecoService;

        public EnderecoAppService(IEnderecoService EnderecoService) : base(EnderecoService)
        {
            _EnderecoService = EnderecoService;
        }
    }
}
