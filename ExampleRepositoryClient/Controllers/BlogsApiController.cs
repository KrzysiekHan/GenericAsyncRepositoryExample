using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericAsyncRepository.EntityFramework;
using GenericAsyncRepository.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleRepositoryClient.Controllers
{
    [Produces("application/json")]
    [Route("api/Blog")]
    public class BlogsApiController : Controller
    {
        private readonly IBlogRepository _blogRepository;

        public BlogsApiController(IBlogRepository blogRepository)
        {
            this._blogRepository = blogRepository;
        }

        [Route("~/api/GetBlogs")]
        [HttpGet]
        public async Task<IEnumerable<Blog>> Index()
        {
            return await _blogRepository.GetAllAsync();
        }

        [Route("~/api/AddBlog")]
        [HttpPost]
        public async Task<Blog> AddBlog([FromBody]Blog blog)
        {
            await _blogRepository.AddAsync(blog);
            await _blogRepository.SaveAsync();
            return blog;
        }

        [Route("~/api/UpdateBlog")]
        [HttpPut]
        public async Task<Blog>UpdateBlog([FromBody] Blog blog)
        {
            var updated = await _blogRepository.UpdateAsync(blog, blog.BlogId);
            return updated;
        }

        [Route("~/api/DeleteBlog/{id}")]
        [HttpDelete]
        public string Delete(int id)
        {
            _blogRepository.Delete(_blogRepository.Get(id));
            return "Employee deleted";
        }

        protected override void Dispose(bool disposing)
        {
            _blogRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}