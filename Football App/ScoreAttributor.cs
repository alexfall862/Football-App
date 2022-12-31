using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    public class Parser
    {
        public void ScoreParser(List<FootballApp.PlayStatus> a)
        {
            if (GameValues._homepossession == true) 
            {
                //Big ol' if else due to switch not taking evaluated expressions.
                if (a.Last().Td == true)
                {
                    //Console.WriteLine("Home Touchdown!");
                    a.Last().HtScore = a.Last().HtScore + GameValues._tdvalue;
                    GameValues._htscore = a.Last().HtScore;
                }
                else if (a.Last().DTd == true)
                {
                    //Console.WriteLine("Away Defensive Touchdown!");
                    a.Last().AtScore = a.Last().AtScore + GameValues._tdvalue;
                    GameValues._atscore = a.Last().AtScore;
                }
                else if (a.Last().FgGood == true)
                {
                    //Console.WriteLine("Home Field Goal!");
                    a.Last().HtScore = a.Last().HtScore + GameValues._fgvalue;
                    GameValues._htscore = a.Last().HtScore;
                }
                else if (a.Last().Safety == true | a.Last().DSafety == true)
                {
                    //Console.WriteLine("Home Safety!");
                    a.Last().HtScore = a.Last().HtScore + GameValues._safetyvalue;
                    GameValues._htscore = a.Last().HtScore;
                }
                else if (a.Last().XpGood == true)
                {
                    //Console.WriteLine("Home Extra Point!");
                    a.Last().HtScore = a.Last().HtScore + GameValues._xpvalue;
                    GameValues._htscore = a.Last().HtScore;
                }
                else if (a.Last().TwoConv == true)
                {
                    //Console.WriteLine("Home 2pt Conversion!");
                    a.Last().HtScore = a.Last().HtScore + GameValues._twoconvvalue;
                    GameValues._htscore = a.Last().HtScore;
                }
                else if (a.Last().TwoConvReturned == true)
                {
                    //Console.WriteLine("Home 2pt Conversion Returned for XP!");
                    a.Last().HtScore = a.Last().HtScore + GameValues._dtwoconvreturnedvalue;
                    GameValues._htscore = a.Last().HtScore;
                }
                else
                {
                    //Console.WriteLine("Home ERROR IN EVAL");
                }
            } else if (GameValues._homepossession != true)
            {
                if (a.Last().Td == true)
                {
                    //Console.WriteLine("Away Touchdown!");
                    a.Last().AtScore = a.Last().AtScore + GameValues._tdvalue;
                    GameValues._atscore = a.Last().AtScore;
                }
                else if (a.Last().DTd == true)
                {
                    //Console.WriteLine("Home Defensive Touchdown!");
                    a.Last().HtScore = a.Last().HtScore + GameValues._tdvalue;
                    GameValues._htscore = a.Last().HtScore;
                }
                else if (a.Last().FgGood == true)
                {
                    //Console.WriteLine("Away Field Goal!");
                    a.Last().AtScore = a.Last().AtScore + GameValues._fgvalue;
                    GameValues._atscore = a.Last().AtScore;
                }
                else if (a.Last().Safety == true | a.Last().DSafety == true)
                {
                    //Console.WriteLine("Away Safety!");
                    a.Last().AtScore = a.Last().AtScore + GameValues._safetyvalue;
                    GameValues._atscore = a.Last().AtScore;
                }
                else if (a.Last().XpGood == true)
                {
                    //Console.WriteLine("Away Extra Point!");
                    a.Last().AtScore = a.Last().AtScore + GameValues._xpvalue;
                    GameValues._atscore = a.Last().AtScore;
                }
                else if (a.Last().TwoConv == true)
                {
                    //Console.WriteLine("Away 2pt Conversion!");
                    a.Last().AtScore = a.Last().AtScore + GameValues._twoconvvalue;
                    GameValues._atscore = a.Last().AtScore;
                }
                else if (a.Last().TwoConvReturned == true)
                {
                    //Console.WriteLine("Away 2pt Conversion Returned for XP!");
                    a.Last().AtScore = a.Last().AtScore + GameValues._dtwoconvreturnedvalue;
                    GameValues._atscore = a.Last().AtScore;
                }
                else
                {
                    //Console.WriteLine("Away ERROR IN EVAL");
                }
            } else
            {
                //Console.WriteLine("Home and Away ERROR IN EVAL");
            }
        }
    }
}
