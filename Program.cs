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
            String line;
            string sub;
            int amount;
            int starting = 50;
            int zero = 0;
            int temp;
            int temp2;

            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:/MaxwellBilango/CSharpCode/AoC2025/DayonePI.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                Console.WriteLine("START");
                while (line != null)
                {
                    //write the line to console window
                    
                    sub = line.Substring(0, 1);
                    amount = Int32.Parse(line.Substring(1));
                    Console.WriteLine(starting);
                    if (sub == "L")
                    {
                        starting = starting - amount;
                        
                        if (starting < 0)
                        {
                            zero = zero + 1;
                            temp = starting * -1;
                            starting = 99 - (temp - 1);
                            
                        }
                        else if (starting == 0)
                        {
                            zero = zero + 1;
                        }
                        
                    }
                    else if (sub == "R")
                    {
                        starting = starting + amount;
                        
                        if (starting > 99)
                        {
                            zero = zero + 1;
                            temp = starting - 99;
                            starting = 0 + (temp - 1);
                            
                        }
                        else if (starting == 0)
                        {
                            zero = zero + 1;
                        }
                        
                    }

                    //Read the next line
                    line = sr.ReadLine();
                }

                Console.WriteLine(zero);

                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
