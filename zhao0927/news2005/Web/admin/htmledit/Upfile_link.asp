<%Server.ScriptTimeOut=5000%>
<!--#include FILE="upload_5xsoft.inc"-->
<link type=text/css href='admin.css' rel=stylesheet>
<BODY bgColor=menu topmargin=15 leftmargin=15 >
<%

dim upload,file,formName,formPath,iCount,mpath,mfilepath,mfilename
set upload=new upload_5xsoft ''建立上传对象

mpath=upload.form("mpath")  '得到上传目录
response.write mpath
if mpath="" then   
 HtmEnd "请输入要上传至的目录!"
 set upload=nothing
 response.end
else
 formPath=mpath
  '在目录后加(/)
 if right(formPath,1)<>"/" then formPath=formPath&"/" 
end if

for each formName in upload.objFile
 set file=upload.file(formName)  ''生成一个文件对象
 if file.FileSize>0 then         ''如果 FileSize > 0 说明有文件数据
randomize
aRnd=cint(rnd*100)
newfileimage=year(now)&month(now)&day(now)&hour(now)&minute(now)&second(now)&  aRnd
mfilename=newfileimage&right(file.filename,4)
response.write mfilename
  file.SaveAs Server.mappath(formPath&mfilename)   ''保存文件
  response.write file.FilePath&file.filename&" ("&file.FileSize&") => "&formPath&mfilename&" 成功!<br>"
  mfilepath=formPath&mfilename
 end if
 set file=nothing
next

%>
<!--#include file="../../include/conn2.asp"-->
<%
cip = Request.ServerVariables("HTTP_X_FORWARDED_FOR")
If cip = "" Then
cip = Request.ServerVariables("REMOTE_ADDR")
End If
set rs=server.CreateObject("adodb.recordset")
rs.Open "tb_eventlog",con,1,3
rs.AddNew 
rs("csort")="图片上传"
rs("cusername")=session("username")
rs("cdo")="上传了"&mfilename
rs("ctime")=now()
rs("cip")=cip
rs("level")="1"
rs.update
rs.Close 
%>
<script language=vbs>
<!--
window.opener.document.form1.cpic.value="<%=mfilepath%>"
window.close
-->
</script>