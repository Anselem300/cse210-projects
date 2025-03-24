public class Order {
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProducts(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        Double _total = 0;
        foreach(var product in _products)
        {
            _total += product.GetTotalCost();
        }
        Double _shippingCost = _customer.IsInUSA()? 5:35;
        return _total + _shippingCost;
    }

    public string GetPackingLabel()
    {
        List<string> _labels = new List<string>();
        foreach(var product in _products)
        {
            _labels.Add(product.GetPackingLabel());
        }
        return string.Join("\n", _labels);
    }

    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }
}