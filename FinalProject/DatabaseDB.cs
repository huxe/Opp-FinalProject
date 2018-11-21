using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace FinalProject
{
    class DatabaseDB
    {
        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\c#\oop\FinalProject\FinalProject\bin\Debug\DBElectronicShop.accdb");

        public int RunQuery(string Query)
        {
            OleDbCommand cmd = new OleDbCommand(Query, Con);
            Con.Open();
            int a = cmd.ExecuteNonQuery();
            Con.Close();
            return a;
        }

        
    }
}
