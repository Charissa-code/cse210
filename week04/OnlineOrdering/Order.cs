


public class Order
{
    private Customer _customer;
    private List<Product> _products;
    
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double OrderCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total = total + product.ProductCost();
        }
        return total;
    }


    public double Shipping()
    {
        if (_customer.IsCountryUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    
    public double TotalCost()
    {
        return OrderCost() + Shipping();
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"Product ID: {product.ProductId}\nProduct Name: {product.ProductName}\n\n";
        }
        return label;
    }


     public string ShippingLabel()
    {
        return $"{_customer.Name}\n{_customer.FullAddress()}";
    }
}




