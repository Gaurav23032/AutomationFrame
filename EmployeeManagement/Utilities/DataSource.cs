using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Utilities
{
    public class DataSource
    {


        public static object[] InvalidLoginData()
        {
            string[] DataSet1 = new string[3];
            DataSet1[0] = "john";
            DataSet1[1] = "john123";
            DataSet1[2] = "Invalid credentials";

            string[] DataSet2 = new string[3];
            DataSet2[0] = "peter";
            DataSet2[1] = "peter123";
            DataSet2[2] = "Invalid credentials";

            string[] DataSet3 = new string[3];
            DataSet3[0] = "saul";
            DataSet3[1] = "saul123";
            DataSet3[2] = "Invalid credentials";

            object[] AllDataSet = new object[3];
            AllDataSet[0] = DataSet1;
            AllDataSet[1] = DataSet2;
            AllDataSet[2] = DataSet3;

            return AllDataSet;
        }
        public static object[] ValidEmployeeTest()
        {
            string[] DataSet1 = new string[6];
            DataSet1[0] = "Admin";
            DataSet1[1] = "admin123";
            DataSet1[2] = "john";
            DataSet1[3] = "w";
            DataSet1[4] = "wick";
            DataSet1[5] = "john wick";

            string[] DataSet2 = new string[6];
            DataSet2[0] = "Admin";
            DataSet2[1] = "admin123";
            DataSet2[2] = "saul";
            DataSet2[3] = "m";
            DataSet2[4] = "mac";
            DataSet2[5] = "saul mac";

            object[] AllDataSet = new object[2];
            AllDataSet[0] = DataSet1;
            AllDataSet[1] = DataSet2;

            return AllDataSet;



        }
    }
}
