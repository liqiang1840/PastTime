using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zhao.Domain
{
    public class NewsLogic
    {
        public News GetNews(string path,string id)
        {
            string file = path+  "News" + id+".xml";
            XmlToEgg<News>.SetXmlPath(file);
            return XmlToEgg<News>.ToEgg();
        }
    }
}
