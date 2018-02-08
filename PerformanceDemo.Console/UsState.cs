using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PerformanceDemo
{
    public class UsState : ReferenceDataWithCode
    {
        private UsState(string code, string name) : base(code)
        {
            Name = name;
        }

        public string Name { get; }

        public static readonly UsState AL = new UsState("AL", "Alabama");
        public static readonly UsState AK = new UsState("AK", "Alaska");
        public static readonly UsState AZ = new UsState("AZ", "Arizona");
        public static readonly UsState AR = new UsState("AR", "Arkansas");
        public static readonly UsState CA = new UsState("CA", "California");
        public static readonly UsState CO = new UsState("CO", "Colorado");
        public static readonly UsState CT = new UsState("CT", "Connecticut");
        public static readonly UsState DE = new UsState("DE", "Delaware");
        public static readonly UsState FL = new UsState("FL", "Florida");
        public static readonly UsState GA = new UsState("GA", "Georgia");
        public static readonly UsState HI = new UsState("HI", "Hawaii");
        public static readonly UsState ID = new UsState("ID", "Idaho");
        public static readonly UsState IL = new UsState("IL", "Illinois");
        public static readonly UsState IN = new UsState("IN", "Indiana");
        public static readonly UsState IA = new UsState("IA", "Iowa");
        public static readonly UsState KS = new UsState("KS", "Kansas");
        public static readonly UsState KY = new UsState("KY", "Kentucky");
        public static readonly UsState LA = new UsState("LA", "Louisiana");
        public static readonly UsState ME = new UsState("ME", "Maine");
        public static readonly UsState MD = new UsState("MD", "Maryland");
        public static readonly UsState MA = new UsState("MA", "Massachusetts");
        public static readonly UsState MI = new UsState("MI", "Michigan");
        public static readonly UsState MN = new UsState("MN", "Minnesota");
        public static readonly UsState MS = new UsState("MS", "Mississippi");
        public static readonly UsState MO = new UsState("MO", "Missouri");
        public static readonly UsState MT = new UsState("MT", "Montana");
        public static readonly UsState NE = new UsState("NE", "Nebraska");
        public static readonly UsState NV = new UsState("NV", "Nevada");
        public static readonly UsState NH = new UsState("NH", "New Hampshire");
        public static readonly UsState NJ = new UsState("NJ", "New Jersey");
        public static readonly UsState NM = new UsState("NM", "New Mexico");
        public static readonly UsState NY = new UsState("NY", "New York");
        public static readonly UsState NC = new UsState("NC", "North Carolina");
        public static readonly UsState ND = new UsState("ND", "North Dakota");
        public static readonly UsState OH = new UsState("OH", "Ohio");
        public static readonly UsState OK = new UsState("OK", "Oklahoma");
        public static readonly UsState OR = new UsState("OR", "Oregon");
        public static readonly UsState PA = new UsState("PA", "Pennsylvania");
        public static readonly UsState RI = new UsState("RI", "Rhode Island");
        public static readonly UsState SC = new UsState("SC", "South Carolina");
        public static readonly UsState SD = new UsState("SD", "South Dakota");
        public static readonly UsState TN = new UsState("TN", "Tennessee");
        public static readonly UsState TX = new UsState("TX", "Texas");
        public static readonly UsState UT = new UsState("UT", "Utah");
        public static readonly UsState VT = new UsState("VT", "Vermont");
        public static readonly UsState VA = new UsState("VA", "Virginia");
        public static readonly UsState WA = new UsState("WA", "Washington");
        public static readonly UsState WV = new UsState("WV", "West Virginia");
        public static readonly UsState WI = new UsState("WI", "Wisconsin");
        public static readonly UsState WY = new UsState("WY", "Wyoming");

        public static readonly List<UsState> All = new List<UsState>
        {
            AL,AK,AZ,AR,CA,CO,CT,DE,FL,GA,HI,ID,IL,IN,IA,KS,KY,LA,ME,MD,MA,MI,MN,MS,MO,
            MT,NE,NV,NH,NJ,NM,NY,NC,ND,OH,OK,OR,PA,RI,SC,SD,TN,TX,UT,VT,VA,WA,WV,WI,WY
        };

        private static readonly Dictionary<string, UsState> _statesByCode = All.ToDictionary(x => x.Code);

        public static UsState FromCode(string code)
        {
            _statesByCode.TryGetValue(code, out var result);
            return result;
        }
    }
}