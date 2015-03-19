using System;
using Microsoft.Office.Interop.Excel;
namespace _15.LINQTOExcel
{
    class CreateExcelDoc
    {
        private Application app = null;
        private Workbook workbook = null;
        private Worksheet worksheet = null;
        
        public CreateExcelDoc()
        {
            createDoc();
        }
        
        public void createDoc()
        {
            try
            {
                app = new Application();
                app.Visible = true;
                workbook = app.Workbooks.Add(1);
                worksheet = (Worksheet)workbook.Sheets[1];
            }
            catch (Exception e)
            {
                Console.Write("Error");
            }
        }

        public void addData(int row, int col,string data)
        {
            worksheet.Cells[row, col] = data;
        }
    }
}