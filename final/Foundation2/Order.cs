using System;

public class Order
{
    Customer _customer;
    List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void SetProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;

        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalCost();
        }

        if (_customer.InUSA())
        {
            return Math.Round(totalPrice + 5, 2);
        }
        else
        {
            return Math.Round(totalPrice + 35, 2);
        }
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $@"----Shipping Label----
        {_customer.GetName()}
        {_customer.GetAddress()}";
        return shippingLabel;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "----Packing List----\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetID()} ---- {product.GetName()} ---- x{product.GetQuantity()}\n";
        }
        return packingLabel;
    }
}