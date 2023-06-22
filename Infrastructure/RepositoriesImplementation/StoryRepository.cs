using Domain.Entities.ModelEF;
using Domain.Entities.ModelEF.Interfaces;
using Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.RepositoriesImplementation
{
    public class StoryRepository : Repository<Story, int>, IStoryRepository
    {
        public StoryRepository(StoryNameLinkContext context) : base(context)
        {
        }
    }
}
