using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        public SqlConnection connection;
        private string dataSource;
        private string dataBase;
        private string userName;
        private string passWord;
        private string connectionSTR;

        public static string DataSource { get; set; }
        public string DataBase { get {return dataBase;} set { dataBase = value; }}
        public string UserName { get {return userName;} set { userName = value; }}
        public string PassWord { get {return passWord;} set { passWord = value; }}
        public string ConnectionSTR { get {return connectionSTR;} set { connectionSTR = value; }}

        

        public DataProvider()
        {
            this.DataBase = "QuanLyCuaHangInternet";
            this.UserName = "sa";
            this.PassWord = "123";
            this.ConnectionSTR = @"Database=" + DataBase + ";Persist Security Info=True;User ID=" + UserName + ";Password=" + PassWord + "";
            connection = new SqlConnection(this.connectionSTR);
        }

        public void Open()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            else
                return;
        }
        public void Close()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
        public void Dispose()
        {
            Close();
            connection.Dispose();
        }



        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();


            try
            {
                    Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(data);

                    Close();
                }
            catch (Exception)
            {

                throw;
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            try
            {   
                    Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteNonQuery();

                    Close();
            }
            catch (Exception)
            {

                throw;
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            try
            {
                    Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteScalar();

                    Close();
                

            }
            catch (Exception)
            {

                throw;
            }
            return data;
        }
    }
}

