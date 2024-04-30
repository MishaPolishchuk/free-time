namespace RunningLine
{
    public static class PaternToPrintContainer
    {
        public static Dictionary<string, string[]> SymbolPatterns;

        static PaternToPrintContainer()
        {
            SymbolPatterns = new()
            {
                 { "a", new string[] {"  aaaa    ", " aa  aa   ", "aa    aa  ", "aaaaaaaa  ", "aa    aa  ", "aa    aa  ", "aa    aa  "}},
                 { "b", new string[] {"bbbbbbb   ", "b      b  ", "b      b  ", "bbbbbbb   ", "b      b  ", "b      b  ", "bbbbbbb   "}},
                 { "c", new string[] {" cccccc   ", "cc     c  ", "cc     c  ", "cc        ", "cc     c  ", "cc     c  ", " cccccc   "}},
                 { "d", new string[] {"dddddd    ", "dd   dd   ", "dd    dd  ", "dd    dd  ", "dd    dd  ", "dd   dd   ", "dddddd    "}},
                 { "e", new string[] {"eeeeeeee  ", "ee        ", "ee        ", "eeeeeeee  ", "ee        ", "ee        ", "eeccccce  "}},
                 { "f", new string[] {"ffffffff  ", "ff        ", "ff        ", "ffffffff  ", "ff        ", "ff        ", "ff        "}},
                 { "g", new string[] {" gggggg   ", "gg    gg  ", "gg        ", "gg  gggg  ", "gg    gg  ", "gg    gg  ", " gggggg   "}},
                 { "h", new string[] {"hh    hh  ", "hh    hh  ", "hh    hh  ", "hhhhhhhh  ", "hh    hh  ", "hh    hh  ", "hh    hh  "}},
                 { "i", new string[] {"   iii    ", "   iii    ", "   iii    ", "   iii    ", "   iii    ", "   iii    ", "   iii    "}},
                 { "j", new string[] {"  jjjjj   ", "  jjjjj   ", "  jjjjj   ", "  jjjjj   ", "  jjjjj   ", "jj jjj    ", " jjjjj    "}},
                 { "k", new string[] {"kk    kk  ", "kk   kk   ", "kk  kk    ", "kkkkk     ", "kk  kk    ", "kk   kk   ", "kk    kk  "}},
                 { "l", new string[] {"ll        ", "ll        ", "ll        ", "ll        ", "ll        ", "ll        ", "llllllll  "}},
                 { "m", new string[] {"mm    mm  ", "mmm  mmm  ", "mm mm mm  ", "mm    mm  ", "mm    mm  ", "mm    mm  ", "mm    mm  "}},
                 { "n", new string[] {"nn    nn  ", "nnn   nn  ", "nnnn  nn  ", "nn nn nn  ", "nn  nnnn  ", "nn   nnn  ", "nn    nn  "}},
                 { "o", new string[] {" oooooo   ", "ooo  ooo  ", "oo    oo  ", "oo    oo  ", "oo    oo  ", "ooo  ooo  ", " oooooo   "}},
                 { "p", new string[] {"ppppppp   ", "pp    pp  ", "pp    pp  ", "ppppppp   ", "pp        ", "pp        ", "pp        "}},
                 { "q", new string[] {" qqqqqq   ", "qq    qq  ", "qq    qq  ", "q     qq  ", "qq  q qq  ", "qq  qqq   ", " qqqq  q  "}},
                 { "r", new string[] {"rrrrrrr   ", "rr    rr  ", "rr   rrr  ", "rrrrrr    ", "rr  rrrr  ", "rr    rr  ", "rr    rr  "}},
                 { "s", new string[] {" ssssss   ", "ss    ss  ", "ss        ", "  ssss    ", "      ss  ", "ss    ss  ", " ssssss   "}},
                 { "t", new string[] {"tttttttt  ", "   tt     ", "   tt     ", "   tt     ", "   tt     ", "   tt     ", "   tt     "}},
                 { "u", new string[] {"uu    uu  ", "uu    uu  ", "uu    uu  ", "uu    uu  ", "uu    uu  ", "uuu  uuu  ", " uuuuuu   "}},
                 { "v", new string[] {" v     v  ", " v     v  ", " vv   vv  ", " vv   vv  ", "  vv vv   ", "  vvvvv   ", "   vvv    "}},
                 { "w", new string[] {"w      w  ", "ww    ww  ", "ww ww ww  ", "wwwwwwww  ", "www  www  ", " ww  ww   ", "  w  w    "}},
                 { "x", new string[] {"xx    xx  ", "xx    xx  ", " xx  xx   ", "  xxxx    ", " xx  xx   ", "xx    xx  ", "xx    xx  "}},
                 { "y", new string[] {"yy    yy  ", "yy    yy  ", " yy  yy   ", "  yyyy    ", "   yy     ", "   yy     ", "   yy     "}},
                 { "z", new string[] {"zzzzzzzz  ", "     zzz  ", "    zzz   ", "  zzz     ", " zzz      ", "zzz       ", "zzzzzzzz  "}}
            };
        }

        public static string[] GetPatternToPrint(string userInput)
        {
            string[] patternToPrint = new string[7];
            for (int i = 0; i < patternToPrint.Length; i++)
            {
                foreach (var symbol in userInput)
                {
                    patternToPrint[i] += SymbolPatterns[symbol.ToString()][i];
                }
            }
            return patternToPrint;
        }
    }
}
