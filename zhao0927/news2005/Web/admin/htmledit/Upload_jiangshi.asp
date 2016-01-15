<!--#include file="../../include/checkuser2.asp"-->
<%
formname=request.QueryString("formname")
formvalue=request.QueryString("formvalue")
%>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
<title>图片上传</title>
<link type=text/css href='admin.css' rel=stylesheet>
<script language=vbscript>
   sub doform()
	   if document.form1.file.value="" then
	      alert("请选择要上传的文件名")
		  exit sub
	   end if 	 
	   myext=right(trim(document.form1.file.value),4)
       if instr(myext,"jpg")=0 and instr(myext,"gif")=0 and instr(myext,"bmp")=0 and instr(myext,"JPG")=0 and instr(myext,"GIF")=0 and instr(myext,"BMP")=0 then
          alert("你所选择的文件禁止上传！")         
          exit sub
       end if 
	   document.form1.submit
   end sub
</script>
<style type="text/css">

</style>
</head>
<BODY bgColor=menu topmargin=15 leftmargin=15 >
<CENTER>
<FIELDSET align=left>
<LEGEND align=left>图片上传</LEGEND>

<form action="upfile_jiangshi.asp" method="post" enctype="multipart/form-data" name="form1">
<table id=t1  width="95%" border=0 align="center" cellPadding=0 cellSpacing=0>
<tr> <td>
<input type="hidden" name="act" value="upload">
<input type="file" name="file">
<input type="button" name="Button" value="上传" onclick="vbscript:doform">
<input type="hidden" name="mpath" value="../../data_qx/upload/jiangshi/"><br>
类型：jpg,gif,bmp，限制：200K
</tr>
</table>
</form></fieldset>
</body>
</html>


