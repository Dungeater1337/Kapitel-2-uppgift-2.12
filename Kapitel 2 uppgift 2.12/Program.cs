using System;


namespace uppgift2_12
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hur länge har du tänkt hyra bilen?");
            string strDagartext = Console.ReadLine();   
            int Dagar = int.Parse(strDagartext);

            
            Console.WriteLine("Hur många KM du tänkt köra?"); 
            string strKMtext=Console.ReadLine();
            int KM = int.Parse(strKMtext);

            int total; 
            total = 300 + 500 * (Dagar - 1) + KM;
            Console.WriteLine("Den totala summan blir " + total  ); 
   

        }


    }
  
}