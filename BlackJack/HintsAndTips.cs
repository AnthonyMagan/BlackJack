using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class HintsAndTips
    {
        
        // Hint Method - Give advice to player as to whether they should twist or stick
        public static string Hint(int score)
        {
            string tip = "";
            if (score >= 20)
                tip = "\n\t(eh...methinks you know what to do here.)";
            else if (score >= 18)
                tip = "\n\t(be careful now, don't blow it. Advice:stick)";
            else if (score >= 15)
                tip = "\n\t(mmm... decisions. Don't blame me! Advice:your call)";
            else if (score >= 11)
                tip = "\n\t(safe enough to twist, but could still bust)";
            else if (score >= 5)
                tip = "\n\t(more cards needed for sure. Advice:twist)";
            else tip = "\n\t(this low score is rare. twist, twist, twist!)";

            return tip;
        }
    }
}
