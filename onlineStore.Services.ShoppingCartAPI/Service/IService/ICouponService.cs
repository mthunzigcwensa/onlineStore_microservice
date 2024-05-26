using onlineStore.Services.ShoppingCartAPI.Models.Dto;

namespace onlineStore.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
