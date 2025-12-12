using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoCdayone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 50;

            string filePath = @"C:\MaxwellBilango\CSharpCode\AoC2025\DayonePI.txt";
            List<char> letter = new List<char>();

            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    int ch = reader.Read();
                    Console.Write((char)ch);
                    string begin = (ch).SubString(0, 1);
                    
                    
                    
                }
                Console.Write(letter[0]);
                Console.Write(letter[1]);
            }
        }
    }
}
