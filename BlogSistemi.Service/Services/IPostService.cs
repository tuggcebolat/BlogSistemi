using BlogSistemi.Entities.DTOs.Posts;
using BlogSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSistemi.Service.Services
{
    public interface IPostService
    {
        Task<List<PostDto>> GetAllPostsAsync();
    }
}
