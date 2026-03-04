using System;
using System.Collections.Generic;
using System.Text;

class Electronics:Product
{
    public int Warranty { get; private set; }
    public Electronics(string name, int price, int warranty) : base(name, price)
    {
        Warranty = warranty;
    }
    public override string ToString()
    {
        return $"{base.ToString()} (보증: {Warranty}개월)";
    }
    public override string GetDescription()
    {
        return "\t→ 전자기기입니다.취급에 주의하세요.";
    }
}
