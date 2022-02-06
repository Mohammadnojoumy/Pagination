using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pagination.Data;
using pagination.Models;

namespace pagination.Controllers
{
    public class UserController : Controller
    {
        private readonly MyContext _context;
        public UserController(MyContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int pageNumber = 1)
        {
            if (pageNumber < 1) return NotFound();
            var users = _context.users;
            var pagination = await PaginationList<User>.CreateAsync(users, pageNumber, 3);
            return View(pagination);
        }
        
    }
 
}