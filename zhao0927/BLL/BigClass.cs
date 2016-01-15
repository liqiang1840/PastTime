using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class BigClass
    {
        #region �����ӿڲ�
        /// <summary>
        /// �����ӿڲ�,ͳһ�������еķ�����ʵ��ҳ��ĵ��õȣ�
        /// </summary>
        #endregion

        #region ʵ������Ķ���
        /// <summary>
        /// ʵ����ҵ���߼���SQLServerDAL��BigClass�Ķ���
        /// ʵ����ʵ���Model��BigClass�Ķ���
        /// </summary>
        SQLServerDAL.BigClass DALBC = new SQLServerDAL.BigClass();
        Model.BigClass delBC = new Model.BigClass();
        #endregion

        #region ���������Ŀ
        /// <summary>
        /// ���������Ŀ,ִ�гɹ�����true,���򷵻�false
        /// </summary>
        /// <param name="Mb">ʵ�����BigClass��Ķ���</param>
        /// <returns>true,false</returns>
        public bool AddBigClass(Model.BigClass Mb)
        {
            return DALBC.AddBigClass(Mb.name);
        }
        #endregion

        #region ɾ��������Ŀ
        /// <summary>
        /// ����idɾ��������Ŀ,ִ�гɹ�����true,���򷵻�false
        /// </summary>
        /// <param name="Mb">ʵ���BigClass��Ķ���</param>
        /// <returns>ִ�гɹ�����true,���򷵻�false</returns>
        public bool DeleteBigClassByID(Model.BigClass Mb)
        {
            return DALBC.DeleteBigClassByID(Mb.id);
        }
        #endregion

        #region �޸�������Ŀ
        /// <summary>
        /// �޸�������Ŀ,ִ�гɹ�����true,���򷵻�false
        /// </summary>
        /// <returns>true,false</returns>
        public bool UpdateBigClass()
        {
            return DALBC.UpdateBigClass(delBC);
        }
        #endregion

        #region ��ȡ�����ȫ������
        /// <summary>
        /// ִ����䷵��BigClass������ݼ���
        /// </summary>
        /// <returns>����DataSet</returns>
        public DataSet GetData_BigClass()
        {
            return DALBC.GetData_BigClass();
        }
        #endregion

        #region ��ȡ������ʾ����Ŀ����
        /// <summary>
        /// ��ȡ������ʾ����Ŀ����
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet GetBigClass()
        {
            return DALBC.GetBigClass();
        }
        #endregion

        #region ����id�޸���Ŀ����ʾ״̬
        /// <summary>
        /// ����id�޸���Ŀ����ʾ״̬,1��ʾ,0����ʾ
        /// </summary>
        /// <returns>true,false</returns>
        public bool UpdateBigClassFlag(Model.BigClass Mb)
        {
            return DALBC.UpdateBigClassFlag(Mb.flag, Mb.id);
        }
        #endregion

        #region ����id�޸���Ŀ���Ƽ���ʾ״̬
        /// <summary>
        /// ����id�޸���Ŀ���Ƽ���ʾ״̬
        /// </summary>
        /// <param name="id">��Ŀ���</param>
        /// <param name="name">��Ŀ����</param>
        /// <param name="flag">��Ŀ״̬</param>
        /// <returns>true,false</returns>
        public bool UpdateBigClassNameAndFlag(Model.BigClass Mb)
        {
            return DALBC.UpdateBigClassNameAndFlag(Mb.id, Mb.name, Mb.flag);
        }
        #endregion  

        #region ����id��ѯ����Ŀ������
        /// <summary>
        /// ����id��ѯ����Ŀ������
        /// </summary>
        /// <param name="Mb">ʵ���BigClass��Ķ���</param>
        /// <returns>DataSet���ݼ���</returns>
        public DataSet GetBigClassByID(Model.BigClass Mb)
        {
            return DALBC.GetBigClassByID(Mb.id);
        }
        
        /// <summary>
        /// ����id��ѯ����Ŀ������
        /// </summary>
        /// <param name="Mb">ʵ���BigClass��Ķ���</param>
        /// <returns>DataSet���ݼ���</returns>
        public DataSet GetBigClassByID(int id)
        {
            return DALBC.GetBigClassByID(id);
        }
        #endregion

        #region ��ȡÿ����Ŀ������������
        /// <summary>
        /// ��ȡÿ����Ŀ������������
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet GetNewsCount()
        {
            return DALBC.GetNewsCount();
        }
        #endregion

        #region ��������˵����Ÿ�����Ŀ�µ���������
        /// <summary>
        /// ��������˵����Ÿ�����Ŀ�µ���������
        /// </summary>
        /// <param name="Mb">ʵ���BigClass��Ķ���</param>
        /// <returns>true,false</returns>
        public bool UpdateNewsCount(Model.BigClass Mb)
        {
            return DALBC.UpdateNewsCount(Mb.id);
        }
        #endregion
    }
}
