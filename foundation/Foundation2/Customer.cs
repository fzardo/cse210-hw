public class Customer
{
    private string _customerName;
    private Address _customerAdress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAdress = customerAddress;
    }

    public bool UsaCustomer()
    {
        bool isUSA = _customerAdress.CountryChecker();
        return isUSA;
    }

    public string CustomerAddress()
    {
        string label = _customerAdress.FullAddress();
        return label;
    }

    public string CustomerName()
    {
        return _customerName;
    }
}