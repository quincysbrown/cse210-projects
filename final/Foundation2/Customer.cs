using System;

public class Customer
{
    private string _name;
    private Address _address;

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    public bool InUSA()
    {
        return _address.InUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.DisplayAddress();
    }

}