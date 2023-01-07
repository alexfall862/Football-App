using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FootballApp
{
    public class OffensivePlays
    {
        public OffensivePlays(
            string playTeam,
            string playType,
            string playFormation,
            string playCategory,
            string playName,
            int playWeight,
            int wrCount,
            int rbCount,
            int teCount,
            bool isPA,
            string strongSide,
            string[] blockers,
            string runner,
            int runnerTarget,
            string[] bBlockers,
            //string bBlocker1,
            //string bBlocker2,
            //string bBlocker3,
            string specialist,
            string target1,
            string target1zone,
            string target1route,
            string target2,
            string target2zone,
            string target2route,
            string target3,
            string target3zone,
            string target3route,
            string target4,
            string target4zone,
            string target4route,
            string target5,
            string target5zone,
            string target5route
            )
        {
            PlayTeam = playTeam;
            PlayType = playType;
            PlayFormation = playFormation;
            PlayCategory = playCategory;
            PlayName = playName;
            PlayWeight = playWeight;
            WrCount = wrCount;
            RbCount = rbCount;
            TeCount = teCount;
            IsPA = isPA;
            StrongSide = strongSide;
            Blockers = blockers;
            Runner = runner;
            RunnerTarget = runnerTarget;
            BBlockers = bBlockers;
            //BBlocker1 = bBlocker1;
            //BBlocker2 = bBlocker2;
            //BBlocker3 = bBlocker3;
            Specialist = specialist;
            Target1 = target1;
            Target1zone = target1zone;
            Target1Route = target1route;
            Target2 = target2;
            Target2zone = target2zone;
            Target2Route = target2route;
            Target3 = target3;
            Target3zone = target3zone;
            Target3Route = target3route;
            Target4 = target4;
            Target4zone = target4zone;
            Target4Route = target4route;
            Target5 = target5;
            Target5zone = target5zone;
            Target5Route = target5route;
            TotalPlayWeight = 0;
        }

        public string PlayTeam { get; set; }
        public string PlayType { get; set; }
        public string PlayFormation { get; set; }
        public string PlayCategory { get; set; }
        public string PlayName { get; set; }
        public int PlayWeight { get; set; }
        public int TotalPlayWeight { get; set; }
        public int WrCount { get; set; }
        public int RbCount { get; set; } 
        public int TeCount { get; set; } 
        public bool IsPA { get; set; }
        public string StrongSide { get; set; }
        public string[] Blockers { get; set; }
        public string Runner { get; set; }
        public int RunnerTarget { get; set; }

        public string[] BBlockers { get; set; }

        //public string BBlocker1 { get; set; }
        //public string BBlocker2 { get; set; }
        //public string BBlocker3 { get; set; }
        public string Specialist { get; set; }
        public string Target1 { get; set; }
        public string Target1zone { get; set; }
        public string Target1Route { get; set; }
        public string Target2 { get; set; }
        public string Target2zone { get; set; }
        public string Target2Route { get; set; }
        public string Target3 { get; set; }
        public string Target3zone { get; set; }
        public string Target3Route { get; set; }
        public string Target4 { get; set; }
        public string Target4zone { get; set; }
        public string Target4Route { get; set; }
        public string Target5 { get; set; }
        public string Target5zone { get; set; }
        public string Target5Route { get; set; }


        //public void ReadPlaybooks(string nameofbook)
        //{
        //    var Playbook = new List<PlayCalls>();
        //    string name = nameofbook;
        //    string file = @"C:\Users\alexf\OneDrive\Documents\FootballApp\"+name+".txt";
        //    foreach(string play in File.ReadAllLines(file))
        //    {
        //        Console.WriteLine(play);
        //    }
        //}
    }
}
