using System;
using System.Collections.Generic;
using System.Text;

class Product
{
    public string Name { get; protected set; }
    public int Price { get; protected set; }

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }
    public override string ToString()
    {
        return $"[{Name} - \\[{Price:n0}]]";
    }
    public virtual string GetDescription()
    {
        return "상품입니다";
    }
}
