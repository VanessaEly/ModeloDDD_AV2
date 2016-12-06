using AutoMapper;
using ModeloDDD_AV2.Domain.Entities;
using ModeloDDD_AV2.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModeloDDD_AV2.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<AutoDeInfracao, AutoDeInfracaoViewModel>();
            Mapper.CreateMap<Endereco, EnderecoViewModel>();
            Mapper.CreateMap<Fornecedor, FornecedorViewModel>();
            Mapper.CreateMap<Processo, ProcessoViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
        }
    }
}