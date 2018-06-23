using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SolcileSite.Models;

namespace SolcileSite.Controllers

{
    [Route("/api/Users")]
    public class UsersController : Controller
    {
        ////IActionResult it an return rezer view isone,ok, object responsobe all 
        [HttpPost]
        public IActionResult CreateUser([FromBody]User user)
        {
            return Ok(user);
        }
    }
}