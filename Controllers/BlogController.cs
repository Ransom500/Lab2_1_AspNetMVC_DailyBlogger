using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab2_1_AspNetMVC_DailyBlogger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab2_1_AspNetMVC_DailyBlogger.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext _context;

        public BlogController(BlogContext context)
        {
            _context = context;
        }
        public IActionResult List()
        {
            IEnumerable<BlogPost> posts = _context.blogPost.ToList<BlogPost>();
            return View(posts);
        }

       
    }
}
