using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SQLServerDAL
{
    /// <summary>
    /// 业务逻辑层
    /// 新闻评论类
    /// </summary>
    public class answer
    {
        /// <summary>
        /// 实例化基类的对象
        /// </summary>
        DBbase db = new DBbase();

        #region 根据新闻ID删除该新闻的全部评论
        /// <summary>
        /// 根据新闻ID删除该新闻的全部评论
        /// </summary>
        /// <param name="NewsID">新闻ID</param>
        /// <returns>true,false</returns>
        public bool DeleteAllByNewsID(int NewsID)
        {
            string strSQL = "delete from answer where newsID=" + NewsID;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        #region 获取全部新闻评论
        /// <summary>
        /// 获取全部新闻评论
        /// </summary>
        /// <returns>DataSet数据集</returns>
        public DataSet GetAllAnswer()
        {
            string strSQL = "select * from answer";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 根据新闻ID查询该新闻的最新3条评论
        /// <summary>
        /// 根据新闻ID查询该新闻的最新3条评论
        /// </summary>
        /// <param name="NewsID">新闻ID</param>
        /// <returns>DataSet数据集合</returns>
        public DataSet GetAnswerByNewsID(int NewsID)
        {
            string strSQL = "select top 3 * from answer where newsID=" + NewsID + " order by cindex DESC";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 根据新闻ID查询该新闻的全部评论
        /// <summary>
        /// 根据新闻ID查询该新闻的全部评论
        /// </summary>
        /// <param name="NewsID">新闻ID</param>
        /// <returns>DataSet数据集合</returns>
        public DataSet GetALLAnswerByNewsID(int NewsID)
        {
            string strSQL = "select  * from answer where newsID=" + NewsID;
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 根据新闻ID获取该新闻的评论的条数
        /// <summary>
        /// 根据新闻ID获取该新闻的评论的条数
        /// </summary>
        /// <param name="NewsID">新闻ＩＤ</param>
        /// <returns>DataSet数据集</returns>
        public DataSet GetCindexByNewsID(int NewsID)
        {
            string strSQL = "select max(cindex) as cindex  from answer where newsID=" + NewsID;
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 根据新闻ID添加评论
        /// <summary>
        /// 根据新闻ID添加评论
        /// </summary>
        /// <param name="Ma">实体层answer类的对象</param>
        /// <returns>DataSet数据集</returns>
        public bool AddAnswerByNewsID(Model.answer Ma)
        {
            int cindex=1;
            if (GetCindexByNewsID(Ma.newID).Tables[0].Rows[0][0].ToString() == "")
            {
                cindex=1;
            }
            else
            {
                cindex = int.Parse(GetCindexByNewsID(Ma.newID).Tables[0].Rows[0][0].ToString());
                cindex += 1;
            }
            string strSQL = "insert into answer (A_user,A_qq,A_email,A_word,A_time,newsID,cindex) values ('" + Ma.A_user + "','" + Ma.A_qq + "','" + Ma.A_email + "','" + Ma.A_word + "','" + Ma.A_time + "'," + Ma.newID + "," + cindex + ")";
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion
    }
}
