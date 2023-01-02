using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
public class GameValues
    {
        public static int _down = 1;
        public static int _time;
        public static int _quarter = 1;
        public static bool _homepossession = true;
        public static int _los = 50;
        public static int _playyards;
        public static int _yardstogo = 10;
        public static int _playid = 1;
        public static string _htname = "Badgers";
        public static string _atname = "Hawkeyes";
        public static int _htscore = 0;
        public static int _atscore = 0;
        public static bool _turnoverondowns = false;
        public static bool _interception = false;
        public static bool _fumble = false;
        public static int _quarterlength = 900;
        public static int _allowabledowns = 4;
        public static int _allowabledistance = 10;
        public static int _allowablektouchback = 25;
        public static int _allowableptouchback = 20;
        public static int _allowablekickstart = 25;
        public static int _allowablesafetypuntstart = 20;
        public static int _allowablefieldlength = 100;
        public static bool _firstdownachieved = false;
        public static bool _td = false;
        public static bool _dtd = false;
        public static int _tdvalue = 6;
        public static bool _safety = false;
        public static bool _dsafety = false;
        public static int _safetyvalue = 2;
        public static bool _fggood = false;
        public static bool _fgbad = false;
        public static int _fgvalue = 3;
        public static bool _xpgood = false;
        public static bool _xpbad = false;
        public static int  _xpvalue = 1;
        public static bool _twoconv = false;
        public static int _twoconvvalue = 2;
        public static bool _dtwoconvreturned = false;
        public static int _dtwoconvreturnedvalue = 1;
        public static bool _extrapointtry = false;
        public static bool _kickoff = false;
        public static string _playtype = "Kickoff";
        public static bool _punt = false;
        public static bool _safetypunt = false;
        public static bool _puntattempt = false;
        public static bool _touchback = false;
        public static bool _cointoss = false;
        public static string _hplaycall = "";
        public static string _aplaycall = "";
        public static string _hplaycalltype = "";
        public static string _aplaycalltype = "";
        public static int _presnaprunoff = 0;
        public static int _playlength = 0;
        public static int _kpreturnyards = 0;
        public static int _dreturnyards = 0;
        public static int _kickyards = 0;
        public static string _ballcarrier = "";
        public static string _tackler = "";
        public static string _passer = "";
        public static string _reciever = "";
        public static string _defender = "";

        public string Defender
        {
            get { return _defender; }
            set { _defender = value; }
        }
        public string Reciever
        {
            get { return _reciever; }
            set { _reciever = value; }
        }
        public string Passer
        {
            get { return _passer; }
            set { _passer = value; }
        }
        public string Tackler
        {
            get { return _tackler; }
            set { _tackler = value; }
        }
        public string BallCarrier
        {
            get { return _ballcarrier; }
            set { _ballcarrier = value; }
        }

        public int KickYards
        {
            get { return _kickyards; }
            set { _kickyards = value; }
        }

        public int DReturnYards
        {
            get { return _dreturnyards; }
            set { _dreturnyards = value; }
        }

        public int KPReturnYards
        {
            get { return _kpreturnyards; }
            set { _kpreturnyards = value; }
        }

        public int PlayLength
        {
            get { return _playlength; }
            set { _playlength = value; }
        }
        public int PreSnapRunoff
        {
            get { return _presnaprunoff; }
            set { _presnaprunoff = value; }
        }
        public string HPlayCallType
        {
            get { return _hplaycalltype; }
            set { _hplaycalltype = value; }
        }
        public string APlayCallType
        {
            get { return _aplaycalltype; }
            set { _aplaycalltype = value; }
        }
        public string HPlayCall
        {
            get { return _hplaycall; }
            set { _hplaycall = value; }
        }
        public string APlayCall
        {
            get { return _aplaycall; }
            set { _aplaycall = value; }
        }

        public bool CoinToss
        {
            get { return _cointoss; }
            set { _cointoss = value; }
        }

        public bool Touchback
        {
            get { return _touchback; }
            set { _touchback = value; }
        }

        public bool PuntAttempt
        {
            get { return _puntattempt; }
            set { _puntattempt = value; }
        }
        public bool Punt
        {
            get { return _punt; }
            set { _punt = value; }
        }

        public bool SafetyPunt
        {
            get { return _safetypunt; }
            set { _punt = value; }
        }

        public string PlayType
        {
            get { return _playtype; }
            set { _playtype = value; }
        }

        public bool Kickoff
        {
            get { return _kickoff; }
            set { _kickoff = value; }
        }

        public bool ExtraPointTry
        {
            get { return _extrapointtry; }
            set { _extrapointtry = value; }
        }
        public int TdValue
        {
            get { return _tdvalue; }
            set { _tdvalue = value; }
        }
        public int SafetyValue
        {
            get { return _safetyvalue; }
            set { _safetyvalue = value; }
        }
        public int FgValue
        {
            get { return _fgvalue; }
            set { _fgvalue = value; }
        }
        public int XpValue
        {
            get { return _xpvalue; }
            set { _xpvalue = value; }
        }
        public int TwoConvValue
        {
            get { return _twoconvvalue; }
            set { _twoconvvalue = value; }
        }
        public int DTwoConvValue
        {
            get { return _dtwoconvreturnedvalue; }
            set { _dtwoconvreturnedvalue = value; }
        }
        public bool TwoConv
        {
            get { return _twoconv; }
            set { _twoconv = value; }
        }
        public bool TwoConvReturned
        {
            get { return _dtwoconvreturned; }
            set { _dtwoconvreturned = value; }
        }
        public bool Td
        {
            get { return _td; }
            set { _td = value; }
        }
        public bool DTd
        {
            get { return _dtd; }
            set { _dtd = value; }
        }
        public bool Safety
        {
            get { return _safety; }
            set { _safety= value; }
        }
        public bool DSafety
        {
            get { return _dsafety; }
            set { _dsafety= value; }
        }
        public bool FgGood
        {
            get { return _fggood; }
            set { _fggood = value; }
        }
        public bool FgBad
        {
            get { return _fgbad; }
            set { _fgbad= value; }
        }
        public bool XpGood
        {
            get { return _xpgood; }
            set { _xpgood= value; }
        }
        public bool XpBad
        {
            get { return _xpbad; }
            set { _xpbad= value; }
        }
        public bool FirstDownAchieved
        {
            get { return _firstdownachieved; }
            set { _firstdownachieved= value; }
        }
        public int AllowableDistance
        {
            get { return _allowabledistance; }
            set { _allowabledistance = value; }
        }
        public int AllowableDowns
        {
            get { return _allowabledowns; }
            set { _allowabledowns= value; }
        }
        public int Quarter
        {
            get { return _quarter; }
            set { _quarter = value; }
        }
        public int QuarterLength
        {
            get { return _quarterlength; }
            set { _quarterlength = value; }
        }
        public int PlayYards
        {
            get { return _playyards; }
            set { _playyards = value; }
        }
        public int PlayID
        {
            get { return _playid; }
            set { _playid = value; }
        }
        public int YardsToGo
        {
            get { return _yardstogo; }
            set { _yardstogo = value; }
        }
        public string HtName
        {
            get { return _htname; }
            set { _htname = value; }
        }
        public int HtScore
        {
            get { return _htscore; }
            set { _htscore = value; }
        }
        public string AtName
        {
            get { return _atname; }
            set { _atname = value; }
        }
        public int AtScore
        {
            get { return _atscore; }
            set { _atscore = value; }
        }
        public int Down
        {
            get { return _down; }
            set { _down = value; }
        }

        public int Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public bool HomePossession
        {
            get { return _homepossession; }
            set { _homepossession = value; }
        }

        public int Los
        {
            get { return _los; }
            set { _los = value; }
        }
        public bool TurnoverOnDowns
        {
            get { return _turnoverondowns; }
            set { _turnoverondowns= value; }
        }
        public bool Interception
        {
            get { return _interception; }
            set { _interception= value; }
        }
        public bool Fumble
        {
            get { return _fumble; }
            set { _fumble = value; }
        }
    }
}
