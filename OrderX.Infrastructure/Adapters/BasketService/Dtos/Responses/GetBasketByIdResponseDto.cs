using OrderX.Domain.BoundedContexts.Basket.DomainDtos;

namespace OrderX.Infrastructure.Adapters.BasketService.Dtos.Responses;

public class GetBasketByIdResponseDto
{
    public BasketDomainDto Basket { get; set; }
}