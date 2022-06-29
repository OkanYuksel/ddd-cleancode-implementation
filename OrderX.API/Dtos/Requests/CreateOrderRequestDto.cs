namespace OrderX.API.Dtos.Requests;

public class CreateOrderRequestDto
{
    public Guid BasketId { get; set; }
    public Guid CustomerId { get; set; }
}