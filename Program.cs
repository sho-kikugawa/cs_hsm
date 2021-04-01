using System;
using System.Text;
using Hsm;

namespace Hsm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting test...");
            Hsm test = new Hsmtst();
            string s = " ";            

            while (s[0] != 'x')
            {
                Console.Write("\r\nSignal<- ");
                s = Console.ReadLine();
                if (s[0] != 'x')
                {
                    Event e = new TestEvent(s[0]);
                    test.dispatch(e);
                }
            }
        }
    }
}
