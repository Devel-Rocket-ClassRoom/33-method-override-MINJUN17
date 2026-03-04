using System;
using System.Collections.Generic;
using System.Text;

class Airplane : Vehicle
{
    public Airplane() : base("보잉747", 900) { }
    public override void Move()
    {
        Console.WriteLine($"[{Name}]이(가) 하늘을 납니다! 속도: [{Speed}]km/h");
    }
}

