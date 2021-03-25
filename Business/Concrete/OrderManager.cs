using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class OrderManager : IOrderService
    {
        protected IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public Order GetById(int id)
        {
            return _orderDal.Get(p => p.OrderId == id);
        }
    }
}
