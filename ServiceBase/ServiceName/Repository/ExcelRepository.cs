using System.Collections.Generic;
using System.Linq;
using Infrastructure.Framework.BaseClasses;
using FastWeb.SQA.Excel.Repository.Interfaces;
using System.IO;
using System.Web.Hosting;
using LinqToExcel;
using FastWeb.SQA.Dto;
using System.Configuration;
using System;
using System.Reflection;
using FastWeb.SQA.CustomException;


namespace FastWeb.SQA.Excel.Repository
{
    public class ExcelRepository : RepositoryBase, IExcelRepository
    {
        ExcelQueryFactory _excel;
        public List<T> GetAllRowsFromExcel<T>(byte[] exelProjectsFile, string workSheetName)
        {
            byte[] uploadedFile = exelProjectsFile;
            int numBytesToRead = uploadedFile.Length;
            string tempFilePath = HostingEnvironment.ApplicationPhysicalPath + @"\uploadedFiles\" + Path.GetRandomFileName();
            List<T> listOfRows;
            try
            {
                using (FileStream fsNew = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                {
                    fsNew.Write(uploadedFile, 0, numBytesToRead);
                }
                _excel = new ExcelQueryFactory(tempFilePath);
                Mapping<T>();
                # region Sample
                //var listOfProjectsFromExcel = from c in excel.Worksheet("Elenco Progetti")
                //                              where c["Target Release Quarter"] == "Q1"
                //                              select c;
                # endregion

                    listOfRows = (from c in _excel.Worksheet<T>(workSheetName)
                                          select c).ToList<T>();
                return listOfRows;
                # region Obsolete
                //string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + dataSource.ToString() +
                //                ";Extended Properties=Excel 12.0;";
                //var con = new OleDbConnection(conStr);
                //con.Open();

                //OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM [Elenco Progetti$]", con);
                //DataSet myDataSet = new DataSet();
                //dataAdapter.Fill(myDataSet, "Projects");
                //DataTable dataTable = myDataSet.Tables["Projects"];
                # endregion
            }
            finally
            {
                if (File.Exists(tempFilePath))
                    File.Delete(tempFilePath);
            }
        }
        private void Mapping<T>()
        {
                Type sourceType = typeof(T);
                foreach (PropertyInfo pi in sourceType.GetProperties())
                {
                    _excel.AddMapping(pi.Name, ConfigurationManager.AppSettings[pi.Name + "_SupportField"]);
                }     
        }      
    }
}
