using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// ʵ���----�����б�
    /// �����Ա����������
    /// </summary>
    public class news
    {
        #region ����news��ĳ�Ա����
        /// <summary>
        /// ����news��ĳ�Ա����
        /// </summary>
        private int _id;
        private string _title;      //���ű���
        private string _info;       //��������
        private int _BigClassID; //��ĿID
        private string _username;   //����������
        private string _infotime;   //����ʱ��
        private int _hits;          //�����
        private int _ok;            //�Ƿ�������ҳͼƬ��Ϣ
        private int _flag;  //�Ƿ�ͨ�����,1ͨ��,0ûͨ��
        private int _cindex; //�������,�õ���������͵õ�����������

        #endregion

        #region ����news���Ա����������
        /// <summary>
        /// ����news���Ա����������
        /// </summary>
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string info
        {
            get { return _info; }
            set { _info = value; }
        }
        public int BigClassID
        {
            get { return _BigClassID; }
            set { _BigClassID = value; }
        }
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string infotime
        {
            get { return _infotime; }
            set { _infotime = value; }
        }
        public int hits
        {
            get { return _hits; }
            set { _hits = value; }
        }
        public int ok
        {
            get { return _ok; }
            set { _ok = value; }
        }
        public int flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
        public int cindex
        {
            get { return _cindex; }
            set { _cindex = value; }
        }
        #endregion
    }
}
