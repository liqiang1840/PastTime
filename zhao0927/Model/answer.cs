using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 项目实体层
    /// 新闻评论类
    /// </summary>
    /// //该源码下载自www.51aspx.com(５１asｐｘ．ｃｏｍ)

    public class answer
    {
        private int _A_id;
        private string _A_user;
        private string _A_qq;
        private string _A_email;
        private string _A_word;
        private string _A_time;
        private int _newID;
        private int _cindex;

        public int A_id
        {
            get { return _A_id; }
            set { _A_id = value; }
        }
        public string A_user
        {
            get { return _A_user; }
            set { _A_user = value; }
        }
        public string A_qq
        {
            get { return _A_qq; }
            set { _A_qq = value; }
        }
        public string A_email
        {
            get { return _A_email; }
            set { _A_email = value; }
        }
        public string A_word
        {
            get { return _A_word; }
            set { _A_word = value; }
        }
        public string A_time
        {
            get { return _A_time; }
            set { _A_time = value; }
        }
        public int newID
        {
            get { return _newID; }
            set { _newID = value; }
        }
        public int cindex
        {
            get { return _cindex; }
            set { _cindex = value; }
        }
    }
}
