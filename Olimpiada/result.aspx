<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="result.aspx.cs" Inherits="Olimpiada.result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	Набрано баллов:<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
			<br />
			<asp:Button ID="Button1" runat="server" Text="Начать игру заново" />
        	<br />
			Предыдущие сессии:<br />
			<asp:GridView ID="GridView1" runat="server">
			</asp:GridView>
        </div>
    </form>
</body>
</html>
