using Services.DTOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    /// <summary>
    /// Interfaces for working with stories
    /// </summary>
    public interface IStoryService
    {
        /// <summary>
        /// Get story
        /// </summary>
        /// <returns>DTO story</returns>
        Task<StoryDto> Get();

        /// <summary>
        /// Update story
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="advertisementDto">Story DTO</param>
        Task Update(int id, StoryDto advertisementDto);        
    }
}
