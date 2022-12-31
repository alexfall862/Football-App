using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    public class Decisions
    {
        public string Evaluate4thDown(List<FootballApp.PlayStatus> a)
        {
            string decision;
            if (a.Last().Los > 10)
            {
                Console.WriteLine((a.Last().PlayID+1) + ": KICKING FG!!!");
                decision = "FG";
                return decision;
            }
            else
            {
                //Console.WriteLine((a.Last().PlayID + 1) + ": Punt");
                decision = "Punt";
                return decision;
            }
        }
    }
}
