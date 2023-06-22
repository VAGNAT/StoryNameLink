using AutoMapper;
using Services.DTOModel;
using StoryNameLink.ViewModel;

namespace StoryNameLink.Helpers
{
    public class StoryUiMappingsProfile : Profile
    {
        public StoryUiMappingsProfile()
        {
            CreateMap<StoryDto, StoryModel>();
            CreateMap<StoryModel, StoryDto>();
        }
        
    }
}
