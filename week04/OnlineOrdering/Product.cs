
public class Product
{
    private string _pName;
    private string _pID;
    private double _price;
    private int _quantity;

    

    public string ProductID => _pID;
    public string ProductName => _pName;

    public Product(string pName, string pID, double price, int quantity)
    {
        _pName = pName;
        _pID = pID;
        _price = price;
        _quantity = quantity;
    }
    public double ProductCost()
    {
        return _price * _quantity;
    }


}