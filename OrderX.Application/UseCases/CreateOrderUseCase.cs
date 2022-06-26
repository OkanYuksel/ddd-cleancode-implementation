using OrderX.Domain.Aggreagates;
using OrderX.Domain.BoundedContexts.Basket.DomainDtos;
using OrderX.Domain.BoundedContexts.Customer.DomainDtos;
using OrderX.Domain.DomainDtos;
using OrderX.Infrastructure.Adapters.BasketService.Interfaces;
using OrderX.Infrastructure.Adapters.UserService.Interfaces;
using OrderX.Infrastructure.Repositories.Order.Interfaces;

namespace OrderX.Application.UseCases;

public class CreateOrderUseCase
{
    private readonly IOrderCommandRepository _orderCommandRepository;
    private readonly IBasketServiceAdapter _basketServiceAdapter;
    private readonly IUserServiceAdapter _userServiceAdapter;

    public CreateOrderUseCase(IOrderCommandRepository _orderCommandRepository, IBasketServiceAdapter basketServiceAdapter, IUserServiceAdapter _userServiceAdapter)
    {
        _orderCommandRepository = _orderCommandRepository;
        _basketServiceAdapter = basketServiceAdapter;
        _userServiceAdapter = _userServiceAdapter;
    }

    public async Task CreateOrder()
    {
        var basket = await _basketServiceAdapter.GetBasketById(Guid.NewGuid());

        var order = Order.Create(new OrderDomainDto()
        {
            Basket = new BasketDomainDto(),
            Customer = new CustomerDomainDto()
        });

        var result = _orderCommandRepository.Insert(order);
    }
}