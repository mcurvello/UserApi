using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsersApi.Data.Dtos;

namespace UsersApi.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddUser(CreateUserDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
