using OrderX.Domain.BoundedContexts.Basket.Constants;
using OrderX.Domain.BoundedContexts.Basket.DomainDtos;
using OrderX.Domain.Core;

namespace OrderX.Domain.BoundedContexts.Basket.Entities;

public class BasketItem : EntityBase
{
    private BasketItem(BasketItemDomainDto basketItemDomainDto)
    {
        Sku = basketItemDomainDto.Sku;
        ProductName = basketItemDomainDto.ProductName;
        Quantity = basketItemDomainDto.Quantity;
    }

    public static BasketItem Load(BasketItemDomainDto basketItemDomainDto)
    {
        Guard.That<DomainException>(basketItemDomainDto == null, nameof(BasketBoundedContextErrorCodes.EDBAS1001),
            BasketBoundedContextErrorCodes.EDBAS1001);
        Guard.That<DomainException>(string.IsNullOrEmpty(basketItemDomainDto.Sku), nameof(BasketBoundedContextErrorCodes.EDBAS1002),
            BasketBoundedContextErrorCodes.EDBAS1002);
        return new BasketItem(basketItemDomainDto);
    }

    
    public string Sku { get; set; }
    public string ProductName { get; set; }
    public string Quantity { get; set; }
    public decimal Price { get; set; }
}