using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessApplication.ChessGame.Structs;

namespace ChessApplication.ChessGame.Utilities
{
    public static class ExtensionMethods
    {
        public static Dictionary<char, int> NotationToInt = new Dictionary<char, int>()
            {
                { 'a', 1 },
                { 'b', 2 },
                { 'c', 3 },
                { 'd', 4 },
                { 'e', 5 },
                { 'f', 6 },
                { 'g', 7 },
                { 'h', 8 }
            };
        private static Dictionary<int, char> IntToNotation = new Dictionary<int, char>()
            {

                { 1 , 'a' },
                { 2, 'b' },
                { 3, 'c' },
                { 4, 'd' },
                { 5, 'e' },
                { 6, 'f' },
                { 7, 'g' },
                { 8, 'h' }
            };



        public static Location ToLocation(this string Notation)
        {
            int y = NotationToInt[Notation[0]];
            Int32.TryParse(Notation[1].ToString(), out int x);
            return new Location(x, y);
        }
        public static string ToNotation(this Location location)
        {
            char y = IntToNotation[location.y];


            return $"{y}{location.x}";
        }
    }
}
