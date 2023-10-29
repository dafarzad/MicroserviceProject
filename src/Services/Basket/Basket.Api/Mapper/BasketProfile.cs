using AutoMapper;
using Basket.Api.Entities;
using EventBus.Message.Events;

namespace Basket.Api.Mapper
{
    public class BasketProfile : Profile
    {
        protected BasketProfile()
        {
            CreateMap<BasketCheckout, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
