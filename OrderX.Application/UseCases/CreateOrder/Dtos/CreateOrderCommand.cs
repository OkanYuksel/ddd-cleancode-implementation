namespace OrderX.Application.UseCases.CreateOrder.Dtos;

public class CreateOrderCommand
{
    public Guid BasketId { get; set; }
    public Guid CustomerId { get; set; }
}