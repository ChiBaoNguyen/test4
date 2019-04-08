using AutoMapper;
using Root.Models;
using Root.Models.Mapping;
using Website.ViewModels;

namespace Service.Mappers
{
	public class ViewModelToDomainMappingProfile : Profile
	{
		public override string ProfileName
		{
			get
			{
				return "ViewModelToDomainMappingProfile";
			}
		}

		protected override void Configure()
		{
            // Sample: Mapper.CreateMap<CustomerViewModel, Customer_M>();
        }
	}
}