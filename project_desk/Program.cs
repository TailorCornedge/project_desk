using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_desk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> e_mailok = new List<string>();
            e_mailok.Add("alma1@kort.hu");
            e_mailok.Add("alma2@korte.hu");
            e_mailok.Add("alma3@kortu.hu");
            e_mailok.Add("alma4@korta.hu");
            e_mailok.Add("alma5@kortm.hu");
            while (true) { 
                Console.Clear();
                Console.WriteLine("0. Kilépés");
                Console.WriteLine("1. e-mailek listázása");
                Console.WriteLine("2. új e-mail");
                Console.WriteLine("3. e-mail törlése");
                Console.WriteLine("4. érvényes e-mailok listázása");

                string valasztas=Console.ReadLine();
                switch (valasztas)
                {
                    case "0": return;
                    case "1": 
                        Console.Clear();
                        Console.WriteLine("e-mail címet:");
                        int sorszam = 0;
                        foreach(String e_mail in e_mailok)
                        {
                            Console.WriteLine($"{sorszam++} {e_mail}");
                        }
                        break;
                    case "2": Console.WriteLine("új e-mailek"); break;
                    case "3": Console.WriteLine("e-mail törlés"); break;
                    case "4": Console.WriteLine("érvényesek listázás"); break;
                    default: Console.Clear(); Console.WriteLine("rossz parancs"); break;
                }
                Console.ReadKey();
            }
        }
    }
}
