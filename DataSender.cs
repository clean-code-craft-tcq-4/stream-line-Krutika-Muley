    using System.Collections.Generic;
    using System;

namespace BMSSender
{ 
    public class Sender
{
    public static int numOfSamples = 50;

    public static List<int> GenerateBatteryData(int number_of_samples, int min_sensor_value, int max_sensor_value)
    {
        Random random = new Random();
        var data = new List<int>();
        for (int i = 0; i < numOfSamples ;i ++)
        {
            data.Add(random.Next(min_sensor_value, max_sensor_value));
        }
        return data;
    }

    public static Tuple<List<int>, List<int>> GetDataFromSensors(int number_of_samples)
    {
            var dataFromTempSensor = GenerateBatteryData(numOfSamples, 0, 45);
            var dataFromSOCSensor = GenerateBatteryData(numOfSamples, 0, 100);
      
        return Tuple.Create( dataFromTempSensor, dataFromSOCSensor);
    }

    public static string FormatData(
        int sampleNum,
        string sensorOne,
        int sensorOneValue,
        string sensorTwo,
        int sensorTwoValue)
    {
        return String.Format("{0}:{1}, {2}:{3}, {4}:{5}\n","SampleNum", sampleNum, sensorOne, sensorOneValue, sensorTwo, sensorTwoValue);
    }

    public static void PrintData(object data)
    {
        Console.WriteLine(data);
    }
    public static void SendData(int numOfSamples)
    {
        var sensorData = GetDataFromSensors(numOfSamples);
        for (int i = 0;i< numOfSamples;i++)
        {
            var data = FormatData(i, "Temperature Sensor" , sensorData.Item1[i], "SOC Sensor", sensorData.Item2[i]);
            PrintData(data);
        }
    }
    static void Main(string[] args)
    {
        SendData(numOfSamples);
    }

 }
}
