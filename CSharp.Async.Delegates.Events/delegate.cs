


namespace DelegateDemo
{
     public delegate void CustomDelegate(string message);

    public static class DelegateExamples
    {
        public static void RunAll()
        {
            CustomDelegate custom = PrintMessage;
            custom("Hello from Custom Delegate!");

            
            Action<string> actionPrinter = msg => Console.WriteLine($"Action says: {msg}");
            actionPrinter("Hello from Action<T>");

            
            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine($"Func result: 5 + 7 = {add(5, 7)}");

            
            Predicate<int> isEven = n => n % 2 == 0;
            Console.WriteLine($"Predicate result: Is 10 even? {isEven(10)}");

            
            CustomDelegate multi = PrintMessage;
            multi += PrintUpperMessage;
            multi("Hello from Multicast Delegate!");

            Console.WriteLine("Multicast Removal");
            multi -= PrintUpperMessage;
            multi("After removal!");

            Console.WriteLine("\n=== Delegate as Parameter ===");
            Execute(() => Console.WriteLine("Lambda executing!"));
        }

        //Named Method
        //private static void MyMethod()
        //{
        //    Console.WriteLine("Executing!");
        //}
        //Execute(MyMethod);  // pass method directly

        //Way 3 — Action variable:

        //Action myAction = () => Console.WriteLine("Executing!");
        //Execute(myAction);

        // Methods used by delegates
        private static void PrintMessage(string msg)
        {
            Console.WriteLine($"PrintMessage: {msg}");
        }

        private static void PrintUpperMessage(string msg)
        {
            Console.WriteLine($"PrintUpperMessage: {msg.ToUpper()}");
        }
        //as suggested by claude

        // delegate as parameter
        public static void Execute(Action action)
        {
            Console.WriteLine("Before execution");
            action();
            Console.WriteLine("After execution");
        }
    }
}
