using Blogforum.Entities;
using Blogpost.BussinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Blogforum.Controllers
{
    public class BlogController : ApiController
    {
        private readonly IBlogPostServices _bpServices;

        public BlogController(IBlogPostServices blogPostServices)
        {
            _bpServices = blogPostServices;
        }
        // GET: api/Blog
        [HttpGet]
        public async Task<IEnumerable<Post>> GetAllPost()
        {
            return await _bpServices.GetAllPost();
        }

        //// GET: api/Blog/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Blog
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Blog/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Blog/5
        //public void Delete(int id)
        //{
        //}
    }
}
