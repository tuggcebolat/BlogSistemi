using AutoMapper;
using BlogSistemi.Entities.DTOs.Posts;
using BlogSistemi.Entities.Entities;


namespace BlogSistemi.Service.AutoMapper
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<PostDto, Post>().ReverseMap();
        }
    }
}
