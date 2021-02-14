using ETS.API.DTOs;
using ETS.API.Models;
using ETS.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ETS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            List<UserDTO> userDTOs = new List<UserDTO>();
            userDTOs = _userService.GetUsers();
            if (userDTOs.Count == 0)
                return NotFound();

            return Ok(userDTOs);
        }


        [HttpPost]
        public IActionResult Register(User user)
        {
            bool isValid = false;
            if (!ModelState.IsValid)
                return BadRequest();
            isValid = _userService.Register(user);
            if (isValid)
                return Ok("Kullanıcı Ekleme başarılı");
            else
                return BadRequest();
        }
    }
}
