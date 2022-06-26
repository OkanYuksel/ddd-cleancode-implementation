using OrderX.Domain.BoundedContexts.Basket.DomainDtos;
using OrderX.Domain.BoundedContexts.Customer.DomainDtos;

namespace OrderX.Domain.DomainDtos;

public class OrderDomainDto
{
    public CustomerDomainDto Customer { get; set; }
    public BasketDomainDto Basket { get; set; }
}