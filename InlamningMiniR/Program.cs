using System;
using System.Collections.Generic;

namespace InlamningMiniR
{
    class Program
    {
        static void Main(string[] args)
        {

            //listan att lägga in alla ekvationer för att kunna skriva ut dem senare som textsrängar
            List<string> ekvLista = new List<string>();

            //variabler för att kunna få operatorernas tecken till täxtsträngar när man skriver ut listan.
            char operatorPlus = '+'; //char då det är 1 tecken nytt namn som kan användas vid konverteringen, operatorn som en textsträng
            char operatorMinus = '-';
            char operatorGanger = '*';
            char operatorDiv = '/';

            Console.Write("Hej och välkommen till Hammarshalls basala miniräknare! ");
            Console.WriteLine("För att bespara migrän, en existentiell kris och ett psykbryt, fyll i vad programmet efterfrågar..");

            /*
            Console.Write("Ange ditt namn: "); // anv skriver in namn får hälsning tbx
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            // försöker göra denna delen till en metod ist
            */

            //metod av hälsningsdelen.

            Console.Write("Vänligen ange ditt namn: ");  //anv namn input
            string name = Console.ReadLine();     //datatyp + namn, deklarerar anv input

            void Greeting (string inputName)     //vi vill bara att den gör ngt, (dattatyp + internt namn i metoden)
            {
                Console.WriteLine( "Hej " + inputName + ", välkommen!"); //metoden är skriv ut text + interna namnet.
            }
            Greeting(name);  //metoden skrivs ut aka namnet på metoden + namnet på input variablen.

            bool runAgain = true; //del av våran do while.


            do // gör detta medans.. true att man vill fortsätta köra programment.
            {

                /* Console.Write("Skriv en siffra: ");
                double inputNum1 = Convert.ToInt32(Console.ReadLine()); // anv skriver in nr.

                Console.Write("Skriv en till siffra: ");
                double inputNum2 = Convert.ToInt32(Console.ReadLine());// valde Double = mer exakta resultat.
                //För att få menyndelen före man väljer sina tal, sattes denna delen in i varje if else statement. */


                Console.WriteLine("Vänligen välj en operator"); //väljer +, -, * etc
                Console.WriteLine("Tryck 1 för att addera");
                Console.WriteLine("tryck 2 för att subtrahera");
                Console.WriteLine("tryck 3 för att multiplicera");
                Console.WriteLine("tryck 4 för att dividera");
                Console.WriteLine("tryck 5 för att skriva ut listan med ekvationer");
                Console.WriteLine("tryck 6 för att avsluta programmet");


                double Inputoperator = Convert.ToInt32(Console.ReadLine()); //input för operator omvandlas
                double sum; // deklarear en variabel för summan

                if (Inputoperator == 1) // anv trycker 1 = addition.
                {
                    Console.Write("Vänligen skriv en siffra: ");
                    double inputNum1 = Convert.ToDouble(Console.ReadLine()); //anv input convert ifrån text till int

                    Console.Write("Skriv in yttligare en siffra: ");
                    double inputNum2 = Convert.ToDouble(Console.ReadLine()); //x2

                    sum = inputNum1 + inputNum2; //adderar inputs
                    
                    Console.WriteLine("Summan av talen är " + sum); //skriver ut input

                    //covertar alla olika ints till strängar för att spara det i ekvLista
                    string ekv1 = inputNum1.ToString(); //input tal nr 1

                    string ekv2 = operatorPlus.ToString(); //operator + som en sträng

                    string ekv3 = inputNum2.ToString(); //Input tal nr 2

                    string ekv4 = sum.ToString(); //summan converterat till sträng

                    string ekv = ekv1 + ekv2 + ekv3 + " = " + ekv4; //string ekv = alla ihopslagna delarna av sträng

                    ekvLista.Add(ekv); //ekvLista add i listan med som värdet är på ekv.
                }

                else if (Inputoperator == 2) //anv trycker 2 = subtraktion
                {
                    //exakt samma händer som jag förklarat ovan fast med annan operator.

                    Console.Write("Vänligen skriv en siffra: ");
                    double inputNum1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Skriv en till siffra: ");
                    double inputNum2 = Convert.ToDouble(Console.ReadLine());

                    sum = inputNum1 - inputNum2;

                    Console.WriteLine("Differensen av talen är " + sum);

                    string ekv1 = inputNum1.ToString();
                    string ekv2 = operatorMinus.ToString(); //ropar på vår char minus som står ovan
                    string ekv3 = inputNum2.ToString();
                    string ekv4 = sum.ToString();

                    string ekv = ekv1 + ekv2 + ekv3 + " = " + ekv4;
                    ekvLista.Add(ekv);
                }

                else if (Inputoperator == 3) //Anv trycker 3 = Mulitplikation
                {

                    //exakt samma händer som jag förklarat ovan fast med Multiplikation

                    Console.Write("Vänligen skriv en siffra: ");
                    double inputNum1 = Convert.ToDouble(Console.ReadLine()); //anv skriver in nr.

                    Console.Write("Skriv en till siffra: ");
                    double inputNum2 = Convert.ToDouble(Console.ReadLine());

                    sum = inputNum1 * inputNum2;
                    Console.WriteLine("Produkten av talen är " + sum);

                    string ekv1 = inputNum1.ToString();
                    string ekv2 = operatorGanger.ToString(); //vår gånger char se ovan
                    string ekv3 = inputNum2.ToString();
                    string ekv4 = sum.ToString();

                    string ekv = ekv1 + ekv2 + ekv3 + " = " + ekv4;
                    ekvLista.Add(ekv);
                }

                else if (Inputoperator == 4) //Anv trycker 4 = division
                {
                    Console.Write("Vänligen skriv en siffra: ");
                    double inputNum1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Skriv en till siffra: ");
                    double inputNum2 = Convert.ToDouble(Console.ReadLine());

                    sum = inputNum1 / inputNum2;
                    Console.WriteLine("Kvoten av talen är " + sum);

                    string ekv1 = inputNum1.ToString();
                    string ekv2 = operatorDiv.ToString(); //divisions char ovan
                    string ekv3 = inputNum2.ToString();
                    string ekv4 = sum.ToString();

                    string ekv = ekv1 + ekv2 + ekv3 + " = " + ekv4;
                    ekvLista.Add(ekv);
                }

                else if (Inputoperator == 5) //Anv trycker 5 = skriva ut alla textsträngar i ekv listan. aka våra ekvationer som sparats där
                {
                    for (int i = 0; i < ekvLista.Count; i++) ///sålänge [i] är mindre än antalet index i listan kmr loopen gå, för varje steg lägger vi på 1
                    {
                        Console.WriteLine(ekvLista[i]); //skriv ut listan
                    }
                }

                else if (Inputoperator == 6) //Anv trycker 6 = avslutas prog pga vår runAgain bool false = koden avslutas vilkoret för att köra är att den är true
                {
                    runAgain = false;
                }

                Console.ReadKey(); //innan den loopar vidare efter summan skrivs ut väntar den på ett knapptryck ifrån anv.

            } while (runAgain == true); // kmr köras så länge de är true. detta är en bool!!!

            Console.WriteLine("Tack för din medverkan! :) ");
        }
    }
}
