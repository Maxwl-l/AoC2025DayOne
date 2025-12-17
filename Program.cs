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
        //static void Main(string[] args)
        //{
        //    String line;
        //    string sub;
        //    int amount;
        //    int starting = 50;
        //    int zero = 0;
        //    int temp;
        //    int temp2;

        //    try
        //    {
        //        //Pass the file path and file name to the StreamReader constructor
        //        StreamReader sr = new StreamReader("C:/MaxwellBilango/CSharpCode/AoC2025/DayonePI.txt");
        //        //Read the first line of text
        //        line = sr.ReadLine();
        //        //Continue to read until you reach end of file
        //        Console.WriteLine("START");
        //        while (line != null)
        //        {
        //            //write the line to console window

        //            sub = line.Substring(0, 1);
        //            amount = Int32.Parse(line.Substring(1));

        //            if (sub == "R")
        //            {
        //                temp2 = starting + amount;
        //                if (temp2 > 99)
        //                {
        //                    temp = temp2 - 99;
        //                    temp2 = 0 + (temp - 1);
        //                    if (temp2 > 99)
        //                    {
        //                        temp = temp2 - 99;
        //                        temp2 = 0 + (temp - 1);
        //                    }
        //                    Console.WriteLine(temp2);
        //                    starting = temp2;
        //                    if (starting == 0)
        //                    {
        //                        zero = zero + 1;
        //                    }

        //                }
        //                else if (temp2 == 0)
        //                {
        //                    zero = zero + 1;
        //                    Console.WriteLine(temp2);
        //                    starting = temp2;

        //                }
        //                else
        //                {
        //                    Console.WriteLine(temp2);
        //                    starting = temp2;
        //                }

        //            }


        //            if (sub == "L")
        //            {
        //                temp2 = starting - amount;
        //                if (temp2 < 0)
        //                {
        //                    temp = temp2 * -1;
        //                    temp2 = 100 - (temp);
        //                    if (temp < 0)
        //                    {
        //                        temp = temp2 * -1;
        //                        temp2 = 100 - (temp);
        //                    }
        //                    Console.WriteLine(temp2);
        //                    starting = temp2;
        //                    if (starting == 0)
        //                    {
        //                        zero = zero + 1;
        //                    }
        //                }
        //                else if (temp2 == 0)
        //                {
        //                    zero = zero + 1;
        //                    Console.WriteLine(temp2);
        //                    starting = temp2;

        //                }
        //                else
        //                {
        //                    Console.WriteLine(temp2);
        //                    starting = temp2;

        //                }

        //            }
        //            Console.WriteLine("-----------------");
        //            //Read the next line
        //            line = sr.ReadLine();
        //        }

        //        Console.WriteLine("Answer:");
        //        Console.WriteLine(zero);

        //        //close the file
        //        sr.Close();
        //        Console.ReadLine();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Exception: " + e.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Executing finally block.");
        //    }
        //}

        static void Main(string[] args)
        {
            //string line;
            //int starting = 50;
            //int zero = 0;

            //try
            //{
            //    StreamReader sr = new StreamReader(
            //        "C:/MaxwellBilango/CSharpCode/AoC2025/DayonePI.txt"
            //    );

            //    Console.WriteLine("START");

            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        char direction = line[0];
            //        int amount = int.Parse(line.Substring(1));

            //        // Reduce rotation to within 0–99
            //        amount %= 100;

            //        if (direction == 'R')
            //        {
            //            starting = (starting + amount) % 100;
            //        }
            //        else if (direction == 'L')
            //        {
            //            starting = (starting - amount + 100) % 100;
            //        }

            //        Console.WriteLine(starting);

            //        if (starting == 0)
            //        {
            //            zero++;
            //        }

            //        Console.WriteLine("-----------------");
            //    }

            //    sr.Close();

            //    Console.WriteLine("Answer:");
            //    Console.WriteLine(zero);
            //    Console.ReadLine();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception: " + e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Executing finally block.");
            //}
            Part2();
        }
        public static void Part2()
        {
            // turns out part 2 of day one requires me to include if a rotation causes it to pass 0
            // which turns out to be the mistake I made initially in part 1



            //String line;
            //string sub;
            //int amount;
            //int starting = 50;
            //int zero = 0;
            //int temp;
            //int temp2;

            //try
            //{
            //    //Pass the file path and file name to the StreamReader constructor
            //    StreamReader sr = new StreamReader("C:/MaxwellBilango/CSharpCode/AoC2025/DayonePI.txt");
            //    //Read the first line of text
            //    line = sr.ReadLine();
            //    //Continue to read until you reach end of file
            //    Console.WriteLine("START");
            //    while (line != null)
            //    {
            //        //write the line to console window

            //        sub = line.Substring(0, 1);
            //        amount = Int32.Parse(line.Substring(1));
            //        amount %= 100;

            //        if (sub == "R")
            //        {
            //            temp2 = starting + amount;
            //            if (temp2 > 99)
            //            {
            //                zero = zero + 1;
            //                temp2 = (50 + amount) % 100;
            //                //temp = temp2 - 99;
            //                //temp2 = 0 + (temp - 1);

            //                Console.WriteLine(temp2);
            //                starting = temp2;
            //                if (starting == 0)
            //                {
            //                    zero = zero + 1;
            //                }

            //            }
            //            else if (temp2 == 0)
            //            {
            //                zero = zero + 1;
            //                Console.WriteLine(temp2);
            //                starting = temp2;

            //            }
            //            else
            //            {
            //                Console.WriteLine(temp2);
            //                starting = temp2;
            //            }

            //        }


            //        if (sub == "L")
            //        {
            //            temp2 = starting - amount;
            //            if (temp2 < 0)
            //            {
            //                temp2 = (50 - amount + 100) % 100;
            //                zero = zero + 1;
            //                //temp = temp2 * -1;
            //                //temp2 = 100 - (temp);

            //                Console.WriteLine(temp2);
            //                starting = temp2;
            //                if (starting == 0)
            //                {
            //                    zero = zero + 1;
            //                }
            //            }
            //            else if (temp2 == 0)
            //            {
            //                zero = zero + 1;
            //                Console.WriteLine(temp2);
            //                starting = temp2;

            //            }
            //            else
            //            {
            //                Console.WriteLine(temp2);
            //                starting = temp2;

            //            }

            //        }
            //        Console.WriteLine("-----------------");
            //        //Read the next line
            //        line = sr.ReadLine();
            //    }

            //    Console.WriteLine("Answer:");
            //    Console.WriteLine(zero);

            //    //close the file
            //    sr.Close();
            //    Console.ReadLine();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception: " + e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Executing finally block.");
            //}

            //string line;
            //int starting = 50;
            //int zero = 0;

            //try
            //{
            //    StreamReader sr = new StreamReader(
            //        "C:/MaxwellBilango/CSharpCode/AoC2025/DayonePI.txt"
            //    );

            //    Console.WriteLine("START");

            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        char direction = line[0];
            //        int amount = int.Parse(line.Substring(1));

            //        // Reduce rotation to within 0–99
            //        amount %= 100;

            //        if (direction == 'R')
            //        {
            //            starting = (starting + amount) % 100;
            //        }
            //        else if (direction == 'L')
            //        {
            //            starting = (starting - amount + 100) % 100;
            //        }

            //        Console.WriteLine(starting);

            //        if (starting == 0)
            //        {
            //            zero++;
            //        }

            //        Console.WriteLine("-----------------");
            //    }

            //    sr.Close();

            //    Console.WriteLine("Answer:");
            //    Console.WriteLine(zero);
            //    Console.ReadLine();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception: " + e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Executing finally block.");
            //}

            string line;
            int starting = 50;
            int zero = 0;
            int temp;

            try
            {
                StreamReader sr = new StreamReader(
                    "C:/MaxwellBilango/CSharpCode/AoC2025/DayonePI.txt"
                );

                Console.WriteLine("START");

                while ((line = sr.ReadLine()) != null)
                {
                    char direction = line[0];
                    int amount = int.Parse(line.Substring(1));
                    starting %= 100;

                    if (direction == 'R')
                    {
                        for (int i = 0; i < amount; i++)
                        {
                            starting = (starting + 1) % 100;
                            if (starting == 0)
                            {
                                Console.WriteLine("ADDED");
                                zero++;
                            }
                        }
                        
                    }
                    if (direction == 'L')
                    {
                        for (int i = 0; i < amount; i++)
                        {
                            starting = (starting - 1 + 100) % 100;
                            if (starting == 0)
                            {
                                Console.WriteLine("ADDED");
                                zero++;
                            }
                        }
                        
                    }
                }

                sr.Close();

                Console.WriteLine("Answer:");
                Console.WriteLine(zero);
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
