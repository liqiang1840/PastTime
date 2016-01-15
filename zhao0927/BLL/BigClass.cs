using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class BigClass
    {
        #region 操作接口层
        /// <summary>
        /// 操作接口层,统一管理所有的方法和实现页面的调用等！
        /// </summary>
        #endregion

        #region 实例化类的对象
        /// <summary>
        /// 实例化业务逻辑层SQLServerDAL类BigClass的对象
        /// 实例化实体层Model类BigClass的对象
        /// </summary>
        SQLServerDAL.BigClass DALBC = new SQLServerDAL.BigClass();
        Model.BigClass delBC = new Model.BigClass();
        #endregion

        #region 添加新闻栏目
        /// <summary>
        /// 添加新闻栏目,执行成功返回true,否则返回false
        /// </summary>
        /// <param name="Mb">实体层下BigClass类的对象</param>
        /// <returns>true,false</returns>
        public bool AddBigClass(Model.BigClass Mb)
        {
            return DALBC.AddBigClass(Mb.name);
        }
        #endregion

        #region 删除新闻栏目
        /// <summary>
        /// 根据id删除新闻栏目,执行成功返回true,否则返回false
        /// </summary>
        /// <param name="Mb">实体层BigClass类的对象</param>
        /// <returns>执行成功返回true,否则返回false</returns>
        public bool DeleteBigClassByID(Model.BigClass Mb)
        {
            return DALBC.DeleteBigClassByID(Mb.id);
        }
        #endregion

        #region 修改新闻栏目
        /// <summary>
        /// 修改新闻栏目,执行成功返回true,否则返回false
        /// </summary>
        /// <returns>true,false</returns>
        public bool UpdateBigClass()
        {
            return DALBC.UpdateBigClass(delBC);
        }
        #endregion

        #region 获取表里的全部数据
        /// <summary>
        /// 执行语句返回BigClass表的数据集合
        /// </summary>
        /// <returns>返回DataSet</returns>
        public DataSet GetData_BigClass()
        {
            return DALBC.GetData_BigClass();
        }
        #endregion

        #region 获取允许显示的栏目名称
        /// <summary>
        /// 获取允许显示的栏目名称
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet GetBigClass()
        {
            return DALBC.GetBigClass();
        }
        #endregion

        #region 根据id修改栏目的显示状态
        /// <summary>
        /// 根据id修改栏目的显示状态,1显示,0不显示
        /// </summary>
        /// <returns>true,false</returns>
        public bool UpdateBigClassFlag(Model.BigClass Mb)
        {
            return DALBC.UpdateBigClassFlag(Mb.flag, Mb.id);
        }
        #endregion

        #region 根据id修改栏目名称及显示状态
        /// <summary>
        /// 根据id修改栏目名称及显示状态
        /// </summary>
        /// <param name="id">栏目编号</param>
        /// <param name="name">栏目名称</param>
        /// <param name="flag">栏目状态</param>
        /// <returns>true,false</returns>
        public bool UpdateBigClassNameAndFlag(Model.BigClass Mb)
        {
            return DALBC.UpdateBigClassNameAndFlag(Mb.id, Mb.name, Mb.flag);
        }
        #endregion  

        #region 根据id查询出栏目的名称
        /// <summary>
        /// 根据id查询出栏目的名称
        /// </summary>
        /// <param name="Mb">实体层BigClass类的对象</param>
        /// <returns>DataSet数据集合</returns>
        public DataSet GetBigClassByID(Model.BigClass Mb)
        {
            return DALBC.GetBigClassByID(Mb.id);
        }
        
        /// <summary>
        /// 根据id查询出栏目的名称
        /// </summary>
        /// <param name="Mb">实体层BigClass类的对象</param>
        /// <returns>DataSet数据集合</returns>
        public DataSet GetBigClassByID(int id)
        {
            return DALBC.GetBigClassByID(id);
        }
        #endregion

        #region 获取每个栏目的新闻总条数
        /// <summary>
        /// 获取每个栏目的新闻总条数
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet GetNewsCount()
        {
            return DALBC.GetNewsCount();
        }
        #endregion

        #region 根据所审核的新闻更新栏目下的新闻条数
        /// <summary>
        /// 根据所审核的新闻更新栏目下的新闻条数
        /// </summary>
        /// <param name="Mb">实体层BigClass类的对象</param>
        /// <returns>true,false</returns>
        public bool UpdateNewsCount(Model.BigClass Mb)
        {
            return DALBC.UpdateNewsCount(Mb.id);
        }
        #endregion
    }
}
