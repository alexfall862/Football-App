    using System;

namespace FootballApp
{
    class GameBackbones
    {
        static void Main()
        {
            int x = 0;
            while (x<=3) 
            {
                Console.WriteLine("****SIM BEING RUN****");
                //Decisions d = new Decisions();
                MathforFootball mf = new MathforFootball();
                PlaybookMaker pm = new PlaybookMaker();
                GameValues gv = new GameValues();
                PrintFunctions p = new PrintFunctions();
                PlayInterpreter pi = new PlayInterpreter();
                //Parser ps = new Parser();
                PlayStructure psr = new PlayStructure();
                PlayPicker pp = new PlayPicker();
                var ListofPlayStatus = new List<PlayStatus>();
                pm.OffensivePlaybookGenerator("AwayOffensivePlays");
                pm.DefensivePlaybookGenerator("AwayDefensivePlays");
                pm.OffensivePlaybookGenerator("HomeOffensivePlays");
                pm.DefensivePlaybookGenerator("HomeDefensivePlays");
                //p.TestofSearch2(pm.PlayList);

                for (gv.Time = gv.QuarterLength; gv.Quarter >= 5 & gv.HtScore == gv.AtScore || gv.Quarter < 5;)
                {

                    for (gv.Time = gv.QuarterLength; gv.Quarter >= 5 & gv.Time >= 1 & gv.HtScore == gv.AtScore || gv.Td == true || gv.DTd == true || gv.Quarter < 5 & gv.Time >= 1;)
                    {
                        pi.PlaySetup(ListofPlayStatus);
                        pp.PlayCallChooser(pm.OPlayList, gv.PlayType, gv.PlayID, gv.HomePossession);
                        pp.PlayCallReactor(pm.DPlayList, gv.PlayType, gv.PlayID, gv.HomePossession);
                        //Console.WriteLine(GameValues._hplaycalltype + GameValues._hplaycall);
                        //Console.WriteLine(GameValues._aplaycalltype + GameValues._aplaycall);
                        //p.TestofSearch2(pm.PlayList);
                        //p.TestofSearch3(pm.PlayList, gv.PlayType, gv.PlayID);
                        pi.PlayOutcome(gv.PlayType);
                        //Console.WriteLine(gv.PlayID + ": " + gv.PlayType);
                        ListofPlayStatus.Add(new PlayStatus(
                            gv.PlayID,
                            gv.PlayYards,
                            gv.HomePossession,
                            gv.Down,
                            gv.HtScore,
                            gv.AtScore,
                            gv.YardsToGo,
                            gv.TurnoverOnDowns,
                            gv.FirstDownAchieved,
                            gv.Los,
                            gv.Td,
                            gv.DTd,
                            gv.FgGood,
                            gv.Safety,
                            gv.DSafety,
                            gv.XpGood,
                            gv.TwoConv,
                            gv.TwoConvReturned,
                            gv.Quarter,
                            gv.Time,
                            gv.ExtraPointTry,
                            gv.Kickoff,
                            gv.PlayType,
                            gv.XpBad,
                            gv.Punt,
                            gv.SafetyPunt,
                            gv.PuntAttempt,
                            gv.Touchback,
                            gv.HPlayCall,
                            gv.APlayCall,
                            gv.PreSnapRunoff,
                            gv.PlayLength,
                            gv.KPReturnYards,
                            gv.DReturnYards,
                            gv.KickYards,
                            gv.FgBad,
                            gv.Rusher,
                            gv.Tackler,
                            gv.Passer,
                            gv.Reciever,
                            gv.Defender
                            ));
                        pi.PlayEval(gv.Down, gv.PlayYards, ListofPlayStatus);
                    }
                    gv.Time = gv.QuarterLength;
                    gv.Quarter++;
                }
                p.PrintPlays(ListofPlayStatus);
                //p.SaveToTxt(ListofPlayStatus);
                //p.TestofSearch(ListofPlays);
                x = x + 1;
            }
        }
    }
}