using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Office.Interop.Excel;

namespace Game_items_selling_web.Controllers.DBControllers
{
    public class Functions
    {
        public static void Excel(string databasevalue, System.Data.DataTable list)
        {
            _Application excelapp = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = false
            };
            Workbook workbook = excelapp.Workbooks.Add(Type.Missing);
            Worksheet worksheet = null;

            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from Database";
            worksheet.Application.DisplayAlerts = false;

            for (int i = 0; i < list.Rows.Count; i++)
            {
                for (int a = 0; a < list.Columns.Count; a++)
                {
                    worksheet.Cells[i + 2, a + 1] = list.Rows[i].ItemArray[a].ToString();
                }
            }
            string xml = "C:" + "\\Users\\User\\Desktop\\" + databasevalue + ".xls";
            int copy = 1;
            string pathvalue = databasevalue + ".xls";
            while (System.IO.File.Exists(xml) != false)
            {
                xml = xml.Replace(pathvalue, databasevalue + Convert.ToString(copy) + ".xls");
                pathvalue = databasevalue + Convert.ToString(copy) + ".xls";
                copy++;
            }
            worksheet.SaveAs(xml, Type.Missing, Type.Missing, Type.Missing, true, false, false, Type.Missing, Type.Missing, Type.Missing);
            excelapp.Quit();
        }
    }
}