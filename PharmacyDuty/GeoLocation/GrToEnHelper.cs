using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmacyDuty.GeoLocation
{
    public class GrToEnHelper
    {
        public static Dictionary<char, string> MatchGrToEn()
        {
            Dictionary<char, string> _MatchGrToEn = new Dictionary<char, string>();
            _MatchGrToEn.Add('α', "a");
            _MatchGrToEn.Add('ά', "a");
            _MatchGrToEn.Add('Α', "A");
            _MatchGrToEn.Add('Ά', "A");
            _MatchGrToEn.Add('β', "b");
            _MatchGrToEn.Add('Β', "B");
            _MatchGrToEn.Add('γ', "g");
            _MatchGrToEn.Add('Γ', "G");
            _MatchGrToEn.Add('δ', "d");
            _MatchGrToEn.Add('Δ', "D");
            _MatchGrToEn.Add('ε', "e");
            _MatchGrToEn.Add('έ', "e");
            _MatchGrToEn.Add('Ε', "E");
            _MatchGrToEn.Add('Έ', "E");
            _MatchGrToEn.Add('ζ', "z");
            _MatchGrToEn.Add('Ζ', "Z");
            _MatchGrToEn.Add('η', "i");
            _MatchGrToEn.Add('ή', "i");
            _MatchGrToEn.Add('Η', "I");
            _MatchGrToEn.Add('Ή', "I");
            _MatchGrToEn.Add('θ', "th");
            _MatchGrToEn.Add('Θ', "Th");
            _MatchGrToEn.Add('ι', "i");
            _MatchGrToEn.Add('ί', "i");
            _MatchGrToEn.Add('ϊ', "i");
            _MatchGrToEn.Add('ΐ', "i");
            _MatchGrToEn.Add('Ι', "I");
            _MatchGrToEn.Add('Ί', "I");
            _MatchGrToEn.Add('Ϊ', "I");
            _MatchGrToEn.Add('κ', "k");
            _MatchGrToEn.Add('Κ', "K");
            _MatchGrToEn.Add('λ', "l");
            _MatchGrToEn.Add('Λ', "L");
            _MatchGrToEn.Add('μ', "m");
            _MatchGrToEn.Add('Μ', "M");
            _MatchGrToEn.Add('ν', "n");
            _MatchGrToEn.Add('Ν', "N");
            _MatchGrToEn.Add('ξ', "ks");
            _MatchGrToEn.Add('Ξ', "Ks");
            _MatchGrToEn.Add('ο', "o");
            _MatchGrToEn.Add('ό', "o");
            _MatchGrToEn.Add('Ο', "O");
            _MatchGrToEn.Add('Ό', "O");
            _MatchGrToEn.Add('π', "p");
            _MatchGrToEn.Add('Π', "P");
            _MatchGrToEn.Add('ρ', "r");
            _MatchGrToEn.Add('Ρ', "R");
            _MatchGrToEn.Add('σ', "s");
            _MatchGrToEn.Add('ς', "s");
            _MatchGrToEn.Add('Σ', "S");
            _MatchGrToEn.Add('τ', "t");
            _MatchGrToEn.Add('Τ', "T");
            _MatchGrToEn.Add('υ', "y");
            _MatchGrToEn.Add('ύ', "y");
            _MatchGrToEn.Add('ϋ', "y");
            _MatchGrToEn.Add('ΰ', "y");
            _MatchGrToEn.Add('Υ', "Y");
            _MatchGrToEn.Add('Ύ', "Y");
            _MatchGrToEn.Add('Ϋ', "Y");
            _MatchGrToEn.Add('φ', "f");
            _MatchGrToEn.Add('Φ', "F");
            _MatchGrToEn.Add('χ', "ch");
            _MatchGrToEn.Add('Χ', "Ch");
            _MatchGrToEn.Add('ψ', "p");
            _MatchGrToEn.Add('Ψ', "Ps");
            _MatchGrToEn.Add('ω', "w");
            _MatchGrToEn.Add('ώ', "w");
            _MatchGrToEn.Add('Ω', "W");
            _MatchGrToEn.Add('Ώ', "W");
            _MatchGrToEn.Add('\n', string.Empty);
            return _MatchGrToEn;

        }
    }
}