using OrderX.Infrastructure.Repositories.Order.Interfaces;

namespace OrderX.Infrastructure.Repositories.Order.Implementations;

public class OrderCommandRepository : IOrderCommandRepository
{
    public async Task<bool> Insert(Domain.Aggreagates.Order order)
    {
        return true;
    }
}