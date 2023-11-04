using AutoMapper;
using BlogSistemi.Data.UnitOfWorks;
using BlogSistemi.Entities.DTOs.Posts;
using BlogSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSistemi.Service.Services
{
    public class PostService : IPostService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public PostService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<List<PostDto>> GetAllPostsAsync()
        {
            var articles = await unitOfWork.GetRepository<Post>().GetAllAsync();
            var map = mapper.Map<List<PostDto>>(articles);
            return map;
        }

       
    }
}
