using System;
class HelloWorld {
  static double Area(double x,double y,double z)
  {
      double s = (x+y+z)/2;
      double a = Math.Sqrt(s*(s-x)*(s-y)*(s-z));
      return a;
  }
  static void Main() {
    Console.Write("Enter the length of the first side of the triangle : ");
    double side1 = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("Enter the length of the second side of the triangle : ");
    double side2 = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("Enter the length of the third side of the triangle : ");
    double side3 = Convert.ToDouble(Console.ReadLine());
    if(side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
    {
    double area = Area(side1,side2,side3);
    Console.WriteLine("The area of the triangle : "+area);
    }
    else 
    {
        Console.WriteLine("The sum of the length of any two sides must exceed the length of other side");
    }
  }
}
