using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SQLServerDAL
{
    #region ҵ���߼���
    /// <summary>
    /// ҵ���߼���
    /// ����SQL��估���÷���ִ��
    /// </summary>
    #endregion

    public class BigClass
    {
        /// <summary>
        /// ʵ������Ķ���
        /// DBbase��ִ��SQL�����
        /// </summary>
        DBbase db = new DBbase();

        #region ���������Ŀ
        /// <summary>
        /// ���������Ŀ,ִ�гɹ�����true,���򷵻�false
        /// </summary>
        /// <param name="name">��Ŀ����</param>
        /// <returns>true,false</returns>
        public bool AddBigClass(string name)
        {
            int cindex = GetMaxCindex()+1;
            string strSQL = "insert into BigClass (name,cindex) values ('" + name + "'," + cindex + ")";
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        #region ������Ŀidɾ��������Ŀ,ִ�гɹ�����true,���򷵻�false
        /// <summary>
        /// ������Ŀidɾ��������Ŀ,ִ�гɹ�����true,���򷵻�false
        /// </summary>
        /// <param name="delBC">ʵ���Model��BigClass��Ķ���</param>
        /// <returns>true,false</returns>
        public bool DeleteBigClassByID(int id)
        {
            string strSQL = "delete from BigClass where id=" + id;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        #region ������Ŀid�޸�������Ŀ
        /// <summary>
        /// ������Ŀid�޸�������Ŀ,ִ�гɹ�����true,���򷵻�false
        /// </summary>
        /// <param name="delBC">ʵ���Model��BigClass��Ķ���</param>
        /// <returns>true,false</returns>
        public bool UpdateBigClass(Model.BigClass delBC)
        {
            string strSQL = "update BigClass set name='" + delBC.name + "' where id=" + delBC.id;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion

        #region �����������������ݼ���
        /// <summary>
        /// ִ��SQL���,����������������ݼ���
        /// </summary>
        /// <returns>����DataSet</returns>
        public DataSet GetData_BigClass()
        {
            string strSQL = "select * from BigClass";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region ��ȡ������ʾ����Ŀ����
        /// <summary>
        /// ��ȡ������ʾ����Ŀ����
        /// </summary>
        /// <returns>DataSet����</returns>
        public DataSet GetBigClass()
        {
            string strSQL = "select id,name from BigClass where flag='��ʾ' order by cindex";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region ����id�޸���Ŀ����ʾ״̬,1��ʾ,0����ʾ
        /// <summary>
        /// ����id�޸���Ŀ����ʾ״̬,1��ʾ,0����ʾ
        /// </summary>
        /// <param name="flag">��Ŀ״̬</param>
        /// <param name="id">��Ŀ���</param>
        /// <returns>true,false</returns>
        public bool UpdateBigClassFlag(string flag,int id)
        {
            string strSQL = "update BigClass set flag = '" + flag + "' where id=" + id;
            return db.ExecuteNonQuery(false, strSQL);
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
        public bool UpdateBigClassNameAndFlag(int id,string name,string flag)
        {
            string strSQL = "update BigClass set name = '"+name+"', flag = '" + flag + "' where id=" + id;
            return db.ExecuteNonQuery(false, strSQL);
        }
        #endregion  

        #region ����id��ѯ����Ŀ������
        /// <summary>
        /// ����id��ѯ����Ŀ������
        /// </summary>
        /// <param name="M_bc">Modelʵ���Ķ���</param>
        /// <returns>DataSet���ݼ�</returns>
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

        #region ��ȡ����Cindex
        /// <summary>
        /// ��ȡ����Cindex
        /// </summary>
        /// <returns>���cindex</returns>
        public int GetMaxCindex()
        {
            string strSQL = "select max(cindex) as cindex from BigClass";
            return int.Parse(db.ReturnDataSet(strSQL).Tables[0].Rows[0][0].ToString());
        }
        #endregion

        #region ��ȡÿ����Ŀ������������
        /// <summary>
        /// ��ȡÿ����Ŀ������������
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet GetNewsCount()
        {
            string strSQL = "select newscount from BigClass";
            return db.ReturnDataSet(strSQL);
        }
        #endregion

        #region ��������˵����Ÿ�����Ŀ�µ���������
        /// <summary>
        /// ��������˵����Ÿ�����Ŀ�µ���������
        /// </summary>
        /// <param name="BigClassID">��ĿID</param>
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
