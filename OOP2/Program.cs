using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static List<ElectricityConsumers> clientsList = new List<ElectricityConsumers>();
        static void Main(string[] args)
        {
            bool newIteration = true;
            do
            {
                Console.Clear();
                float summOnPlan = 0;
                float summInFact = 0;
                float summMistake = 0;
                float summPMistake = 0;

                #region Caption
                Console.Write("╔═══╤");
                for (int j = 0; j < 34; j++) Console.Write('═');
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("╤");
                    for (int k = 0; k < 14; k++)
                        Console.Write("═");
                }
                Console.WriteLine("╗");
                Console.Write("║{0,3}", "№");
                Console.Write("│{0,34}", "Завод");
                Console.Write("│{0,14}", "за планом");
                Console.Write("│{0,14}", "фактично");
                Console.Write("│{0,14}", "у кВт/год");
                Console.Write("│{0,14}║", "у вiдсотках");
                Console.WriteLine();
                #endregion

                for (int i = 0; i < clientsList.Count; i++)
                {
                    Console.Write("╟───┼");
                    for (int j = 0; j < 34; j++) Console.Write('─');
                    for(int j = 0; j < 4; j++)
                    {
                        Console.Write("┼");
                        for(int k = 0; k < 14; k++)
                            Console.Write("─");
                    }
                    Console.WriteLine("╢");
                    Console.Write("║{0,3}", i + 1);
                    Console.Write("│{0,34}", clientsList[i].nameConsumers);
                    Console.Write("│{0,14:0.##}", clientsList[i].consumptionOnPlan);
                    Console.Write("│{0,14:0.##}", clientsList[i].consumptionInFact);
                    Console.Write("│{0,14:0.##}", clientsList[i].mistake);
                    Console.Write("│{0,14:0.##}║", clientsList[i].pMistake);
                    Console.WriteLine();

                    summOnPlan += clientsList[i].consumptionOnPlan;
                    summInFact += clientsList[i].consumptionInFact;
                    summMistake += clientsList[i].mistake;
                    summPMistake += (summMistake * 100) / summOnPlan;
                    
                }

                #region Result
                Console.Write("╟───┼");
                for (int j = 0; j < 34; j++) Console.Write('─');
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("┼");
                    for (int k = 0; k < 14; k++)
                        Console.Write("─");
                }
                Console.WriteLine("╢");
                Console.Write("║{0,3}", "");
                Console.Write("│{0,34}", "Разом");
                Console.Write("│{0,14:0.##}", summOnPlan);
                Console.Write("│{0,14:0.##}", summInFact);
                Console.Write("│{0,14:0.##}", summMistake);
                Console.Write("│{0,14:0.##}║", summPMistake);
                Console.WriteLine();

                Console.Write("╚═══╧");
                for (int j = 0; j < 34; j++) Console.Write('═');
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("╧");
                    for (int k = 0; k < 14; k++)
                        Console.Write("═");
                }
                Console.WriteLine("╝");
                #endregion
                Console.Write("Оберiть номер дiї (1 - додати, 2 - видалити, 3 завершити):");
                ConsoleKeyInfo variant = Console.ReadKey();
                if (variant.Key == ConsoleKey.D1) AddItem();
                else if (variant.Key == ConsoleKey.D2) DeleteItem();
                else if (variant.Key == ConsoleKey.D3) newIteration = false;
            } while (newIteration);   
        }
        static void DeleteItem()
        {
            Console.Write("\nВведiть номер запису: ");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine()) - 1;
                if (n > clientsList.Count)
                {
                    Console.Write("Запис не iснує");
                    Console.ReadKey();
                }
                else clientsList.RemoveAt(n);
            }
            catch
            {
                Console.WriteLine("Помилка введення");
                Console.ReadKey();
            }
           
        }

        static void AddItem()
        {
            try
            {
                Console.Write("\nВведiть назву споживача: ");
                string name = Console.ReadLine();
                Console.Write("Введiть заплановану кiлькiсть спожитої енергiї: ");
                float onPlan = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введiть фактичну кiлькiсть спожитої енергiї: ");
                float inFact = Convert.ToInt32(Console.ReadLine());
                clientsList.Add(new ElectricityConsumers(name, onPlan, inFact));
            }
            catch
            {
                Console.WriteLine("Помилка введення");
                Console.ReadKey();
            }
            
        }

    }
}
