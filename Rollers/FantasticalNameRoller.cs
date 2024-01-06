using Rollbard.Library.Extensions;
using Rollbard.Library.Rollers.Interfaces;
using System;

namespace Rollbard.Library.Rollers
{
    public class FantasticalNameRoller : IFantasticalNameRoller
    {
        private readonly string[] singleConsonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z", };
        private readonly string[] consonants = { 


            "bb", "bc", "bd", "bh", "bl", "bn", "br", "bt", "bz",
            "cc", "cd", "ch", "cj", "ck", "cl", "cm", "cn", "cr", "cs", "ct", "cw", "cz",
            "db", "dd", "dg", "dh", "dj", "dm", "dr", "ds", "dt", "dw", "dz",
            "ff", "fl", "fr", "ft", 
            "gg", "gh", "gl", "gn", "gr", "gs", "gw", 
            "hn", "ht", 
            "kh", "kl", "kn", "kr", "kw",
            "lb", "lc", "ld", "lf", "lk", "ll", "lm", "ln", "lp", "lq", "ls", "lt", "lz",
            "mb", "mc", "md", "mm", "mn", "mp", "ms", "mt", 
            "nb", "nc", "nd", "ng", "nk", "nm", "nn", "np", "nt", 
            "pf", "ph", "pl", "pn", "pp", "pr", "ps", "pt", 
            "rb", "rc", "rd", "rg", "rh", "rk", "rm", "rn", "rp", "rr", "rs", "rt", "rw", 
            "sc", "sh", "sk", "sl", "sm", "sn", "sp", "sq", "ss", "st", "sw", 
            "th", "tr", "tt", "tw", "tz",
            "vh", "vl", "vr", 
            "wh", "wr", 
            "xt", "xx", 
            "zh", "zw", "zz",
        };
        private readonly Random random = new Random();

        private readonly string[] singleVowels = { "a", "e", "i", "o", "u", };
        private readonly string[] vowels = { "ae", "ai", "ao", "au", "ea", "ee", "ei", "eo", "eu", "ia", "ie", "io", "iu", "ua", "ue", "ui", "uo", "oa", "oe", "oi", "oo", "ou", "ay", "ey", "oy"};

        public string Get()
        {
            string name = "";

            int length = random.Next(3, 7);

            bool isVowel = random.NextBool();

            for (int i = 0; i < length; i++)
            {
                var isDouble = random.NextBool(name.Length * (100 / (length + 3)));
                if (isVowel)
                {
                    name += isDouble ? vowels.GetRandom() : singleVowels.GetRandom();
                }
                else
                {
                    name += isDouble ? consonants.GetRandom() : singleConsonants.GetRandom();
                }

                isVowel = !isVowel;
            }

            return char.ToUpper(name[0]) + name[1..];
        }
    }
}