<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Olimpiada._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	Количество вопросов:<br />
			<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
			<br />
			<asp:Button ID="Button1" runat="server" Text="Начать" />
        </div>
    </form>
</body>
</html>
