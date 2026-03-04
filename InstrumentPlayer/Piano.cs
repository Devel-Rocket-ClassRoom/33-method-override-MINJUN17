using System;
using System.Collections.Generic;
using System.Text;

class Piano : Instrument
{
    public Piano() : base("피아노")
    {

    }
    public override void Play()
    {
        Console.WriteLine("🎹 피아노 건반을 누릅니다 - 딩동댕~");
    }
    public override void Tune()
    {
        Console.WriteLine("피아노 현을 조율합니다");
    }

}
