using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
    class AccountDTO
    {
        #region Fields

        private int id;
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }


        private string userName;
        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }


        private string passWord;
        public string PassWord
        {
            get
            {
                return passWord;
            }

            set
            {
                passWord = value;
            }
        }


        private string displayName;
        public string DisplayName
        {
            get
            {
                return displayName;
            }

            set
            {
                displayName = value;
            }
        }

        public int Permission
        {
            get
            {
                return permission;
            }

            set
            {
                permission = value;
            }
        }

        private int permission;



        #endregion

        #region Constructors

        public AccountDTO() { }

        public AccountDTO(int id, string userName, string passWord, string displayName, int permission)
        {
            this.id = id;
            this.userName = userName;
            this.passWord = passWord;
            this.displayName = displayName;
            this.permission = permission;
        }
        
        public AccountDTO(DataRow row)
        {
            this.id = (int) row["id"];
            this.userName = row["userName"].ToString();
            this.passWord = row["passWord"].ToString();
            this.displayName = row["displayName"].ToString();
            this.permission = (int) row["permission"];
        }
        #endregion
    }
}
