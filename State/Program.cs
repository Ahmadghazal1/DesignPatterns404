using State.Example1;

namespace State;

internal class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        order.Pay();      // New → Paid
        order.Ship();     // Paid → Shipped
        order.Deliver();  // Shipped → Delivered
        order.Cancel();   // ❌ Not allowed
    }
}
