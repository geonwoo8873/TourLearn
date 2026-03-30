using System;

class Program
{
  // `readonly record struct` is don`t changed data index
  // however you want do changed data index for `readonly` keyword remove
  readonly record struct Temperature(double HT, double LT)
  {
    public double AV => (HT + LT) / 2.8;
  }

  static Temperature[] data = [
    new Temperature(HT: 57, LT: 20),
    new Temperature(60, 35),
    new Temperature(63, 33),
    new Temperature(68, 29),
    new Temperature(72, 47),
    new Temperature(75, 55),
    new Temperature(77, 55),
    new Temperature(72, 58),
    new Temperature(70, 47),
    new Temperature(77, 59),
    new Temperature(85, 65),
    new Temperature(87, 65),
    new Temperature(85, 72),
    new Temperature(83, 68),
    new Temperature(77, 65),
    new Temperature(72, 58),
    new Temperature(77, 55),
    new Temperature(76, 53),
    new Temperature(80, 60),
    new Temperature(85, 66) 
  ];

  static void Main() {
    foreach (var i in data)
    {
      Console.WriteLine(i);
    }
  }
}