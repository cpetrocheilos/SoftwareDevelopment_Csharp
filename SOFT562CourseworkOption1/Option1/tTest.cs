using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option1
{
    public class tTest : Statistics
    {
        public double DegreesOfFreedom(double[] dependent , int[] independentfactor)
        {
            // Because the t test is for 2 groups we need to know the number of each group
            // This method calculate the degree of freedom of a t.test using the Mathimatical 
            // Formula df = N1 - N2 - 2 
            int n1Facor = 0, n2Factor = 0;

            
            for (int i = 0; i < independentfactor.Length; i++)
            {
                if (independentfactor[i] == 0)
                {
                    n1Facor += 1;
                }
                else
                {
                    n2Factor += 1;
                }
            }
            
            double df = n1Facor + n2Factor - 2;

            return df;

        } //End of degrees of freedom method       
       
        public double[] SeparatioOfGroupsArrays(double[] dependent, int[] independentFactor, int groupLabel)
        {
            int length; // we calculate the length of the new output Array.

            // Using the GroupNumberLength method I calculate how many element of groupLabel are in the endependent factor array.
            length = GroupNumberLength(independentFactor, groupLabel);
            
            // I create the output array with the length I found from the above function.
            double[] group = new double[length]; 


                int j = 0; // this keepes the position of the new array while the for loop fill the array.
                for (int i = 0; i < dependent.Length; i++)               
                {
                    // The if statement check if the independentFactor contains the group label thw user ask for.
                    if (independentFactor[i] == groupLabel)
                    {
                        // If the statement is true the we save the value of the dependend to group variable
                        group[j] = dependent[i];
                        j++; // Add one to the group posision keeper.
                    }
                    
                }

            return group;        
           
        } // end of group separation method.

        public int GroupNumberLength(int[] indepentendfactor, int GroupLabel)
        {
            int nFactor = 0;
            for (int i = 0; i < indepentendfactor.Length; i++)
            {
                if (indepentendfactor[i] == GroupLabel)
                {
                    nFactor += 1;
                }
            }
            return nFactor;
        } // end of group members counter.    
    }
}
