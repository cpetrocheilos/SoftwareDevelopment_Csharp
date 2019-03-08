using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Option1
{

    /// <summary>
    /// class DataLoader
    /// Loads and holds the data needed for the SOFT562 assignment
    /// Not all the data series are needed for the SOFT562 assignment in 2017
    /// </summary>
    class DataLoader
    {
        private List<int> ageList; 
        private List<int> edList;
        private List<int> employList; 
        private List<int> addressList;
        private List<double> incomeList;
        private List<double> debtincList;
        private List<double> creddebtList;
        private List<double> othdebtList;
        private List<int> previousDefaultList;

        public DataLoader()
        {
            CreateDataLists();
        }

        private void CreateDataLists()
        {

            ageList = new List<int>();
            edList = new List<int>();
            employList = new List<int>();
            addressList = new List<int>();
            incomeList = new List<double>();
            debtincList = new List<double>();
            creddebtList = new List<double>();
            othdebtList = new List<double>();
            previousDefaultList = new List<int>();
        }


        public void LoadData()
        {
            String fileName;

            fileName = "Bank Loan data.csv";

            CreateDataLists();

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    // first line is the column headings, so ignore this line
                    reader.ReadLine();

                    while (!reader.EndOfStream)
                    {
                        ProcessLine(reader.ReadLine());
                    }
                }  // end using
            }
            catch (FileNotFoundException ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }  // end LoadData()


        /// <summary>
        /// Take a line from the file and seperate into component parts
        /// befor adding each part to the data lists
        /// </summary>
        /// <param name="lineFromFile"></param>
        private void ProcessLine(String lineFromFile)
        {
            String[] columns;

            char[] delimiter = { ',' };

            columns = lineFromFile.Split(delimiter);

            // data is in form of:
            // age,ed,employ,address,income,debtinc,creddebt,othdebt,default
            try
            {
                ageList.Add(Convert.ToInt32(columns[0].Trim()));
                edList.Add(Convert.ToInt32(columns[1].Trim()));
                employList.Add(Convert.ToInt32(columns[2].Trim()));
                addressList.Add(Convert.ToInt32(columns[3].Trim()));
                incomeList.Add(Convert.ToDouble(columns[4].Trim()));
                debtincList.Add(Convert.ToDouble(columns[5].Trim()));
                creddebtList.Add(Convert.ToDouble(columns[6].Trim()));
                othdebtList.Add(Convert.ToDouble(columns[7].Trim()));
                previousDefaultList.Add(Convert.ToInt32(columns[8].Trim()));
            }
            catch (FormatException ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        } // end ProcessLine();



        //  public methods to access the 
        // data lists as an array
        public int[] GetEdArray()
        {
            return edList.ToArray();
        }


        public double[] GetIncomeArray()
        {
            return incomeList.ToArray();
        }

        public double[] GetDebtincArray()
        {
            return debtincList.ToArray();
        }

        public double[] GetCreddebtArray()
        {
            return creddebtList.ToArray();
        }



        public int[] GetPreviousDefaulArray()
        {
            return previousDefaultList.ToArray();
        }



        // not used
        //public int[] GetAgeArray()
        //{
        //    return ageList.ToArray();
        //}

        // not used
        //public int[] GetEmployArray()
        //{
        //    return employList.ToArray();
        //}

        // not used
        //public int[] GetAddresArray()
        //{
        //    return addressList.ToArray();
        //}

        // not used
        //public double[] GetOthdebtArray()
        //{
        //    return othdebtList.ToArray();
        //}
    }
}
