using AutoMapper;
using onlineStore.Services.CouponAPI.Models;
using onlineStore.Services.CouponAPI.Models.Dto;

namespace onlineStore.Services.CouponAPI
{
	public class MappingConfig
	{
		public static MapperConfiguration RegisterMaps()
		{
			var mappingConfig = new MapperConfiguration(config =>
			{
				config.CreateMap<CouponDto, Coupon>();
				config.CreateMap<Coupon, CouponDto>();
			});
			return mappingConfig;
		}
	}
}
