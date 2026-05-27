public class Address
{
    private string _stAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string stAddress, string city, string stateProvince, string country)
    {
        _stAddress = stAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;

        
    }
    
    public string FullAddress()
        {
            return($"{_stAddress}\n{_city}, {_stateProvince} {_country}");
        }

    public bool IsCountryUSA()
    {
        return _country == "USA"; 
    }
}

