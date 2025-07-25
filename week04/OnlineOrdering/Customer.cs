
using System.Runtime.InteropServices;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(Address address, string name)
    {
        _name = name;
        _address = address;
    }

    public string DisplayCustomer()
    {
        return $"Name: {_name} {_address.DisplayAddress()}";
    }

    public bool IsUnitedStates()
    {
        if (_address.CheckCountry() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}