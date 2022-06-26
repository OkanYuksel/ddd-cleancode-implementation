using OrderX.Domain.BoundedContexts.Customer.DomainDtos;

namespace OrderX.Domain.BoundedContexts.Basket.DomainDtos;

public class BasketDomainDto
{
    public Guid Id { get; set; }
    public CustomerDomainDto Customer { get; set; }
    public IEnumerable<BasketItemDomainDto> Items { get; set; }
}