using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using onlineStore.Services.CouponAPI.Data;
using onlineStore.Services.CouponAPI.Models;
using onlineStore.Services.CouponAPI.Models.Dto;
using static Azure.Core.HttpHeader;

namespace onlineStore.Services.CouponAPI.Controllers
{
	[Route("api/coupon")]
	[ApiController]
    [Authorize]
    public class CouponAPIController : ControllerBase
	{
		private readonly AppDbContext _db;
		private ResponseDto _response;
		private IMapper _mapper;

		public CouponAPIController(AppDbContext db, IMapper mapper)
		{
			_db = db;
			_mapper = mapper;
			_response = new ResponseDto();
		}

		[HttpGet]
		public ResponseDto Get() 
		{
			try
			{
				IEnumerable<Coupon> coupons = _db.Coupons.ToList();
				_response.Result = _mapper.Map<IEnumerable<CouponDto>>(coupons);

			} 
			catch (Exception ex) 
			{ 
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			
			}
			return _response;
		}

		[HttpGet]
		[Route("{id:int}")]
		public ResponseDto Get(int id)
		{
			try
			{
				Coupon coupon = _db.Coupons.First(u => u.CouponId == id);
				_response.Result = _mapper.Map<CouponDto>(coupon);

			}
			catch (Exception ex) 
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return _response ;
		}

		[HttpGet]
		[Route("GetByCode/{code}")]
		public ResponseDto GetByCode(string code)
		{
			try
			{
				Coupon coupon = _db.Coupons.First(u => u.CouponCode.ToLower() == code.ToLower());
				_response.Result = _mapper.Map<CouponDto>(coupon);

			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return _response;
		}

		[HttpPost]
		public ResponseDto Post([FromBody] CouponDto couponDto)
		{
			try
			{
				Coupon coupon = _mapper.Map<Coupon>(couponDto);
				_db.Coupons.Add(coupon);
				_db.SaveChanges();
				_response.Result = _mapper.Map<CouponDto>(coupon);
			} 
			catch (Exception ex) 
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return _response;

		}

		[HttpPut]
		public ResponseDto put([FromBody] CouponDto couponDto)
		{
			try
			{
				Coupon coupon = _mapper.Map<Coupon>(couponDto);
				_db.Coupons.Update(coupon);
				_db.SaveChanges();
				_response.Result = _mapper.Map<CouponDto>(coupon);
			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return _response;

		}

		[HttpDelete]
		[Route("{id:int}")]
		public ResponseDto Delete(int id)
		{
			try
			{
				Coupon coupon = _db.Coupons.First(u => u.CouponId == id);
				_db.Coupons.Remove(coupon);
				_db.SaveChanges();
				//_response.Result = _mapper.Map<CouponDto>(coupon);
			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return _response;

		}
	}
}
