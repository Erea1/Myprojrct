using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_Excel操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //连接到数据对象
            string fileName = "装备信息.xls";
            string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + fileName + ";" + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";
            OleDbConnection connection = new OleDbConnection(connectString);
            //打开连接
            connection.Open();
            string sql = "select*from[Sheet1$] ";//查询命令
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql,connection);
            DataSet dataSet = new DataSet();//用来存放数据; 存放datatable

            adapter.Fill(dataSet);//把查询的结果放到dataset里面
            connection.Close();
            //取得数据
            DataTableCollection tableCollection= dataSet.Tables;//获取当前集合中所有表格
            DataTable table= tableCollection[0];//只有一个表格所以
            //取得表格中的数据
            DataRowCollection rowCollection = table.Rows;
            foreach (DataRow row  in rowCollection)
            {
                //取得row中前8列
                for (int i = 0; i < 8; i++)
                {
                    Console.Write(row[i]+" ");
                    
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
