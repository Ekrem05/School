namespace Threads
{
    using System.Threading;
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstThread first = new();
            Thread thread1 = new(first.DoTask1);
            Thread thread2 = new(first.DoTask2);
            Thread thread3 = new(first.Print);
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }
}