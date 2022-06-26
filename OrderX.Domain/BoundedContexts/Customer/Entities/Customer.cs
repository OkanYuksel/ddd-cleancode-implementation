using OrderX.Domain.BoundedContexts.Customer.Constants;
using OrderX.Domain.BoundedContexts.Customer.DomainDtos;
using OrderX.Domain.Core;

namespace OrderX.Domain.BoundedContexts.Customer.Entities;

public class Customer : EntityBase
{
    private Customer(Guid id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public static Customer Load(CustomerDomainDto customerDomainDto)
    {
        Guard.That<DomainException>(customerDomainDto == null, nameof(CustomerBoundedContextErrorCodes.EDCUS1001),
            CustomerBoundedContextErrorCodes.EDCUS1001);
        Guard.That<DomainException>(customerDomainDto.Id == Guid.Empty, nameof(CustomerBoundedContextErrorCodes.EDCUS1002),
            CustomerBoundedContextErrorCodes.EDCUS1002);
        return new Customer(customerDomainDto.Id, customerDomainDto.FirstName, customerDomainDto.LastName);
    }
    
    private string FirstName { get; }
    private string LastName { get; }
}