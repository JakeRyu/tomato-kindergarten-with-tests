using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TomatoKindergarten.Core;
using TomatoKindergarten.Core.Models;

namespace TomatoKindergarten.Persistence
{
    public class GroupRepository : IGroupRepository
    {
        private readonly AppDbContext _context;

        public GroupRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Group group)
        {
            _context.Groups.Add(group);
        }

        public async Task<IEnumerable<Group>> GetAllGroups()
        {
            return await _context.Groups.ToListAsync();
        }

        public async Task<Group> GetGroup(int id, bool includeRelated = true)
        {
            if(!includeRelated)
                return await _context.Groups.FindAsync(id);

            return await _context.Groups
                            .Include(g => g.Albums)
                            .SingleOrDefaultAsync(g => g.Id == id);
        }

        public void Remove(Group group)
        {
            throw new System.NotImplementedException();
        }
    }
}