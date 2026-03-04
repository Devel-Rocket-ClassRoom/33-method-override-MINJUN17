using System;
using System.Collections.Generic;
using System.Text;

class Guitar : Instrument
{
    public Guitar() : base("기타")
    {

    }
    public override void Play()
    {
        Console.WriteLine("🎸 기타 줄을 튕깁니다 - 통통통~");
    }
    public override void Tune()
    {
        Console.WriteLine("기타 줄을 조율합니다");
    }

}