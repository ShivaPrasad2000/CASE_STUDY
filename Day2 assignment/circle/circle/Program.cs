using System;

namespace circle
{
    class circle
    {
        int radius;
        public circle()
        {
            Console.WriteLine("Enter radius...");
            radius = int.Parse(Console.ReadLine());
        }
        public void SetRadius(int radius)
        {
            this.radius = radius;
        }
        public int GetRadius()
        {
            return this.radius;
        }
        public int calcDiameter()
        {
            return radius * 2;
        }
        public double calcArea()
        {
            return (3.14 * radius * radius);
        }
    }
    class CircleTest
    {
        public static void Main(string[] args)
        {
            circle Circle1 = new circle();
            Console.WriteLine("The radius of circle is...{0}", Circle1.GetRadius());
           
            Console.WriteLine("The diameter of circle is...{0}", Circle1.calcDiameter());
            
            Console.WriteLine("The area of circle is...{0}",Circle1.calcArea());
            
        }
    }
    
}
