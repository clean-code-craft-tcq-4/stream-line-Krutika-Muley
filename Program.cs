using System;
using System.Collections.Generic;

namespace BMSSender
{
    class Program
    {
        private const float SOC_MIN = 0;
        private const float SOC_MAX = 80;
        private const float TEMP_MIN = -50;
        private const float TEMP_MAX = 200;
        private const int MAX_READING = 100;
        static void Main(string[] args)
        {
            BatteryData.TempData = BatteryData.GenerateBatteryData(TEMP_MIN, TEMP_MAX, MAX_READING);
            BatteryData.SOC = BatteryData.GenerateBatteryData(SOC_MIN, SOC_MAX, MAX_READING);
            BatteryData.PrintBatteryData(BatteryData.TempData, BatteryData.SOC);
        }
    }
 }
