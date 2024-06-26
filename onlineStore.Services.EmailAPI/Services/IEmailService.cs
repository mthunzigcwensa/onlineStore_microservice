﻿using onlineStore.Services.EmailAPI.Message;
using onlineStore.Services.EmailAPI.Models.Dto;

namespace onlineStore.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
