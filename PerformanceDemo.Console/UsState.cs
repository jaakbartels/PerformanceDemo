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

        public static UsState AL => new UsState("AL", "Alabama");
        public static UsState AK => new UsState("AK", "Alaska");
        public static UsState AZ => new UsState("AZ", "Arizona");
        public static UsState AR => new UsState("AR", "Arkansas");
        public static UsState CA => new UsState("CA", "California");
        public static UsState CO => new UsState("CO", "Colorado");
        public static UsState CT => new UsState("CT", "Connecticut");
        public static UsState DE => new UsState("DE", "Delaware");
        public static UsState FL => new UsState("FL", "Florida");
        public static UsState GA => new UsState("GA", "Georgia");
        public static UsState HI => new UsState("HI", "Hawaii");
        public static UsState ID => new UsState("ID", "Idaho");
        public static UsState IL => new UsState("IL", "Illinois");
        public static UsState IN => new UsState("IN", "Indiana");
        public static UsState IA => new UsState("IA", "Iowa");
        public static UsState KS => new UsState("KS", "Kansas");
        public static UsState KY => new UsState("KY", "Kentucky");
        public static UsState LA => new UsState("LA", "Louisiana");
        public static UsState ME => new UsState("ME", "Maine");
        public static UsState MD => new UsState("MD", "Maryland");
        public static UsState MA => new UsState("MA", "Massachusetts");
        public static UsState MI => new UsState("MI", "Michigan");
        public static UsState MN => new UsState("MN", "Minnesota");
        public static UsState MS => new UsState("MS", "Mississippi");
        public static UsState MO => new UsState("MO", "Missouri");
        public static UsState MT => new UsState("MT", "Montana");
        public static UsState NE => new UsState("NE", "Nebraska");
        public static UsState NV => new UsState("NV", "Nevada");
        public static UsState NH => new UsState("NH", "New Hampshire");
        public static UsState NJ => new UsState("NJ", "New Jersey");
        public static UsState NM => new UsState("NM", "New Mexico");
        public static UsState NY => new UsState("NY", "New York");
        public static UsState NC => new UsState("NC", "North Carolina");
        public static UsState ND => new UsState("ND", "North Dakota");
        public static UsState OH => new UsState("OH", "Ohio");
        public static UsState OK => new UsState("OK", "Oklahoma");
        public static UsState OR => new UsState("OR", "Oregon");
        public static UsState PA => new UsState("PA", "Pennsylvania");
        public static UsState RI => new UsState("RI", "Rhode Island");
        public static UsState SC => new UsState("SC", "South Carolina");
        public static UsState SD => new UsState("SD", "South Dakota");
        public static UsState TN => new UsState("TN", "Tennessee");
        public static UsState TX => new UsState("TX", "Texas");
        public static UsState UT => new UsState("UT", "Utah");
        public static UsState VT => new UsState("VT", "Vermont");
        public static UsState VA => new UsState("VA", "Virginia");
        public static UsState WA => new UsState("WA", "Washington");
        public static UsState WV => new UsState("WV", "West Virginia");
        public static UsState WI => new UsState("WI", "Wisconsin");
        public static UsState WY => new UsState("WY", "Wyoming");

        public static List<UsState> All => new List<UsState>
        {
            AL,AK,AZ,AR,CA,CO,CT,DE,FL,GA,HI,ID,IL,IN,IA,KS,KY,LA,ME,MD,MA,MI,MN,MS,MO,
            MT,NE,NV,NH,NJ,NM,NY,NC,ND,OH,OK,OR,PA,RI,SC,SD,TN,TX,UT,VT,VA,WA,WV,WI,WY
        };

        public static UsState FromCode(string code)
        {
            return All.FirstOrDefault(s => s.Code.Equals(code, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}