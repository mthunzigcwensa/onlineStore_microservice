﻿using onlineStore.Services.ShoppingCartAPI.Models.Dto;

namespace onlineStore.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
