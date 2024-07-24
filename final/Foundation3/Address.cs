using System;

public class Address
{
    private string _locationName;
    private string _street;
    private string _city;
    private string _state;
    private int _zip;
    public Address(string name, string street, string city, string state, int zip)
    {
        _locationName = name;
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
    }

    public string DisplayAddress()
    {
        string pattern = $@"{_locationName}
        {_street}
        {_city}, {_state}
        {_zip}";
        return pattern;
    }

}