<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ZhaoPin.aspx.cs" Inherits="MaYiGzsUI.ZhaoPin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        岗位名称：<asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
        <br />
        学历要求：<asp:TextBox ID="txt_xueli" runat="server"></asp:TextBox>
        <br />
        岗位介绍：<asp:TextBox ID="txt_desc" runat="server"></asp:TextBox>
        <br />
        工作经验：<asp:TextBox ID="txt_year" runat="server"></asp:TextBox>
        <br />
        支付薪水：<asp:TextBox ID="txt_money" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="but_ok" runat="server" Text="确定" OnClick="but_ok_Click" />
    
    </div>
    </form>
</body>
</html>
