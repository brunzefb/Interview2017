// Copyright AB SCIEX 2017. All rights reserved.

using System;
using System.IO;
using JsonPrettyPrinterPlus;
using Newtonsoft.Json;

namespace Centroid
{
    /// <summary>
    /// Class MsData.
    /// </summary>
    public class MsData
    {
        /// <summary>
        /// The x values
        /// </summary>
        public double[] xValues;
        /// <summary>
        /// The y values
        /// </summary>
        public double[] yValues;
    }

    /// <summary>
    /// Class Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Statistics generator");
            GenerateData();
            var statistics = new Statistics();
            Console.WriteLine(string.Format("Highest Y value is: {0}", statistics.FindHighestYValue()));
            Console.WriteLine(string.Format("Second highest Y value is: {0}", statistics.FindSecondHighestYValue()));
            Console.WriteLine(string.Format("Lowest  X value is: {0}", statistics.FindLowestXValue()));
            Console.WriteLine(string.Format("Zero-based Centroid X value: {0}", statistics.FindCentroid()));
            Console.ReadLine();
        }


        /// <summary>
        /// Generates the data.
        /// </summary>
        private static void GenerateData()
        {
            try
            {
                var data = new MsData();
                data.xValues = Data.XValues;
                data.yValues = Data.YValues;
                var str = JsonConvert.SerializeObject(data);
                CreateFileWithData(ApplicationConstant.FilePath, str);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        /// <summary>
        /// Creates the file with data.
        /// </summary>
        /// <param name="filepath">The filepath.</param>
        /// <param name="data">The data.</param>
        private static void CreateFileWithData(string filepath, string data)
        {
            try
            {
                if (!File.Exists(filepath))
                {
                    using (var sw = File.CreateText(filepath))
                    {
                        sw.Close();
                        File.WriteAllText(ApplicationConstant.FilePath, data.PrettyPrintJson());
                    }
                }

            }
            catch (IOException ioex)
            {
                Console.WriteLine(ioex.Message);
            }
        }
    }
}