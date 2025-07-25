using System;

class Program
{
    static void Main(string[] args)
    {
        //order 1 
        Product pen = new Product("pen", "AILO98", 2.0f, 10f);
        Product pencil = new Product("pencil", "ALOI80", 1.0f, 10f);
        Address address1 = new Address("Av. do Forte 11", "Porto Alegre", "RS", "BR");
        Customer customer1 = new Customer(address1, "Julia");

        Order order1 = new Order(customer1);
        order1.AddProduct(pen);
        order1.AddProduct(pencil);

        //order 2 
        Product scissors = new Product("scissors", "ElM76", 3.0f, 10f);
        Product eraser = new Product("eraser", "AVV12", 0.5f, 10f);
        Product tape = new Product("tape", "TAP76", 2.5f, 2f);
        Address address2 = new Address("914 south 12 west, 176", "Rexburg", "ID", "USA");
        Customer customer2 = new Customer(address2, "Mark");

        Order order2 = new Order(customer2);
        order2.AddProduct(scissors);
        order2.AddProduct(eraser);
        order2.AddProduct(tape);

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine();
            Console.WriteLine("Packing Label: ");
            order.GetPackingLabel();
            Console.WriteLine();
            Console.WriteLine("Shipping Label: ");
            order.GetShippingLabel();
            Console.WriteLine();
            order.TotalPrice();
        }
            
    }
}