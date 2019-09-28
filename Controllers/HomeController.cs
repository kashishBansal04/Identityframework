using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TestIdentityFramework.Models;

namespace TestIdentityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private UserManager<User> _usermanager;
        private SignInManager<User> _signInManager;

        public HomeController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _usermanager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost]
        [Route("Register")]
        //POST : api/Home/Register
         public IActionResult Register(UserModel userModel)
        {
            var user = new User
            {
                UserName = userModel.UserName,
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                Email = userModel.Email,
            };
            try
            {
                var result = _usermanager.CreateAsync(user,userModel.Password).GetAwaiter().GetResult(); 
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}