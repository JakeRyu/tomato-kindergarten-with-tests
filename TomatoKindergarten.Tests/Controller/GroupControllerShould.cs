using Xunit;
using Moq;
using AutoMapper;
using TomatoKindergarten.Core;
using TomatoKindergarten.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TomatoKindergarten.Tests.Controller
{
    public class GroupControllerShould
    {
        private readonly Mock<IMapper> _mapper;
        private readonly Mock<IGroupRepository> _groupRepo;
        private readonly Mock<IUnitOfWork> _uow;

        private readonly GroupController _sut;

        public GroupControllerShould()
        {
           _mapper = new Mock<IMapper>();
            _groupRepo = new Mock<IGroupRepository>();
            _uow = new Mock<IUnitOfWork>();

            _sut = new GroupController(_mapper.Object, _groupRepo.Object, _uow.Object);
        }

        [Fact]
        public async void ReturnNotFound()
        {
            IActionResult result =  await _sut.GetGroup(0);

            Assert.IsType<NotFoundResult>(result);
        }
    }
}