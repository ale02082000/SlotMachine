using SlotMachineLib;
using System;

namespace bartolucci.alessandro._4i.SlotConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            SlotMachine slotMachine = new SlotMachine();


            bool stopSimbolo1 = false;
            bool stopSimbolo2 = false;
            bool stopSimbolo3 = false;

            while (true)
            {
                Console.WriteLine("Premi 'S' per girare la slot machine o 'Q' per uscire:");
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (char.ToUpper(input) == 'Q')
                {
                    break;
                }
                else if (char.ToUpper(input) == 'S')
                {

                    slotMachine.StopSimbolo1 = stopSimbolo1;
                    slotMachine.StopSimbolo2 = stopSimbolo2;
                    slotMachine.StopSimbolo3 = stopSimbolo3;


                    slotMachine.Gioca();


                    Console.WriteLine($"Simbolo 1: {slotMachine.Simbolo1}");
                    Console.WriteLine($"Simbolo 2: {slotMachine.Simbolo2}");
                    Console.WriteLine($"Simbolo 3: {slotMachine.Simbolo3}");
                    Console.WriteLine($"Vincita: {slotMachine.GetMoneteVinte()}");
                    Console.WriteLine($"Crediti: {slotMachine.Credito}");

                    if (slotMachine.NumGiocata % 3 == 0)
                    {
                        stopSimbolo1 = stopSimbolo2 = stopSimbolo3 = false;
                    }
                }
                else
                {
                    Console.WriteLine("Input non valido. Riprova.");
                }
            }
        }
    }
}

