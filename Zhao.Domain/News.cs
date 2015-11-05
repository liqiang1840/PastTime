using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zhao.Domain
{
    public class News
    {
        public int Id
        {
            get; set;
        }

        public Catalog Catalog
        {
            get;
            set;
        }
        public string Title
        {
            get; set;
        }

        public List<string> Keys
        {
            get;
            set;
        }

        public string ComeFrom
        {
            get; set;
        }

        public Author Operater
        {
            get; set;
        }

      
        public DateTime CreateTime
        {
            get; set;
        }

        public string Context
        {
            get;
            set;
        }

        public PublishStatus PublishStatus
        {
            get; set;
        }
        public string IPAddress
        { get; set; }

        public int ReadCount
        {
            get;
            set;
        }

        public int Comment
        {
            get; set;
        }
    }

    public enum PublishStatus
    {
        Pending = 0,
        Success = 1,
        Closed = 2
    }
}
