using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace Option1
{
    public partial class RegressionTypeLabel : Form
    {

        private DataLoader dataLoader;
        private Statistics stat;
        private LinearRegression Model;
        private tTest test;

        private int[] education;
        private double[] income;
        private double[] debtToIncome;
        private double[] creditCardDebt;
        private int[] previousDefault;     



        public RegressionTypeLabel()
        {
            InitializeComponent();

            // The window atomatically resize when something of the elements is open
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;            
            

            // Call the classes when the form load.
            dataLoader = new DataLoader();
            stat = new Statistics();
            Model = new LinearRegression();
            test = new tTest();
            
            // Load the data atommaticaly when the form loads.
            dataLoader.LoadData();

            GetData();

            WriteData();          
            
        }       
        
        /// <summary>
        /// populate the data arrays by retrieving the data from the dataloader object
        /// </summary>
        private void GetData()
        {
            education = dataLoader.GetEdArray();
            income = dataLoader.GetIncomeArray();
            debtToIncome = dataLoader.GetDebtincArray();
            creditCardDebt = dataLoader.GetCreddebtArray();
            previousDefault = dataLoader.GetPreviousDefaulArray();            
        }

        /// <summary>
        /// helper method to display the data arrays
        /// </summary>
        private void WriteData()
        {

            //Debug.WriteLine(" Contents of EdArray is: ");
            //WriteArray(education);
            
            Debug.WriteLine(" Contents of debtToIncome is: ");
            WriteArray(debtToIncome);

            //Debug.WriteLine(" Contents of previousDefault is: ");
            //WriteArray(previousDefault);

        }

        private void WriteArray(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                Debug.WriteLine("value of element at index {0} is  {1} ", i, intArray[i]);

            }
            Debug.WriteLine("======================================== ");
        }
        
        private void WriteArray(double[] doubleArray)
        {
            for (int i = 0; i < doubleArray.Length; i++)
            {
                Debug.WriteLine("value of element at index {0} is  {1} ", i, doubleArray[i]);

            }
            Debug.WriteLine("======================================== ");
        }

        private void LinearRegressionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // When the user click the linear Regration radio button make invisible all the other
            // charts and group boxes is not used.
            VarEqualCheckBox.Visible = false;
            DistributionChart.Visible = false;
            T_testResultsGroup.Visible = false;
            AnovagroupBox.Visible = false;
        } // End of the linear Regrassion Radio buttom code.

        private void tTestRadioButton_CheckedChanged(object sender, EventArgs e)
        {              

            // I add one additional feature to my t test to give the user the chance select if they want to make the test 
            // assuming that the variance is equal or not.
            VarEqualCheckBox.Visible = true;

            // When the user click the ratio buttons of a specific test change the visibility of the element 
            LinearChart.Visible = false;
            AnovagroupBox.Visible = false;
            LinearRegrationgroupBox.Visible = false;

        }// End of the T.test Ratio button code.     

        private void AnovaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // When the user click the linear Regration radio button make invisible all the other
            // charts and group boxes is not used.
            VarEqualCheckBox.Visible = false;
            DistributionChart.Visible = false;
            T_testResultsGroup.Visible = false;
            LinearRegrationgroupBox.Visible = false;
            LinearChart.Visible = false;
        } // End of Anova Radio Button code.

        private void TestResultButton_Click(object sender, EventArgs e)
        {

            if (LinearRegressionRadioButton.Checked)
            {
                // Change the location of the LinearChart
                this.LinearChart.Location = new Point(19, 99);
                this.LinearChart.Size = new Size(495, 408); // Change the size of the plot manually.

                this.LinearRegrationgroupBox.Location = new Point(515, 207);
                this.LinearRegrationgroupBox.Size = new Size(168, 162);

                LinearChart.Visible = true; // Make linear Regration chart Visible when the test result clicked.
                LinearRegrationgroupBox.Visible = true; // Make the linear Regration groupbox visible

                // load the alpha and the beta in a text boxes used later for the linear regration
                //formula which is y = bx + a 
                double beta = Model.beta(income, creditCardDebt);
               // betaintercept.Text = beta.ToString("n5");
                double alpha = Model.alpha(income, creditCardDebt);
                //alphaSlope.Text = alpha.ToString("n4");

                // Write the results of the slope and the intersept on a label. Additionally i Add the linear regression Type.
                SlopeLabel.Text =  beta.ToString("n4");
                InterceptLabel.Text = alpha.ToString("n4");
                LinearRegrassionTypeLabel.Text = $"y = {beta.ToString("n4")}x + {alpha.ToString("n4")}";
         


                // I plot the linear Regression line using a for statement and a formula method 
                // I produced in the Linear regression class
                LinearChart.Series[1].Points.DataBindXY(income, creditCardDebt);
                for (int i = 0; i < creditCardDebt.Length; i++)
                {
                    // This statement produse the plot.
                    LinearChart.Series[0].Points.AddXY(income[i], Model.LinearRegressionFormula(income, creditCardDebt, income[i]));
                }
                 
                // I put a title to the two axis of the plot.
                LinearChart.ChartAreas[0].AxisX.Title = "Income";
                LinearChart.ChartAreas[0].AxisY.Title = "Credit Card Debt";

            } // End of linear Regression Code.

            else if (tTestRadioButton.Checked)
            {
                // Here is the T test part of the test Results Button 

                //Change the location and the size of the Distribution chart manualy.
                this.DistributionChart.Location = new Point(330, 99);
                this.DistributionChart.Size = new Size(462, 403);


                // //Change the location and the size of the T test results manualy.
                this.T_testResultsGroup.Location = new Point(19, 160);
                this.T_testResultsGroup.Size = new Size(328, 223);

                // Make visible and unvisible the Group boxes and the charts I need for the statistics.
                LinearChart.Visible = false;
                AnovagroupBox.Visible = false;
                T_testResultsGroup.Visible = true;
                DistributionChart.Visible = true;

                // Building the two new arrays in order to put separate the two factors to new arrays.
                double[] factor0 = new double[test.GroupNumberLength(previousDefault, 0)];
                double[] factor1 = new double[test.GroupNumberLength(previousDefault, 1)];

                // Separating the factor 0 and 1 from education array using the method and put i in a new arrays.
                factor0 = test.SeparatioOfGroupsArrays(debtToIncome, previousDefault, 0);
                factor1 = test.SeparatioOfGroupsArrays(debtToIncome, previousDefault, 1);

                if (VarEqualCheckBox.Checked)
                {
                    // The program give the option with a check box to the user make the T test 
                    // using the formulas when the Variance of two factors are Equal.

                   

                    // Mean Of the t test groups.
                    Mean0FacLabel.Text = stat.Mean(factor0).ToString("n3");
                    Mean1FacLabel.Text = stat.Mean(factor1).ToString("n3");


                    // Calculate the Standard Deviation of the t test groups.
                    double sd0 = stat.StandardDeviation(factor0);
                    sd0FacLabel.Text = sd0.ToString("n5"); // Place it in the correct text box with 5 decimal places.
                    double sd1 = stat.StandardDeviation(factor1);
                    sd1FacLabel.Text = sd1.ToString("n5"); // Place it in the correct text box with 5 decimal places.



                    // Calculate the Number of elements in each group.
                    double n0 = test.GroupNumberLength(previousDefault, 0);
                    double n1 = test.GroupNumberLength(previousDefault, 1);
                    elementsNumber0FacLabel.Text = n0.ToString(); // Add the 0 leabed factor the the text box "elementsNumber0FacLabel"                  
                    elementsNumber1FacLabel.Text = n1.ToString(); //Add the 1 leabed factor the the text box "elementsNumber1FacLabel"



                    // Calculate degrees of freedom for the variables ask in the Coursework.
                    double df;
                    df = test.DegreesOfFreedom(debtToIncome, previousDefault);
                    dfLabel.Text = df.ToString();


                    // Here I calculate the defference of the mean the two groups has and add the result to the MeanDiffLabel text box.
                    double mean_deff = stat.Mean(factor0) - stat.Mean(factor1);
                    MeanDiffLabel.Text = mean_deff.ToString("n4");


                    //Display the Standard error as se0 for factor 0 , as se1 the factor 1 and as se the unequal variance se using the formula.
                    double se0 = Math.Pow(stat.StandardDeviation(factor0), 2) / (double) factor0.Length;
                    double se1 = Math.Pow(stat.StandardDeviation(factor1), 2) / (double) factor1.Length;
                    double se = Math.Sqrt((((((double)(n0 - 1.0)) * Math.Pow(sd0, 2)) + (double)(n1 - 1.0) * Math.Pow(sd1, 2)) / (double)(n0 + n1 - 2.0)) * ((1.0 / (double)n0) + (1.0 / (double)n1)));
                    

                    setextBox.Text = se.ToString("n5"); //Write the standard error of the unequal model of variance.
                    Se0Label.Text = Math.Sqrt(se0).ToString("n5"); // Write the Standar errod of the Factor 0 on a label
                    Se1Label.Text = Math.Sqrt(se1).ToString("n5"); // Write the Standar error of the factor 1 on a label

                    // Calculating the t value and add it th the tValueLabel with 4 desimal places.
                    double t_value = mean_deff / se;
                    tValueLabel.Text = t_value.ToString("n5");

                    
                    DistributionChart.Series[4].Points.Clear();// Clear the old p value when the user make again the test
                    DistributionChart.Series[1].Points.Clear(); // Clear the unequal variance t value.
                    DistributionChart.Series[4].Points.AddXY(t_value, 0); // Visualize the specific t value when the user select to represent
                    // the Equal Variance t value.
                }
                else
                {
                    
                    // The Unequal varience test and the results will be displayed under here.
                    // Mean Of the t test groups.
                    Mean0FacLabel.Text = stat.Mean(factor0).ToString("n3");
                    Mean1FacLabel.Text = stat.Mean(factor1).ToString("n3");



                    // Sd of the t test groups.
                    sd0FacLabel.Text = stat.StandardDeviation(factor0).ToString("n5");
                    sd1FacLabel.Text = stat.StandardDeviation(factor1).ToString("n5");



                    // Number of elements in each group.
                    elementsNumber0FacLabel.Text = (factor0.Length).ToString();
                    elementsNumber1FacLabel.Text = (factor1.Length).ToString();


                    // Calculate degrees of freedom for the variables ask in the Coursework.
                    double df;
                    df = test.DegreesOfFreedom(debtToIncome, previousDefault);
                    dfLabel.Text = test.DegreesOfFreedom(debtToIncome, previousDefault).ToString();

                    // Calulate the mean of diference 
                    double mean_deff = stat.Mean(test.SeparatioOfGroupsArrays(debtToIncome, previousDefault, 0)) - stat.Mean(test.SeparatioOfGroupsArrays(debtToIncome, previousDefault, 1));
                    MeanDiffLabel.Text = mean_deff.ToString("n4");

                    // Display the Standard error as se0 for factor 0 , as se1 the factor 1 and as se the unequal variance se using the formula.
                    double se0 = Math.Pow(stat.StandardDeviation(factor0), 2) / (double) factor0.Length;
                    double se1 = Math.Pow(stat.StandardDeviation(factor1), 2) / (double) factor1.Length;
                    double se = Math.Sqrt(se0 + se1);

                    setextBox.Text = se.ToString("n5"); //Write the standard error of the unequal model of variance.
                    Se0Label.Text = Math.Sqrt(se0).ToString("n5"); // Write the Standar errod of the Factor 0 on a label
                    Se1Label.Text = Math.Sqrt(se1).ToString("n5"); // Write the Standar error of the factor 1 on a label

                    double t_value = mean_deff / se;
                    tValueLabel.Text = t_value.ToString("n5");

                    DistributionChart.Series[1].Points.Clear(); // clear the old result of point if the user remake the test.
                    DistributionChart.Series[4].Points.Clear(); // Clear the equal varience t value.
                    DistributionChart.Series[1].Points.AddXY(t_value, 0);   // Add the t value point in the graph.               
                }

                // Here I plot the three distributions (the two factor labed as 0 and 1 and the whole data Arrays), 
                // which it the same for both Equal and Unequal formulas.
                //
                // Clear the old data before replot it.
                DistributionChart.Series[0].Points.Clear();
                DistributionChart.Series[2].Points.Clear();
                DistributionChart.Series[3].Points.Clear();
                // The firts for statement is for the whole data distribution
                for (int i = 0; i < debtToIncome.Length; i++)
                {
                    double var = stat.Variance(debtToIncome);//Calulate the Variance of the Array.
                    double mean = stat.Mean(debtToIncome); //Calulate the Mean of the Array.
                    double sd = stat.StandardDeviation(debtToIncome); //Calulate the Standard Deviation of the Array.
                    double x0 = debtToIncome.Min() - 50; //Calulate the min of the Array and substract by 50 in order to have the whole curve.
                    double x1 = debtToIncome.Max(); //Calulate the max of the Array

                    double x = x0 + (x1 - x0) * i / debtToIncome.Length - 1; // i use this fromula to compute the x value 
                    // And I use the representation under to visualize the point using as x the fromula and as y the distribution formula.
                    DistributionChart.Series[0].Points.AddXY(x, 1.0 / Math.Sqrt(2 * Math.PI * var) * Math.Exp(-(x - mean) * (x - mean) / 2 / var));

                } //End of whole data Distirbution

                // I repeat the same for statement two more time in order to represent the groups curve using the same formulas 
                // Additionally , I use the Separation function to take only the 1 label and the 0 label from the factor variable
                //  The result coming from the same formulas.
                for (int i = 0; i < test.SeparatioOfGroupsArrays(debtToIncome, previousDefault, 1).Length; i++)
                {
                    double var = stat.Variance(test.SeparatioOfGroupsArrays(debtToIncome, previousDefault, 1));
                    double mean = stat.Mean(test.SeparatioOfGroupsArrays(debtToIncome, previousDefault, 1));
                    double sd = stat.StandardDeviation(test.SeparatioOfGroupsArrays(debtToIncome, previousDefault, 1));
                    double x0 = test.SeparatioOfGroupsArrays(debtToIncome, previousDefault, 1).Min() - 50;
                    double x1 = test.SeparatioOfGroupsArrays(debtToIncome, previousDefault, 1).Max();

                    double x = x0 + (x1 - x0) * i / (test.SeparatioOfGroupsArrays(debtToIncome, previousDefault, 1).Length - 1);
                    DistributionChart.Series[2].Points.AddXY(x, 1.0 / Math.Sqrt(2 * Math.PI * var) * Math.Exp(-(x - mean) * (x - mean) / 2 / var));

                } //End of 1 factor Distirbution

                // This is the third Distripution Which respresent the other factor 0 on the graph. The eplanation is the same 
                // As the above and for that reason omitted.
                for (int i = 0; i < test.SeparatioOfGroupsArrays(debtToIncome, previousDefault, 0).Length; i++)
                {
                    double var = stat.Variance(test.SeparatioOfGroupsArrays(debtToIncome, previousDefault, 0));
                    double mean = stat.Mean(test.SeparatioOfGroupsArrays(debtToIncome, previousDefault, 0));
                    double sd = stat.StandardDeviation(test.SeparatioOfGroupsArrays(debtToIncome, previousDefault, 0));
                    double x0 = test.SeparatioOfGroupsArrays(debtToIncome, previousDefault, 0).Min() - 50;
                    double x1 = test.SeparatioOfGroupsArrays(debtToIncome, previousDefault, 0).Max();

                    double x = x0 + (x1 - x0) * i / (test.SeparatioOfGroupsArrays(debtToIncome, previousDefault, 0).Length - 1);
                    DistributionChart.Series[3].Points.AddXY(x, 1.0 / Math.Sqrt(2 * Math.PI * var) * Math.Exp(-(x - mean) * (x - mean) / 2 / var));

                } //End of 0 factor Distirbution
            } // End of T.test code.

            else
            {
                // Anova Test if Statement Part.
                
                this.AnovagroupBox.Location = new Point(44, 108); //Change the location of the group box.
                this.AnovagroupBox.Size = new Size(506, 239); //change the size of the Anovagroupbox.


                //Change the visibility of the elements.
                AnovagroupBox.Visible = true;
                DistributionChart.Visible = false;
                T_testResultsGroup.Visible = false;
                LinearChart.Visible = false;

                // Build the new groups arrays.
                double[] n0 = new double[test.GroupNumberLength(education, 1)];
                double[] n1 = new double[test.GroupNumberLength(education, 2)];
                double[] n2 = new double[test.GroupNumberLength(education, 3)];
                double[] n3 = new double[test.GroupNumberLength(education, 4)];
                double[] n4 = new double[test.GroupNumberLength(education, 5)];

                // Separate all the Factors from the array
                n0 = test.SeparatioOfGroupsArrays(income, education, 1);
                n1 = test.SeparatioOfGroupsArrays(income, education, 2);
                n2 = test.SeparatioOfGroupsArrays(income, education, 3);
                n3 = test.SeparatioOfGroupsArrays(income, education, 4);
                n4 = test.SeparatioOfGroupsArrays(income, education, 5);
                

                // Calculate the Mean of the factors from the separates Arrays
                double mean0 = stat.Mean(n0);
                double mean1 = stat.Mean(n1);
                double mean2 = stat.Mean(n2);
                double mean3 = stat.Mean(n3);
                double mean4 = stat.Mean(n4);                
                

                //Write the mean for each category on a text box.
                AnovaMean0textBox.Text = mean0.ToString("n4");
                AnovaMean1textBox.Text = mean1.ToString("n4");
                AnovaMean2textBox.Text = mean2.ToString("n4");
                AnovaMean3textBox.Text = mean3.ToString("n4");
                AnovaMean4textBox.Text = mean4.ToString("n4");
                

                // Calculate the mean of the whole sample Array (grand mean)
                double meanTotal = stat.Mean(income);


                // Write the total mean on a text box.
                AnovaMeanTotaltextBox1.Text = meanTotal.ToString("n3");

                // Write the length of each group and the total
                n0textbox.Text = n0.Length.ToString();
                n1textbox.Text = n1.Length.ToString();
                n2textbox.Text = n2.Length.ToString();
                n3textbox.Text = n3.Length.ToString();
                n4textbox.Text = n4.Length.ToString();
                nTotaltextbox.Text = income.Length.ToString();



                //** Total sum of squares ** for whole data
                double[] Squares = new double[income.Length];
                for (int i = 0; i< income.Length; i++)
                {
                    Squares[i] = Math.Pow(income[i],2);
                }
                double sumSquares = stat.Sum(Squares);


                //** Group sum of squares **
                double Sum_group_Squares = n0.Length * Math.Pow((mean0 - meanTotal), 2) +
                    n1.Length * Math.Pow((mean1 - meanTotal), 2) +
                    n2.Length * Math.Pow((mean2 - meanTotal), 2) +
                    n3.Length * Math.Pow((mean3 - meanTotal), 2) +
                    n4.Length * Math.Pow((mean4 - meanTotal), 2);

                //Write the result to the textbox.
                SumOfGroupSquareLabel.Text = Sum_group_Squares.ToString("n3");
                    
                
                
                //** Residual sum of squares **
                // Using direct calulation formula given in MATH500 class. I produce a formula calculate the mean squart minus a number and i call it here to 
                // compute the Residual Sum of squares.
                double ss_residual = stat.SumOfSquaresMinusMean(n0) + 
                    stat.SumOfSquaresMinusMean(n1) +                    
                    stat.SumOfSquaresMinusMean(n2) +
                    stat.SumOfSquaresMinusMean(n3) + 
                    stat.SumOfSquaresMinusMean(n4);

                // ** Write the results of the squers at the textbox.**
                ResedualSumOfSquarLabel.Text = ss_residual.ToString("n2");
                
                
                //** Degrees of freedom **
                //Degrees of freedom corresponding to group
                int n_of_groups = 5;
                int  degrees_freedom_Group = n_of_groups - 1;
                dfGrouptextBox.Text = degrees_freedom_Group.ToString("n0");


                // Degrees of freedom corresponding to residuals
                int degrees_freedom_Residuals = income.Length - n_of_groups; //Total sample size - number of groups
                dfResidualstextBox.Text = degrees_freedom_Residuals.ToString("n0");


                //**Group mean square **
                double Mean_Square_Group  = Sum_group_Squares / degrees_freedom_Group;
                MeanSquaretextbox.Text = Mean_Square_Group.ToString("n4"); 
                

                // ** Residual mean square **
                double Mean_Square_Residuals = ss_residual / degrees_freedom_Residuals;
                MeanSquareResedualstextBox.Text = Mean_Square_Residuals.ToString("n2");


                // ** F-value **
                double F_value = Mean_Square_Group / Mean_Square_Residuals;
                FvaluetextBox.Text = F_value.ToString("n4");
                
            } // end of the Anova Code

        } // End of the Test Results Button.

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close(); // The exit button close the programm with this code.
        } // End of exit button code.

        private void cleanbutton_Click(object sender, EventArgs e)
        {
            // Clean all the charts in order to update the data.
            // And makes the program to looks like starting again.

            // Cler the plots series and visibility
            DistributionChart.Series[0].Points.Clear();
            DistributionChart.Series[1].Points.Clear();
            DistributionChart.Series[2].Points.Clear();
            DistributionChart.Series[3].Points.Clear();
            DistributionChart.Series[4].Points.Clear();
            DistributionChart.Visible = false;
            LinearChart.Series[0].Points.Clear();
            LinearChart.Series[1].Points.Clear();
            LinearChart.Visible = false;

            // Actually i am not clearing the elements of the boxes 
            // I just made it invisible to the user this is because this data
            // does not change. For that reason the program creates the illution to the user 
            // that clean also this data.
            T_testResultsGroup.Visible = false;
            AnovagroupBox.Visible = false;    
            
        }   // End of clear button code. 

       
    }  // end StatisticsForm
}
