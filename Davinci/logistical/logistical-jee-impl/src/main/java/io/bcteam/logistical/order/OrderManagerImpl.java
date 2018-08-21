package io.bcteam.logistical.order;

import io.bcteam.base.preconditionViolation.RequestNotValidException;
import io.bcteam.entity.product.Product;
import io.bcteam.entity.product.ProductRecordKeeper;
import io.bcteam.entity.product.identifier.ProductName;
import io.bcteam.security.account.Account;
import io.bcteam.security.account.AccountRecordKeeper;

public class OrderManagerImpl implements OrderManager.OrderManagerLocal,
        OrderManager.OrderManagerRemote {

    private AccountRecordKeeper accountRecordKeeper;
    private OrderRecordKeeper orderRecordKeeper;
    private ProductRecordKeeper productRecordKeeper;

    @Override
    public SubmitOrderResponse submitOrder(SubmitOrderRequest submitOrderRequest) throws
            RequestNotValidException {

        if (submitOrderRequest.getOrder()== null || submitOrderRequest.getAccount()== null){
            throw new RequestNotValidException("Order and Account must be provided.");
        }

        try {
            Account account = accountRecordKeeper.retrieveAccount(
                    new AccountRecordKeeper.RetrieveAccountRequest()
                            .setAccountIdentifier(submitOrderRequest.getAccount())).getAccount();
        } catch (AccountRecordKeeper.AccountDoesNotExistException |
                AccountRecordKeeper.AccountNotUniqueException |
                AccountRecordKeeper.UnsupportedAccountIdentifierException e) {

            /**
             * TODO proper error handling.
             */
        }

        /**
         * Make Sure to provide order with a Account identifier.
         */

        try {
            orderRecordKeeper.createOrder(new OrderRecordKeeper.CreateOrderRequest().setOrder(submitOrderRequest.getOrder()));
        } catch (OrderRecordKeeper.OrderAlreadyExistsException e) {
            /**
             * TODO proper error handling.
             */
        }

        /**
         * Making Sure to update stock of products.
         */

        for (String productName: submitOrderRequest.getOrder().getProducts()) {
            try {
                Product product = productRecordKeeper.retrieveProduct(new ProductRecordKeeper.RetrieveProductRequest()
                        .setProductIdentifier(
                                new ProductName()
                                        .setProductName(productName))).getProduct();
                product.setStockAvailable(product.getStockAvailable() - 1);
                productRecordKeeper.updateProduct(new ProductRecordKeeper.UpdateProductRequest().setProduct(product)
                        .setProductIdentifier(new ProductName().setProductName(productName)));

            } catch (ProductRecordKeeper.UnsupportedProductIdentifierException |
                    ProductRecordKeeper.ProductNotUniqueException |
                    ProductRecordKeeper.ProductDoesNotExistException e) {
                /**
                 * TODO proper error handling.
                 */
            }
        }

        return new SubmitOrderResponse();
    }

    @Override
    public ClaimOrderResponse claimOrder(ClaimOrderRequest claimOrderRequest) throws
            RequestNotValidException,
            OrderAlreadyClaimedException {

        if (claimOrderRequest.getOrder()== null){
            throw new RequestNotValidException("Order must be provided.");
        }

        Order order = null;
        try {
            order = orderRecordKeeper.retrieveOrder(new OrderRecordKeeper.RetrieveOrderRequest().setOrderIdentifier(claimOrderRequest.getOrder())).getOrder();
            if (order.isClaimed()){
                throw new OrderAlreadyClaimedException("Order cannot be claimed more than once!");
            }
            if (order.getPayment() != null){
                order.setClaimed(true);
            }
            orderRecordKeeper.updateOrder(new OrderRecordKeeper.UpdateOrderRequest().setOrder(order));

        } catch (OrderRecordKeeper.UnsupportedOrderIdentifierException |
                OrderRecordKeeper.OrderNotUniqueException |
                OrderRecordKeeper.OrderDoesNotExistException e) {
            /**
             * TODO proper error handling.
             */
        }
        return new ClaimOrderResponse().setOrder(order);
    }

    @Override
    public OrderPaymentResponse orderPayment(OrderPaymentRequest orderPaymentRequest) throws
            RequestNotValidException,
            OrderPaymentAlreadyPaidException {

        if (orderPaymentRequest.getOrder()== null || orderPaymentRequest.getPayment()== null){
            throw new RequestNotValidException("Order and payment must be provided.");
        }

        Order order = null;
        try {
            order = orderRecordKeeper.retrieveOrder(new OrderRecordKeeper.RetrieveOrderRequest().setOrderIdentifier(orderPaymentRequest.getOrder())).getOrder();
            if (order.getPayment() != null){
                throw new OrderPaymentAlreadyPaidException("Order has been paid for!");
            }
            else{
                order.setPayment(orderPaymentRequest.getPayment());
                orderRecordKeeper.updateOrder(new OrderRecordKeeper.UpdateOrderRequest().setOrder(order));
            }
        } catch (OrderRecordKeeper.UnsupportedOrderIdentifierException |
                OrderRecordKeeper.OrderNotUniqueException |
                OrderRecordKeeper.OrderDoesNotExistException e) {
            /**
             * TODO proper error handling.
             */
        }

        return new OrderPaymentResponse();
    }
}
