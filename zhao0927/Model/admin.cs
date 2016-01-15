using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 实体层----管理员表
    /// 定义成员变量及属性
    /// </summary>
    public class admin
    {
        #region 定义类的成员变量
        /// <summary>
        /// 定义类的成员变量
        /// </summary>
        private int _cid;
        private string _username;
        private string _password;
        private string _useremail;
        private string _aleave;
        #endregion

        #region 定义类成员变量的属性
        /// <summary>
        /// 定义类成员变量的属性
        /// </summary>
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        public int cid
        {
            get { return _cid; }
            set { _cid = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string useremail
        {
            get { return _useremail; }
            set { _useremail = value; }
        }
        public string aleave
        {
            get { return _aleave; }
            set { _aleave = value; }
        }
        #endregion
    }
}
