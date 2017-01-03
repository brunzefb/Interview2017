// Copyright AB SCIEX 2017. All rights reserved.

using System;
using System.IO;
using JsonPrettyPrinterPlus;
using Newtonsoft.Json;

namespace Centroid
{
    public class MsData
    {
        public double[] xValues;
        public double[] yValues;
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Statistics generator");
            var data = new MsData();
            data.xValues = Data.XValues;
            data.yValues = Data.YValues;
            var str = JsonConvert.SerializeObject(data);
            File.WriteAllText(@"c:\temp\data.txt", str.PrettyPrintJson());
            var statistics = new Statistics();
            Console.WriteLine(string.Format("Highest Y value is: {0}", statistics.FindHighestYValue()));
            Console.WriteLine(string.Format("Second highest Y value is: {0}", statistics.FindSecondHighestYValue()));
            Console.WriteLine(string.Format("Zero-based Centroid X value: {0}", statistics.FindCentroid()));

            Console.ReadLine();
        }
    }
}