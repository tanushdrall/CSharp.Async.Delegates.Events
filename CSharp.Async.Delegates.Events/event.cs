using System;

namespace EventsDemo
{
    public class OrderEventArgs : EventArgs  //Custom Eventrgs class
    {
        public string OrderId { get; }
        public int Quantity { get; }
        public DateTime ProcessedAt { get; }
        public OrderEventArgs(string orderId, int quantity, DateTime processedAt)
        { 
            OrderId = orderId;
            Quantity = quantity;
            ProcessedAt = processedAt;
        }
    }
    public class OrderProcessor  //Publisher Class
    {
        public event EventHandler<OrderEventArgs>? OrderProcessed;

        public void ProcessOrder(string orderId, int quantity)
        {
            Console.WriteLine($"Processing order {orderId} for quantity {quantity}...");
           
            OrderProcessed?.Invoke(this, new OrderEventArgs(orderId, quantity, DateTime.Now));
        }
     }

    public class  NotificationService  //Subscriber Class 
    {
        public void OnOrderProcessed(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"[Notification] Order {e.OrderId} processed at {e.ProcessedAt}, quantity: {e.Quantity}");
        }
    }
    public class  LoggerService
    {
        public void OnOrderProcessed(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"[Logger] Order {e.OrderId} processed at {e.ProcessedAt}, quantity: {e.Quantity}");
        }
    }
}