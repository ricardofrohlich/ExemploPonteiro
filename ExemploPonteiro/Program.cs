using System;

namespace ExemploPonteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int i;
                i = 10;
                int* ponteiro;
                ponteiro = &i;
                Console.WriteLine("O valor que o ponteiro está apontando é = "+ *ponteiro);
            }
        }
    }
}
