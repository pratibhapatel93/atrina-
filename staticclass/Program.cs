using System;
namespace staticclass
 {
    class Circle
    {
       static float _PI;
       int _Radius;

       static Circle()
       {
         Console.WriteLine("static c'tor called");//are always called before instance ctor  
        Circle._PI=3.141F;// initialize static field
       }

       public Circle(int Radius)
       {
        Console.WriteLine("instance c'tor called");
        this._Radius=Radius;
       }
      
       public float CalculateArea()
       {
         return Circle._PI*this._Radius*this._Radius;
       }

    }

    class Program
    {
        public static void Main()
        {
            Circle C1 = new Circle(5);
            float Area1=C1.CalculateArea();
            //static members using class name 
            Console.WriteLine("Area={0}",Area1);

            Circle C2 = new Circle(6);
            float Area2=C2.CalculateArea();
            Console.WriteLine("Area={0}",Area2);


        }
    }




 }