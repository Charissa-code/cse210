public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string FullAddress()
    {
        return _address.FullAddress();
    }
    public string Name => _name;


    // public bool IsCountryUSA()
    // {
    //     return _address.IsCountryUSA();
    // } SAME AS
    public bool IsCountryUSA() => _address.IsCountryUSA();
}