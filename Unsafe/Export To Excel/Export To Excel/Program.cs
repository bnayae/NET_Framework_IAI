using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Export_To_Excel
{
    class Program
    {
        private const int ITERATIONS = 5000;
        private const string EXCEL_8 = @"Provider = Microsoft.Jet.OLEDB.4.0;Data Source=MyData.xlsx;Extended Properties=""Excel 8.0;""";
        private const string EXCEL_2010 = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MyData.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES"";";
        private const string COMMAND_QUERY = @"Insert into [Sheet1$] (Id, Name) values (@Id, @Name)";
        static void Main(string[] args)
        {
            Task t = ExecuteAsync(EXCEL_2010);

            Console.ReadKey();
        }

        private static async Task ExecuteAsync(string connStr)
        {
            var sw = Stopwatch.StartNew();
            using (var conn = new OleDbConnection(connStr))
            {
                try
                {
                    
                    await conn.OpenAsync();
                    OleDbCommand cmd = new OleDbCommand(COMMAND_QUERY, conn);
                    var pId = cmd.Parameters.Add("Id", OleDbType.Integer);
                    var pName = cmd.Parameters.Add("Name", OleDbType.VarChar, 100);
                    for (int i = 0; i < ITERATIONS; i++)
                    {
                        pId.Value = i;
                        pName.Value = "Name " + i;
                        await cmd.ExecuteNonQueryAsync();
                        if(i % 1000 == 0)
                            Console.WriteLine("Processing {0}", i);
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(ex);
                    Console.ResetColor();
                }
            }
            sw.Stop();
            Console.WriteLine("Duration = {0:N3}", sw.Elapsed.TotalSeconds);
        }
    }
}
