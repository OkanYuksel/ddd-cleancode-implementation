using OrderX.Domain.BoundedContexts.Basket.Entities;
using OrderX.Domain.BoundedContexts.Customer.Entities;
using OrderX.Domain.Constants;
using OrderX.Domain.Core;
using OrderX.Domain.DomainDtos;

namespace OrderX.Domain.Aggreagates;

public class Order
{
    private Order(Customer customer, Basket basket, long orderNumber)
    {
        Customer = customer;
        Basket = basket;
        OrderNumber = orderNumber;
    }

    public static Order Load(OrderDomainDto orderDomainDto)
    {
        Guard.That<DomainException>(orderDomainDto == null, nameof(DomainErrorCodes.EDORDER1001),
            DomainErrorCodes.EDORDER1001);
        Guard.That<DomainException>(orderDomainDto.Customer == null, nameof(DomainErrorCodes.EDORDER1002),
            DomainErrorCodes.EDORDER1002);
            
        return new Order(Customer.Load(orderDomainDto.Customer), Basket.Load(orderDomainDto.Basket), orderDomainDto.OrderNumber);
    }

    public static Order Create(OrderDomainDto orderDomainDto)
    {
        return Load(orderDomainDto);
    }

    public Customer Customer { get; set; }
    public Basket Basket { get; set; }
    public long OrderNumber { get; set; }
}