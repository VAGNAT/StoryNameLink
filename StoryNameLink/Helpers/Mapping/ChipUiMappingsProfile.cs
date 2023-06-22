using AutoMapper;
using Services.DTOModel;
using StoryNameLink.ViewModel;

namespace StoryNameLink.Helpers.Mapping
{
    public class ChipUiMappingsProfile : Profile
    {
        public ChipUiMappingsProfile()
        {
            CreateMap<ChipDto, ChipModel>();
            CreateMap<ChipModel, ChipDto>();
        }

    }
}
