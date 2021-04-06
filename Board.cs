using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace PWSG_LAB5
{
    /// <summary>
    /// Bool representation of the board with true representing black and false white
    /// </summary>
    public static class Board
    {
        public static bool[,] EmptyBoard(int XSize, int YSize)
        {
            return new bool[XSize, YSize];
        }

        public static bool[,] RandomBoard(int XSize, int YSize)
        {
            Random rng = new();
            bool[,] colors = new bool[XSize, YSize];

            for (int i = 0; i < XSize; ++i)
            {
                for (int j = 0; j < YSize; ++j)
                {
                    colors[i, j] = rng.Next(2) == 1;
                }
            }

            return colors;
        }

        public static bool[,] LoadBoard(string fileName)
        {
            //https://docs.microsoft.com/pl-pl/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-5-0
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<bool[,]>(jsonString);
        }

        public static void SaveBoard(string fileName, bool[,] board)
        {
            //https://docs.microsoft.com/pl-pl/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-5-0
            var jsonString = JsonSerializer.Serialize(board);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
