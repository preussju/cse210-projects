
public class Order
{
    private List<Product> _product = new List<Product>();
    private Customer _customer;


    public Order(Customer customer )
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _product.Add(product);
    }

    public void TotalPrice()
    {
        float cost = 0;
        foreach (var product in _product)
        {
            cost += product.ProductCost();
        }

        if (_customer.IsUnitedStates() == true)
        {
            cost += 5;
            Console.WriteLine($"Total Cost: {cost}$");
        }
        else
        {
            cost += 35;
            Console.WriteLine($"Total Cost: {cost}$");
        }
    }

    public void GetPackingLabel()
    {
        foreach (var product in _product)
        {
            Console.WriteLine(product.DisplayLabel());
        }
    }
    public void GetShippingLabel()
    {
        Console.WriteLine(_customer.DisplayCustomer());
    }

}