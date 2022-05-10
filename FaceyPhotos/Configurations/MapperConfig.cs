using AutoMapper;
using FaceyPhotos.Data;
using FaceyPhotos.Models;

namespace FaceyPhotos.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Product, ProductVM>();
        }

    }
}
