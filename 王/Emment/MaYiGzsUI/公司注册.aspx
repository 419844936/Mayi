<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="公司注册.aspx.cs" Inherits="MaYiGzsUI.公司注册" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>公司注册</title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <meta name="apple-mobile-web-app-capable" content="yes" />
    <link href="resources/css/jquery-ui-themes.css" type="text/css" rel="stylesheet" />
    <link href="resources/css/axure_rp_page.css" type="text/css" rel="stylesheet" />
    <link href="data/styles.css" type="text/css" rel="stylesheet" />
    <link href="files/公司注册/styles.css" type="text/css" rel="stylesheet" />
    <script src="resources/scripts/jquery-1.7.1.min.js"></script>
    <script src="resources/scripts/jquery-ui-1.8.10.custom.min.js"></script>
    <script src="resources/scripts/prototypePre.js"></script>
    <script src="data/document.js"></script>
    <script src="resources/scripts/prototypePost.js"></script>
    <script src="files/公司注册/data.js"></script>
    <script type="text/javascript">
        $axure.utils.getTransparentGifPath = function () { return 'resources/images/transparent.gif'; };
        $axure.utils.getOtherPath = function () { return 'resources/Other.html'; };
        $axure.utils.getReloadPath = function () { return 'resources/reload.html'; };
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="base" class="">

            <!-- Unnamed (占位符) -->
            <div id="u150" class="ax_default placeholder">
                <img id="u150_img" class="img " src="images/公司注册/u150.png" />
                <div id="u150_text" class="text ">
                    <p><span>logo</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u151" class="ax_default label">
                <div id="u151_div" class=""></div>
                <div id="u151_text" class="text ">
                    <p><span>weAlink.com</span></p>
                    <p><span>中国领先的社交招聘网</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u152" class="ax_default label">
                <div id="u152_div" class=""></div>
                <div id="u152_text" class="text ">
                    <p><span>手机版</span></p>
                </div>
            </div>

            <!-- Unnamed (图片) -->
            <div id="u153" class="ax_default image">
                <img id="u153_img" class="img " src="images/公司注册/u153.png" />
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u154" class="ax_default box_1">
                <div id="u154_div" class=""></div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u155" class="ax_default _三级标题">
                <div id="u155_div" class=""></div>
                <div id="u155_text" class="text ">
                    <p><span>招聘方注册</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u156" class="ax_default label">
                <div id="u156_div" class=""></div>
                <div id="u156_text" class="text ">
                    <p><span>海联名气职位，拓展人脉关系，体验社交招聘</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u157" class="ax_default label">
                <div id="u157_div" class=""></div>
                <div id="u157_text" class="text ">
                    <p><span>公司名称：</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u158" class="ax_default label">
                <div id="u158_div" class=""></div>
                <div id="u158_text" class="text ">
                    <p><span>密码：</span></p>
                </div>
            </div>

            <!-- Unnamed (文本框) -->
            <div id="u159" class="ax_default text_field">
                <asp:TextBox ID="u159_input" runat="server"></asp:TextBox>
            </div>

            <!-- Unnamed (文本框) -->
            <div id="u160" class="ax_default text_field">
                <asp:TextBox ID="u160_input" runat="server"></asp:TextBox>
            </div>

            <!-- Unnamed (复选框) -->
            <div id="u161" class="ax_default checkbox">
              <%--  <label for="u161_input" style="position: absolute; left: 0px;">
                    <div id="u161_text" class="text ">
                        <p><span>我已阅读并接受《用户协议》</span></p>
                    </div>
                </label>
                <input id="u161_input" type="checkbox" value="checkbox" />--%>
                 <asp:CheckBox ID="u143_input" runat="server" Text="我已阅读并接受《用户协议》"  Checked ="true"/>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u162" class="ax_default button">
                <div id="u162_div" class=""></div>
                <asp:Button ID="u162_text" runat="server" Text="注册" OnClick="u162_text_Click" />
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u163" class="ax_default label">
                <div id="u163_div" class=""></div>
                <div id="u163_text" class="text ">
                    <p><span>客户服务邮箱 sdngignigwnieg.com</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u164" class="ax_default label">
                <div id="u164_div" class=""></div>
                <div id="u164_text" class="text ">
                    <p><span>找工作，积人脉?</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u165" class="ax_default label">
                <div id="u165_div" class=""></div>
                <div id="u165_text" class="text ">
                    <a href="注册.aspx">求职者注册》》</a>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u166" class="ax_default label">
                <div id="u166_div" class=""></div>
                <div id="u166_text" class="text ">
                    <p><span>我要登录</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u167" class="ax_default label">
                <div id="u167_div" class=""></div>
                <div id="u167_text" class="text ">
                    <a href="登录.aspx">登录</a>
                </div>
            </div>

            <!-- Unnamed (图片) -->
            <div id="u168" class="ax_default image">
                <img id="u168_img" class="img " src="images/公司注册/u168.png" />
                <div id="u168_text" class="text ">
                    <p><span>招聘图片，为美化</span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u169" class="ax_default label">
                <div id="u169_div" class=""></div>
                <div id="u169_text" class="text ">
                    <p><span>关于若邻 | 联系我们 | 加入我们 | 媒体报道 | 帮助中心 | 友情链接 | 网站地图 | 社区&nbsp; 加关注&nbsp;&nbsp; 关注&nbsp; 热度&nbsp; </span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u170" class="ax_default label">
                <div id="u170_div" class=""></div>
                <div id="u170_text" class="text ">
                    <p><span>根据城市搜索招聘信息 | 根据城市搜索公司信息&nbsp; &nbsp;&nbsp; </span></p>
                </div>
            </div>

            <!-- Unnamed (矩形) -->
            <div id="u171" class="ax_default label">
                <div id="u171_div" class=""></div>
                <div id="u171_text" class="text ">
                    <p><span>确认密码：</span></p>
                </div>
            </div>

            <!-- Unnamed (文本框) -->
            <div id="u172" class="ax_default text_field">
                <asp:TextBox ID="u172_input" runat="server"></asp:TextBox>
            </div>

            <!-- Unnamed (矩形) -->
           

            <!-- Unnamed (文本框) -->
            
        </div>
    </form>
</body>
</html>
