using DelegateDemo;
using EventsDemo;
using System;

namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Running Delegate Demo ===");
            DelegateExamples.RunAll();
            Console.WriteLine("\n=== Demo Complete ===");

            //Event Details 
            var processor = new OrderProcessor();
            var notifier = new NotificationService();
            var logger = new LoggerService();

            processor.OrderProcessed += notifier.OnOrderProcessed;
            processor.OrderProcessed += logger.OnOrderProcessed;
            processor.ProcessOrder("ORD123", 5);
            processor.ProcessOrder("ORD456", 10);
        }

    }
}
