using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Item
{
    private int id;
    private string title { get; set; }
    public int quantity { get; set; }
    public double price { get; set; }
    public double subtotal { get; set; }
    private string type;

    public Item(int id, string title, int quantity, string type, double price)
    {
        this.id = id;
        this.title = title;
        this.quantity = quantity;
        this.type = type;
        this.price = price;
        this.subtotal = 0;
    }
    public string getTitle()
    {
        return title;
    }
    public int getQuantity()
    {
        return quantity;
    }
    public string getType()
    {
        return type;
    }
    public double getPrice()
    {
        return price;
    }
    public double getSubtotal()
    {
        subtotal = price * quantity;
        return subtotal;
    }
}