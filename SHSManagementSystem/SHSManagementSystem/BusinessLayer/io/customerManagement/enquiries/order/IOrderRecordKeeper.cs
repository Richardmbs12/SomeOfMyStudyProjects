using BusinessLayer.io.customerManagement.enquiries.order;
using BusinessLayer.io.search.criteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.io.orderManagement.enquiries.order
{
    public interface IOrderRecordKeeper
    {
        CreateOrderResponse CreateOrder(CreateOrderRequest createOrderRequest);
        FindOrderResponse FindOrder(FindOrderRequest findOrderRequest);
        RemoveOrderResponse RemoveOrder(RemoveOrderRequest removeOrderRequest);
        RetrieveOrderResponse RetrieveOrder(RetrieveOrderRequest retrieveOrderRequest);
        UpdateOrderResponse UpdateOrder(UpdateOrderRequest updateOrderRequest);
    }

    [Serializable]
    public class CreateOrderRequest
    {
        private Order order;
        public CreateOrderRequest setOrder(Order order)
        {
            this.order = order;
            return this;
        }
        public Order getOrder()
        {
            return this.order;
        }
    }
    [Serializable]
    public class CreateOrderResponse
    {
        private string error;
        public CreateOrderResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
    }
    [Serializable]
    public class FindOrderRequest
    {
        private SearchCriteria searchCriteria;
        public FindOrderRequest setSearchCriteria(SearchCriteria searchCriteria)
        {
            this.searchCriteria = searchCriteria;
            return this;
        }
        public SearchCriteria getSearchCriteria()
        {
            return this.searchCriteria;
        }
    }
    [Serializable]
    public class FindOrderResponse
    {
        private List<Order> orders;
        private string error;
        public FindOrderResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public FindOrderResponse setOrder(List<Order> orders)
        {
            this.orders = orders;
            return this;
        }
        public List<Order> getOrders()
        {
            return this.orders;
        }
    }
    [Serializable]
    public class RemoveOrderRequest
    {
        private Order order;
        public RemoveOrderRequest setOrder(Order order)
        {
            this.order = order;
            return this;
        }
        public Order getOrder()
        {
            return this.order;
        }
    }
    [Serializable]
    public class RemoveOrderResponse
    {
        private string error;
        public RemoveOrderResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
    }
    [Serializable]
    public class RetrieveOrderRequest
    {
        private int trackingNumber;
        public RetrieveOrderRequest setOrderTrackingNumber(int trackingNumber)
        {
            this.trackingNumber = trackingNumber;
            return this;
        }
        public int getOrderTrackingNumber()
        {
            return this.trackingNumber;
        }
    }
    [Serializable]
    public class RetrieveOrderResponse
    {
        private Order order;
        private string error;
        public RetrieveOrderResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public RetrieveOrderResponse setOrder(Order order)
        {
            this.order = order;
            return this;
        }
        public Order getOrder()
        {
            return this.order;
        }
    }
    [Serializable]
    public class UpdateOrderRequest
    {
        private int trackingNumber;
        private Order order;
        public UpdateOrderRequest setOrder(Order order)
        {
            this.order = order;
            return this;
        }
        public Order getOrder()
        {
            return this.order;
        }
        public UpdateOrderRequest setOrderTrackingNumber(int trackingNumber)
        {
            this.trackingNumber = trackingNumber;
            return this;
        }
        public int getOrderTrackingNumberentifier()
        {
            return this.trackingNumber;
        }
    }
    [Serializable]
    public class UpdateOrderResponse
    {
        private Order order;
        private string error;
        public UpdateOrderResponse setError(string error)
        {
            this.error = error;
            return this;
        }
        public string getError()
        {
            return this.error;
        }
        public UpdateOrderResponse setOrder(Order order)
        {
            this.order = order;
            return this;
        }
        public Order getOrder()
        {
            return this.order;
        }
    }
    [Serializable]
    public class OrderNotUnique : Exception
    {
        public OrderNotUnique()
          : base()
        {
        }
        public OrderNotUnique(String message)
          : base(message)
        {
        }
        public OrderNotUnique(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected OrderNotUnique(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class OrderAlreadyExists : Exception
    {
        public OrderAlreadyExists()
          : base()
        {
        }
        public OrderAlreadyExists(String message)
          : base(message)
        {
        }
        public OrderAlreadyExists(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected OrderAlreadyExists(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
    [Serializable]
    public class OrderDoesNotExist : Exception
    {
        public OrderDoesNotExist()
          : base()
        {
        }
        public OrderDoesNotExist(String message)
          : base(message)
        {
        }
        public OrderDoesNotExist(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected OrderDoesNotExist(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
