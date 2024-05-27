using onlineStore.Services.EmailAPI.Models.Dto;

namespace onlineStore.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
    }
}
