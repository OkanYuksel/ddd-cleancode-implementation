namespace OrderX.Domain.BoundedContexts.Basket.Constants;

public static class BasketBoundedContextErrorCodes
{
    public static readonly string EDBAS1001 = "BasketItemProductDomainDtoCanNotBeNull";
    public static readonly string EDBAS1002 = "BasketItemProductSkuCanNotBeNull";
    public static readonly string EDBAS1003 = "BasketItemDomainDtoCanNotBeNull";
    public static readonly string EDBAS1005 = "BasketItemQuantityMustGreaterThanZeroToLoadBasketItem";
    public static readonly string EDBAS1006 = "BasketItemProductCanNotBeNullToLoadBasketItem";
    public static readonly string EDBAS1007 = "BasketDomainDtoCanNotBeNull";
    public static readonly string EDBAS1008 = "BasketIdCanNotBeNullToLoadBasket";
    public static readonly string EDBAS1009 = "BasketItemsCanNotBeNullOrEmptyToLoadBasket";
    public static readonly string EDBAS1010 = "BasketItemTaxRateMustGreaterThanZero";
    public static readonly string EDBAS1011 = "MerchantDomainDtoCanNotBeNull";
    public static readonly string EDBAS1012 = "MerchantIdCanNotBeNullOrEmpty";
}