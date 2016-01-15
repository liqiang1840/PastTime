using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 实体层----新闻列表
    /// 定义成员变量及属性
    /// </summary>
    public class news
    {
        #region 定义news类的成员变量
        /// <summary>
        /// 定义news类的成员变量
        /// </summary>
        private int _id;
        private string _title;      //新闻标题
        private string _info;       //新闻内容
        private int _BigClassID; //栏目ID
        private string _username;   //发布者名称
        private string _infotime;   //发布时间
        private int _hits;          //点击率
        private int _ok;            //是否设置首页图片信息
        private int _flag;  //是否通过审核,1通过,0没通过
        private int _cindex; //最大索引,得到最大索引就得到了新闻总数

        #endregion

        #region 定义news类成员变量的属性
        /// <summary>
        /// 定义news类成员变量的属性
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
