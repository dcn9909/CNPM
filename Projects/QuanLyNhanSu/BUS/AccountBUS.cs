using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.DAO;
namespace QuanLyNhanSu.BUS
{
    class AccountBUS
    {
        #region Singletone

        private static AccountBUS instance;

       

        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountBUS();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private AccountBUS() { }

        #endregion

        #region Methods

        /// <summary>
        /// hàm kiểm tra đăng nhập
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        #endregion
    }
}
