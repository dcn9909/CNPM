using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    class DataProvider
    {

        #region Singletone
        /// <summary>
        /// Singletone parttern
        /// </summary>
        private static DataProvider instance;

        /// <summary>
        /// public instance để thực thi query
        /// </summary>
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        /// <summary>
        /// Singletone parttern
        /// </summary>
        private DataProvider() { }
        #endregion

        /// <summary>
        /// String connection
        /// </summary>
        private string connectionString = @"Data Source=.;Initial Catalog=quanlynhansu;Integrated Security=True";

        /// <summary>
        /// connection dùng để kết nối db
        /// </summary>
        private SqlConnection connection;

       
        /// <summary>
        /// hàm ExecuteQuery và trả về 1 datatable dùng cho select
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (connection = new SqlConnection(connectionString))
            {

                connection.Open();//mở kết nối

                SqlCommand command = new SqlCommand(query, connection);//tạo query 

                //kiểm tra xem có parameter truyền vào hay không
                //nếu có thì cắt chuỗi và add value vào query
                if (parameter!=null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (var item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item,listPara[i]);
                            i++;
                        }
                    }                                        
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();//đóng kết nối
            }

            return data;
        } 

        /// <summary>
        /// dùng cho delete, update, insert
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int result = 0;//số dòng affect 

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter!=null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (var item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i++]);
                        }
                    }
                }
                result = command.ExecuteNonQuery();
                connection.Close();
            }

            return result;
        } 

        /// <summary>
        /// executeScalar trả về cell dòng dữ liệu đơn
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object result = null;

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (var item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i++]);
                        }
                    }
                }

                result = command.ExecuteScalar();

                connection.Close();
            }

            return result;
        }

    }
}
