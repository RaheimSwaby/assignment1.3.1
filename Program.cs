using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;

namespace assignment1._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareLength = 5.5;
             double result = SquareArea(squareLength);
            Console.WriteLine(result);

            double rectLenght = 6.6;
            double rectHeight = 5;
            Console.WriteLine("the area of the rectangle is: ");
            double result1 = rectArea(rectLenght * rectHeight);
          
            Console.WriteLine(result1);

            double triBase = 5.6;
            double triHeight = 10 * 0.5;
            double result2 = triBase * triHeight;
            Console.WriteLine("the area of this triangle is : ");
            Console.WriteLine(result2);


            
            
         


            

        }
        static double SquareArea(double length)
        {
            double area = length * length;

            return area;

        }
        

        static double rectArea(double length)
        {
            double area1 = length;
            return area1;
        }
        

        

        
        

    }
}
