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
        float subtotal = 0;
        for (int i = 0; i < _productsList.Count; i++)
        {
            subtotal += _productsList[i].GetProductTotalCost();
        }
        return subtotal;
    }

    public string PackingLabel()
    {
        string packingLabel = "";
        for (int i = 0; i < _productsList.Count; i++)
        {
            packingLabel += $"{_productsList[i].GetProductName()}\n";
        }
        return packingLabel;
    }

    public string ShippingLabel()
    {
        string shippingLabel = _customer.UsaCustomer();
    }
}