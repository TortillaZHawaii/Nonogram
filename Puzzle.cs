using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PWSG_LAB5
{
    public class Puzzle
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string[] RowLabels { get; set; }
        public string[] ColLabels { get; set; }

        public Puzzle(string title, string description, int width, int height, string[] rowLabels, string[] colLabels)
        {
            Title = title;
            Description = description;
            Width = width;
            Height = height;
            RowLabels = rowLabels;
            ColLabels = colLabels;
        }

        //json
        //https://docs.microsoft.com/pl-pl/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-5-0
        public static Puzzle LoadPuzzle(string fileName)
        {
            //https://docs.microsoft.com/pl-pl/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-5-0
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<Puzzle>(jsonString);
        }

        public static void SavePuzzle(string fileName, Puzzle puzzle)
        {
            //https://docs.microsoft.com/pl-pl/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-5-0
            var jsonString = JsonSerializer.Serialize(puzzle);
            File.WriteAllText(fileName, jsonString);
        }

    }
}
