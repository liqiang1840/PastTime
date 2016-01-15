using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 实体层----新闻栏目表
    /// 定义成员变量及属性 
    /// </summary>
    public class BigClass
    {
        #region  定义类的成员变量
        /// <summary>
        /// 定义类的成员变量
        /// </summary>
        private int _id;
        private string _name;
        private string _flag; //是否显示分类标记
        private int _cindex; //最大索引代表新闻系统新闻的总条数
        private int _newscount;
        #endregion

        #region 定义成员变量的属性
        /// <summary>
        /// 定义类的成员变量的属性
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
