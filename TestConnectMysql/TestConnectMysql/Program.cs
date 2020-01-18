using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TestConnectMysql
{
    class Program
    {
        static void Main(string[] args)
        {
            //连接数据库，根据自己的情况修改值
            string constructorString =
               " Server = localhost;Port = 3306;Database = testconnect;Uid = root;Pwd = 11111111";
            MySqlConnection myConnnect = new MySqlConnection(constructorString);       
            try
            {
                myConnnect.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Console.ReadKey();//防止黑框闪退，可以看到结果

            //进行查找
            MySqlCommand myCmd = myConnnect.CreateCommand();
            myCmd.CommandText = "select ads from test1 where user = 1;";
            MySqlDataReader reader = myCmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["ads"].ToString());
            }          
            //关闭数据库
            try
            {
                myConnnect.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            //进行增加数据,先连接mysql
            try
            {
                myConnnect.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myCmd = myConnnect.CreateCommand();
            myCmd.CommandText = "insert into test1 values(2, 2,'win');";
            myCmd.ExecuteNonQuery();
            myCmd.CommandText = "select ads from test1 where user = 2;";
            reader = myCmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["ads"].ToString());
            }
            
            //关闭数据库
            try
            {
                myConnnect.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        
    }
}
