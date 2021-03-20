using System;

namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            
            JUST IN TIME VARIABLE DECLARATION, DONT USE UNNECESSARY VARIABLES AND DECLARE A VARIABLE JUST BEFORE USING IT, NOT 1000 LINES ABOVE


            Console.WriteLine("Please enter a number to obtain its factorial: ");
            int a = 1;
            int b = int.Parse(Console.ReadLine());
            int c = 1;
            while (a < b)
            {
                c *= b;
                b--;
            }
            Console.WriteLine(c);


            -----------------------------------------------------------------------------------------------
            
            BE POSITIVE, DECLEARE CONDITIONS IN A POSITIVE MANNER, NOT LIKE !isnotlogin FOR INSTACE...


            bool isRegistered = true;
            while (isRegistered)
            {
               // Do something...
            }

            -----------------------------------------------------------------------------------------------

            YOU MIGHT USE TERNARY IF OPERATOR WHEN POSSIBLE BUT NOT IN CASES WHERE THERE ARE MANY CONDITIONS


            // Permission to enter a bar

            bool permission = ageOfMajority ? true : false;


            -----------------------------------------------------------------------------------------------

            USE STRONGLY TYPING LANGUAGE PROPERTIES and AVOID USING BLURRY VARIABLES


            // It is not clear what that number is.
            if (wealth > 1000000){
                Console.WriteLine("You are a rich person");
            }
            

            // Instead use this
            int moneyAmount = 1000000
            if (wealth > moneyAmount){
                Console.WriteLine("You are a rich person");
            }
            
            -----------------------------------------------------------------------------------------------
            
            FAIL FAST

            // Sorry you are not wealth and learned that quickly...
            if (wealth > moneyAmount){
                throw ....
            }

            -----------------------------------------------------------------------------------------------
            
            
            RETURN EARLY
            

            // Let's say you want to let the people into your bar between certain ages 

            minAge = 21;
            if(age < minAge) 
                return false;
            int maxAge = 55; 
            if(userAge > maxAge) 
                return false;
         








            */



        }
    }
}
