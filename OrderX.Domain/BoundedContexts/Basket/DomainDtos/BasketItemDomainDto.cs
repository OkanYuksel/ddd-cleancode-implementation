namespace OrderX.Domain.BoundedContexts.Basket.DomainDtos;

public class BasketItemDomainDto
{
    public string Sku { get; set; }
    public string ProductName { get; set; }
    public string Quantity { get; set; }
    public decimal Price { get; set; }
}