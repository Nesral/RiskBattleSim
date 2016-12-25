using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskBattleSim
{
    class Army
    {
        private int units;
        public Army(int u)
        {
            units = u;
        }
        public void attack(Army army, int attDiceNum, int defDiceNum, int repeats)
        {
            Random randy = new Random();

            for (int i = 0; i < repeats; i++)
            {
                int[] attDice = new int[attDiceNum];
                int[] defDice = new int[defDiceNum];
                for (int j = 0; j < attDice.Length; j++)
                {
                    attDice[j] = (randy.Next() * 10) % 6;
                }
                for (int j = 0; j < defDice.Length; j++)
                {
                    defDice[j] = (randy.Next() * 10) % 6;
                }
                foreach (int num in attDice)
                {
                    Console.WriteLine(num);
                }
                foreach (int num in defDice)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
