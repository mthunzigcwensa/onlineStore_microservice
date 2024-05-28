using onlineStore.Services.OrderAPI.Models.Dto;

namespace onlineStore.Services.OrderAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
