using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Dice
    {
        public int NewRoll()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(0, 21);
            return randomNumber;
        }
    }

}
