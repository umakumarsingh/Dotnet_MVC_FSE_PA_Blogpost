using Blogforum.Entities;
using Blogpost.BussinessLayer.Interfaces;
using Blogpost.BussinessLayer.Services.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blogpost.BussinessLayer.Services
{
    public class BlogPostServices : IBlogPostServices
    {
        private readonly IBlogPostRepository _postRepository;

        public BlogPostServices(IBlogPostRepository blogPostRepository)
        {
            _postRepository = blogPostRepository;
        }
        public async Task<Comment> Comments(int postId, Comment comments)
        {
            var result = await _postRepository.Comments(postId, comments);
            return result;
        }

        public async Task<Post> Create(Post blogPost)
        {
            var result = await _postRepository.Create(blogPost);
            return result;
        }

        public async Task<IEnumerable<Comment>> GetAllComments(int postId)
        {
            var result = await _postRepository.GetAllComments(postId);
            return result;
        }

        public async Task<IEnumerable<Post>> GetAllPost()
        {
            var result = await _postRepository.GetAllPost();
            return result;
        }

        public async Task<Post> GetPostById(int postId)
        {
            var result = await _postRepository.GetPostById(postId);
            return result;
        }
    }
}
