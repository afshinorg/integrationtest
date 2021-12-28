using Basket.API.Entities;

namespace Basket.API.Repositories;

public interface IBasketRepository
{
    Task<ShoppingCart> GetBasket(string userName);
    // No create since we are using Redis -> use key and whole object to create -> Update whole basket
    Task<ShoppingCart> UpdateBasket(ShoppingCart basket);
    Task DeleteBasket(string userName);
}

