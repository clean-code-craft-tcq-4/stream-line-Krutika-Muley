using System;
using System.Collections.Generic;

namespace BMSDataSender
{
     public static class BatteryData
    {

        public static List<float> TempData { get; set; }
        public static List<float> SOC { get; set; }
  
        public static List<float> GenerateBatteryData(float minValue, float maxValue, int maxReading)
        {
            Random random = new Random();
            List<float> dataSamples = new List<float>();
            for (int index = 0; index < maxReading; index++)
                {
                  dataSamples.Add((float)(random.NextDouble() + dataSamples[index]));
                 }
            return dataSamples;
        }

        public static void PrintBatteryData(List<float>tempData, List<float> socData)
        {
            Console.WriteLine("TempData:");
            PrintData(tempData);
            Console.WriteLine("SOCData:");
            PrintData(socData);
        }
        private static void PrintData(List<float> data)
        {
            foreach (var d in data)
            {
                Console.Write($"{d}\t");
            }
        }
    }
}
