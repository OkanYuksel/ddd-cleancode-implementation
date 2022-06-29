using OrderX.DomainServices.Dtos.Responses;

namespace OrderX.DomainServices.Interfaces;

public interface IOrderDomainService
{
    Task<GenerateOrderNumberResponseDto> GenerateOrderNumber();
}