using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine( true || true);
            Console.WriteLine( false || true);
            Console.WriteLine( false || false);
            
            Console.WriteLine( true && true);
            Console.WriteLine( false && true);
            Console.WriteLine( false && false);

            Console.WriteLine( false == false);
            Console.WriteLine( true == false);
            Console.WriteLine( 2.25 == 2.25 );
            Console.WriteLine( 2.25 == 3.14);

            Console.WriteLine( 6 > 7 );
            Console.WriteLine( 10 > 5 );

            Console.WriteLine( 6 < 7 );
            Console.WriteLine( 10 < 5 );

            Console.WriteLine( 5 >= 5 );
            Console.WriteLine( 4 >= 5 );

            
            Console.WriteLine( 7 <= 7 );
            Console.WriteLine( 10 <= 5 );


            Console.WriteLine( false != false);
            Console.WriteLine( true != false);
            Console.WriteLine( 5 != 5);
            Console.WriteLine( 10 != 5);

        }
    }
}
