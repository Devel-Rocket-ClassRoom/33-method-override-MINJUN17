using System;

Instrument[] instruments = new Instrument[3]
{
    new Piano(),
    new Guitar(),
    new Drum()
};
Console.WriteLine("=== 악기 연주회 ===");

foreach(Instrument instrument in instruments)
{
    instrument.Play();
    instrument.Tune();
}