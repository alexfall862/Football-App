﻿        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

namespace FootballApp
{
    public class PrintFunctions
    {
        public void PrintStatus()
        {
            Console.WriteLine(Environment.NewLine + $"{GameValues._htname} {GameValues._htscore} | {GameValues._atname} {GameValues._atscore} || Possession: {GameValues._homepossession} Down: {GameValues._down} ToGo: {GameValues._yardstogo} LOS: {GameValues._los} || Quarter: {GameValues._quarter} Time: {GameValues._time}");
        }

        public void PrintPlays(List<FootballApp.PlayStatus> a)
        {
            foreach (var e in a)
            {
                //Console.WriteLine("Name: " + e);
                Console.WriteLine(
                    "Play ID: " + String.Format("{0, 4}", e.PlayID) + " "
                    + "Q: " + e.Quarter + " | " + (e.Time/60).ToString("D2") + ":" + (e.Time % 60).ToString("D2") + " "
                    + "LOS: " + String.Format("{0, 2}", e.Los) + " "
                    + "Poss: " + e.HomePossession + "\t"
                    + "Down: " + e.Down + " &" + String.Format("{0, 2}", e.YardsToGo) + " "
                    + "PlayType: " + String.Format("{0, 9}", e.PlayType) + " "
                    + "Tkl: " + String.Format("{0, 5}", e.Tackler) + " "
                    + "Pass: " + String.Format("{0, 5}", e.Passer) + " "
                    + "Rush: " + String.Format("{0, 5}", e.Rusher) + " "
                    + "HPC: " + String.Format("{0, 22}", e.HPlayCall) + " "
                    + "APC: " + String.Format("{0, 22}", e.APlayCall) + " "
                    + "Yardage: " + String.Format("{0, 2}", e.Yardage) + " "
                    //+ "Touchdown: " + TouchdownTextEval(e._td, e._dtd) + "\t"
                    + "Home: " + String.Format("{0, 3}", e.HtScore) + "\t"
                    + "Away: " + String.Format("{0, 3}", e.AtScore)
                    );
                //Console.WriteLine("Previous Play Test: " + e.PlayID);

            }
        }

        public string TouchdownTextEval(bool td, bool dtd)
        {
            if (td == true) 
            {
                return String.Format("{0, 5}", "OTrue");
            } else if (dtd == true) 
            {
                return String.Format("{0, 5}", "DTrue");
            }
            else if (td == true & dtd == true) 
            {
                return String.Format("{0, 5}", "ERROR");
            } else if (td == false & dtd == false)
            {
                return String.Format("{0, 5}", "False");
            }
            return String.Format("ERROR2");
        }

        public void SaveToTxt(List<FootballApp.PlayStatus> a)
        {
            using (TextWriter tw = new StreamWriter(@"C:\Users\alexf\source\repos\Football App\Playbooks\test.csv"))
            {
                tw.Write(
                    "PlayID" + "," +
                    "Yardage" + "," +
                    "HomePossession" + "," +
                    "Down" + "," +
                    "HtScore" + "," +
                    "AtScore" + "," +
                    "YardsToGo" + "," +
                    "TurnoverOnDowns" + "," +
                    "FirstDownAchieved" + "," +
                    "Los" + "," +
                    "Td" + "," +
                    "DTd" + "," +
                    "FgGood" + "," +
                    "FgBad" + "," +
                    "Safety" + "," +
                    "DSafety" + "," +
                    "XpGood" + "," +
                    "TwoConv" + "," +
                    "TwoConvReturned" + "," +
                    "Quarter" + "," +
                    "Time" + "," +
                    "ExtraPointTry" + "," +
                    "Kickoff" + "," +
                    "PlayType" + "," +
                    "XpBad" + "," +
                    "Punt" + "," +
                    "SafetyPunt" + "," +
                    "PuntAttempt" + "," +
                    "Touchback" + "," +
                    "HPlayCall" + "," +
                    "APlayCall" + "," +
                    "PreSnapRunoff" + "," +
                    "PlayLength" +
                    "Return Yards" +
                    Environment.NewLine
                    );

                foreach (var e in a)
                {
                    tw.Write(
                        e.PlayID.ToString() + "," +
                        e.Yardage.ToString() + "," + 
                        e.HomePossession.ToString() + "," +
                        e.Down.ToString() + "," +
                        e.HtScore.ToString() + "," + 
                        e.AtScore.ToString() + "," + 
                        e.YardsToGo.ToString() + "," +
                        e.TurnoverOnDowns.ToString() + "," +
                        e.FirstDownAchieved.ToString() + "," +
                        e.Los.ToString() + "," + 
                        e.Td.ToString() + "," +
                        e.DTd.ToString() + "," +
                        e.FgGood.ToString() + "," +
                        e.FgBad.ToString() + "," +
                        e.Safety.ToString() + "," + 
                        e.DSafety.ToString() + "," + 
                        e.XpGood.ToString() + "," + 
                        e.TwoConv.ToString() + "," + 
                        e.TwoConvReturned.ToString() + "," + 
                        e.Quarter.ToString() + "," + 
                        e.Time.ToString() + "," + 
                        e.ExtraPointTry.ToString() + "," + 
                        e.Kickoff.ToString() + "," + 
                        e.PlayType.ToString() + "," + 
                        e.XpBad.ToString() + "," + 
                        e.Punt.ToString() + "," + 
                        e.SafetyPunt.ToString() + "," + 
                        e.PuntAttempt.ToString() + "," + 
                        e.Touchback.ToString() + "," + 
                        e.HPlayCall.ToString() + "," + 
                        e.APlayCall.ToString() + "," + 
                        e.PreSnapRunoff.ToString() + "," + 
                        e.PlayLength.ToString() + "," +
                        e.KPReturnYards.ToString() +
                        Environment.NewLine
                        );
                }
            }
        }

        public void TestofSearch(List<FootballApp.PlayStatus> a)
        {
            foreach (var p in a.Where(p => p.PlayType == "Extra Point"))
            {
                Console.WriteLine("playID: " + p.PlayID + "\t LOS: " + p.Los + "\t Yardage: " + p.Yardage + "\t Possession: " +  p.HomePossession);
            }
            //foreach (var p in a.Where(p => p.FirstDownAchieved == true))
            //{
            //    Console.WriteLine("fd: " + p.PlayID);
            //}
        }

        public void TestofSearch2(List<FootballApp.OffensivePlays> a)
        {
            foreach (var p in a)
            {
                Console.WriteLine("playTeam: " + p.PlayTeam + "\t PlayType: " + p.PlayType + "\t PlayName: " + p.PlayName + "\t PlayWeight: " + p.PlayWeight);
            }
            //foreach (var p in a.Where(p => p.FirstDownAchieved == true))
            //{
            //    Console.WriteLine("fd: " + p.PlayID);
            //}
        }

        public void TestofSearch3(List<FootballApp.OffensivePlays> a, string playtype, int playid)
        {
            foreach (var p in a.Where(p => p.PlayType == playtype).Take(1))
            {
                Console.WriteLine($"PlayID: " + playid + "\tPlayTeam: " + p.PlayTeam + "\tPlayType: " + p.PlayType + "\tPlayName: " + p.PlayName);
            }
            //foreach (var p in a.Where(p => p.FirstDownAchieved == true))
            //{
            //    Console.WriteLine("fd: " + p.PlayID);
            //}
        }
    }
}
    
