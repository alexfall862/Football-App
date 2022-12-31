using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    public class PlayInterpreter
    {
        Parser ps = new Parser();

        

        public void PlaySetup()
        {
            if (GameValues._turnoverondowns == true)
            {
                ResetDowns();
                FlipPossession();
                GameValues._turnoverondowns = false;
            }

            if (GameValues._firstdownachieved == true)
            {
                ResetDowns();
                GameValues._firstdownachieved = false;
            }

            if (GameValues._td == true)
            {
                GameValues._extrapointtry = true;
                //This is the point in the functino where deciding to xp or 2pt conversion would be valuable. Problem will be considering how to evaluate this and escape triggering a touchdown.
                GameValues._playtype = "XP";
                GameValues._td = false;
            }

            if (GameValues._safety == true)
            {
                ResetDowns();
                FlipPossession();
                GameValues._los = 20;
                GameValues._safety = false;
            }
            
            if (GameValues._kickoff == true)
            {
                GameValues._kickoff = false;
                GameValues._playtype = "Normal";
            }
            if (GameValues._playid ==1)
            {
                //Console.WriteLine("Triggered by beginning of game.");
                GameValues._kickoff = true;
                GameValues._playtype = "Kickoff";
            }

            if (GameValues._quarterlength == GameValues._time & GameValues._quarter == 3)
            {
                if (GameValues._cointoss == false)
                {
                    //Console.WriteLine("Triggered by half game.");
                    GameValues._kickoff = true;
                    GameValues._playtype = "Kickoff";
                    GameValues._homepossession = false;
                }
                else
                {
                    //Console.WriteLine("Triggered by half game.");
                    GameValues._kickoff = true;
                    GameValues._playtype = "Kickoff";
                    GameValues._homepossession = true;
                }
            }

            if (GameValues._xpgood == true | GameValues._xpbad == true)
            {
                //Console.WriteLine("Diagnostic 2");
                GameValues._kickoff = true;
                GameValues._playtype = "Kickoff";
                GameValues._xpgood = false;
                GameValues._xpbad = false;
                GameValues._extrapointtry = false;
            }

            if (GameValues._punt == true)
            {
                GameValues._punt = false;
                GameValues._playtype = "Normal";
            }

            if (GameValues._down == GameValues._allowabledowns)
            {
                GameValues._punt = true;
                GameValues._playtype = "Punt";
            }

        }
        public void PlayOutcome(string x)
        {
            if (x == "Kickoff") 
            {
                GameValues._down = 0;
                GameValues._los = 35;
                GameValues._yardstogo = 0;
                GameValues._playyards = 50;
            } else if (x == "XP")
            {
                GameValues._down = 0;
                GameValues._los = 98;
                GameValues._yardstogo = 0;
                GameValues._playyards = 0;

            } else if (x == "Normal")
            {
                Random random = new Random();
                GameValues._playyards = random.Next(3, 10);
            } else if (x == "Punt")
            {
                //Console.WriteLine("Punt Triggered");
                if (GameValues._los + 50 >= 100)
                {
                    //Punt Touchback, should add Touchback tag
                    GameValues._los = 20;
                    GameValues._playyards = 50;
                } else
                {
                    //Not touchback, should add return functionality.
                    GameValues._playyards = 50;
                    GameValues._returnyards = 5;
                }
            }


        }
        public void PlayEval(int down, int playyardseval, List<FootballApp.PlayStatus> a)
        {
            //Touchdown
            if ((GameValues._los + GameValues._playyards) > 100 & GameValues._interception == false & GameValues._fumble == false & GameValues._playtype == "Normal")
            {
                GameValues._td = true;
                a.Last().Td = true;
                GameValues._playyards = Math.Abs(GameValues._los - 100);
                a.Last().Yardage= GameValues._playyards;
                //Console.WriteLine("Touchdown was: " + GameValues._playyards + " yards long.");
                ps.ScoreParser(a);
            }

            //Safety
            if ((GameValues._los + GameValues._playyards) <= 0 & GameValues._interception == false & GameValues._fumble == false & GameValues._playtype == "Normal")
            {
                //Console.WriteLine("Safety!");
                GameValues._safety = true;
                a.Last().Safety = true;
                GameValues._playyards = -GameValues._los;
                a.Last().Yardage = GameValues._playyards;
                ps.ScoreParser(a);
            }

            //ExtraPointTry
            if (GameValues._extrapointtry == true)
            {
                Random dice = new Random();
                int diceroll = 1;//dice.Next(0, 2);

                if (diceroll == 1)
                {
                    //Console.WriteLine("Extra Point Good!");
                    GameValues._xpgood = true;
                    a.Last().XpGood = true;
                    a.Last().Yardage = GameValues._playyards;
                    ps.ScoreParser(a);
                }
                else
                {
                    //Console.WriteLine("Extra Point Bad!");
                    GameValues._xpbad = true;
                    a.Last().XpBad = true;
                }
            }
            
            //This Reckons how the play went and is part of the eval immediately below it.
            //Console.WriteLine("Test Step 1: " + GameValues._playid + " " + GameValues._yardstogo);
            GameValues._yardstogo = GameValues._yardstogo - playyardseval;
            //Console.WriteLine("Test Step 2: " + GameValues._playid + " " + GameValues._yardstogo);
            GameValues._los = GameValues._los + playyardseval; GameValues._down++;

            //This decideds where a play runs time off the clock or not. Primarily for extra point or two point conversions. Separate from the eventual function that'll need to be added to run time off the clock.
            if (GameValues._playtype == "XP" | GameValues._playtype == "Kickoff" | GameValues._playtype == "Punt")
            {
            } else 
            {
                //Evaluates whether play was a first down.
                if (GameValues._yardstogo <= 0 & down != 0)
                {
                    //Console.WriteLine("Reset Triggered");
                    a.Last().FirstDownAchieved = true;
                    GameValues._firstdownachieved = true;
                }
                //Evaluates whether play was a failed turnover on downs.
                if (down == GameValues._allowabledowns)
                {

                    //Console.WriteLine("Turnover on Downs");
                    a.Last().TurnoverOnDowns = true;
                    GameValues._turnoverondowns = true;
                }
            }

            if (GameValues._playtype == "Normal")
            {
                GameValues._time = GameValues._time - RunTime(false);
                GameValues._time--;
                GameValues._playid++;
            }
            else if (GameValues._playtype == "Kickoff")
            {
                GameValues._time = GameValues._time - RunTime(true);
                GameValues._playid++;
                ResetDowns();
                FlipPossession();
            }
            else if (GameValues._playtype == "XP")
            {
                GameValues._playid++;
            }
            else if (GameValues._playtype == "Punt")
            {
                GameValues._time = GameValues._time - RunTime(true);
                GameValues._playid++;
                GameValues._returnyards = 0;
                ResetDowns();
                FlipPossession();
            }
        }

        public void ResetDowns()
        {
            GameValues._down = 1;
            GameValues._yardstogo = GameValues._allowabledistance; 
        }

        public void FlipPossession()
        {
            GameValues._homepossession = !GameValues._homepossession;
            GameValues._los = Math.Abs(GameValues._los - 100);
        }

        public int RunTime(bool stoppedclock)
        {
            //Ultimately we'll add an if statement to check for outofbounds or team offensive goal - which will be something that's included in playbook/strategy.
            Random rand = new Random();
            GameValues._presnaprunoff = rand.Next(5,40);
            GameValues._playlength = rand.Next(5, 9);

            //Accepts bool for whether clock's stopped between plays.
            if (stoppedclock == true)
            {
                GameValues._presnaprunoff = rand.Next(5, 40);
                GameValues._playlength = rand.Next(5, 9);
            } else
            {
                //GameValues._presnaprunoff = rand.Next(5, 40);
                GameValues._playlength = rand.Next(5, 9);
            }
            int time = GameValues._presnaprunoff + GameValues._playlength;
            return time;
        }
    }
}
