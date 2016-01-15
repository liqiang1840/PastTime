using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BLL
{
    public class news
    {
        #region �����ӿڲ�
        /// <summary>
        /// �����ӿڲ�,ͳһ�������еķ�����ʵ��ҳ��ĵ��õȣ�
        /// </summary>
        #endregion

        #region ʵ������Ķ���
        /// <summary>
        /// ʵ����ҵ���߼���SQLServerDAL��news�Ķ���
        /// ʵ����ʵ���Model��news�Ķ���
        /// </summary>
        SQLServerDAL.news DAL_news = new SQLServerDAL.news();
        Model.news M_news = new Model.news();
        #endregion

        #region ��ȡ��������ID
        /// <summary>
        /// ��ȡ��������ID
        /// </summary>
        /// <returns>DataSet���ݼ�</returns>
        public DataSet GetNewsID()
        {
            return DAL_news.GetNewsID();
        }
        #endregion

        #region ��ȡȫ����������,����DataSet����
        /// <summary>
        /// ��ȡȫ����������,����DataSet����
        /// </summary>
        /// <returns></returns>
        public DataSet GetData_news()
        {
            return DAL_news.GetData_news();
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
            return DAL_news.GetData_news(BigClassID);
        }
        #endregion

        #region ����Ŀ��ȡ�����б�
        /// <summary>
        /// ����Ŀ��ȡ�����б�
        /// </summary>
        /// <returns>DataSet���ݼ�</returns>
        public DataSet GetDataByBigClass(int BigClassID)
        {
            return DAL_news.GetDataByBigClass(BigClassID);
        }
        #endregion

        #region ��ȡÿ������ǰ6������
        /// <summary>
        /// ��ȡÿ������ǰ6������
        /// </summary>
        /// <returns>DataSet���ݼ�</returns>
        public DataSet GetDataByBigClassTopSix()
        {
            return DAL_news.GetDataByBigClassTopSix(M_news);
        }
        #endregion

        #region ��ȡ����8������
        /// <summary>
        /// ��ȡ����8������
        /// </summary>
        /// <returns>DataSet���ݼ�</returns>
        public DataSet GetDataEightNew()
        {
            return DAL_news.GetDataEightNew();
        }
        #endregion

        #region ��ȡ�������ߵ�10�����ű���
        /// <summary>
        /// ��ȡ�������ߵ�10�����ű���
        /// </summary>
        /// <returns>DataSet���ݼ�</returns>
        public DataSet GetDataTopTenHits()
        {
            return DAL_news.GetDataTopTenHits();
        }
        #endregion 

        #region ����µ�����,��ӳɹ�����true,���򷵻�false
        /// <summary>
        /// �������,,��ӳɹ�����true,���򷵻�false
        /// </summary>
        /// <param name="m_news">�������</param>
        /// <returns>�ɹ�����true,ʧ�ܷ���false</returns>
        public bool AddNews(Model.news m_news)
        {
            return DAL_news.AddNews(m_news);
        }
        #endregion

        #region ��������idɾ������,ɾ���ɹ�����true,���򷵻�false
        /// <summary>
        /// ��������idɾ������,ɾ���ɹ�����true,���򷵻�false
        /// </summary>
        /// <param name="M">ʵ���news��Ķ���</param>
        /// <returns>true��false </returns>
        public bool DeleteNewByID(Model.news M)
        {
            return DAL_news.DeleteNewByID(M.id);
        }
        #endregion

        #region  �������ŵĵ����
        /// <summary>
        /// �������ŵĵ����
        /// </summary>
        public void UpdateHits(int id)
        {
            DAL_news.UpdateHits(id);
        }
        #endregion  

        #region ����ָ��id��ָ������������
        /// <summary>
        /// ����ָ��id��ָ������������
        /// </summary>
        /// <param name="id">Ҫ�󶨵�����id</param>
        /// <returns>DataSet���ݼ���</returns>
        public DataSet DataBindNews(int id)
        {
            return DAL_news.DataBindNews(id);
        }
        #endregion

        #region �����ű���ģ����ѯ�����б�
        /// <summary>
        /// �����ű���ģ����ѯ�����б�
        /// </summary>
        /// <param name="M_news">ʵ���news��Ķ���</param>
        /// <returns>DataSet���ݼ�</returns>
        public DataSet QueryByNewsTitle(Model.news M_news)
        {
            return DAL_news.QueryByNewsTitle(M_news.title);
        }
        #endregion

        #region �����ű���ģ����ѯ�����б�
        /// <summary>
        /// �����ű���ģ����ѯ�����б�
        /// </summary>
        /// <param name="M_news">ʵ���news��Ķ���</param>
        /// <returns>DataSet���ݼ�</returns>
        public DataSet AdminQueryByNewsTitle(Model.news M_news)
        {
            return DAL_news.AdminQueryByNewsTitle(M_news.title);
        }
        #endregion

        #region ����������ģ����ѯ�����б�
        /// <summary>
        /// ����������ģ����ѯ�����б�
        /// </summary>
        /// <param name="M_news">ʵ���news��Ķ���</param>
        /// <returns>DataSet���ݼ�</returns>
        public DataSet QueryByNewsInfo(Model.news M_news)
        {
            return DAL_news.QueryByNewsInfo(M_news.info);
        }
        #endregion

        #region ����������ģ����ѯ�����б�
        /// <summary>
        /// ����������ģ����ѯ�����б�
        /// </summary>
        /// <param name="M_news">ʵ���news��Ķ���</param>
        /// <returns>DataSet���ݼ�</returns>
        public DataSet AdminQueryByNewsInfo(Model.news M_news)
        {
            return DAL_news.AdminQueryByNewsInfo(M_news.info);
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
            return DAL_news.UpdateNews(M_news);
        }
        #endregion

        #region ��ȡ����û��˵����ż���
        /// <summary>
        /// ��ȡ����û��˵����ż���
        /// </summary>
        /// <returns>DataSet���ݼ���</returns>
        public DataSet GetNewsOfFlag0()
        {
            return DAL_news.GetNewsOfFlag0();
        }
        #endregion

        #region ����id�����������,��˳ɹ�����true,���򷵻�false
        /// <summary>
        /// ����id�����������,��˳ɹ�����true,���򷵻�false
        /// </summary>
        /// <param name="M">ʵ���news��Ķ���</param>
        /// <returns>��˳ɹ�����true,���򷵻�false</returns>
        public bool CheckNewsByID(Model.news M)
        {
            return DAL_news.CheckNewsByID(M.id);
        }
        #endregion

        #region ������ĿIDɾ������Ŀ������������Ϣ
        /// <summary>
        /// ������ĿIDɾ������Ŀ������������Ϣ
        /// </summary>
        /// <param name="Mn">ʵ���news��Ķ���</param>
        /// <returns>true,false</returns>
        public bool DeleteNewsByBigClassID(Model.news Mn)
        {
            return DAL_news.DeleteNewsByBigClassID(Mn.BigClassID);
        }
        #endregion
    }
}
