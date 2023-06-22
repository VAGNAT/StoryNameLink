using AutoMapper;
using Domain.Entities.ModelEF;
using Services.DTOModel;

namespace Services.Helpers.Mapping
{
    public class StoryMappingsProfile : Profile
    {
        public StoryMappingsProfile()
        {
            CreateMap<Story, StoryDto>().ForMember(d => d.Chips, opt => opt.MapFrom(src => new Dictionary<string, ChipDto>()));
            CreateMap<StoryDto, Story>()
                .ForMember(d => d.Id, map => map.Ignore())                
                .ForMember(d => d.Text, map => map.MapFrom(m => m.Text));
        }
    }
}
