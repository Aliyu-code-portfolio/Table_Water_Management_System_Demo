using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Application.Contracts;

namespace TWMS.Application.CommonContracts
{
    public interface IRepositoryManager
    {
        ICustomerRepository customerRepository { get; }
        ICustomerAddressRepository customerAddressRepository { get; }
        IStaffRepository staffRepository { get; }
        IStaffAddressRepository staffAddressRepository { get; }
        IProductRepository productRepository { get; }
        IOrderRepository orderRepository { get; }   
        IOrderItemRepository orderItemRepository { get; }

        void Save();
    }
}
