namespace OrderX.Infrastructure.Repositories.Order.Interfaces;

public interface IOrderCommandRepository
{
    public Task<bool> Insert(Domain.Aggreagates.Order order);
}