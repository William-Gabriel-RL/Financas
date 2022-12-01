using BusinessLayer.DTO.UserDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using EntityLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsuarioController()
        {
            _userService = new UserService();
        }

        [HttpPost]
        public ActionResult Create([Bind(include: "Name, Email, Password")] CreateUserDTO user)
        {
            _userService.CreateUser(user);
            return Ok("User created successfully");
        }

        [HttpPut]
        public ActionResult Update([Bind(include: "Id, Name, Email, Password")] User user)
        {
            _userService.UpdateUser(user);
            return Ok("User updated successfully");
        }
    }
}
