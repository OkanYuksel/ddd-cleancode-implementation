using OrderX.Infrastructure.Adapters.UserService.Dtos.Responses;

namespace OrderX.Infrastructure.Adapters.UserService.Interfaces;

public interface IUserServiceAdapter
{
    Task<GetUserByIdResponseDto> GetUserById(Guid basketId);
}