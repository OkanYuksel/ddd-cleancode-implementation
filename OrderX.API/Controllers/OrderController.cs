using Microsoft.AspNetCore.Mvc;
using OrderX.API.Dtos.Requests;
using OrderX.API.Dtos.Responses;

namespace OrderX.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "CreateOrder")]
        public async Task<CreateOrderResponseDto> CreateOrder([FromBody] CreateOrderRequestDto requestDto)
        {
            // var commandResult =
            //     CreateOrderUseCase.CreateOrder(_mapper.Map<CreateOrderRequestDto, CreateOrderCommand>(requestDto));
            //
            // return _mapper.Map<CommandResult, CreateOrderResponseDto>(commandResult);

            return new CreateOrderResponseDto
            {
                OrderNumber = 111
            };
        }
    }
}