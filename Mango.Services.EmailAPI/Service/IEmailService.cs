using Mango.Services.EmailAPI.Dto;
using Mango.Services.EmailAPI.Message;

namespace Mango.Services.EmailAPI.Service
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
