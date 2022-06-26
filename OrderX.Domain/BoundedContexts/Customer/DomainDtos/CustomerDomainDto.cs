namespace OrderX.Domain.BoundedContexts.Customer.DomainDtos;

public class CustomerDomainDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}