using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// ʵ���----������Ŀ��
    /// �����Ա���������� 
    /// </summary>
    public class BigClass
    {
        #region  ������ĳ�Ա����
        /// <summary>
        /// ������ĳ�Ա����
        /// </summary>
        private int _id;
        private string _name;
        private string _flag; //�Ƿ���ʾ������
        private int _cindex; //���������������ϵͳ���ŵ�������
        private int _newscount;
        #endregion

        #region �����Ա����������
        /// <summary>
        /// ������ĳ�Ա����������
        /// </summary>
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
        public int cindex
        {
            get { return _cindex; }
            set { _cindex = value; }
        }
        public int newscount
        {
            get { return _newscount; }
            set { _newscount = value; }
        }
        #endregion
    }
}
