using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace BookStore.Controllers
{
    public class AdminController : ControllerBase
    {


        [HttpPost]
        [Route("api/register")]
        public IActionResult Register([FromBody] Register register)
        {
            var result = 
        }

        [HttpPut]
        [Route("api/login")]
        public IActionResult Login([FromBody] Login login)
        {

        }

        [HttpPost]
        [Route("api/addBook")]
        public IActionResult AddBook([FromBody] Books book)
        {

        }

        [HttpPut]
        [Route("api/updateBook")]
        public IActionResult UpdateBook([FromBody] Books book)
        {

        }

        [HttpDelete]
        [Route("api/deleteBook")]
        public IActionResult DeleteBook(int id)
        {

        }
    }
}