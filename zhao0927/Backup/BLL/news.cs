using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BLL
{
    public class news
    {
        #region 操作接口层
        /// <summary>
        /// 操作接口层,统一管理所有的方法和实现页面的调用等！
        /// </summary>
        #endregion

        #region 实例化类的对象
        /// <summary>
        /// 实例化业务逻辑层SQLServerDAL类news的对象
        /// 实例化实体层Model类news的对象
        /// </summary>
        SQLServerDAL.news DAL_news = new SQLServerDAL.news();
        Model.news M_news = new Model.news();
        #endregion

        #region 获取现有新闻ID
        /// <summary>
        /// 获取现有新闻ID
        /// </summary>
        /// <returns>DataSet数据集</returns>
        public DataSet GetNewsID()
        {
            return DAL_news.GetNewsID();
        }
        #endregion

        #region 获取全部新闻内容,返回DataSet集合
        /// <summary>
        /// 获取全部新闻内容,返回DataSet集合
        /// </summary>
        /// <returns></returns>
        public DataSet GetData_news()
        {
            return DAL_news.GetData_news();
        }
        #endregion

        #region 根据栏目ID获取全部新闻内容
        /// <summary>
        /// 获取全部新闻内容
        /// </summary>
        /// <param name="BigClassID">新闻栏目ID</param>
        /// <returns></returns>
        public DataSet GetData_news(int BigClassID)
        {
            return DAL_news.GetData_news(BigClassID);
        }
        #endregion

        #region 分栏目获取新闻列表
        /// <summary>
        /// 分栏目获取新闻列表
        /// </summary>
        /// <returns>DataSet数据集</returns>
        public DataSet GetDataByBigClass(int BigClassID)
        {
            return DAL_news.GetDataByBigClass(BigClassID);
        }
        #endregion

        #region 获取每个分栏前6条新闻
        /// <summary>
        /// 获取每个分栏前6条新闻
        /// </summary>
        /// <returns>DataSet数据集</returns>
        public DataSet GetDataByBigClassTopSix()
        {
            return DAL_news.GetDataByBigClassTopSix(M_news);
        }
        #endregion

        #region 获取最新8条新闻
        /// <summary>
        /// 获取最新8条新闻
        /// </summary>
        /// <returns>DataSet数据集</returns>
        public DataSet GetDataEightNew()
        {
            return DAL_news.GetDataEightNew();
        }
        #endregion

        #region 获取点击率最高的10条新闻标题
        /// <summary>
        /// 获取点击率最高的10条新闻标题
        /// </summary>
        /// <returns>DataSet数据集</returns>
        public DataSet GetDataTopTenHits()
        {
            return DAL_news.GetDataTopTenHits();
        }
        #endregion 

        #region 添加新的新闻,添加成功返回true,否则返回false
        /// <summary>
        /// 添加新闻,,添加成功返回true,否则返回false
        /// </summary>
        /// <param name="m_news">对象参数</param>
        /// <returns>成功返回true,失败返回false</returns>
        public bool AddNews(Model.news m_news)
        {
            return DAL_news.AddNews(m_news);
        }
        #endregion

        #region 根据新闻id删除新闻,删除成功返回true,否则返回false
        /// <summary>
        /// 根据新闻id删除新闻,删除成功返回true,否则返回false
        /// </summary>
        /// <param name="M">实体层news类的对象</param>
        /// <returns>true，false </returns>
        public bool DeleteNewByID(Model.news M)
        {
            return DAL_news.DeleteNewByID(M.id);
        }
        #endregion

        #region  更新新闻的点击率
        /// <summary>
        /// 更新新闻的点击率
        /// </summary>
        public void UpdateHits(int id)
        {
            DAL_news.UpdateHits(id);
        }
        #endregion  

        #region 根据指定id绑定指定的新闻内容
        /// <summary>
        /// 根据指定id绑定指定的新闻内容
        /// </summary>
        /// <param name="id">要绑定的新闻id</param>
        /// <returns>DataSet数据集合</returns>
        public DataSet DataBindNews(int id)
        {
            return DAL_news.DataBindNews(id);
        }
        #endregion

        #region 按新闻标题模糊查询新闻列表
        /// <summary>
        /// 按新闻标题模糊查询新闻列表
        /// </summary>
        /// <param name="M_news">实体层news类的对象</param>
        /// <returns>DataSet数据集</returns>
        public DataSet QueryByNewsTitle(Model.news M_news)
        {
            return DAL_news.QueryByNewsTitle(M_news.title);
        }
        #endregion

        #region 按新闻标题模糊查询新闻列表
        /// <summary>
        /// 按新闻标题模糊查询新闻列表
        /// </summary>
        /// <param name="M_news">实体层news类的对象</param>
        /// <returns>DataSet数据集</returns>
        public DataSet AdminQueryByNewsTitle(Model.news M_news)
        {
            return DAL_news.AdminQueryByNewsTitle(M_news.title);
        }
        #endregion

        #region 按新闻内容模糊查询新闻列表
        /// <summary>
        /// 按新闻内容模糊查询新闻列表
        /// </summary>
        /// <param name="M_news">实体层news类的对象</param>
        /// <returns>DataSet数据集</returns>
        public DataSet QueryByNewsInfo(Model.news M_news)
        {
            return DAL_news.QueryByNewsInfo(M_news.info);
        }
        #endregion

        #region 按新闻内容模糊查询新闻列表
        /// <summary>
        /// 按新闻内容模糊查询新闻列表
        /// </summary>
        /// <param name="M_news">实体层news类的对象</param>
        /// <returns>DataSet数据集</returns>
        public DataSet AdminQueryByNewsInfo(Model.news M_news)
        {
            return DAL_news.AdminQueryByNewsInfo(M_news.info);
        }
        #endregion

        #region 修改指定的新闻,修改成功返回true,否则返回false
        /// <summary>
        /// 修改指定的新闻,修改成功返回true,否则返回false
        /// </summary>
        /// <param name="M_news">对象参数</param>
        /// <returns>成功返回true,失败返回false</returns>
        public bool UpdateNews(Model.news M_news)
        {
            return DAL_news.UpdateNews(M_news);
        }
        #endregion

        #region 获取所有没审核的新闻集合
        /// <summary>
        /// 获取所有没审核的新闻集合
        /// </summary>
        /// <returns>DataSet数据集合</returns>
        public DataSet GetNewsOfFlag0()
        {
            return DAL_news.GetNewsOfFlag0();
        }
        #endregion

        #region 根据id进行审核新闻,审核成功返回true,否则返回false
        /// <summary>
        /// 根据id进行审核新闻,审核成功返回true,否则返回false
        /// </summary>
        /// <param name="M">实体层news类的对象</param>
        /// <returns>审核成功返回true,否则返回false</returns>
        public bool CheckNewsByID(Model.news M)
        {
            return DAL_news.CheckNewsByID(M.id);
        }
        #endregion

        #region 根据栏目ID删除该栏目的所有新闻信息
        /// <summary>
        /// 根据栏目ID删除该栏目的所有新闻信息
        /// </summary>
        /// <param name="Mn">实体层news类的对象</param>
        /// <returns>true,false</returns>
        public bool DeleteNewsByBigClassID(Model.news Mn)
        {
            return DAL_news.DeleteNewsByBigClassID(Mn.BigClassID);
        }
        #endregion
    }
}
