// Copyright AB SCIEX 2017. All rights reserved.


using System.Linq;

namespace Centroid
{
    /// <summary>
    /// Class Statistics.
    /// </summary>
    public class Statistics
    {
        /// <summary>
        /// Finds the highest y value.
        /// </summary>
        /// <returns>System.Double.</returns>
        public double FindHighestYValue()
        {
            return Data.YValues != null ? Data.YValues.OrderByDescending(maxYValue => maxYValue).Max() : 0;
        }

        /// <summary>
        /// Finds the lowest x value.
        /// </summary>
        /// <returns>System.Double.</returns>
        public double FindLowestXValue()
        {
            return Data.XValues != null ? Data.XValues.OrderByDescending(maxYValue => maxYValue).Where(x => x > 0).DefaultIfEmpty().Min() : 0;
        }

        /// <summary>
        /// Finds the second highest y value.
        /// </summary>
        /// <returns>System.Double.</returns>
        public double FindSecondHighestYValue()
        {
            return Data.YValues != null ? Data.YValues.Distinct().OrderByDescending(s => s).Skip(1).First() : 0;
        }


        /// <summary>
        /// Finds the centroid.
        /// </summary>
        /// <returns>System.Double.</returns>
        public double FindCentroid()
        {
           return Data.CentroidY != null ? GetCentroid(Data.CentroidY.Select(a => a).Distinct().OrderByDescending(s => s).ToArray()) : 0 ;
        }
        /// <summary>
        /// Gets the median.
        /// </summary>
        /// <param name="sourceNumbers">The source numbers.</param>
        /// <returns>System.Int32.</returns>
        public static double GetCentroid(int[] sourceNumbers)
        {
            if (sourceNumbers != null)
            {
                //Take the array length
                var size = sourceNumbers.Length;
                //Identifies the middle element of length
                var mid = size / 2;
                //Find the centroid
                var centroid = (size % 2 != 0) ? sourceNumbers[mid] : (sourceNumbers[mid] + sourceNumbers[mid - 1]) / 2;
                //Returns the centroid value as double datatype
                return centroid;
            }
            else
            {
                return 0;
            }
        }

    }
}