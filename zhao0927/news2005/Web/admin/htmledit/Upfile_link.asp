<%Server.ScriptTimeOut=5000%>
<!--#include FILE="upload_5xsoft.inc"-->
<link type=text/css href='admin.css' rel=stylesheet>
<BODY bgColor=menu topmargin=15 leftmargin=15 >
<%

dim upload,file,formName,formPath,iCount,mpath,mfilepath,mfilename
set upload=new upload_5xsoft ''�����ϴ�����

mpath=upload.form("mpath")  '�õ��ϴ�Ŀ¼
response.write mpath
if mpath="" then   
 HtmEnd "������Ҫ�ϴ�����Ŀ¼!"
 set upload=nothing
 response.end
else
 formPath=mpath
  '��Ŀ¼���(/)
 if right(formPath,1)<>"/" then formPath=formPath&"/" 
end if

for each formName in upload.objFile
 set file=upload.file(formName)  ''����һ���ļ�����
 if file.FileSize>0 then         ''��� FileSize > 0 ˵�����ļ�����
randomize
aRnd=cint(rnd*100)
newfileimage=year(now)&month(now)&day(now)&hour(now)&minute(now)&second(now)&  aRnd
mfilename=newfileimage&right(file.filename,4)
response.write mfilename
  file.SaveAs Server.mappath(formPath&mfilename)   ''�����ļ�
  response.write file.FilePath&file.filename&" ("&file.FileSize&") => "&formPath&mfilename&" �ɹ�!<br>"
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
rs("csort")="ͼƬ�ϴ�"
rs("cusername")=session("username")
rs("cdo")="�ϴ���"&mfilename
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