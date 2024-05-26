using AutoMapper;
using onlineStore.Services.ProductAPI.Models;
using onlineStore.Services.ProductAPI.Models.Dto;

namespace onlineStore.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
