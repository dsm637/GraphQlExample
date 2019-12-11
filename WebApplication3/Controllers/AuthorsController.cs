using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Services;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly BlogService blogService;
        public AuthorsController(BlogService blogService)
        {
            this.blogService = blogService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return new ObjectResult(blogService.GetAllAuthors());
        }
        [HttpGet("{id}")]
        public IActionResult GetAuthorById(string id)
        {
            return new ObjectResult(blogService.GetAuthorById(id));
        }
        [HttpGet("{id}/posts")]
        public IActionResult GetPostsByAuthor(string id)
        {
            return new ObjectResult(blogService.GetPostsByAuthor(id));
        }
        [HttpGet("{id}/socials")]
        public IActionResult GetSocialsByAuthor(string id)
        {
            return new ObjectResult(blogService.GetSNsByAuthor(id));
        }
    }
}