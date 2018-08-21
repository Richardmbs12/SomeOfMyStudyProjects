using BusinessLayer.io.customerManagement.enquiries.order;
using BusinessLayer.io.fileHandler;
using BusinessLayer.io.globalExceptions;
using BusinessLayer.io.orderManagement.enquiries.order;
using BusinessLayer.io.orderManagement.enquiries.order.searchCriteria;
using BusinessLayer.io.search.criteria;
using DataAccessLayer.Persistance.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.io.customerManagement.enquiries.order
{
    public class OrderRecordKeeper : IOrderRecordKeeper
    {
        private IUnitOfWork unitOfWork;
        private IFileHandler fileHandler;
        public OrderRecordKeeper(IUnitOfWork unitOfWork, IFileHandler fileHandler)
        {
            this.unitOfWork = unitOfWork;
            this.fileHandler = fileHandler;
        }
        public CreateOrderResponse CreateOrder(CreateOrderRequest createOrderRequest)
        {
            try
            {
                if (createOrderRequest.getOrder() == null)
                {
                    throw new RequestNotValid("CreateOrderRequest Not Valid.");
                }
                Order exceptionTest = RetrieveOrder(new RetrieveOrderRequest().setOrderTrackingNumber(
                    createOrderRequest.getOrder().TrackingNumber)).getOrder();

                if (exceptionTest != null)
                {
                    throw new OrderAlreadyExists("OrderAlreadyExists");
                }
                unitOfWork.CustomerEnquiries.Add(createOrderRequest.getOrder());
                unitOfWork.Complete();
            }
            catch (OrderAlreadyExists e)
            {
                return new CreateOrderResponse().setError(e.Message);
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical Error : " + e.Message });

            }
            return new CreateOrderResponse();
        }

        public FindOrderResponse FindOrder(FindOrderRequest findOrderRequest)
        {
            List<Order> orders = new List<Order>();
            try
            {
                if (findOrderRequest.getSearchCriteria() == null)
                {
                    throw new RequestNotValid("CreateOrderRequest Not Valid.");
                }

                List<Expression<Func<Order, object>>> orderIncluders = new List<Expression<Func<Order, object>>>();
                orderIncluders.Add(x => x.Customer);
                orderIncluders.Add(x => x.TechnicalTask);
                orderIncluders.Add(x => x.BillingInvoice);
                orderIncluders.Add(x => x.ProductsOrdered);

                if (findOrderRequest.getSearchCriteria() is AllSearch)
                {
                    orders = unitOfWork.Orders.GetAll(orderIncluders) as List<Order>;
                }
                else if (findOrderRequest.getSearchCriteria() is OrderSearchCriteria)
                {
                    string id = ((OrderSearchCriteria)findOrderRequest.getSearchCriteria()).getCustomerId();
                    orders = unitOfWork.Orders.Find(x => x.Customer.ID == id , orderIncluders) as List<Order>;
                }
                else
                {
                    throw new UnsupportedSearchCriteria("UnsupportedSearchCriteria");
                }

                if (orders.Count == 0)
                {
                    throw new OrderDoesNotExist("OrderDoesNotExist");
                }
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (UnSupportedSearchIdentifier e)
            {
                return new FindOrderResponse().setError(e.Message);
            }
            catch (UnsupportedSearchCriteria e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (OrderDoesNotExist e)
            {
                return new FindOrderResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new FindOrderResponse().setOrder(orders);
        }

        public RemoveOrderResponse RemoveOrder(RemoveOrderRequest removeOrderRequest)
        {
            try
            {
                if (removeOrderRequest.getOrder() == null)
                {
                    throw new RequestNotValid("RemoveOrderRequest Not Valid.");
                }
                Order exceptionTest = RetrieveOrder(new RetrieveOrderRequest().setOrderTrackingNumber(
                                         removeOrderRequest.getOrder().TrackingNumber)).getOrder();

                if (exceptionTest == null)
                {
                    throw new OrderDoesNotExist("OrderDoesNotExist");
                }
                unitOfWork.CustomerEnquiries.Remove(removeOrderRequest.getOrder());
                unitOfWork.Complete();
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (OrderDoesNotExist e)
            {
                return new RemoveOrderResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new RemoveOrderResponse();
        }

        public RetrieveOrderResponse RetrieveOrder(RetrieveOrderRequest retrieveOrderRequest)
        {
            Order order = null;
            try
            {
                if (retrieveOrderRequest.getOrderTrackingNumber() == null)
                {
                    throw new RequestNotValid("RetrieveOrderRequest Not Valid.");
                }
                List<Expression<Func<Order, object>>> orderIncluders = new List<Expression<Func<Order, object>>>();
                orderIncluders.Add(x => x.Customer);
                orderIncluders.Add(x => x.TechnicalTask);
                orderIncluders.Add(x => x.BillingInvoice);
                orderIncluders.Add(x => x.ProductsOrdered);

                order = unitOfWork.Orders.Get(retrieveOrderRequest.getOrderTrackingNumber(), orderIncluders);

                if (order == null)
                {
                    throw new OrderDoesNotExist("OrderDoesNotExist");
                }
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (UnSupportedSearchIdentifier e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (OrderDoesNotExist e)
            {
                return new RetrieveOrderResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }

            return new RetrieveOrderResponse().setOrder(order);
        }

        public UpdateOrderResponse UpdateOrder(UpdateOrderRequest updateOrderRequest)
        {
            Order order = null;
            try
            {
                if (updateOrderRequest.getOrder() == null)
                {
                    throw new RequestNotValid("UpdateOrderRequest Not Valid.");
                }

                order = RetrieveOrder(new RetrieveOrderRequest().setOrderTrackingNumber(
                                         updateOrderRequest.getOrder().TrackingNumber)).getOrder();

                if (order == null)
                {
                    throw new OrderDoesNotExist("OrderDoesNotExist");
                }

                order = updateOrderRequest.getOrder();
                unitOfWork.Complete();
            }
            catch (RequestNotValid e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (UnSupportedSearchIdentifier e)
            {
                fileHandler.AppendToTxt(new List<string>() { e.Message });
            }
            catch (OrderDoesNotExist e)
            {
                return new UpdateOrderResponse().setError(e.Message);
            }
            catch (Exception e)
            {
                fileHandler.AppendToTxt(new List<string>() { "Critical error" + e.Message });
            }
            return new UpdateOrderResponse().setOrder(order);
        }
    }
}
