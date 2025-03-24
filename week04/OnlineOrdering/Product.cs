public class Product {
    private string _prodcutID;
    private string _name;
    private double _price;
    private int _quantity;

    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _prodcutID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackingLabel()
    {
        return $"Product: {_name} ID: {_prodcutID}";
    }
}