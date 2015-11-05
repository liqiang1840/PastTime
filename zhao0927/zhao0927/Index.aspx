<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="zhao0927.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta name="viewport" content="width=device-width">
    <title>赵陵铺-生活社区</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=2.0">
    <link rel="stylesheet" type="text/css" href="index.css" media="all">
</head>
<body>
    <form id="form1" runat="server">
        <div class="topbg">
        <div class="fh-tb"><a href="javascript:history.back();"></a></div>
        <div class="topwz">赵陵铺-生活社区</div>
      
    </div>
        <div class="life-all">
        <div class="clear"></div>
        <div class="life-main">
            <div class="all">
                <div class="clear"></div>
                <ul id="nav">
                    <li><a href="#">首页</a></li>
                    <li><a href="#">新闻</a></li>                  
                </ul>
            </div>
        </div>
        <div class="life-center">
            <div class="life-nr">
                <div class="life-wid">
                    <div class="lifepic">
                        <a href="http://localhost:7793/Context/1">
                        <img src="2015061721550712549.jpg" height="65" border="0" width="70"></a>
                    </div>
                    <div class="rightnr">
                        <div class="topwz1">
                            <a href="http://localhost:7793/Context/1">
                                <%=GetTitle() %>
                            </a>
                        </div>
                        <div class="toptb">
                            <div class="wz">
                                发表时间：<%= News.CreateTime.ToShortDateString() %>
                                来源：<%= News.ComeFrom %>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
          
            <div class="fy">
                <div class="fybtn"><a href="http://m.manshijian.com/parties/party_list/2">下一页</a></div><div class="fybtn"><a href="http://m.manshijian.com/parties/party_list/11">最后一页</a></div>
            </div>

        </div>
    </div>
    </form>
</body>
</html>
