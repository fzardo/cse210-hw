public class Order
{
    private List<Product> _productsList;
    private Customer _customer;

    public Order(List<Product> productsList, Customer customer)
    {
        _productsList = productsList;
        _customer = customer;
    }

    public float Subtotal()
    {
        int fromUSA = 5;
        int notfromUSA = 35;

        float subtotal = 0;
        for (int i = 0; i < _productsList.Count; i++)
        {
            subtotal += _productsList[i].GetProductTotalCost();
        }

        if (_customer.UsaCustomer())
        {
            subtotal += fromUSA;
        }
        else
        {
            subtotal += notfromUSA;
        }

        return subtotal;
    }

    public string PackingLabel()
    {
        string packingLabel = $"{_customer.CustomerName()}\n";

        for (int i = 0; i < _productsList.Count; i++)
        {
            packingLabel += $"{_productsList[i].GetProductName()}\n";
        }
        return packingLabel;
    }

    public string ShippingLabel()
    {
        string shippingLabel = _customer.CustomerAddress();
        return shippingLabel;
    }
}