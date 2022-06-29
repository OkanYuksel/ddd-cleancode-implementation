using OrderX.Domain.Core;

namespace OrderX.Application.UseCases.CreateOrder.Dtos;

public class CreateOrderCommandResult : CommandResultBase
{
    public long OrderNumber { get; set; }
}