public class Product
{
    private string _productName;
    private int _productId;
    private float _productPrice;
    private int _productQuantity;

    public Product(string productName, int productId, float productPrice, int productQuantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public float GetProductTotalCost()
    {
        float _totalCost = _productPrice * _productQuantity;
        return _totalCost;
    }

    public string GetProductName()
    {
        _productName = _productName + $" {_productQuantity}";
        return _productName;
    }
}