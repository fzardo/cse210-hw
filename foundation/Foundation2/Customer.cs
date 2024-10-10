public class Customer
{
    private string _customerName;
    private Address _customerAdress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAdress = customerAddress;
    }

    public (bool, string) UsaCustomer()
    {
        bool isUSA = _customerAdress.CountryChecker();
        string label = _customerAdress.FullAddress();
        return (isUSA, label);
    }
}