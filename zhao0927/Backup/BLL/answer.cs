using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BLL
{
    public class answer
    {
        SQLServerDAL.answer DAL_a = new SQLServerDAL.answer();

        #region 根据新闻ID删除该新闻的全部评论
        /// <summary>
        /// 根据新闻ID删除该新闻的全部评论
        /// </summary>
        /// <param name="Ma">实体层answer类的对象</param>
        /// <returns>true,false</returns>
        public bool DeleteAllByNewsID(Model.answer Ma)
        {
            return DAL_a.DeleteAllByNewsID(Ma.newID);
        }
        #endregion

        #region 获取全部新闻评论
        /// <summary>
        /// 获取全部新闻评论
        /// </summary>
        /// <returns>DataSet数据集</returns>
        public DataSet GetAllAnswer()
        {
            return DAL_a.GetAllAnswer();
        }
        #endregion

        #region 根据新闻ID查询该新闻的最新3条评论
        /// <summary>
        /// 根据新闻ID查询该新闻的全部评论
        /// </summary>
        /// <param name="newsID">新闻ID</param>
        /// <returns>DataSet数据集合</returns>
        public DataSet GetAnswerByNewsID(int newsID)
        {
            return DAL_a.GetAnswerByNewsID(newsID);
        }
        #endregion

        #region 根据新闻ID查询该新闻的全部评论
        /// <summary>
        /// 根据新闻ID查询该新闻的全部评论
        /// </summary>
        /// <param name="newsID">新闻ID</param>
        /// <returns>DataSet数据集合</returns>
        public DataSet GetALLAnswerByNewsID(int newsID)
        {
            return DAL_a.GetALLAnswerByNewsID(newsID);
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
            return DAL_a.AddAnswerByNewsID(Ma);
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
            return DAL_a.GetCindexByNewsID(NewsID);
        }
        #endregion
    }
}
