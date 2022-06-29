using OrderX.Infrastructure.Adapters.UserService.Dtos.Responses;
using OrderX.Infrastructure.Adapters.UserService.Interfaces;

namespace OrderX.Infrastructure.Adapters.UserService.Implementations;

public class UserServiceAdapter : IUserServiceAdapter
{
    public async Task<GetUserByIdResponseDto> GetUserById(Guid basketId)
    {
        return new GetUserByIdResponseDto();
    }
}