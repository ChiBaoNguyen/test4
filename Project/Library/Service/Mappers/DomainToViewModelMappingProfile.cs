using AutoMapper;
using Root.Models;
using Website.ViewModels;

namespace Service.Mappers
{
	public class DomainToViewModelMappingProfile : Profile
	{
		public override string ProfileName
		{
			get
			{
				return "DomainToViewModelMappingProfile";
			}
		}


		protected override void Configure()
		{
            // Sample: Mapper.CreateMap<Trailer_M, TrailerViewModel>();
        }
	}
}