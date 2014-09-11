using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S1.L01A
{
    class Vaxelpengar
    {
  
        static void Main(string[] args)
        {
         
            //Deklarera variabler
            double totalSum;
            double roundOff;
            double totalSumRoundOff;
            int cashGiven;
            int cashBack;
            int fiveHundreds;
            int oneHundreds;
            int fifties;
            int twenties;
            int tens;
            int fives;
            int ones;

            //Läs in värden från tangentbord...
            
            while (true)
                {
                    //..och kasta exceptions om värdet skrivs på ett felaktigt sätt
                    try
                    {
                        Console.Write("Ange totalsumma     : ");
                        totalSum = double.Parse(Console.ReadLine());
                    
                        if (totalSum < 0.51)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Summan du angivit är för liten.");
                            Console.ResetColor();
                
                        }else
                        {
                            break;
                        }
                        
                    }
                    catch (FormatException)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Du måste ange ett decimaltal i siffror.");
                        Console.ResetColor();
                    }                   
                }
            //Skriv ett felmeddelande om summan är för liten
            

            while (true)
            {
                try
                {
                    Console.Write("Ange erhållet belopp: ");
                    cashGiven = int.Parse(Console.ReadLine());

                    if (totalSum > cashGiven)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Totalsumman överstiger det erhållna beloppet");
                        Console.ResetColor();
                    }
                    else
                    {
                        break;
                    }
                    
                }
                //Kasta exceptions om värdet skrivs på ett felaktigt sätt
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du måste ange ett heltal i siffror.");
                    Console.ResetColor();
                }
            }

                                          
            //Aritmetik
            roundOff = Math.Round(totalSum) - totalSum;
            totalSumRoundOff = totalSum;
            totalSum = (int)Math.Round(totalSum);
            cashBack = cashGiven - (int)Math.Round(totalSum);
            fiveHundreds = cashBack / 500;
            cashBack = cashBack % 500;
            oneHundreds = cashBack / 100;
            cashBack = cashBack % 100;
            fifties = cashBack / 50;
            cashBack = cashBack % 50;
            twenties = cashBack / 20;
            cashBack = cashBack % 20;
            tens = cashBack / 10;
            cashBack = cashBack % 10;
            fives = cashBack / 5;
            cashBack = cashBack % 5;
            ones = cashBack;
            cashBack = cashGiven - (int)totalSum;
            
            //Presentera
            Console.WriteLine();
            Console.WriteLine("KVITTO");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Totalt: {0, 19:c}", totalSumRoundOff);
            Console.WriteLine("Öresavrundning: {0, 11:c}", roundOff);
            Console.WriteLine("Att betala: {0, 12} kr ", (int)Math.Round(totalSum));
            Console.WriteLine("Kontant: {0, 15} kr", cashGiven);
            Console.WriteLine("Tillbaka: {0, 14} kr", cashBack);
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            //Presentera bara sedlar och mynt om det behövs.

            if (fiveHundreds > 0)
            {
                Console.WriteLine("500-lappar: {0} ", fiveHundreds);
            }

            if (oneHundreds > 0)
            {
                Console.WriteLine("100-lappar: {0} ", oneHundreds);
            }
            if (fifties > 0)
            {
                Console.WriteLine("50-lappar: {0} ", fifties);
            }
            if (twenties > 0)
            {
                Console.WriteLine("20-lappar: {0}", twenties);
            }
            if (tens > 0)
            {
                Console.WriteLine("10-kronor: {0} ", tens);
            }            
            if (fives > 0)
            {
                Console.WriteLine("5-kronor: {0}", fives);
            }
            if (ones > 0)
            {
                Console.WriteLine("1-kronor: {0}", ones);
            }            
        }
    }
}