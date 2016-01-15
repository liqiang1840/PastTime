using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SQLServerDAL
{
    #region 业务逻辑层
    /// <summary>
    /// 业务逻辑层
    /// 构造SQL语句及调用方法执行
    /// </summary>
    #endregion

    public class admin
    {
        /// <summary>
        /// 实例化类的对象
        /// DBbase类执行SQL语句类
        /// </summary>
        DBbase db = new DBbase();

        #region 执行SQL语句,返回记录总行数,主要应用于管理员的登录
        /// <summary>
        /// 执行SQL语句,返回记录总行数,主要应用于管理员的登录
       /// </summary>
       /// <param name="UserName">用户名</param>
       /// <param name="PassWord">密码</param>
       /// <returns>记录数量</returns>
        public int ReRowCount(string UserName,string PassWord)
        {           
            return db.ReturnUserCount(UserName, PassWord);
        }
        #endregion

        #region 添加用户,语句执行成功返回true,否则返回false
        /// <summary>
        /// 添加管理员用户,语句执行成功返回true,否则返回false
        /// </summary>
        /// <param name="del_ad">实体层类的对象</param>
        /// <returns>true,false</returns>
        public bool AddUser(Model.admin del_ad)
        {
            string strSQL = "insert into admin (username,password,email,aleave) values ('" + del_ad.username + "','" + del_ad.password + "','" + del_ad.useremail + "','"+del_ad.aleave+"')";
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        #region 删除用户信息,语句执行成功返回true,否则返回false
        /// <summary>
        /// 删除用户信息,语句执行成功返回true,否则返回false
        /// </summary>
        /// <param name="del_ad">实体层类的对象</param>
        /// <returns>true,false</returns>
        public bool DeleteAdmin(Model.admin ma)
        {
            string strSQL = "delete from admin where cid=" + ma.cid;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        #region 修改管理员密码,语句执行成功返回true,否则返回false
        /// <summary>
        /// 修改管理员密码,语句执行成功返回true,否则返回false
        /// </summary>
        /// <param name="Cid">管理员用户Cid</param>
        /// <param name="del_ad">实体层类的对象</param>
        /// <returns>true,false</returns>
        public bool UpdateAdminPassword(Model.admin del_ad)
        {
            string strSQL = "update admin set password='" + del_ad.password + "' where cid=" + del_ad.cid;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        #region 修改管理员用户权限,语句执行成功返回true,否则返回false
        /// <summary>
        /// 修改管理员用户权限,语句执行成功返回true,否则返回false
        /// </summary>
        /// <param name="Cid">管理员用户Cid</param>
        /// <param name="del_ad">实体层类的对象</param>
        /// <returns>true,false</returns>
        public bool UpdateAdminAleave(Model.admin del_ad)
        {
            string strSQL = "update admin set aleave='" + del_ad.aleave + "' where cid=" + del_ad.cid;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        #region 获取admin表格里的数据集合
        /// <summary>
        /// 执行SQL语句,返回admin表格里的数据集合
        /// </summary>
        /// <returns>DataSet数据集合</returns>
        public DataSet GetDataAdmin()
        {
            string strSQL = "select * from admin";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 根据ID查询相关信息
        /// <summary>
        /// 根据ID查询相关信息
        /// </summary>
        /// <param name="id">关键字</param>
        /// <returns>DataSet数据集合</returns>
        public DataSet QueryUserInfoByID(int id)
        {
            string strSQL = "select * from admin where cid=" + id;
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 根据用户名查询相关信息
        /// <summary>
        /// 根据用户名查询相关信息
        /// </summary>
        /// <param name="name">关键字</param>
        /// <returns>DataSet数据集合</returns>
        public DataSet QueryUserInfoByName(string name)
        {
            string strSQL = "select * from admin where username='" + name + "'";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 根据用户名修改用户数据
        /// <summary>
        /// 根据用户名修改用户数据
        /// </summary>
        /// <param name="name">关键字</param>
        /// <returns>bool值</returns>
        public bool UpdateUserInfoByName(string name, string pwd, string email)
        {
            string strSQL = "update  admin set password='" + pwd + "',email='" + email + "'  where username='" + name + "'";
            return db.ExecuteNonQuery(false,strSQL);
        }
        #endregion

        #region 根据ID修改相关信息
        /// <summary>
        /// 根据ID修改相关信息
        /// </summary>
        /// <param name="ma">实体层admin类的对象</param>
        /// <returns>true,false</returns>
        public bool UpdateUserInfo(Model.admin ma)
        {
            string strSQL = "update admin set username='" + ma.username + "',password='" + ma.password + "',email='" + ma.useremail + "',aleave='" + ma.aleave + "' where cid=" + ma.cid;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion 

        #region 检测用户名是否存在
        /// <summary>
        /// 检测用户名是否存在
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <returns>整型数据</returns>
        public int CheckUser(string UserName)
        {
            string strSQL = "select * from admin where username='" + UserName + "'";
            return db.ReturnRowCount(strSQL);
        }
        #endregion

        #region 用户用户登陆的方法
        /// <summary>
        /// 用户用户登陆的方法
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <param name="PassWord">用户密码</param>
        /// <returns>数据集合</returns>
        public DataSet UserLogin(string UserName, string PassWord)
        {
            string al="普通用户";
            string strSQL = "select * from admin where username='" + UserName + "' and password='" + PassWord + "' and aleave='" + al + "'";
            return db.ReturnDataSet(strSQL);
        }
        #endregion
    }
}
