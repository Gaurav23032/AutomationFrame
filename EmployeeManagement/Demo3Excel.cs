using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace EmployeeManagement
{
    public class Demo3Excel
    {
        [Test]
        public void DemoExcelRead()
        {
            XLWorkbook book = new XLWorkbook(@"C:\Users\gauravsk\Desktop\C Sharpe\AutomationFramework\EmployeeManagement\TestData\OrangeHRM_data.xlsx");
            IXLWorksheet sheet = book.Worksheet("InvalidLoginTest");
            IXLRange range = sheet.RangeUsed();
           
            for(int r=2;r<=4;r++)
            {
                for(int c=1;c<=3;c++)
                {
                    string value = range.Cell(r, c).GetString();
                    Console.WriteLine(value);
                }
            }
            book.Dispose();
        }

    }
}
