using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreenGagesGreenCenterTests
{
    [TestClass()]
    public class GreengagesGardenCenter : SqlDatabaseTestClass
    {

        public GreengagesGardenCenter()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        [TestMethod]
        public void InsertCustomersTest()
        {
            SqlDatabaseTestActions testActions = this.InsertCustomersTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        [TestMethod()]
        public void ImportSupplierTest()
        {
            SqlDatabaseTestActions testActions = this.ImportSupplierTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void ImportProductTest()
        {
            SqlDatabaseTestActions testActions = this.ImportProductTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void UpdateProductQuantityTORetailLocationTest()
        {
            SqlDatabaseTestActions testActions = this.UpdateProductQuantityTORetailLocationTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void AddNewProductType()
        {
            SqlDatabaseTestActions testActions = this.AddNewProductTypeData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void AddNewProductLocation()
        {
            SqlDatabaseTestActions testActions = this.AddNewProductLocationData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void AddNewSeasonTest()
        {
            SqlDatabaseTestActions testActions = this.AddNewSeasonTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void CheckProductsTriger()
        {
            SqlDatabaseTestActions testActions = this.CheckProductsTrigerData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void CheckSuppliersTriggerTest()
        {
            SqlDatabaseTestActions testActions = this.CheckSuppliersTriggerTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void WarehouseCheckProsedureTest()
        {
            SqlDatabaseTestActions testActions = this.WarehouseCheckProsedureTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void StockIdconcatinationTest()
        {
            SqlDatabaseTestActions testActions = this.StockIdconcatinationTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction InsertCustomersTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GreengagesGardenCenter));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction InsertCustomersTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction InsertCustomersTest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ImportSupplierTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ImportSupplierTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ImportSupplierTest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ImportProductTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ImportProductTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ImportProductTest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction UpdateProductQuantityTORetailLocationTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction UpdateProductQuantityTORetailLocationTest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddNewProductType_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddNewProductType_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddNewProductType_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddNewProductLocation_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddNewProductLocation_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction UpdateProductQuantityTORetailLocationTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddNewProductLocation_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddNewSeasonTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddNewSeasonTest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition8;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddNewSeasonTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction CheckProductsTriger_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction CheckProductsTriger_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition9;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction CheckProductsTriger_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition10;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction CheckSuppliersTriggerTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition8;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction CheckSuppliersTriggerTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction CheckSuppliersTriggerTest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition12;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction WarehouseCheckProsedureTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition9;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction WarehouseCheckProsedureTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction WarehouseCheckProsedureTest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition11;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StockIdconcatinationTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition10;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StockIdconcatinationTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition14;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StockIdconcatinationTest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition13;
            this.InsertCustomersTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ImportSupplierTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ImportProductTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.UpdateProductQuantityTORetailLocationTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.AddNewProductTypeData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.AddNewProductLocationData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.AddNewSeasonTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.CheckProductsTrigerData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.CheckSuppliersTriggerTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.WarehouseCheckProsedureTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StockIdconcatinationTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            InsertCustomersTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            InsertCustomersTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            InsertCustomersTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ImportSupplierTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            ImportSupplierTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            ImportSupplierTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            ImportProductTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            ImportProductTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            ImportProductTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            UpdateProductQuantityTORetailLocationTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            UpdateProductQuantityTORetailLocationTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            AddNewProductType_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            AddNewProductType_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            AddNewProductType_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            AddNewProductLocation_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            AddNewProductLocation_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            UpdateProductQuantityTORetailLocationTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            AddNewProductLocation_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            AddNewSeasonTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            AddNewSeasonTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition8 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            AddNewSeasonTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            CheckProductsTriger_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            CheckProductsTriger_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition9 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            CheckProductsTriger_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition10 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            CheckSuppliersTriggerTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition8 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            CheckSuppliersTriggerTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            CheckSuppliersTriggerTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition12 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            WarehouseCheckProsedureTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition9 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            WarehouseCheckProsedureTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            WarehouseCheckProsedureTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition11 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            StockIdconcatinationTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition10 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            StockIdconcatinationTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition14 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            StockIdconcatinationTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition13 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            // 
            // InsertCustomersTest_TestAction
            // 
            InsertCustomersTest_TestAction.Conditions.Add(rowCountCondition1);
            resources.ApplyResources(InsertCustomersTest_TestAction, "InsertCustomersTest_TestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 1;
            // 
            // InsertCustomersTest_PretestAction
            // 
            resources.ApplyResources(InsertCustomersTest_PretestAction, "InsertCustomersTest_PretestAction");
            // 
            // InsertCustomersTest_PosttestAction
            // 
            InsertCustomersTest_PosttestAction.Conditions.Add(rowCountCondition2);
            resources.ApplyResources(InsertCustomersTest_PosttestAction, "InsertCustomersTest_PosttestAction");
            // 
            // rowCountCondition2
            // 
            rowCountCondition2.Enabled = true;
            rowCountCondition2.Name = "rowCountCondition2";
            rowCountCondition2.ResultSet = 1;
            rowCountCondition2.RowCount = 1;
            // 
            // ImportSupplierTest_TestAction
            // 
            ImportSupplierTest_TestAction.Conditions.Add(inconclusiveCondition1);
            resources.ApplyResources(ImportSupplierTest_TestAction, "ImportSupplierTest_TestAction");
            // 
            // inconclusiveCondition1
            // 
            inconclusiveCondition1.Enabled = true;
            inconclusiveCondition1.Name = "inconclusiveCondition1";
            // 
            // ImportSupplierTest_PretestAction
            // 
            resources.ApplyResources(ImportSupplierTest_PretestAction, "ImportSupplierTest_PretestAction");
            // 
            // ImportSupplierTest_PosttestAction
            // 
            resources.ApplyResources(ImportSupplierTest_PosttestAction, "ImportSupplierTest_PosttestAction");
            // 
            // ImportProductTest_TestAction
            // 
            ImportProductTest_TestAction.Conditions.Add(inconclusiveCondition2);
            resources.ApplyResources(ImportProductTest_TestAction, "ImportProductTest_TestAction");
            // 
            // inconclusiveCondition2
            // 
            inconclusiveCondition2.Enabled = true;
            inconclusiveCondition2.Name = "inconclusiveCondition2";
            // 
            // ImportProductTest_PretestAction
            // 
            resources.ApplyResources(ImportProductTest_PretestAction, "ImportProductTest_PretestAction");
            // 
            // ImportProductTest_PosttestAction
            // 
            resources.ApplyResources(ImportProductTest_PosttestAction, "ImportProductTest_PosttestAction");
            // 
            // UpdateProductQuantityTORetailLocationTest_TestAction
            // 
            UpdateProductQuantityTORetailLocationTest_TestAction.Conditions.Add(inconclusiveCondition3);
            resources.ApplyResources(UpdateProductQuantityTORetailLocationTest_TestAction, "UpdateProductQuantityTORetailLocationTest_TestAction");
            // 
            // inconclusiveCondition3
            // 
            inconclusiveCondition3.Enabled = true;
            inconclusiveCondition3.Name = "inconclusiveCondition3";
            // 
            // UpdateProductQuantityTORetailLocationTest_PosttestAction
            // 
            UpdateProductQuantityTORetailLocationTest_PosttestAction.Conditions.Add(scalarValueCondition2);
            resources.ApplyResources(UpdateProductQuantityTORetailLocationTest_PosttestAction, "UpdateProductQuantityTORetailLocationTest_PosttestAction");
            // 
            // scalarValueCondition2
            // 
            scalarValueCondition2.ColumnNumber = 3;
            scalarValueCondition2.Enabled = true;
            scalarValueCondition2.ExpectedValue = "23";
            scalarValueCondition2.Name = "scalarValueCondition2";
            scalarValueCondition2.NullExpected = false;
            scalarValueCondition2.ResultSet = 1;
            scalarValueCondition2.RowNumber = 1;
            // 
            // AddNewProductType_TestAction
            // 
            AddNewProductType_TestAction.Conditions.Add(inconclusiveCondition4);
            resources.ApplyResources(AddNewProductType_TestAction, "AddNewProductType_TestAction");
            // 
            // inconclusiveCondition4
            // 
            inconclusiveCondition4.Enabled = true;
            inconclusiveCondition4.Name = "inconclusiveCondition4";
            // 
            // AddNewProductType_PretestAction
            // 
            AddNewProductType_PretestAction.Conditions.Add(rowCountCondition3);
            resources.ApplyResources(AddNewProductType_PretestAction, "AddNewProductType_PretestAction");
            // 
            // rowCountCondition3
            // 
            rowCountCondition3.Enabled = true;
            rowCountCondition3.Name = "rowCountCondition3";
            rowCountCondition3.ResultSet = 1;
            rowCountCondition3.RowCount = 7;
            // 
            // AddNewProductType_PosttestAction
            // 
            AddNewProductType_PosttestAction.Conditions.Add(rowCountCondition4);
            resources.ApplyResources(AddNewProductType_PosttestAction, "AddNewProductType_PosttestAction");
            // 
            // rowCountCondition4
            // 
            rowCountCondition4.Enabled = true;
            rowCountCondition4.Name = "rowCountCondition4";
            rowCountCondition4.ResultSet = 1;
            rowCountCondition4.RowCount = 8;
            // 
            // AddNewProductLocation_TestAction
            // 
            AddNewProductLocation_TestAction.Conditions.Add(inconclusiveCondition5);
            resources.ApplyResources(AddNewProductLocation_TestAction, "AddNewProductLocation_TestAction");
            // 
            // inconclusiveCondition5
            // 
            inconclusiveCondition5.Enabled = true;
            inconclusiveCondition5.Name = "inconclusiveCondition5";
            // 
            // AddNewProductLocation_PretestAction
            // 
            AddNewProductLocation_PretestAction.Conditions.Add(rowCountCondition5);
            resources.ApplyResources(AddNewProductLocation_PretestAction, "AddNewProductLocation_PretestAction");
            // 
            // rowCountCondition5
            // 
            rowCountCondition5.Enabled = true;
            rowCountCondition5.Name = "rowCountCondition5";
            rowCountCondition5.ResultSet = 1;
            rowCountCondition5.RowCount = 6;
            // 
            // UpdateProductQuantityTORetailLocationTest_PretestAction
            // 
            UpdateProductQuantityTORetailLocationTest_PretestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(UpdateProductQuantityTORetailLocationTest_PretestAction, "UpdateProductQuantityTORetailLocationTest_PretestAction");
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 3;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "3";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // AddNewProductLocation_PosttestAction
            // 
            AddNewProductLocation_PosttestAction.Conditions.Add(rowCountCondition6);
            resources.ApplyResources(AddNewProductLocation_PosttestAction, "AddNewProductLocation_PosttestAction");
            // 
            // rowCountCondition6
            // 
            rowCountCondition6.Enabled = true;
            rowCountCondition6.Name = "rowCountCondition6";
            rowCountCondition6.ResultSet = 1;
            rowCountCondition6.RowCount = 7;
            // 
            // AddNewSeasonTest_TestAction
            // 
            AddNewSeasonTest_TestAction.Conditions.Add(inconclusiveCondition6);
            resources.ApplyResources(AddNewSeasonTest_TestAction, "AddNewSeasonTest_TestAction");
            // 
            // inconclusiveCondition6
            // 
            inconclusiveCondition6.Enabled = true;
            inconclusiveCondition6.Name = "inconclusiveCondition6";
            // 
            // AddNewSeasonTest_PosttestAction
            // 
            AddNewSeasonTest_PosttestAction.Conditions.Add(rowCountCondition8);
            resources.ApplyResources(AddNewSeasonTest_PosttestAction, "AddNewSeasonTest_PosttestAction");
            // 
            // rowCountCondition8
            // 
            rowCountCondition8.Enabled = true;
            rowCountCondition8.Name = "rowCountCondition8";
            rowCountCondition8.ResultSet = 1;
            rowCountCondition8.RowCount = 7;
            // 
            // AddNewSeasonTest_PretestAction
            // 
            AddNewSeasonTest_PretestAction.Conditions.Add(rowCountCondition7);
            resources.ApplyResources(AddNewSeasonTest_PretestAction, "AddNewSeasonTest_PretestAction");
            // 
            // rowCountCondition7
            // 
            rowCountCondition7.Enabled = true;
            rowCountCondition7.Name = "rowCountCondition7";
            rowCountCondition7.ResultSet = 1;
            rowCountCondition7.RowCount = 5;
            // 
            // CheckProductsTriger_TestAction
            // 
            CheckProductsTriger_TestAction.Conditions.Add(inconclusiveCondition7);
            resources.ApplyResources(CheckProductsTriger_TestAction, "CheckProductsTriger_TestAction");
            // 
            // inconclusiveCondition7
            // 
            inconclusiveCondition7.Enabled = true;
            inconclusiveCondition7.Name = "inconclusiveCondition7";
            // 
            // CheckProductsTriger_PretestAction
            // 
            CheckProductsTriger_PretestAction.Conditions.Add(rowCountCondition9);
            resources.ApplyResources(CheckProductsTriger_PretestAction, "CheckProductsTriger_PretestAction");
            // 
            // rowCountCondition9
            // 
            rowCountCondition9.Enabled = true;
            rowCountCondition9.Name = "rowCountCondition9";
            rowCountCondition9.ResultSet = 1;
            rowCountCondition9.RowCount = 5;
            // 
            // CheckProductsTriger_PosttestAction
            // 
            CheckProductsTriger_PosttestAction.Conditions.Add(rowCountCondition10);
            resources.ApplyResources(CheckProductsTriger_PosttestAction, "CheckProductsTriger_PosttestAction");
            // 
            // rowCountCondition10
            // 
            rowCountCondition10.Enabled = true;
            rowCountCondition10.Name = "rowCountCondition10";
            rowCountCondition10.ResultSet = 1;
            rowCountCondition10.RowCount = 1;
            // 
            // CheckSuppliersTriggerTest_TestAction
            // 
            CheckSuppliersTriggerTest_TestAction.Conditions.Add(inconclusiveCondition8);
            resources.ApplyResources(CheckSuppliersTriggerTest_TestAction, "CheckSuppliersTriggerTest_TestAction");
            // 
            // inconclusiveCondition8
            // 
            inconclusiveCondition8.Enabled = true;
            inconclusiveCondition8.Name = "inconclusiveCondition8";
            // 
            // CheckSuppliersTriggerTest_PretestAction
            // 
            resources.ApplyResources(CheckSuppliersTriggerTest_PretestAction, "CheckSuppliersTriggerTest_PretestAction");
            // 
            // CheckSuppliersTriggerTest_PosttestAction
            // 
            CheckSuppliersTriggerTest_PosttestAction.Conditions.Add(rowCountCondition12);
            resources.ApplyResources(CheckSuppliersTriggerTest_PosttestAction, "CheckSuppliersTriggerTest_PosttestAction");
            // 
            // rowCountCondition12
            // 
            rowCountCondition12.Enabled = true;
            rowCountCondition12.Name = "rowCountCondition12";
            rowCountCondition12.ResultSet = 1;
            rowCountCondition12.RowCount = 1;
            // 
            // WarehouseCheckProsedureTest_TestAction
            // 
            WarehouseCheckProsedureTest_TestAction.Conditions.Add(inconclusiveCondition9);
            resources.ApplyResources(WarehouseCheckProsedureTest_TestAction, "WarehouseCheckProsedureTest_TestAction");
            // 
            // inconclusiveCondition9
            // 
            inconclusiveCondition9.Enabled = true;
            inconclusiveCondition9.Name = "inconclusiveCondition9";
            // 
            // WarehouseCheckProsedureTest_PretestAction
            // 
            resources.ApplyResources(WarehouseCheckProsedureTest_PretestAction, "WarehouseCheckProsedureTest_PretestAction");
            // 
            // WarehouseCheckProsedureTest_PosttestAction
            // 
            WarehouseCheckProsedureTest_PosttestAction.Conditions.Add(rowCountCondition11);
            resources.ApplyResources(WarehouseCheckProsedureTest_PosttestAction, "WarehouseCheckProsedureTest_PosttestAction");
            // 
            // rowCountCondition11
            // 
            rowCountCondition11.Enabled = true;
            rowCountCondition11.Name = "rowCountCondition11";
            rowCountCondition11.ResultSet = 1;
            rowCountCondition11.RowCount = 3;
            // 
            // InsertCustomersTestData
            // 
            this.InsertCustomersTestData.PosttestAction = InsertCustomersTest_PosttestAction;
            this.InsertCustomersTestData.PretestAction = InsertCustomersTest_PretestAction;
            this.InsertCustomersTestData.TestAction = InsertCustomersTest_TestAction;
            // 
            // ImportSupplierTestData
            // 
            this.ImportSupplierTestData.PosttestAction = ImportSupplierTest_PosttestAction;
            this.ImportSupplierTestData.PretestAction = ImportSupplierTest_PretestAction;
            this.ImportSupplierTestData.TestAction = ImportSupplierTest_TestAction;
            // 
            // ImportProductTestData
            // 
            this.ImportProductTestData.PosttestAction = ImportProductTest_PosttestAction;
            this.ImportProductTestData.PretestAction = ImportProductTest_PretestAction;
            this.ImportProductTestData.TestAction = ImportProductTest_TestAction;
            // 
            // UpdateProductQuantityTORetailLocationTestData
            // 
            this.UpdateProductQuantityTORetailLocationTestData.PosttestAction = UpdateProductQuantityTORetailLocationTest_PosttestAction;
            this.UpdateProductQuantityTORetailLocationTestData.PretestAction = UpdateProductQuantityTORetailLocationTest_PretestAction;
            this.UpdateProductQuantityTORetailLocationTestData.TestAction = UpdateProductQuantityTORetailLocationTest_TestAction;
            // 
            // AddNewProductTypeData
            // 
            this.AddNewProductTypeData.PosttestAction = AddNewProductType_PosttestAction;
            this.AddNewProductTypeData.PretestAction = AddNewProductType_PretestAction;
            this.AddNewProductTypeData.TestAction = AddNewProductType_TestAction;
            // 
            // AddNewProductLocationData
            // 
            this.AddNewProductLocationData.PosttestAction = AddNewProductLocation_PosttestAction;
            this.AddNewProductLocationData.PretestAction = AddNewProductLocation_PretestAction;
            this.AddNewProductLocationData.TestAction = AddNewProductLocation_TestAction;
            // 
            // AddNewSeasonTestData
            // 
            this.AddNewSeasonTestData.PosttestAction = AddNewSeasonTest_PosttestAction;
            this.AddNewSeasonTestData.PretestAction = AddNewSeasonTest_PretestAction;
            this.AddNewSeasonTestData.TestAction = AddNewSeasonTest_TestAction;
            // 
            // CheckProductsTrigerData
            // 
            this.CheckProductsTrigerData.PosttestAction = CheckProductsTriger_PosttestAction;
            this.CheckProductsTrigerData.PretestAction = CheckProductsTriger_PretestAction;
            this.CheckProductsTrigerData.TestAction = CheckProductsTriger_TestAction;
            // 
            // CheckSuppliersTriggerTestData
            // 
            this.CheckSuppliersTriggerTestData.PosttestAction = CheckSuppliersTriggerTest_PosttestAction;
            this.CheckSuppliersTriggerTestData.PretestAction = CheckSuppliersTriggerTest_PretestAction;
            this.CheckSuppliersTriggerTestData.TestAction = CheckSuppliersTriggerTest_TestAction;
            // 
            // WarehouseCheckProsedureTestData
            // 
            this.WarehouseCheckProsedureTestData.PosttestAction = WarehouseCheckProsedureTest_PosttestAction;
            this.WarehouseCheckProsedureTestData.PretestAction = WarehouseCheckProsedureTest_PretestAction;
            this.WarehouseCheckProsedureTestData.TestAction = WarehouseCheckProsedureTest_TestAction;
            // 
            // StockIdconcatinationTestData
            // 
            this.StockIdconcatinationTestData.PosttestAction = StockIdconcatinationTest_PosttestAction;
            this.StockIdconcatinationTestData.PretestAction = StockIdconcatinationTest_PretestAction;
            this.StockIdconcatinationTestData.TestAction = StockIdconcatinationTest_TestAction;
            // 
            // StockIdconcatinationTest_TestAction
            // 
            StockIdconcatinationTest_TestAction.Conditions.Add(inconclusiveCondition10);
            resources.ApplyResources(StockIdconcatinationTest_TestAction, "StockIdconcatinationTest_TestAction");
            // 
            // inconclusiveCondition10
            // 
            inconclusiveCondition10.Enabled = true;
            inconclusiveCondition10.Name = "inconclusiveCondition10";
            // 
            // StockIdconcatinationTest_PretestAction
            // 
            StockIdconcatinationTest_PretestAction.Conditions.Add(rowCountCondition14);
            resources.ApplyResources(StockIdconcatinationTest_PretestAction, "StockIdconcatinationTest_PretestAction");
            // 
            // rowCountCondition14
            // 
            rowCountCondition14.Enabled = true;
            rowCountCondition14.Name = "rowCountCondition14";
            rowCountCondition14.ResultSet = 1;
            rowCountCondition14.RowCount = 0;
            // 
            // StockIdconcatinationTest_PosttestAction
            // 
            StockIdconcatinationTest_PosttestAction.Conditions.Add(rowCountCondition13);
            resources.ApplyResources(StockIdconcatinationTest_PosttestAction, "StockIdconcatinationTest_PosttestAction");
            // 
            // rowCountCondition13
            // 
            rowCountCondition13.Enabled = true;
            rowCountCondition13.Name = "rowCountCondition13";
            rowCountCondition13.ResultSet = 1;
            rowCountCondition13.RowCount = 1;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion        
        private SqlDatabaseTestActions InsertCustomersTestData;
        private SqlDatabaseTestActions ImportSupplierTestData;
        private SqlDatabaseTestActions ImportProductTestData;
        private SqlDatabaseTestActions UpdateProductQuantityTORetailLocationTestData;
        private SqlDatabaseTestActions AddNewProductTypeData;
        private SqlDatabaseTestActions AddNewProductLocationData;
        private SqlDatabaseTestActions AddNewSeasonTestData;
        private SqlDatabaseTestActions CheckProductsTrigerData;
        private SqlDatabaseTestActions CheckSuppliersTriggerTestData;
        private SqlDatabaseTestActions WarehouseCheckProsedureTestData;
        private SqlDatabaseTestActions StockIdconcatinationTestData;
    }
}
