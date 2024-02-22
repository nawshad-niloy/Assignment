using System;
class HelloWorld {
    static void Area(double x)
    {
        double pi = Math.PI;
        double a = pi*Math.Pow(x,2);
        Console.WriteLine("The area of the circle is : "+a+" meter square");
    }
  static void Main() {
    Console.Write("Enter the radius of circle in meter unit : ");
    double r = Convert.ToDouble(Console.ReadLine());
    Area(r);
  }
}
