<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="求职档案.aspx.cs" Inherits="MaYiGzsUI.求职档案" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>求职档案</title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <meta name="apple-mobile-web-app-capable" content="yes" />
    <link href="resources/css/jquery-ui-themes.css" type="text/css" rel="stylesheet" />
    <link href="resources/css/axure_rp_page.css" type="text/css" rel="stylesheet" />
    <link href="data/styles.css" type="text/css" rel="stylesheet" />
    <link href="files/求职档案/styles.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="base" class="">

            <!-- Unnamed (文本框) -->
            <div id="u427" class="ax_default text_field">
                <input id="u427_input" type="text" value="" />
            </div>

            <!-- Unnamed (提交按钮) -->
            <div id="u428" class="ax_default html_button">
                <input id="u428_input" type="submit" value="搜索" />
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u429" class="ax_default link_button">
                <div id="u429_div" class=""></div>
                <div id="u429_text" class="text ">
                    <p><span>登陆</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u430" class="ax_default link_button">
                <div id="u430_div" class=""></div>
                <div id="u430_text" class="text ">
                    <p><span>注册</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u431" class="ax_default box_3">
                <div id="u431_div" class="">
                    <br />
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u432" class="ax_default _三级标题">
                <div id="u432_div" class=""></div>
                <div id="u432_text" class="text ">
                    <p><span>修改档案信息</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u433" class="ax_default _三级标题">
                <div id="u433_div" class=""></div>
                <div id="u433_text" class="text ">
                    <p><span>基本信息</span></p>
                </div>
            </div>

            <!-- Unnamed (水平线) -->
            <div id="u434" class="ax_default line">
                <img id="u434_img" class="img " src="images/求职档案/u434.png" />
            </div>

            <!-- Unnamed (水平线) -->
            <div id="u435" class="ax_default line">
                &nbsp;</div>

            <!-- Unnamed (矩形) -->
            <div id="u436" class="ax_default _三级标题">
                <div id="u436_div" class=""></div>
                <div id="u436_text" class="text ">
                    <p><span>教育经历</span></p>
                </div>
            </div>

            <!-- Unnamed (水平线) -->
            <div id="u437" class="ax_default line">
                <img id="u437_img" class="img " src="images/求职档案/u434.png" />
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u438" class="ax_default button">
                <asp:Button ID="u438_div" runat="server" Text="确定" OnClick="u438_text_Click" />


            </div>

            <!-- Unnamed (矩形) -->
            <div id="u439" class="ax_default button">
                <asp:Button ID="u439_div" runat="server" Text="取消" OnClick="u439_div_Click" />
            </div>

            <!-- Unnamed (图片) -->
            <div id="u440" class="ax_default _图片">
                <img id="u440_img" class="img " src="images/首页/u54.png" />
            </div>

            <!-- Unnamed (表格) -->
            <div id="u441" class="ax_default">

                <!-- Unnamed (单元格) -->
                <div id="u442" class="ax_default table_cell">
                    <img id="u442_img" class="img " src="images/求职档案/u442.png" />
                    <div id="u442_text" class="text ">
                        <p><a href="ShouYeNew.aspx">首页</a></p>
                    </div>
                </div>

                <!-- Unnamed (单元格) -->
                <div id="u443" class="ax_default table_cell">
                    <img id="u443_img" class="img " src="images/求职档案/u443.png" />
                    <div id="u443_text" class="text ">
                        <p><a href="我的求职.aspx">我的蚂蚁</a></p>
                    </div>
                </div>

                <!-- Unnamed (单元格) -->
                <div id="u444" class="ax_default table_cell">
                    <img id="u444_img" class="img " src="images/求职档案/u444.png" />
                    <div id="u444_text" class="text ">
                        <p><a href="Job.aspx">职位</a></p>
                    </div>
                </div>

                <!-- Unnamed (单元格) -->
                <div id="u445" class="ax_default table_cell">
                    <img id="u445_img" class="img " src="images/求职档案/u445.png" />
                    <div id="u445_text" class="text ">
                        <p><span>公司</span></p>
                    </div>
                </div>

                <!-- Unnamed (单元格) -->
                <div id="u446" class="ax_default table_cell">
                    <img id="u446_img" class="img " src="images/求职档案/u446.png" />
                    <div id="u446_text" class="text ">
                        <p><span>工资</span></p>
                    </div>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u447" class="ax_default label">
                <div id="u447_div" class=""></div>
                <div id="u447_text" class="text ">
                    <p><span>姓&nbsp; &nbsp; &nbsp;&nbsp; 名：</span></p>
                </div>
            </div>

            <!-- Unnamed (文本框) -->
            <div id="u448" class="ax_default text_field">

                <asp:TextBox ID="u448_input" runat="server"></asp:TextBox>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u449" class="ax_default label">
                <div id="u449_div" class=""></div>
                <div id="u449_text" class="text ">
                    <p><span>年&nbsp; &nbsp; &nbsp;&nbsp; 龄：</span></p>
                </div>
            </div>

            <!-- Unnamed (文本框) -->
            <div id="u450" class="ax_default text_field">

                <asp:TextBox ID="u450_input" runat="server"></asp:TextBox>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u451" class="ax_default label">
                <div id="u451_div" class=""></div>
                <div id="u451_text" class="text ">
                    <p><span>手机号码：</span></p>
                </div>
            </div>

            <!-- Unnamed (文本框) -->
            <div id="u452" class="ax_default text_field">

                <asp:TextBox ID="u452_input" runat="server"></asp:TextBox>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u453" class="ax_default label">
                <div id="u453_div" class=""></div>
                <div id="u453_text" class="text ">
                    <p><span>性&nbsp; &nbsp; &nbsp;&nbsp; 别：</span></p>
                </div>
            </div>

            <!-- Unnamed (文本框) -->
            <div id="u454" class="ax_default text_field">

                <asp:TextBox ID="u454_input" runat="server"></asp:TextBox>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u455" class="ax_default label">
                <div id="u455_div" class=""></div>
                <div id="u455_text" class="text ">
                    <p><span>工作经验：</span></p>
                </div>
            </div>

            <!-- Unnamed (文本框) -->
            <div id="u456" class="ax_default text_field">

                <asp:TextBox ID="u456_input" runat="server"></asp:TextBox>
            </div>

            <!-- Unnamed (图片) -->

            <!-- Unnamed (矩形) -->
            

            <!-- Unnamed (矩形) -->
            <div id="u459" class="ax_default label">
                <div id="u459_div" class=""></div>
                <div id="u459_text" class="text ">
                    <p><span>必填项</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u460" class="ax_default label">
                <div id="u460_div" class=""></div>
                <div id="u460_text" class="text ">
                    <p><span>必填项</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u461" class="ax_default label">
                <div id="u461_div" class=""></div>
                <div id="u461_text" class="text ">
                    <p><span>必填项</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u462" class="ax_default label">
                <div id="u462_div" class=""></div>
                <div id="u462_text" class="text ">
                    <p><span>必填项</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u463" class="ax_default label">
                <div id="u463_div" class=""></div>
                <div id="u463_text" class="text ">
                    <p><span>必填项</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->

            <!-- Unnamed (矩形) -->

            <!-- Unnamed (文本框) -->

            <!-- Unnamed (文本框) -->

            <!-- Unnamed (矩形) -->

            <!-- Unnamed (矩形) -->

            <!-- Unnamed (矩形) -->

            <!-- Unnamed (矩形) -->
            <div id="u471" class="ax_default label">
                <div id="u471_div" class=""></div>
                <div id="u471_text" class="text ">
                    <p><span>期望行业：</span></p>
                </div>
            </div>

            <!-- Unnamed (文本框) -->

            <!-- Unnamed (文本框) -->
            <div id="u473" class="ax_default text_field">

                <asp:TextBox ID="u473_input" runat="server"></asp:TextBox>
            </div>

            <!-- Unnamed (矩形) -->

            <!-- Unnamed (矩形) -->

            <!-- Unnamed (矩形) -->
            <div id="u476" class="ax_default label">
                <div id="u476_div" class=""></div>
                <div id="u476_text" class="text ">
                    <p><span>时&nbsp; &nbsp; &nbsp;&nbsp; 间：</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u477" class="ax_default label">
                <div id="u477_div" class=""></div>
                <div id="u477_text" class="text ">
                    <p><span>学校名称：</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u478" class="ax_default label">
                <div id="u478_div" class=""></div>
                <div id="u478_text" class="text ">
                    <p><span>专&nbsp; &nbsp; &nbsp;&nbsp; 业：</span></p>
                </div>
            </div>

            <!-- Unnamed (文本框) -->
            <div id="u479" class="ax_default text_field">

                <asp:TextBox ID="u479_input" runat="server"></asp:TextBox>
            </div>

            <!-- Unnamed (文本框) -->
            <div id="u480" class="ax_default text_field">
                <asp:TextBox ID="u480_input" runat="server"></asp:TextBox>

            </div>

            <!-- Unnamed (文本框) -->
            <div id="u481" class="ax_default text_field">

                <asp:TextBox ID="u481_input" runat="server"></asp:TextBox>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u482" class="ax_default label">
                <div id="u482_div" class=""></div>
                <div id="u482_text" class="text ">
                    <p><span>必填项</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u483" class="ax_default label">
                <div id="u483_div" class=""></div>
                <div id="u483_text" class="text ">
                    <p><span>必填项</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u484" class="ax_default label">
                <div id="u484_div" class=""></div>
                <div id="u484_text" class="text ">
                    <p><span>必填项</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u485" class="ax_default label">
                <div id="u485_div" class=""></div>
                <div id="u485_text" class="text ">
                    <p><span>学&nbsp; &nbsp; &nbsp;&nbsp; 历：</span></p>
                </div>
            </div>

            <!-- Unnamed (文本框) -->
            <div id="u486" class="ax_default text_field">

                <asp:TextBox ID="u486_input" runat="server"></asp:TextBox>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u487" class="ax_default label">
                <div id="u487_div" class=""></div>
                <div id="u487_text" class="text ">
                    <p><span>必填项</span></p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
