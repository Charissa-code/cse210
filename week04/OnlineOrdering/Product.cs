
public class Product
{
    private string _pName;
    private string _pId;
    private double _price;
    private int _quantity;

    
    public string ProductId => _pId;
    public string ProductName => _pName;

    public Product(string pName, string pId, double price, int quantity)
    {
        _pName = pName;
        _pId = pId;
        _price = price;
        _quantity = quantity;
    }
    public double ProductCost()
    {
        return _price * _quantity;
    }


}