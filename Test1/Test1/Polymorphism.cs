using System;


namespace Test1
{

    class Polymorphism
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        public virtual void MethodOveriding()
        {
            Console.WriteLine("example of overriding");
        }
        /*
        public static void Main(string[] args)
        {
            Polymorphism obj = new Polymorphism();
            obj.Add(10, 20);
            obj.Add(10.5f, 20.5f);
            obj.MethodOveriding();
            Console.ReadKey();
        }
        */
    }

        class MethodOverriding : Polymorphism
        {
            public  override void  MethodOveriding()
            {
                Console.WriteLine("The above method has been overridden");
            }
        }
    
}

