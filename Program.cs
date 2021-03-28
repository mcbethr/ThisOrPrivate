using System;
using System.Diagnostics;

namespace ThisOrPrivate
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch1 = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();


            stopwatch2.Start();
            UsingThis UT = new UsingThis();
            stopwatch2.Stop();

            stopwatch1.Start();
            DirectAssignment UU = new DirectAssignment(1);
            stopwatch1.Stop();


            Console.WriteLine("Direct Assignment: " + stopwatch1.ElapsedTicks);
            Console.WriteLine("Using This:" + stopwatch2.ElapsedTicks);

        }
    }

    public class DirectAssignment
    {

        int _example;

        public DirectAssignment(int incomingExample)
        {
            _example = incomingExample;
        }

    }

    public class UsingThis
    {

        int example;

        public void UsingThisAssignment(int incomingExample)
        {
            this.example = incomingExample;
        }

    }

}
