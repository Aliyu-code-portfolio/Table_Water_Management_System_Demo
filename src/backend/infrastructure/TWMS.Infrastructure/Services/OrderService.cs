using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Application.Contracts;
using TWMS.Domain.Models.Order;
using TWMS.Infrastructure.Persistence.DBContext;
using TWMS.Infrastructure.Persistence.Repositories;

namespace TWMS.Infrastructure.Services
{
    public class OrderService:RepositoryBase<Order>,IOrderRepository
    {
        private readonly RepositoryContext _appDbContext;    
        public OrderService(RepositoryContext appDbContext):base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
        /*public override void Add(Order order)
        {
            var availableItems = _appDbContext.Inventory;
            foreach( var item in order.OrderItems)
            {

            }
        }*/



    }
}
