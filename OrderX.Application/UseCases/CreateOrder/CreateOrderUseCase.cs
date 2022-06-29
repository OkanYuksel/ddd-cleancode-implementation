using OrderX.Application.UseCases.CreateOrder.Dtos;
using OrderX.Domain.Aggreagates;
using OrderX.Domain.BoundedContexts.Basket.DomainDtos;
using OrderX.Domain.BoundedContexts.Customer.DomainDtos;
using OrderX.Domain.DomainDtos;
using OrderX.DomainServices.Interfaces;
using OrderX.Infrastructure.Adapters.BasketService.Dtos.Responses;
using OrderX.Infrastructure.Adapters.BasketService.Interfaces;
using OrderX.Infrastructure.Adapters.UserService.Interfaces;
using OrderX.Infrastructure.Repositories.Order.Interfaces;

namespace OrderX.Application.UseCases.CreateOrder;

public class CreateOrderUseCase
{
    private readonly IOrderCommandRepository _orderCommandRepository;
    private readonly IBasketServiceAdapter _basketServiceAdapter;
    private readonly IUserServiceAdapter _userServiceAdapter;
    private readonly IOrderDomainService _orderDomainService;

    public CreateOrderUseCase(IOrderCommandRepository orderCommandRepository, IBasketServiceAdapter basketServiceAdapter, IUserServiceAdapter userServiceAdapter, IOrderDomainService orderDomainService)
    {
        _orderCommandRepository = orderCommandRepository;
        _basketServiceAdapter = basketServiceAdapter;
        _userServiceAdapter = userServiceAdapter;
        _orderDomainService = orderDomainService;
    }

    public async Task<CreateOrderCommandResult> CreateOrder(CreateOrderCommand command)
    {
        var user = await _userServiceAdapter.GetUserById(command.CustomerId);

        if (user == null)
        {
            return new CreateOrderCommandResult()
            {
                IsSuccess = false
            };
        }
        
        var getBasketByIdResponseDto = await _basketServiceAdapter.GetBasketById(command.BasketId);

        var generateOrderNumberResponseDto = await _orderDomainService.GenerateOrderNumber();

        var order = Order.Create(new OrderDomainDto()
        {
            OrderNumber = generateOrderNumberResponseDto.OrderNumber,
            // Basket = _mapper.Map<GetBasketByIdResponseDto, BasketDomainDto>(basket),
            Customer = new CustomerDomainDto()
            {
                Id = command.CustomerId,
                FirstName = user.FirstName,
                LastName = user.LastName
            }
        });

        var result = await _orderCommandRepository.Insert(order);

        if (!result)
        {
            return new CreateOrderCommandResult()
            {
                IsSuccess = false
            };
        }
        
        return new CreateOrderCommandResult()
        {
            OrderNumber = order.OrderNumber,
            IsSuccess = true
        };
    }
}