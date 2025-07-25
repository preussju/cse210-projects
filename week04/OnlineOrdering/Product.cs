
public class Product
{
    private string _productName;
    private string _productId;
    private float _price;
    private float _quantity;

    public Product(string productName, string productId, float price, float quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public float ProductCost()
    {
        return _price * _quantity;
    }

    public string DisplayLabel()
    {
        return $"Product: {_productName} |  ID: {_productId}";
    }


}