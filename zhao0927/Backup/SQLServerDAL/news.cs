using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SQLServerDAL
{
    #region ҵ���߼���
    /// <summary>
    /// ҵ���߼���
    /// ����SQL��估���÷���ִ��
    /// </summary>
    #endregion

    public class news
    {
        /// <summary>
        /// ʵ����DBbase��Ķ���,���ڵ������ڲ�������ִ�в�ͬ�Ĳ���
        /// </summary>
        DBbase db = new DBbase();

        #region ��ȡ��������ID
        /// <summary>
        /// ��ȡ��������ID
        /// </summary>
        /// <returns>DataSet���ݼ�</returns>
        public DataSet GetNewsID()
        {
            string strSQL = "select id from news where flag='�����'";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region ��������ȡȫ����������
        /// <summary>
        /// ��ȡȫ����������
        /// </summary>
        /// <returns></returns>
        public DataSet GetData_news()
        {
            string strSQL = "select news.*,BigClass.name from news,BigClass where news.flag='�����' and  news.BigClassID=BigClass.id";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region ������ĿID��ȡȫ����������
        /// <summary>
        /// ��ȡȫ����������
        /// </summary>
        /// <param name="BigClassID">������ĿID</param>
        /// <returns></returns>
        public DataSet GetData_news(int BigClassID)
        {
            string strSQL = "select news.*,BigClass.name from news,BigClass where news.flag='�����' and news.BigClassID=" + BigClassID + "  and  news.BigClassID=BigClass.id";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region ����Ŀ��ȡ�����б�
        /// <summary>
        /// ����Ŀ��ȡ�����б�
        /// </summary>
        /// <param name="M_news">Modelʵ���news��Ķ���</param>
        /// <returns>DataSet���ݼ�</returns>
        public DataSet GetDataByBigClass(int BigClassID)
        {
            string strSQL = "select * from news where BigClassID =" + BigClassID + " and flag='�����' order by cindex";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region ��ȡÿ������ǰ6������
        /// <summary>
        /// ��ȡÿ������ǰ6������
        /// </summary>
        /// <param name="M_news">Modelʵ���news��Ķ���</param>
        /// <returns>DataSet���ݼ�</returns>
        public DataSet GetDataByBigClassTopSix(Model.news M_news)
        {
            string strSQL = "select top 6 * from news where BigClassID='" + M_news.BigClassID.ToString() + "' and flag=1 order by cindex";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region ��ȡ����8������
        /// <summary>
        /// ��ȡ����8������
        /// </summary>
        /// <returns>DataSet���ݼ�</returns>
        public DataSet GetDataEightNew()
        {
            string strSQL = "select top 8 id,title,infotime,hits from news where flag='�����' order by cindex";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region ��ȡ�������ߵ�10�����ű���
        /// <summary>
        /// ��ȡ�������ߵ�10�����ű���
        /// </summary>
        /// <returns>DataSet���ݼ�</returns>
        public DataSet GetDataTopTenHits()
        {
            string strSQL = "select top 10 id,title,hits from news where flag='�����' order by hits DESC";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region ����µ�����,��ӳɹ�����true,���򷵻�false
        /// <summary>
        /// �������,��ӳɹ�����true,���򷵻�false
        /// </summary>
        /// <param name="M_news">����</param>
        /// <returns>boolֵ</returns>
        public bool AddNews(Model.news M_news)
        {
            string times = System.DateTime.Now.ToString();
            int cindex = GetMaxCindex()+1;
            string strSQL = "insert news (title,info,BigClassID,username,infotime,cindex) values('" + M_news.title + "','" + M_news.info + "'," + M_news.BigClassID + ",'" + M_news.username + "','" + times + "', " + cindex + " )";
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        #region �޸�ָ��������,�޸ĳɹ�����true,���򷵻�false
        /// <summary>
        /// �޸�ָ��������,�޸ĳɹ�����true,���򷵻�false
        /// </summary>
        /// <param name="M_news">�������</param>
        /// <returns>�ɹ�����true,ʧ�ܷ���false</returns>
        public bool UpdateNews(Model.news M_news)
        {
            string strSQL = "update news set title='" + M_news.title + "',BigClassID=" + M_news.BigClassID + ",info='" + M_news.info + "',username='" + M_news.username + "' where id=" + M_news.id;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        #region ��������idɾ������,ɾ���ɹ�����true,���򷵻�false
        /// <summary>
        /// ��������idɾ������,ɾ���ɹ�����true,���򷵻�false
        /// </summary>
        /// <param name="id">�ؼ��ֶ�id</param>
        /// <returns>true,false</returns>
        public bool DeleteNewByID(int id)
        {
            string strSQL = "delete from news where id=" + id;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        #region  �������ŵĵ����
        /// <summary>
        /// �������ŵĵ����
        /// </summary>
        /// <param name="id">Ҫ���µ���ʵ�����id</param>
        public void UpdateHits(int id)
        {
            string strSQL = "update news set hits=hits+1 where id=" +id;
            db.ExecuteNonQuery(strSQL);
        }
        #endregion

        #region ����ָ��id��ָ������������
        /// <summary>
        /// ����ָ��id��ָ������������
        /// </summary>
        /// <param name="id">Ҫ�����ŵ�id</param>
        /// <returns>DataSet���ݼ���</returns>
        public DataSet DataBindNews(int id)
        {
            string strSQL = "select * from news where id=" + id;
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region �����ű���ģ����ѯ�����б�
        /// <summary>
        /// �����ű���ģ����ѯ�����б�
        /// </summary>
        /// <param name="title">���ű���</param>
        /// <returns>DataSet���ݼ�</returns>
        public DataSet QueryByNewsTitle(string  title)
        {
            string strSQL = "select id,title,infotime,hits from news where flag='�����' and title like '%" + title + "%' order by cindex";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region �����ű���ģ����ѯ�����б�
        /// <summary>
        /// �����ű���ģ����ѯ�����б�
        /// </summary>
        /// <param name="title">���ű���</param>
        /// <returns>DataSet���ݼ�</returns>
        public DataSet AdminQueryByNewsTitle(string title)
        {
            string strSQL = "select news.*,BigClass.name from news,BigClass where news.flag='�����' and  news.BigClassID=BigClass.id and title like '%" + title + "%' order by news.cindex";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region ����������ģ����ѯ�����б�
        /// <summary>
        /// ����������ģ����ѯ�����б�
        /// </summary>
        /// <param name="info">��������</param>
        /// <returns>DataSet���ݼ�</returns>
        public DataSet QueryByNewsInfo(string info)
        {
            string strSQL = "select id,title,infotime,hits from news where flag='�����' and info like '%" + info + "%' order by cindex";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region ����������ģ����ѯ�����б�
        /// <summary>
        /// ����������ģ����ѯ�����б�
        /// </summary>
        /// <param name="info">��������</param>
        /// <returns>DataSet���ݼ�</returns>
        public DataSet AdminQueryByNewsInfo(string info)
        {
            string strSQL = "select news.*,BigClass.name from news,BigClass where news.flag='�����' and  news.BigClassID=BigClass.id and info like '%" + info + "%' order by news.cindex";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region ��ȡ����Cindex
        /// <summary>
        /// ��ȡ����Cindex
        /// </summary>
        /// <returns>���cindex</returns>
        public int GetMaxCindex()
        {
            string strSQL = "select max(cindex) as cindex from news";
            return int.Parse(db.ReturnDataSet(strSQL).Tables[0].Rows[0][0].ToString());
        }
        #endregion

        #region ��ȡ����û��˵����ż���
        /// <summary>
        /// ��ȡ����û��˵����ż���
        /// </summary>
        /// <returns>DataSet���ݼ���</returns>
        public DataSet GetNewsOfFlag0()
        {
            string strSQL = "select news.*,BigClass.name from news,BigClass where news.flag='δ���' and news.BigClassID=BigClass.id order by news.cindex DESC";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region ����id�����������,��˳ɹ�����true,���򷵻�false
        /// <summary>
        /// ����id�����������,��˳ɹ�����true,���򷵻�false
        /// </summary>
        /// <param name="id">�ؼ��ֶ�</param>
        /// <returns>��˳ɹ�����true,���򷵻�false</returns>
        public bool CheckNewsByID(int id)
        {
            string strSQL = "update news set flag='�����' where id=" + id;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        #region ������ĿIDɾ������Ŀ������������Ϣ
        /// <summary>
        /// ������ĿIDɾ������Ŀ������������Ϣ
        /// </summary>
        /// <param name="BigClassID">��ĿID</param>
        /// <returns>true,false</returns>
        public bool DeleteNewsByBigClassID(int BigClassID)
        {
            string strSQL = "delete from news where BigClassID=" + BigClassID;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion  
    }
}
