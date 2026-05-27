using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Jerry St", "Fort Worth", "Texas", "USA");
        Customer customer1 = new Customer("Charlie Brown", address1);
        Order order1 = new Order(customer1);
        Product product1a = new Product("Blanket", "B123", 65, 1);
        Product product1b = new Product("Candy Bar", "F951", 2.50, 1);
        Product product1c = new Product("Dishes Set", "D1258", 95, 1);
        order1.AddProduct(product1a); 
        order1.AddProduct(product1b); 
        order1.AddProduct(product1c); 

        
        Address address2 = new Address("456 Mud St", "Fort Worth", "Texas", "USA");
        Customer customer2 = new Customer("Andrew Chase", address2);
        Order order2 = new Order(customer2);
        Product product2a = new Product("Paints", "P001358", 75, 6);
        Product product2b = new Product("Chain Saw", "CS4560", 200, 1);
        order2.AddProduct(product2a);
        order2.AddProduct(product2b);

        Address address3 = new Address("7890 Sparkle Ln", "Calgary", "Albert", "Canada");
        Customer customer3 = new Customer("Sarah Thompson", address3);
        Order order3 = new Order(customer3);
        Product product3a = new Product("Shoes", "SH35879", 126, 1);
        Product product3b = new Product("Necklace", "N7531", 1059, 1);
        Product product3c = new Product("Shoes", "SH35815", 195, 1);
        order3.AddProduct(product3a);
        order3.AddProduct(product3b);
        order3.AddProduct(product3c);


        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);
        orders.Add(order3);

        foreach (Order order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine($"{order.PackingLabel()}");
            Console.WriteLine("Shipping Label:");
            Console.WriteLine($"{order.ShippingLabel()}\n");
            Console.WriteLine($"Subtotal: ${order.OrderCost()}");
            Console.WriteLine($"Shipping: ${order.Shipping()}");
            Console.WriteLine($"Total Cost: ${order.TotalCost()}\n");
            Console.WriteLine("=================================================");
        }
    }
}