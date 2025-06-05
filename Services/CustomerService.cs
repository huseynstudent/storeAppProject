
using StoreAppProject.Database;
using StoreAppProject.Models;
using StoreAppProject.Services.Abstract;
using StoreAppProject.Services;

namespace StoreAppProject.Services
{
    public class CustomerService : BaseService<Customer>, ICustomerService
    {
        public CustomerService(StoreAppDatabase database) : base(database)
        {
        }

        public override void Add(Customer item)
        {
            throw new NotImplementedException();
        }

        public override List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Customer item)
        {
            throw new NotImplementedException();
        }
    }
}
