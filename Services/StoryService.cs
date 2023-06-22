using AutoMapper;
using Domain.Entities.ModelEF;
using Domain.Entities.ModelEF.Interfaces;
using Services.DTOModel;
using Services.Interfaces;

namespace Services
{
    /// <summary>
    /// Service for working with stories
    /// </summary>
    public class StoryService : IStoryService
    {
        private readonly IMapper _mapper;
        private readonly IStoryRepository _storyRepository;

        public StoryService(IMapper mapper, IStoryRepository storyRepository)
        {
            _mapper = mapper;
            _storyRepository = storyRepository;
        }

        /// <summary>
        /// Get story
        /// </summary>
        /// <returns>DTO story</returns>
        public async Task<StoryDto> Get()
        {
            var query = await _storyRepository.GetAllAsync(new CancellationToken());
            Story? story = query.FirstOrDefault();
            return _mapper.Map<StoryDto>(story);
        }

        /// <summary>
        /// Update story
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="storyDto">Story DTO</param>
        public async Task Update(int id, StoryDto storyDto)
        {
            var entity = await _storyRepository.GetAsync(id);
            entity.Text = storyDto.Text;
            _storyRepository.Update(entity);
            await _storyRepository.SaveChangesAsync();
        }        
    }
}