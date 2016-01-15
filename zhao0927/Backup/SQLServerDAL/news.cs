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

    public class news
    {
        /// <summary>
        /// 实例化DBbase类的对象,用于调用其内部方法来执行不同的操作
        /// </summary>
        DBbase db = new DBbase();

        #region 获取现有新闻ID
        /// <summary>
        /// 获取现有新闻ID
        /// </summary>
        /// <returns>DataSet数据集</returns>
        public DataSet GetNewsID()
        {
            string strSQL = "select id from news where flag='已审核'";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 无条件获取全部新闻内容
        /// <summary>
        /// 获取全部新闻内容
        /// </summary>
        /// <returns></returns>
        public DataSet GetData_news()
        {
            string strSQL = "select news.*,BigClass.name from news,BigClass where news.flag='已审核' and  news.BigClassID=BigClass.id";
            return db.ReturnDataSet(strSQL);
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
            string strSQL = "select news.*,BigClass.name from news,BigClass where news.flag='已审核' and news.BigClassID=" + BigClassID + "  and  news.BigClassID=BigClass.id";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 分栏目获取新闻列表
        /// <summary>
        /// 分栏目获取新闻列表
        /// </summary>
        /// <param name="M_news">Model实体层news类的对象</param>
        /// <returns>DataSet数据集</returns>
        public DataSet GetDataByBigClass(int BigClassID)
        {
            string strSQL = "select * from news where BigClassID =" + BigClassID + " and flag='已审核' order by cindex";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 获取每个分栏前6条新闻
        /// <summary>
        /// 获取每个分栏前6条新闻
        /// </summary>
        /// <param name="M_news">Model实体层news类的对象</param>
        /// <returns>DataSet数据集</returns>
        public DataSet GetDataByBigClassTopSix(Model.news M_news)
        {
            string strSQL = "select top 6 * from news where BigClassID='" + M_news.BigClassID.ToString() + "' and flag=1 order by cindex";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 获取最新8条新闻
        /// <summary>
        /// 获取最新8条新闻
        /// </summary>
        /// <returns>DataSet数据集</returns>
        public DataSet GetDataEightNew()
        {
            string strSQL = "select top 8 id,title,infotime,hits from news where flag='已审核' order by cindex";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 获取点击率最高的10条新闻标题
        /// <summary>
        /// 获取点击率最高的10条新闻标题
        /// </summary>
        /// <returns>DataSet数据集</returns>
        public DataSet GetDataTopTenHits()
        {
            string strSQL = "select top 10 id,title,hits from news where flag='已审核' order by hits DESC";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 添加新的新闻,添加成功返回true,否则返回false
        /// <summary>
        /// 添加新闻,添加成功返回true,否则返回false
        /// </summary>
        /// <param name="M_news">参数</param>
        /// <returns>bool值</returns>
        public bool AddNews(Model.news M_news)
        {
            string times = System.DateTime.Now.ToString();
            int cindex = GetMaxCindex()+1;
            string strSQL = "insert news (title,info,BigClassID,username,infotime,cindex) values('" + M_news.title + "','" + M_news.info + "'," + M_news.BigClassID + ",'" + M_news.username + "','" + times + "', " + cindex + " )";
            return db.ExecuteNonQuery(false, strSQL);
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
            string strSQL = "update news set title='" + M_news.title + "',BigClassID=" + M_news.BigClassID + ",info='" + M_news.info + "',username='" + M_news.username + "' where id=" + M_news.id;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        #region 根据新闻id删除新闻,删除成功返回true,否则返回false
        /// <summary>
        /// 根据新闻id删除新闻,删除成功返回true,否则返回false
        /// </summary>
        /// <param name="id">关键字段id</param>
        /// <returns>true,false</returns>
        public bool DeleteNewByID(int id)
        {
            string strSQL = "delete from news where id=" + id;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        #region  更新新闻的点击率
        /// <summary>
        /// 更新新闻的点击率
        /// </summary>
        /// <param name="id">要更新点击率的新闻id</param>
        public void UpdateHits(int id)
        {
            string strSQL = "update news set hits=hits+1 where id=" +id;
            db.ExecuteNonQuery(strSQL);
        }
        #endregion

        #region 根据指定id绑定指定的新闻内容
        /// <summary>
        /// 根据指定id绑定指定的新闻内容
        /// </summary>
        /// <param name="id">要绑定新闻的id</param>
        /// <returns>DataSet数据集合</returns>
        public DataSet DataBindNews(int id)
        {
            string strSQL = "select * from news where id=" + id;
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 按新闻标题模糊查询新闻列表
        /// <summary>
        /// 按新闻标题模糊查询新闻列表
        /// </summary>
        /// <param name="title">新闻标题</param>
        /// <returns>DataSet数据集</returns>
        public DataSet QueryByNewsTitle(string  title)
        {
            string strSQL = "select id,title,infotime,hits from news where flag='已审核' and title like '%" + title + "%' order by cindex";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 按新闻标题模糊查询新闻列表
        /// <summary>
        /// 按新闻标题模糊查询新闻列表
        /// </summary>
        /// <param name="title">新闻标题</param>
        /// <returns>DataSet数据集</returns>
        public DataSet AdminQueryByNewsTitle(string title)
        {
            string strSQL = "select news.*,BigClass.name from news,BigClass where news.flag='已审核' and  news.BigClassID=BigClass.id and title like '%" + title + "%' order by news.cindex";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 按新闻内容模糊查询新闻列表
        /// <summary>
        /// 按新闻内容模糊查询新闻列表
        /// </summary>
        /// <param name="info">新闻内容</param>
        /// <returns>DataSet数据集</returns>
        public DataSet QueryByNewsInfo(string info)
        {
            string strSQL = "select id,title,infotime,hits from news where flag='已审核' and info like '%" + info + "%' order by cindex";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 按新闻内容模糊查询新闻列表
        /// <summary>
        /// 按新闻内容模糊查询新闻列表
        /// </summary>
        /// <param name="info">新闻内容</param>
        /// <returns>DataSet数据集</returns>
        public DataSet AdminQueryByNewsInfo(string info)
        {
            string strSQL = "select news.*,BigClass.name from news,BigClass where news.flag='已审核' and  news.BigClassID=BigClass.id and info like '%" + info + "%' order by news.cindex";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 获取最大的Cindex
        /// <summary>
        /// 获取最大的Cindex
        /// </summary>
        /// <returns>最大cindex</returns>
        public int GetMaxCindex()
        {
            string strSQL = "select max(cindex) as cindex from news";
            return int.Parse(db.ReturnDataSet(strSQL).Tables[0].Rows[0][0].ToString());
        }
        #endregion

        #region 获取所有没审核的新闻集合
        /// <summary>
        /// 获取所有没审核的新闻集合
        /// </summary>
        /// <returns>DataSet数据集合</returns>
        public DataSet GetNewsOfFlag0()
        {
            string strSQL = "select news.*,BigClass.name from news,BigClass where news.flag='未审核' and news.BigClassID=BigClass.id order by news.cindex DESC";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region 根据id进行审核新闻,审核成功返回true,否则返回false
        /// <summary>
        /// 根据id进行审核新闻,审核成功返回true,否则返回false
        /// </summary>
        /// <param name="id">关键字段</param>
        /// <returns>审核成功返回true,否则返回false</returns>
        public bool CheckNewsByID(int id)
        {
            string strSQL = "update news set flag='已审核' where id=" + id;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        #region 根据栏目ID删除该栏目的所有新闻信息
        /// <summary>
        /// 根据栏目ID删除该栏目的所有新闻信息
        /// </summary>
        /// <param name="BigClassID">栏目ID</param>
        /// <returns>true,false</returns>
        public bool DeleteNewsByBigClassID(int BigClassID)
        {
            string strSQL = "delete from news where BigClassID=" + BigClassID;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion  
    }
}
