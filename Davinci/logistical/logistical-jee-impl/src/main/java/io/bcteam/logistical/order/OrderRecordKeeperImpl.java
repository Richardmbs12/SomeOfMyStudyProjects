package io.bcteam.logistical.order;

import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.entity.product.Product;
import io.bcteam.entity.product.ProductRecordKeeper;
import io.bcteam.entity.product.identifier.ProductName;
import io.bcteam.entity.product.search.criteria.ProductIdentifierSearch;
import io.bcteam.financial.payment.Payment;
import io.bcteam.financial.payment.PaymentMethod;
import io.bcteam.logistical.order.identifier.OrderByAccountIdentifier;
import io.bcteam.logistical.order.identifier.OrderIdentifier;
import io.bcteam.logistical.order.search.criteria.OrderIdentifierSearch;
import io.bcteam.search.criteria.AllSearch;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

public class OrderRecordKeeperImpl implements OrderRecordKeeper.OrderRecordKeeperLocal,
        OrderRecordKeeper.OrderRecordKeeperRemote {

    private ProductRecordKeeper productRecordKeeper;

    @Override
    public CreateOrderResponse createOrder(CreateOrderRequest createOrderRequest) throws
            RequestNotValidException,
            OrderAlreadyExistsException {

        if (createOrderRequest.getOrder()==null){
            throw new RequestNotValidException("Order must be provided.");
        }

        /**
         * TODO Check if order already exists and throw OrderAlreadyExistsException accordingly.
         */

        /**
         * TODO Persist Order To Database
         */
        return new CreateOrderResponse();
    }

    @Override
    public FindOrdersResponse findOrders(FindOrdersRequest findOrdersRequest) throws
            RequestNotValidException,
            UnsupportedSearchCriteriaException {

            if (findOrdersRequest.getSearchCriteria() == null){
                throw new RequestNotValidException("OrderSearchCriteria must be provided.");
            }

            if (findOrdersRequest.getSearchCriteria() instanceof OrderIdentifierSearch) {
                if (((OrderIdentifierSearch) findOrdersRequest.getSearchCriteria()).getOrderIdentifier() instanceof OrderByAccountIdentifier){
                    /**
                     * TODO Find Orders From Database by account identifier (Multiple Orders)
                     */
                }
                else {
                    throw new RuntimeException("OrderIdentifierSearch not allowed for findOrders. " +
                            "Use retrieveOrder.");
                }
            } else if (findOrdersRequest.getSearchCriteria() instanceof AllSearch) {
                /**
                 * TODO Find all orders from database.
                 */
            }
            else {
                throw new UnsupportedSearchCriteriaException("Search Criteria is not supported for find orders.");
            }

        /**
         * Below is just mock implementation to get server started without relying on database.
         */

        List<Product> products = null;
        try {
            products = productRecordKeeper.findProducts(
                    new ProductRecordKeeper.FindProductsRequest()
                            .setSearchCriteria(
                                    new ProductIdentifierSearch().setProductIdentifier(
                                    new ProductName().setProductName("ProductName")))).getProducts();
        } catch (ProductRecordKeeper.UnsupportedSearchCriteriaException e) {
            e.printStackTrace();

            throw new RuntimeException("Unsupported Product SearchCriteria");
        }

        List<String> orderProducts = products.stream().map(product -> {
           return product.getName();
        }).collect(Collectors.toList());

        List<Order> orders = new ArrayList<>();
        orders.add(
                new Order()
                        .setBarcode("BarcodeString")
                        .setClaimed(false)
                        .setPayment(new Payment()
                                .setMethod(PaymentMethod.CASH))
                        .setProducts(orderProducts)
                        .setTotalPrice(100.00));
        /**
         * Above is just mock implementation to get server started without relying on database.
         */

        return new FindOrdersResponse().setOrders(orders);
    }

    @Override
    public RemoveOrderResponse removeOrder(RemoveOrderRequest removeOrderRequest) throws
            RequestNotValidException,
            UnsupportedOrderIdentifierException,
            OrderDoesNotExistException,
            OrderNotUniqueException {

        if (removeOrderRequest.getOrderIdentifier() == null){
            throw new RequestNotValidException();
        }

        if (!(removeOrderRequest.getOrderIdentifier() instanceof OrderIdentifier)){
            throw new UnsupportedOrderIdentifierException(
                    "Identifier is not instance of OrderIdentifier.");
        }

        Order order = retrieveOrder(new RetrieveOrderRequest().setOrderIdentifier(removeOrderRequest.getOrderIdentifier())).getOrder();

        /**
         * TODO Remove Order From Database
         */

        return new RemoveOrderResponse();
    }

    @Override
    public RetrieveOrderResponse retrieveOrder(RetrieveOrderRequest retrieveOrderRequest) throws
            RequestNotValidException,
            UnsupportedOrderIdentifierException,
            OrderNotUniqueException,
            OrderDoesNotExistException {

        if (retrieveOrderRequest.getOrderIdentifier() == null){
            throw new RequestNotValidException();
        }

        if (!(retrieveOrderRequest.getOrderIdentifier() instanceof OrderIdentifier)){
            throw new UnsupportedOrderIdentifierException(
                    "Identifier is not instance of OrderIdentifier.");
        }
        /**
         * TODO Retrieve Orders From Database
         */

        /**
         * TODO Validate that only one order returns otherwise -> OrderNotUniqueException
         */

        /**
         * TODO Validate that at least a order returns -> OrderDoesNotExistException
         */

        /**
         * Below is just mock implementation to get server started without relying on database.
         */

        /**
         * TODO Retrieve Order From Database
         */

        List<Product> products = null;
        try {
            products = productRecordKeeper.findProducts(
                    new ProductRecordKeeper.FindProductsRequest()
                            .setSearchCriteria(
                                    new ProductIdentifierSearch().setProductIdentifier(
                                            new ProductName().setProductName("ProductName")))).getProducts();
        } catch (ProductRecordKeeper.UnsupportedSearchCriteriaException e) {

        }

        List<String> orderProducts = products.stream().map(product -> {
            return product.getName();
        }).collect(Collectors.toList());

        Order order =  new Order() //Used OrderIdentifier in request object to retrieve order
                        .setBarcode("BarcodeString")
                        .setClaimed(false)
                        .setPayment(new Payment()
                                .setMethod(PaymentMethod.CASH))
                        .setProducts(orderProducts)
                        .setTotalPrice(100.00);

        /**
         * Above is just mock implementation to get server started without relying on database.
         */

        return new RetrieveOrderResponse().setOrder(order);
    }

    @Override
    public UpdateOrderResponse updateOrder(UpdateOrderRequest updateOrderRequest) throws
            RequestNotValidException,
            UnsupportedOrderIdentifierException,
            OrderNotUniqueException,
            OrderDoesNotExistException {

        Order order = updateOrderRequest.getOrder();

        if (order == null || updateOrderRequest.getOrderIdentifier() == null){
            throw new RequestNotValidException();
        }

        if (!(updateOrderRequest.getOrderIdentifier() instanceof OrderIdentifier)){
            throw new UnsupportedOrderIdentifierException(
                    "Identifier is not instance of OrderIdentifier.");
        }

        Order orderEntity = retrieveOrder(new RetrieveOrderRequest().setOrderIdentifier(updateOrderRequest.getOrderIdentifier())).getOrder();

        /* Update only the fields that may be updated */
        orderEntity.setPayment(order.getPayment());
        orderEntity.setClaimed(order.isClaimed());
        orderEntity.setProducts(order.getProducts());
        orderEntity.setTotalPrice(order.getTotalPrice());

        /**
         * TODO Update Order To Database
         */

        return new UpdateOrderResponse();
    }
}
