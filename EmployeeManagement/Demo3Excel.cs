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
            string value = range.Cell(2, 1).GetString();
            Console.WriteLine(value);
            book.Dispose();
        }

    }
}
