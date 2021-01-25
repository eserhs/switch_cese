using System;

namespace switch_cese
{
    class Program
    {
        static void Main(string[] args)
        {
            int  gun1 = 10;
            int  gun2 = 5;

            switch (gun1)
            {

                case  (10):
                    for (int i = 0; i  < 10 ; i++)
                    {
                        Console.WriteLine(10 - i);
                    }
                    break;
                case 5 :
                    Console.WriteLine(5-4 ) ;
                    break;

                default:
                    Console.WriteLine("yok valla abi olmadı ");
                    break;
                   
            }
        }
    }
}
