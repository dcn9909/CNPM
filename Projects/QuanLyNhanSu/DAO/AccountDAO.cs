using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.DTO;
namespace QuanLyNhanSu.DAO
{
    class AccountDAO
    {
        #region Singletone

        private static AccountDAO instance;



        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private AccountDAO() { }

        #endregion

        #region Methods
        public bool Login(string userName, string passWord)
        {
            string query = "EXEC dbo.USP_Login @userName , @passWord";
            int count = (int) DataProvider.Instance.ExecuteScalar(query, new object[] { userName,passWord} );

            return count > 0;
        }

        #endregion

    }
}
