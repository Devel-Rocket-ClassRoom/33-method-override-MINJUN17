using System;
using System.Collections.Generic;
using System.Text;

class Clothing: Product
{
    public string Size { get; private set; }
    public Clothing(string name, int price, string size) : base(name, price)
    {
        Size = size;
    }
    public override string ToString()
    {
        return $"{base.ToString()} (사이즈: {Size})";
    }
    public override string GetDescription()
    {
        return "\t→ 의류입니다. 세탁 방법을 확인하세요.";
    }
}
