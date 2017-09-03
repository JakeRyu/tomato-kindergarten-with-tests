using AutoMapper;
using TomatoKindergarten.Controllers.Resources;
using TomatoKindergarten.Core.Models;

namespace TomatoKindergarten.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
             CreateMap<Group, GroupResource>();
        }
    }
}