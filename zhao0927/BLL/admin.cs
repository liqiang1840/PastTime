using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    #region 操作接口层
    /// <summary>
    /// 操作接口层,统一管理所有的方法和实现页面的调用等！
    /// </summary>
    #endregion
    public class admin
    {
        #region 实例化类的对象
        /// <summary>
        /// 实例化业务逻辑层SQLServerDAL类admin的对象
        /// 实例化实体层Model类admin的对象
        /// </summary>
        SQLServerDAL.admin DALad = new SQLServerDAL.admin();
        Model.admin M_ad = new Model.admin();
        #endregion

        #region 返回记录总数,用户登陆的方法
        /// <summary>
        /// 返回记录总数,用户登陆的方法
        /// </summary>
        /// <param name="Ma">实体层admin类的对象</param>
        /// <returns>记录行数</returns>
        public int ReRowCount(Model.admin Ma)
        {
            return DALad.ReRowCount(Ma.username,Ma.password);
        }
        #endregion

        #region 添加用户,语句执行成功返回true,否则返回false
        /// <summary>
        /// 添加用户,语句执行成功返回true,否则返回false
        /// </summary>
        /// <param name="M_ad">实体层admin类的对象</param>
        /// <returns>true,false</returns>
        public bool AddUser(Model.admin M_ad)
        {
            return DALad.AddUser(M_ad);
        }
        #endregion

        #region 根据id删除用户
        /// <summary>
        /// 删除用户信息,语句执行成功返回true,否则返回false
        /// </summary>
        /// <returns>true,fasle</returns>
        public bool DeleteAdmin(Model.admin ma)
        {
            return DALad.DeleteAdmin(ma);
        }
        #endregion

        #region 修改管理员密码
        /// <summary>
        /// 修改管理员密码,语句执行成功返回true,否则返回false
        /// </summary>
        /// <returns>true,false</returns>
        public bool UpdateAdminPassword()
        {
            return DALad.UpdateAdminAleave(M_ad);
        }
        #endregion

        #region 修改管理员权限
        /// <summary>
        /// 修改管理员权限,语句执行成功返回true,否则返回false
        /// </summary>
        /// <returns>true,false</returns>
        public bool UpdateAdminAleave()
        {
            return DALad.UpdateAdminAleave(M_ad);
        }
        #endregion

        #region 获取表里的全部数据
        /// <summary>
        /// 获取表里的全部数据
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet GetDataAdmin()
        {
            return DALad.GetDataAdmin();
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
            return DALad.QueryUserInfoByID(id);
        }
        #endregion

        #region 根据用户名查询相关信息
        /// <summary>
        /// 根据用户名查询相关信息
        /// </summary>
        /// <param name="Ma">实体层admin类的对象</param>
        /// <returns>DataSet数据集合</returns>
        public DataSet QueryUserInfoByName(Model.admin Ma)
        {
            return DALad.QueryUserInfoByName(Ma.username);
        }
        #endregion

        #region 根据用户名修改用户数据
        /// <summary>
        /// 根据用户名修改用户数据
        /// </summary>
        /// <param name="Ma">实体层admin类的对象</param>
        /// <returns>bool值</returns>
        public bool UpdateUserInfoByName(Model.admin Ma)
        {
            return DALad.UpdateUserInfoByName(Ma.username, Ma.password, Ma.useremail);
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
            return DALad.UpdateUserInfo(ma);
        }
        #endregion 

        #region 检测用户名是否存在
        /// <summary>
        /// 检测用户名是否存在
        /// </summary>
        /// <param name="Ma">实体层admin类的对象</param>
        /// <returns>整型数据</returns>
        public int CheckUser(Model.admin Ma)
        {
            return DALad.CheckUser(Ma.username);
        }
        #endregion

        #region 用户用户登陆的方法
        /// <summary>
        /// 用户用户登陆的方法
        /// </summary>
        /// <param name="Ma">实体层admin类的对象</param>
        /// <returns>数据集合</returns>
        public DataSet UserLogin(Model.admin Ma)
        {
            return DALad.UserLogin(Ma.username, Ma.password);
        }
        #endregion
    }
}
