using OrderX.Infrastructure.Adapters.BasketService.Dtos.Responses;

namespace OrderX.Infrastructure.Adapters.BasketService.Interfaces;

public interface IBasketServiceAdapter
{
    Task<GetBasketByIdResponseDto> GetBasketById(Guid basketId);
}