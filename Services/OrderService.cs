
using StoreAppProject.Database;
using StoreAppProject.Models;
using StoreAppProject.Services;
using StoreAppProject.Services.Abstract;

namespace StoreAppProject.Services;
public class OrderService : BaseService<Order>, IOrderService
{
    public OrderService(StoreAppDatabase database) : base(database)
    {
    }

    public override void Add(Order item)
    {
        throw new NotImplementedException();
    }

    public override List<Order> GetAll()
    {
        throw new NotImplementedException();
    }

    public Order GetByCustomerId(int customerId)
    {
        throw new NotImplementedException();
    }

    public override Order GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Remove(Order item)
    {
        throw new NotImplementedException();
    }
}
