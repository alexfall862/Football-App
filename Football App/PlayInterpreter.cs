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
        Decisions d = new Decisions();
        
        public void PlaySetup(List<FootballApp.PlayStatus> a)
        {
            //Should be unneeded, given the reset on the playeval function, but here as a stopgap.
            if (GameValues._touchback == true)
            {
                GameValues._touchback = false;
            }

            if (GameValues._fgbad == true)
            {
                GameValues._playtype = "Normal";
                GameValues._fgbad = false;
            }

            if (GameValues._turnoverondowns == true)
            {
                ResetDowns();
                FlipPossession();
                GameValues._turnoverondowns = false;
            }

            if (GameValues._firstdownachieved == true)
            {
                //ResetDowns();
                GameValues._firstdownachieved = false;
            }

            if (GameValues._safetypunt == true)
            {
                GameValues._safetypunt = false;
                GameValues._playtype = "Normal";
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
                GameValues._safetypunt = true;
                GameValues._safety = false;
                GameValues._playtype = "Punt";
                GameValues._los = GameValues._allowablesafetypuntstart;
            }
            
            if (GameValues._kickoff == true)
            {
                GameValues._kickoff = false;
                GameValues._playtype = "Normal";
            }

            if (GameValues._fggood == true)
            {
                GameValues._kickoff = true;
                GameValues._playtype = "Kickoff";
                GameValues._fggood = false;
            }

            //Sets opening play as a kickoff.
            if (GameValues._playid == 1)
            {
                //Console.WriteLine("Triggered by beginning of game.");
                if (GameValues._cointoss == true)
                { 

                    GameValues._kickoff = true;
                    GameValues._playtype = "Kickoff";
                    GameValues._homepossession = true;
                } else
                {
                    GameValues._kickoff = true;
                    GameValues._playtype = "Kickoff";
                    GameValues._homepossession = false;
                }
                
            }
            // Post Q1 kickoffs. Eventually we'll need to add some kind of mechanic to differentiate between college and NFL rules, but ehh...
            if (GameValues._quarterlength == GameValues._time & GameValues._quarter == 3 | GameValues._quarterlength == GameValues._time & GameValues._quarter >= 5)
            {
                if (GameValues._quarter == 3)
                {
                    if (GameValues._cointoss == true)
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
                } else if (GameValues._quarter == 5) 
                {
                    Random rand = new Random();
                    int flip = rand.Next(0, 2);
                    if (flip == 0)
                    {
                        Console.WriteLine("Coin flip goes for away");
                        GameValues._cointoss = false;
                    } else
                    {
                        Console.WriteLine("Coin flip goes for home");
                        GameValues._cointoss = true;
                    }

                    if (GameValues._cointoss == true)
                    {
                        Console.WriteLine("Triggered by overtime q5 game.");
                        GameValues._kickoff = true;
                        GameValues._playtype = "Kickoff";
                        GameValues._homepossession = false;
                    }
                    else
                    {
                        Console.WriteLine("Triggered by overtime q5 game.");
                        GameValues._kickoff = true;
                        GameValues._playtype = "Kickoff";
                        GameValues._homepossession = true;
                    }
                } else if (GameValues._quarter >= 6)
                {
                    GameValues._cointoss = !GameValues._cointoss;
                    if (GameValues._cointoss == true)
                    {
                        Console.WriteLine("Triggered by ot game.");
                        GameValues._kickoff = true;
                        GameValues._playtype = "Kickoff";
                        GameValues._homepossession = false;
                    }
                    else
                    {
                        Console.WriteLine("Triggered by ot game.");
                        GameValues._kickoff = true;
                        GameValues._playtype = "Kickoff";
                        GameValues._homepossession = true;
                    }
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
                //Here's where to insert function that returns play type as it's string value. Then assign that to _playtype.
                GameValues._playtype = d.Evaluate4thDown(a);
                if (GameValues._playtype == "Punt")
                {
                    GameValues._punt = true;
                }
            }

            if (GameValues._dtd == true)
            {
                GameValues._dtd = false;
                GameValues._extrapointtry = true;
                GameValues._playtype = "XP";
            }

        }
        public void PlayOutcome(string x)
        {
            if (x == "Kickoff") 
            {
                //Initializing state for kicks.
                GameValues._down = 0;
                GameValues._yardstogo = 0;
                GameValues._los = GameValues._allowablekickstart;

                //Generating kicker's result
                Random random = new Random();
                GameValues._kickyards = random.Next(90, 91);

                //If statement evaluates whether ball hits endzone line or not. In the future it should eval whether players on other team take out of endzone (in other words, ball kicked 105+ can be returned given if statement or maybe time context)
                //Console.WriteLine("PlayYards + Allowable Kick Start is: " + GameValues._playyards + " and " + GameValues._allowablekickstart);
                
                if (GameValues._kickyards + GameValues._allowablekickstart >= GameValues._allowablefieldlength)
                {
                    //Console.WriteLine(GameValues._playid + ": Touchback triggered");
                    GameValues._touchback = true;
                    GameValues._playyards = (GameValues._allowablefieldlength - GameValues._allowablekickstart) - GameValues._allowablektouchback;
                }
                else
                {
                    GameValues._playyards = GameValues._kickyards;
                    GameValues._kpreturnyards = random.Next(0, 1) * -1;

                    //Console.WriteLine("Kickoff Yardage on Return: " + GameValues._kpreturnyards);
                }
            } else if (x == "XP")
            {
                GameValues._down = 0;
                GameValues._los = 98;
                GameValues._yardstogo = 0;
                GameValues._playyards = 0;

            } else if (x == "Normal")
            {
                Random random = new Random();
                GameValues._playyards = random.Next(1, 4);
            } else if (x == "FG")
            {
                GameValues._playyards = 0;
                int accuracy;
                Random random = new Random();
                GameValues._kickyards = random.Next(50, 51);
                accuracy = random.Next(0,2);
                Console.WriteLine("FG Kick Eval: " + GameValues._allowablefieldlength + " " + GameValues._los + " Final Outcome: " + (GameValues._allowablefieldlength - GameValues._los + 10) );
                if (GameValues._kickyards < (GameValues._allowablefieldlength - GameValues._los + 10))
                {
                    //Console.WriteLine("FG Short");
                    GameValues._fgbad = true;
                } else if (accuracy == 1)
                {
                    //Console.WriteLine("Field Goal Good");
                    GameValues._fggood = true;
                } else if (accuracy == 0)
                {
                    //Console.WriteLine("Field Goal Missed");
                    GameValues._fgbad = true;
                }

            } else if (x == "Punt")
            {
                Random random = new Random();
                GameValues._kickyards = random.Next(100, 101);

                //Console.WriteLine("Punt Triggered");
                if (GameValues._los + GameValues._kickyards >= GameValues._allowablefieldlength)
                {
                    Console.WriteLine("Punt Touchback Triggered");
                    //Punt Touchback, should add Touchback tag
                    //GameValues._los = GameValues._allowableptouchback;
                    GameValues._playyards = (GameValues._allowablefieldlength - GameValues._los) - GameValues._allowableptouchback;
                    GameValues._touchback = true;
                } else
                {
                    //Not touchback, should add return functionality.

                    GameValues._playyards = 50;
                    GameValues._kpreturnyards = random.Next(0, 1)*-1;
                    Console.WriteLine("Punt Yardage net: " + (GameValues._playyards + GameValues._kpreturnyards));
                }
            }


        }
        public void PlayEval(int down, int playyardseval, List<FootballApp.PlayStatus> a)
        {

            //FG Eval
            if (GameValues._fggood == true | GameValues._fggood == true)
            {
                if (GameValues._fggood == true)
                {
                    a.Last().FgGood = true;
                    ps.ScoreParser(a);
                } else if (GameValues._fgbad)
                {
                    a.Last().FgBad = true;
                }
            }

            //Console.WriteLine("Returned yards eligibilty: " + GameValues._playid + " - " + (GameValues._los + GameValues._playyards + GameValues._kpreturnyards));
            //Returned kick or punt
            if ((GameValues._los + GameValues._playyards + GameValues._kpreturnyards) <= 0 & GameValues._playtype == "Kickoff" | GameValues._los + GameValues._playyards + GameValues._kpreturnyards <= 0 & GameValues._playtype == "Punt")
            {
                //Console.WriteLine("Punt/Kick eval triggered");
                if (GameValues._playtype == "Punt")
                {
                    //Console.WriteLine("Eval Punt Success");
                    //Console.WriteLine("Punt TD: " + GameValues._playid);
                    GameValues._dtd = true;
                    a.Last().DTd = true;
                }
                else if (GameValues._playtype == "Kickoff")
                {
                    //Console.WriteLine("Eval Kick Success");
                    //Console.WriteLine("Kickoff TD: " + GameValues._playid);
                    GameValues._dtd = true;
                    a.Last().DTd = true;
                }
                //GameValues._td = true;
                //a.Last().Td = true;
                GameValues._playyards = Math.Abs(GameValues._los - GameValues._allowablefieldlength);
                a.Last().Yardage = GameValues._playyards;
                //Console.WriteLine("Touchdown was: " + GameValues._playyards + " yards long.");
                //Console.WriteLine("Being sent to score parser, status is: " + GameValues._dtd);
                ps.ScoreParser(a);
            }

            //Touchdown
            if ((GameValues._los + GameValues._playyards) >= GameValues._allowablefieldlength & GameValues._interception == false & GameValues._fumble == false & GameValues._playtype == "Normal")
            {
                GameValues._td = true;
                a.Last().Td = true;
                GameValues._playyards = Math.Abs(GameValues._los - GameValues._allowablefieldlength);
                a.Last().Yardage= GameValues._playyards;
                //Console.WriteLine("Touchdown was: " + GameValues._playyards + " yards long.");
                ps.ScoreParser(a);
            }

            //Safety
            if ((GameValues._los + GameValues._playyards) <= 0 & GameValues._interception == false & GameValues._fumble == false & GameValues._playtype == "Normal")
            {
                Console.WriteLine("Safety!");
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
            GameValues._los = GameValues._los + playyardseval + GameValues._kpreturnyards; 
            GameValues._down++;

            //This decideds where a play runs time off the clock or not. Primarily for extra point or two point conversions. Separate from the eventual function that'll need to be added to run time off the clock.
            if (GameValues._playtype == "XP" | GameValues._playtype == "Kickoff" | GameValues._playtype == "Punt" | GameValues._playtype == "FG" & GameValues._fggood == true)
            {
            } else 
            {
                //Evaluates whether play was a first down.
                if (GameValues._yardstogo <= 0 & down != 0)
                {
                    //Console.WriteLine("Reset Triggered");
                    a.Last().FirstDownAchieved = true;
                    GameValues._firstdownachieved = true;
                    ResetDowns();
                }
                //Evaluates whether play was a failed turnover on downs.
                else if (down == GameValues._allowabledowns & GameValues._playtype == "Normal")
                {
                    //Console.WriteLine(GameValues._playid + ": Turnover on Downs Triggered");
                    //Console.WriteLine("Turnover on Downs");
                    a.Last().TurnoverOnDowns = true;
                    GameValues._turnoverondowns = true;
                }
            }
            //Clock and record keeping evaluation
            //regular play
            if (GameValues._playtype == "Normal")
            {
                GameValues._time = GameValues._time - RunTime(false);
                GameValues._time--;
                GameValues._playid++;
            }
            //Non-returned kickoff
            else if (GameValues._playtype == "Kickoff" && GameValues._td == false | GameValues._playtype == "Kickoff" && GameValues._dtd == false)
            {
                if (GameValues._touchback == true)
                {
                    //Console.WriteLine("Non-returned Kickoff Eval Triggered");
                    GameValues._touchback = false;
                    a.Last().Yardage = (GameValues._allowablefieldlength - GameValues._allowablekickstart);
                }
                GameValues._kickyards = 0; 
                GameValues._time = GameValues._time - RunTime(true);
                GameValues._playid++;
                ResetDowns();
                FlipPossession();
            }
            //extra point
            else if (GameValues._playtype == "XP")
            {
                GameValues._playid++;
                GameValues._kickyards = 0;
            }

            else if (GameValues._playtype == "FG")
            {
                GameValues._time = GameValues._time - RunTime(true);
                GameValues._playid++;
                GameValues._kickyards = 0;
                if (GameValues._fgbad)
                {
                    ResetDowns();
                    FlipPossession();
                }
            }

            //Non-returned punt
            else if (GameValues._playtype == "Punt" && GameValues._td == false | GameValues._playtype == "Punt" && GameValues._dtd == false)
            {
                GameValues._time = GameValues._time - RunTime(true);
                GameValues._playid++;
                GameValues._kickyards = 0;
                GameValues._kpreturnyards = 0;
                ResetDowns();
                FlipPossession();
            }
            //returned kick or punt
            else if (GameValues._playtype == "Punt" && GameValues._dtd == true || GameValues._playtype == "Kickoff" && GameValues._dtd == true)
            {
                //Console.WriteLine(GameValues._playid + ": Scoring eval triggered");
                GameValues._time = GameValues._time - RunTime(true);
                GameValues._playid++;
                GameValues._kickyards =0;
                GameValues._kpreturnyards = 0;
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
            GameValues._los = Math.Abs(GameValues._los - GameValues._allowablefieldlength);
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
