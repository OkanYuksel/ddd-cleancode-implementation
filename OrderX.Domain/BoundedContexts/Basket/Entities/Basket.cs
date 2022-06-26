using OrderX.Domain.BoundedContexts.Basket.Constants;
using OrderX.Domain.BoundedContexts.Basket.DomainDtos;
using OrderX.Domain.BoundedContexts.Customer.DomainDtos;
using OrderX.Domain.Core;

namespace OrderX.Domain.BoundedContexts.Basket.Entities;

public class Basket : EntityBase
{
    private Basket(Guid id, CustomerDomainDto customer, IEnumerable<BasketItemDomainDto> items)
    {
        Id = id;
        Customer = BoundedContexts.Customer.Entities.Customer.Load(customer);
        Items = items.Select(BasketItem.Load);
    }

    public static Basket Load(BasketDomainDto basketDomainDto)
    {
        Guard.That<DomainException>(basketDomainDto == null, nameof(BasketBoundedContextErrorCodes.EDBAS1007),
            BasketBoundedContextErrorCodes.EDBAS1007);
        Guard.That<DomainException>(basketDomainDto.Id == Guid.Empty, nameof(BasketBoundedContextErrorCodes.EDBAS1008),
            BasketBoundedContextErrorCodes.EDBAS1008);
        return new Basket(basketDomainDto.Id, basketDomainDto.Customer, basketDomainDto.Items);
    }
    
    public Customer.Entities.Customer Customer { get; }
    public IEnumerable<BasketItem> Items { get;}
    public decimal TotalPrice => Items.Sum(x => x.Price);
}