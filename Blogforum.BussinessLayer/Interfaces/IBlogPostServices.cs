using Blogforum.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blogpost.BussinessLayer.Interfaces
{
    public interface IBlogPostServices
    {
        Task<Post> Create(Post blogPost);
        Task<Post> GetPostById(int postId);
        Task<IEnumerable<Post>> GetAllPost();
        Task<IEnumerable<Comment>> GetAllComments(int postId);
        Task<Comment> Comments(int postId, Comment comments);
    }
}
