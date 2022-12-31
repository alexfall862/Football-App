        using System;
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
                    "Play ID: " + e.PlayID + "\t"
                    + "Q: " + e.Quarter + " "
                    + "Time: " + (e.Time/60).ToString("D2") + ":" + (e.Time % 60).ToString("D2") + "\t"
                    + "LOS: " + String.Format("{0, 3}", e.Los) + " "
                    + "Poss: " + e.HomePossession + "\t"
                    + "Down: " + e.Down + "\t"
                    + "YTG: " + String.Format("{0, 2}", e.YardsToGo) + " "
                    + "PlayType: " + String.Format("{0, 11}", e.PlayType) + "\t"
                    + "HPC: " + String.Format("{0, 14}", e.HPlayCall) + "\t"
                    + "APC: " + String.Format("{0, 14}", e.APlayCall) + "\t"
                    + "Yardage: " + e.Yardage + "\t"
                    + "Touchdown: " + String.Format("{0, 6}", e.Td) + "\t"
                    + "Home: " + String.Format("{0, 3}", e.HtScore) + "\t"
                    + "Away: " + String.Format("{0, 3}", e.AtScore)
                    );
                //Console.WriteLine("Previous Play Test: " + e.PlayID);
            }
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
                        e.PlayLength.ToString() +
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

        public void TestofSearch2(List<FootballApp.Plays> a)
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

        public void TestofSearch3(List<FootballApp.Plays> a, string playtype, int playid)
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
    
