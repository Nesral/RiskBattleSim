using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskBattleSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean running = true,first = true;
            Console.Write("enter the number of attackers >> ");
            int att = Int32.Parse(Console.ReadLine());
            Console.Write("enter the number of deffenders >> ");
            int def = Int32.Parse(Console.ReadLine());
            Army attackers = new Army(att);
            Army deffenders = new Army(def);
            while(running)
            {
                String s;
                if(first)
                {
                    printCommands();
                    first = false;
                }
                Console.Write("enter command >> ");
                s = Console.ReadLine();
                string[] command = s.Split();
                if (command[0].Equals("help"))
                {
                    Console.WriteLine("help entered");
                }
                else if (command[0].Equals("attack"))
                {
                    Console.WriteLine("attack entered");
                    if(command.Length==1)
                    {

                    }
                    
                }
                else if (command[0].Equals("close"))
                {
                    Console.WriteLine("end simulation");
                    running = false;
                }
                Console.Write("enter command >>");
            }
        }
        static void printCommands()
        {
            Console.WriteLine("Comands are: \n" +
                          "help ==> lists commands\n" +
                          "attack  ==> attacks until either win or defeat"+
                          "attack <int> attacks with that number of dice\n" +
                          "attack <int> <int> attacks with that number of dice that many times\n" +
                          "close ==> ends simulation\n");
        }
    }
}
