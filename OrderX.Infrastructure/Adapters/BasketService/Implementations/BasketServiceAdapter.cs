using OrderX.Infrastructure.Adapters.BasketService.Dtos.Responses;
using OrderX.Infrastructure.Adapters.BasketService.Interfaces;

namespace OrderX.Infrastructure.Adapters.BasketService.Implementations;

public class BasketServiceAdapter : IBasketServiceAdapter
{
    public async Task<GetBasketByIdResponseDto> GetBasketById(Guid basketId)
    {
        return new GetBasketByIdResponseDto();
    }
}