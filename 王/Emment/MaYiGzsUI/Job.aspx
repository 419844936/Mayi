
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Job.aspx.cs" Inherits="MaYiGzsUI.Job" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
            background-color: #FF9933;
            height: 20px;
        }
        boby {
            background-image:url("images/BGM/捕获.PNG");
        }
        #zong {
        background-image:url("images/BGM/捕获.PNG");
        width:100%;
        height:100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="zong">

            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <a href="ShouYeNew.aspx">首页</a>&nbsp;&nbsp;&nbsp;
        <a href="我的求职.aspx">我的蚂蚁</a>&nbsp;&nbsp;&nbsp;
        <a href="Job.aspx">职位浏览</a>&nbsp;&nbsp;&nbsp;
        <a href="我的求职.aspx">我要求职</a>&nbsp;&nbsp;&nbsp;
        <a href="我要招聘.aspx">我要招聘</a>&nbsp;&nbsp;&nbsp;
        <a href="Job.aspx">求职档案</a>&nbsp;&nbsp;&nbsp;
        <a href="Job.aspx">关于我们</a>
    
            <br />
            <br />
            <br />
            <br />
            按城市：&nbsp;&nbsp;&nbsp;
             
            <asp:DropDownList ID="Drop_city" runat="server" OnSelectedIndexChanged="Drop_city_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            按岗位：&nbsp;&nbsp;&nbsp; 
            <asp:DropDownList ID="Drop_job" runat="server" OnSelectedIndexChanged="Drop_job_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            按公司名称：&nbsp; <asp:DropDownList ID="Drop_ComName" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Drop_ComName_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />

            <br />
            <asp:DropDownList ID="drop_xlk1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drop_xlk1_SelectedIndexChanged">
                <asp:ListItem Value="0">按工资降序查询</asp:ListItem>
                <asp:ListItem Value="1">按工资升序查询</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;
            <br />
            <br />
            <table style="width: 100%; background-color: #FFCC99;">
                <tr>
                    <td class="auto-style1">公司名称</td>
                    <td class="auto-style1">招聘岗位</td>
                    <td class="auto-style1">公司位置</td>
                    <td class="auto-style1">工资（元/月）</td>
                    <td class="auto-style1">公司简介</td>
                </tr>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("ComparyName") %></td>
                            <td><%#Eval("JobName") %></td>
                            <td><%#Eval("Comparylocation") %></td>
                            <td><%#Eval("Salary") %></td>
                            <td><%#Eval("CompantDesc") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>

        </div>
    </form>
</body>
</html>
