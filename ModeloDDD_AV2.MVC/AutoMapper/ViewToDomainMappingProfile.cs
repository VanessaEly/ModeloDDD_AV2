using AutoMapper;
using ModeloDDD_AV2.Domain.Entities;
using ModeloDDD_AV2.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModeloDDD_AV2.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<AutoDeInfracaoViewModel, AutoDeInfracao>();
            Mapper.CreateMap<EnderecoViewModel, Endereco>();
            Mapper.CreateMap<FornecedorViewModel, Fornecedor>();
            Mapper.CreateMap<ProcessoViewModel, Processo>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }
}