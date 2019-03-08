using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option1
{
    class LinearRegression : Statistics
    {
        public double beta(double[] x, double[] y)
        {
            //This method calculate the  slope of the Linear regression.

            double meanX, meanY , Sy , Sx; //Accumulator, to hold means and standard deviations called from the statisics class

            meanX = Mean(x); // means methods x and y calculate from statistics class.
            meanY = Mean(y);

            Sy = StandardDeviation(y); // Calculates the x and the y sd from method provited in statistics class
            Sx = StandardDeviation(x);


            //Accumulator, initialized to 0 to calculate some part of the formula. 
            double Rxy1 = 0,Rxy2 = 0 ,Rxy3 = 0;

            // For loop make the calculation to some parts  sample correlation coefficient formula 
            for (int i = 0; i < x.Length; i++)
            {
                Rxy1 += x[i] * y[i];
                Rxy2 += Math.Pow(x[i], 2);
                Rxy3 += Math.Pow(y[i], 2);
            }

            // Continues the calculation of  sample correlation coefficient .
            Rxy1 = x.Length * Rxy1 - (Sum(x) * Sum(y));
            Rxy2 = Math.Sqrt(x.Length * Rxy2 - Math.Pow(Sum(x), 2));
            Rxy3 = Math.Sqrt(y.Length * Rxy3 - Math.Pow(Sum(y), 2));


            // Find the  sample correlation coefficient .
            double Rxy = Rxy1 / (Rxy2 *Rxy3);

            // Calculate the slope using the formula of  sample correlation coefficient multiply by the division of the 
            //  standard deviations y and x
            double slope = Rxy * (Sy / Sx);

            return slope; // Return the slope.

        }// End of the beta(slope) method.

        public double alpha(double[] x, double[] y)
        {
            // This method calculate the intersept of the linear regression.

            // Calculate the means x and y and saved to the X and Y variable.
            double X = Mean(x);
            double Y = Mean(y);


            double slope;//Accumulator, to hold slope value.

            slope = beta(x, y); // I use the beta method to call calculate the slope using in the formula of intersept.

            // Calculate the intercept of the linear regression
            double intercept =Y - slope * X;
            return intercept;

        }    // End of beta(intercept) method.           

        public double LinearRegressionFormula(double[] iArray , double[] jArray, double x)
        {
            // This method builded to produce the linear regression line.

            // Calling the two private method to calculate the slope and the intercept needed
            // to count the formula y = a + bx
            double a = alpha(iArray, jArray);
            double b = beta(iArray, jArray);

            // Return the formula to use
            return (b * x + a);
        }  // End Linear regression formula method. 
        

    } // End of LinearRegression class.
}
