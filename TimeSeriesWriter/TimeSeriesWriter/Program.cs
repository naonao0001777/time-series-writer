﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TimeSeriesWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] timeSeparate = Console.ReadLine().Split(':');
                Console.Clear();
                //string fileName = @"\test.txt";
                //string directryPath = @"C:\temp";
                //string fileFullPath = string.Concat(directryPath,fileName);

                //StreamWriter sw = new StreamWriter(fileFullPath,true,Encoding.GetEncoding("Shift-jis"));

                int timeHour = 0;
                int timeMinute = 0;
                int timeSecond = 0;

                if (timeSeparate.Count() == 3)
                {
                    timeHour = int.Parse(timeSeparate[0]);
                    timeMinute = int.Parse(timeSeparate[1]);
                    timeSecond = int.Parse(timeSeparate[2]);
                }
                else if (timeSeparate.Count() == 2)
                {
                    timeMinute = int.Parse(timeSeparate[0]);
                    timeSecond = int.Parse(timeSeparate[1]);
                }
                else
                {
                    timeSecond = int.Parse(timeSeparate[0]);
                }
                
                string minute = null;

                string second = null;

                for (int i = 0; i <= timeMinute; i++)
                {
                    minute = i.ToString();
                    int count = 0;

                    for (int j = 0; j < 60; j++)
                    {
                        if (i == timeMinute && j > timeSecond)
                        {
                            break;
                        }

                        count++;

                        second = j.ToString();

                        if (j < 10)
                        {
                            second = string.Concat("0", second);
                        }

                        Console.Write(minute + ":" + second + " ");

                        if (count % 7 == 0)
                        {
                            Console.Write("\n");
                        }
                    }
                    Console.Write("\n");
                }
                Console.ReadKey(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey(true);
            }
        }
    }
}
