namespace OrderX.Domain.BoundedContexts.Customer.Constants;

public static class CustomerBoundedContextErrorCodes
{
    public static readonly string EDCUS1001 = "CanNotCreateAnEmptyCustomerEntity";
    public static readonly string EDCUS1002 = "CustomerIdCanNotBeNullToCreateCustomerEntity";
}