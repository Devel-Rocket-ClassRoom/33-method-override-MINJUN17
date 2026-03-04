using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

class Food : Product
{
    public string ExpirationDate { get; private set; }
    public Food(string name, int price, string expirationDate) : base(name, price)
    {
        ExpirationDate = expirationDate;
    }
    public override string ToString()
    {
        return $"{base.ToString()} (유통기한: {ExpirationDate})";
    }
    public override string GetDescription()
    {
        return "\t→ 식품입니다. 냉장 보관하세요.";
    }
}
