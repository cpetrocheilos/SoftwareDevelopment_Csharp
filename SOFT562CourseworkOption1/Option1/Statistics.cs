using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Option1
{
    public class Statistics
    {
        
        public double Sum(double[] iArray)
        {
            // this method calculate the Sum of an array.

            double total = 0; // Accumulator , to save the Sum.
            for (int i = 0; i < iArray.Length; i++)
            {
                total += iArray[i]; // Add every element of the array in the total.
            }

            return total; // Return the value of the sum.
        } // End of Sum method.

        public double Median(double[] iArray)
        {
            double median = 0;
            // Count the size of the iArray in order to calulate the median
            int evenORodd = iArray.Length % 2;

            // Check with the if statemanet if the Array length is even or odd and do 
            // the caclulation of the median using the median formula.
            if (evenORodd == 1)
            {
                int i = iArray.Length / 2;
                median = (iArray[i] + iArray[i + 1]) / 2;
            }
            else
            {
                int j = iArray.Length / 2;
                median = iArray[j];
            }
            return median;
        } // End of median Method.

        public double Mean(double[] iArray)
        {
            // Calulate the the total using the sum method from the same class.
            double total = Sum(iArray); 
           
            // Calculate the mean.
            double mean = total / (double)iArray.Length;

            // Return the mean.
            return mean;

        }// End of the Mean Method which calculate the mean. 

        public double SumOfSquaresMinusMean(double[] iArray)
        {
            // This function need to work an the Array.

            double Sum=0; // Accumulator, to keep the value of the sum.

            double mean = Mean(iArray); // Call the Mean method and find the mean of the Array.

            for (int i = 0; i < iArray.Length; i++)
            {
                Sum += Math.Pow(iArray[i] - mean, 2);// Find the sum of squares by subration every element from the mean.
            }
            return Sum;// Return the value af the sum.

        } // End of Sum of Squares method.

        public double Variance(double[] iArray)
        {
            //Creating new Array holding the data of the iArray
            //and calling the mean function in order to use it in the varience formula
            
            double mean = Mean(iArray);

            //Accumulator, set the default value to 0 for the varience in order to be calculated.
            double var = 0;

            // Use the for loop to calculate the variance of the iArray,
            // and calculate the variance using the formula.
            for (int i = 0; i < iArray.Length; i++)
            {
                var += Math.Pow(iArray[i] - mean, 2);
            }

            // Finishing the calculation of the formula.
            var = var /(double)(iArray.Length - 1);
            //Return the value of the variance.
            return var;

        }//End of the Variance method within the Statistics Class

        public double StandardDeviation(double[] iArray)
        {
            
            double variance = Variance(iArray);

            double sd; // which hold the standar devition value.

            // Use the formula in order to calculate the sd.
            sd = Math.Sqrt(variance);


            // Return the value of the standar devition.
            return sd;

        } // End of the Standard Devition Method.
        

    } // End of statistics class.
}
