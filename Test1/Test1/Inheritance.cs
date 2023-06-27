using System;

namespace Test1
{
    public interface IPlayable
    {
        void Play();
    }
    public class Musician : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing music...");
            
        }
    }

    class Inheritance
    {
        /*
         public static void Main()
        {
            Musician player = new Musician();
            player.Play();
        }
        */
    }
}

