using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    public class DefensivePlays
    {
        public DefensivePlays(
            string playTeam, 
            string playType, 
            string playFormation,
            string playCategory,
            string playName, 
            int wrCount,
            int playWeight,
            string blitzer1,
            string blitzer2,
            string blitzer3,
            string blitzer4,
            string blitzer5,
            string blitzer6,
            string blitzer7,
            string blitzer8,
            string blitzer9,
            string blitzer10,
            string blitzer11,
            string man1,
            string man2,
            string man3,
            string man4,
            string man5,
            string qbSpy,
            string onezero,
            string oneone,
            string onetwo,
            string onethree,
            string onefour,
            string onefive,
            string onesix,
            string oneseven,
            string oneeight,
            string onenine,
            string oneten,
            string oneeleven,
            string twozero,
            string twoone,
            string twotwo,
            string twothree,
            string twofour,
            string twofive,
            string twosix,
            string twoseven,
            string twoeight,
            string twonine,
            string twoten,
            string twoeleven,
            string threezero,
            string threeone,
            string threetwo,
            string threethree,
            string threefour,
            string threefive,
            string threesix,
            string threeseven,
            string threeeight,
            string threenine,
            string threeten,
            string threeeleven
            )
        {
            PlayTeam = playTeam;
            PlayType = playType;
            PlayFormation = playFormation;
            PlayCategory = playCategory;
            PlayName = playName;
            WrCount = wrCount;
            PlayWeight = playWeight;
            Blitzer1 = blitzer1;
            Blitzer2 = blitzer2;
            Blitzer3 = blitzer3;
            Blitzer4 = blitzer4;
            Blitzer5 = blitzer5;
            Blitzer6 = blitzer6;
            Blitzer7 = blitzer7;
            Blitzer8 = blitzer8;
            Blitzer9 = blitzer9;
            Blitzer10 = blitzer10;
            Blitzer11 = blitzer11;
            Man1 = man1;
            Man2 = man2;
            Man3 = man3;
            Man4 = man4;
            Man5 = man5;
            QbSpy = qbSpy;
            OneZero = onezero;
            OneOne = oneone;
            OneTwo = onetwo;
            OneThree = onethree;
            OneFour = onefour;
            OneFive = onefive;
            OneSix = onesix;
            OneSeven = oneseven;
            OneEight = oneeight;
            OneNine = onenine;
            OneTen = oneten;
            OneEleven = oneeleven;
            TwoZero = twozero;
            TwoOne = twoone;
            TwoTwo = twotwo;
            TwoThree = twothree;
            TwoFour = twofour;
            TwoFive = twofive;
            TwoSix = twosix;
            TwoSeven = twoseven;
            TwoEight = twoeight;
            TwoNine = twonine;
            TwoTen = twoten;
            TwoEleven = twoeleven;
            ThreeZero = threezero;
            ThreeOne = threeone;
            ThreeTwo = threetwo;
            ThreeThree = threethree;
            ThreeFour = threefour;
            ThreeFive = threefive;
            ThreeSix = threesix;
            ThreeSeven = threeseven;
            ThreeEight = threeeight;
            ThreeNine = threenine;
            ThreeTen = threeten;
            ThreeEleven = threeeleven;
            TotalPlayWeight = 0;
        }


        public string PlayFormation  { get; set; }
        public string PlayCategory { get; set; }
        public int WrCount  { get; set; }

        public string Blitzer1  { get; set; }
        public string Blitzer2  { get; set; } 
        public string Blitzer3  { get; set; } 
        public string Blitzer4  { get; set; } 
        public string Blitzer5  { get; set; } 
        public string Blitzer6  { get; set; } 
        public string Blitzer7  { get; set; } 
        public string Blitzer8  { get; set; } 
        public string Blitzer9  { get; set; } 
        public string Blitzer10  { get; set; } 
        public string Blitzer11  { get; set; } 
        public string Man1  { get; set; } 
        public string Man2  { get; set; } 
        public string Man3  { get; set; } 
        public string Man4  { get; set; } 
        public string Man5  { get; set; } 
        public string QbSpy  { get; set; } 
        public string OneZero  { get; set; } 
        public string OneOne  { get; set; } 
        public string OneTwo  { get; set; } 
        public string OneThree  { get; set; } 
        public string OneFour  { get; set; } 
        public string OneFive  { get; set; } 
        public string OneSix  { get; set; } 
        public string OneSeven  { get; set; } 
        public string OneEight  { get; set; } 
        public string OneNine  { get; set; } 
        public string OneTen  { get; set; } 
        public string OneEleven  { get; set; } 
        public string TwoZero  { get; set; } 
        public string TwoOne  { get; set; } 
        public string TwoTwo  { get; set; } 
        public string TwoThree  { get; set; } 
        public string TwoFour  { get; set; } 
        public string TwoFive  { get; set; } 
        public string TwoSix  { get; set; } 
        public string TwoSeven  { get; set; } 
        public string TwoEight  { get; set; } 
        public string TwoNine  { get; set; } 
        public string TwoTen  { get; set; } 
        public string TwoEleven  { get; set; } 
        public string ThreeZero  { get; set; } 
        public string ThreeOne  { get; set; } 
        public string ThreeTwo  { get; set; } 
        public string ThreeThree  { get; set; } 
        public string ThreeFour  { get; set; } 
        public string ThreeFive  { get; set; } 
        public string ThreeSix  { get; set; } 
        public string ThreeSeven  { get; set; } 
        public string ThreeEight  { get; set; } 
        public string ThreeNine  { get; set; } 
        public string ThreeTen  { get; set; } 
        public string ThreeEleven  { get; set; }




        public string PlayTeam { get; set; }
        public string PlayType { get; set; }
        public string PlayName { get; set; }
        public int PlayWeight { get; set; }
        public int TotalPlayWeight { get; set; }
    }
}
