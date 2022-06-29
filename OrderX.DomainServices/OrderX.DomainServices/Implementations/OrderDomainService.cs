using OrderX.DomainServices.Dtos.Responses;
using OrderX.DomainServices.Interfaces;

namespace OrderX.DomainServices.Implementations;

public class OrderDomainService : IOrderDomainService
{
    public async Task<GenerateOrderNumberResponseDto> GenerateOrderNumber()
    {
        var orderNumber = (long) 123; // _orderServiceAdapter.GenerateOrderNumber();

        return new GenerateOrderNumberResponseDto
        {
            OrderNumber = orderNumber
        };
    }
}