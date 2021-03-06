using System;
using System.Collections.Generic;
using System.Text;

namespace MolopolyGame
{
     /// <summary>
    /// This is class for a die that generates random number 1-6 inclusive
    /// </summary>
    
    public class Die
    {
        private static Random numGenerator = new Random();        
        protected int numberRolled;
        
        public virtual int roll()
        {
            numberRolled = numGenerator.Next(1, 7);
            return numberRolled;
            //return 30;
        }

        public int numberLastRolled()
        {
            return numberRolled;
        }
         
        public override string ToString()
        {
            return numberRolled.ToString();
        }
    }
}
