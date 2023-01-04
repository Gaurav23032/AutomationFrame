using EmployeeManagement.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public  class DemoTest

    {
        public static object[] DemoValidData()
        {
            string[] DataSet1 = new string[2];
            DataSet1[0] = "john";
            DataSet1[1] = "john123";

            string[] DataSet2 = new string[2];
            DataSet2[0] = "peter";
            DataSet2[1] = "peter123";

            string[] DataSet3 = new string[2];
            DataSet3[0] = "saul";
            DataSet3[1] = "saul123";

            object[] AllDataSet = new object[3];
            AllDataSet[0] = DataSet1;
            AllDataSet[1] = DataSet2;
            AllDataSet[2] = DataSet3;

            return AllDataSet;


        }
        [Test,TestCaseSource(nameof(DemoValidData))]
        public void DemoValidLogin(string username,string password)
        {
            Console.WriteLine("hello" + username+password);

        }
    }
}
