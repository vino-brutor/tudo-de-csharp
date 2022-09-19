using System;

namespace media_do_triangul_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            float b;
            float altura;

            Console.WriteLine("Quanto vale a base?");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("e quanto vale a altura?");
            altura = float.Parse(Console.ReadLine());

            float area = (b*altura)/2;

            Console.WriteLine("a área desse triangulo é {0}",area);
            Console.Write("um baita triangulo realmente");
        }
    }
}
