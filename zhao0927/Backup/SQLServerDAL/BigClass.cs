using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SQLServerDAL
{
    #region 业务逻辑层
    /// <summary>
    /// 业务逻辑层
    /// 构造SQL语句及调用方法执行
    /// </summary>
    #endregion

    public class BigClass
    {
        /// <summary>
        /// 实例化类的对象
        /// DBbase类执行SQL语句类
        /// </summary>
        DBbase db = new DBbase();

        #region 添加新闻栏目
        /// <summary>
        /// 添加新闻栏目,执行成功返回true,否则返回false
        /// </summary>
        /// <param name="name">栏目名称</param>
        /// <returns>true,false</returns>
        public bool AddBigClass(string name)
        {
            int cindex = GetMaxCindex()+1;
            string strSQL = "insert into BigClass (name,cindex) values ('" + name + "'," + cindex + ")";
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        #region 根据栏目id删除新闻栏目,执行成功返回true,否则返回false
        /// <summary>
        /// 根据栏目id删除新闻栏目,执行成功返回true,否则返回false
        /// </summary>
        /// <param name="delBC">实体层Model下BigClass类的对象</param>
        /// <returns>true,false</returns>
        public bool DeleteBigClassByID(int id)
        {
            string strSQL = "delete from BigClass where id=" + id;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        #region 根据栏目id修改新闻栏目
        /// <summary>
        /// 根据栏目id修改新闻栏目,执行成功返回true,否则返回false
        /// </summary>
        /// <param name="delBC">实体层Model下BigClass类的对象</param>
        /// <returns>true,false</returns>
        public bool UpdateBigClass(Model.BigClass delBC)
        {
            string strSQL = "update BigClass set name='" + delBC.name + "' where id=" + delBC.id;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        #region 返回整个表格里的数据集合
        /// <summary>
        /// 执行SQL语句,返回整个表里的数据集合
        /// </summary>
        /// <returns>返回DataSet</returns>
        public DataSet GetData_BigClass()
        {
            string strSQL = "select * from BigClass";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 获取允许显示的栏目名称
        /// <summary>
        /// 获取允许显示的栏目名称
        /// </summary>
        /// <returns>DataSet集合</returns>
        public DataSet GetBigClass()
        {
            string strSQL = "select id,name from BigClass where flag='显示' order by cindex";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 根据id修改栏目的显示状态,1显示,0不显示
        /// <summary>
        /// 根据id修改栏目的显示状态,1显示,0不显示
        /// </summary>
        /// <param name="flag">栏目状态</param>
        /// <param name="id">栏目编号</param>
        /// <returns>true,false</returns>
        public bool UpdateBigClassFlag(string flag,int id)
        {
            string strSQL = "update BigClass set flag = '" + flag + "' where id=" + id;
            return db.ExecuteNonQuery(false, strSQL);
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
        public bool UpdateBigClassNameAndFlag(int id,string name,string flag)
        {
            string strSQL = "update BigClass set name = '"+name+"', flag = '" + flag + "' where id=" + id;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion  

        #region 根据id查询出栏目的名称
        /// <summary>
        /// 根据id查询出栏目的名称
        /// </summary>
        /// <param name="M_bc">Model实体层的对象</param>
        /// <returns>DataSet数据集</returns>
        public DataSet GetBigClassByID(int M_bc)
        {
            try
            {
                string strSQL = "select id,name from BigClass where id=" + M_bc;
                return db.ReturnDataSet(strSQL);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region 获取最大的Cindex
        /// <summary>
        /// 获取最大的Cindex
        /// </summary>
        /// <returns>最大cindex</returns>
        public int GetMaxCindex()
        {
            string strSQL = "select max(cindex) as cindex from BigClass";
            return int.Parse(db.ReturnDataSet(strSQL).Tables[0].Rows[0][0].ToString());
        }
        #endregion

        #region 获取每个栏目的新闻总条数
        /// <summary>
        /// 获取每个栏目的新闻总条数
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet GetNewsCount()
        {
            string strSQL = "select newscount from BigClass";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 根据所审核的新闻更新栏目下的新闻条数
        /// <summary>
        /// 根据所审核的新闻更新栏目下的新闻条数
        /// </summary>
        /// <param name="BigClassID">栏目ID</param>
        /// <returns>true,false</returns>
        public bool UpdateNewsCount(int BigClassID)
        {
            int newscount = GetNesCount(BigClassID) + 1;
            string strSQL = "update BigClass set newscount=" + newscount + " where id=" + BigClassID;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        public int GetNesCount(int id)
        {
            string strSQL = "select newscount from bigclass where id=" + id;
            return int.Parse(db.ReturnDataSet(strSQL).Tables[0].Rows[0][0].ToString());
        }
    }
}
