using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TomatoKindergarten.Controllers.Resources;
using TomatoKindergarten.Core;
using TomatoKindergarten.Core.Models;

namespace TomatoKindergarten.Controllers
{
    [Route("/api/groups")]
    public class GroupController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGroupRepository _groupRepo;
        private IUnitOfWork _uow;

        public GroupController(IMapper mapper, IGroupRepository groupRepo, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _groupRepo = groupRepo;
            _uow = unitOfWork;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGroup(int id)
        {
            var group = await _groupRepo.GetGroup(id);

            if(group == null)
                return NotFound();

            return Ok(Mapper.Map<Group, GroupResource>(group));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGroups()
        {
            var groups = await _groupRepo.GetAllGroups();
            return Ok(Mapper.Map<IEnumerable<Group>, IEnumerable<GroupResource>>(groups));
        }
    }
}