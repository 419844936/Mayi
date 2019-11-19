<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShouYeNew.aspx.cs" Inherits="MaYiGzsUI.ShouYeNew" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta http-equiv="content-type" content="text/html; charset=utf-8"/>
    <meta name="apple-mobile-web-app-capable" content="yes"/>
    <link href="resources/css/jquery-ui-themes.css" type="text/css" rel="stylesheet"/>
    <link href="resources/css/axure_rp_page.css" type="text/css" rel="stylesheet"/>
    <link href="data/styles.css" type="text/css" rel="stylesheet"/>
    <link href="files/首页/styles.css" type="text/css" rel="stylesheet"/>
    <script type="text/javascript" src="js/jquery-1.11.0.min.js"></script>
    <script type="text/javascript">
        function lunbo() {
            var index = 0;//当前播放图片的索引
            var stop = false;//默认为自动播放
            var $li = $(".banner").find("#imgs li");//保存组织编号的li
            var $pageIndex = $(".banner").find("#numbers li");
            $pageIndex.eq(index).addClass("number_over").stop(true, true).siblings().removeClass("number_over");

            setInterval(function () {
                if (stop) return;
                index++;
                if (index >= $li.length) {
                    index = 0;
                }
                $li.eq(index).stop(true, true).fadeIn("slow").siblings().fadeOut("slow");
                $pageIndex.eq(index).addClass("number_over").stop(true, true).siblings().removeClass("number_over");
            }, 3000);
            $pageIndex.mouseover(function () {
                stop = true;
                index = $pageIndex.index($(this));
                $li.eq(index).stop(true, true).fadeIn("slow").siblings().fadeOut("slow");
                $(this).addClass("number_over").stop(true, true).siblings().removeClass("number_over");
            }).mouseout(function () {
                stop = false;
            });
        }
        $(function () {
            lunbo();
        })
    </script>
    <style type="text/css">
        #base {
        
            background-image:url("images/BGM/新建文件夹256299103.jpg" );
        }
    </style>
</head>
<body style="margin:auto">
    <form id="form1" runat="server">
    <div id="base" class="">

      <!-- Unnamed (图片) -->
      <div id="u0" class="ax_default _图片 selected">
        <img id="u0_img" class="img " src="images/首页/u0.png"/>
      </div>

      <!-- Unnamed (矩形) -->
      <div id="u1" class="ax_default box_3">
        <div id="u1_div" class=""></div>
      </div>

      <!-- Unnamed (矩形) -->

      <!-- Unnamed (表格) -->
      <%--<div id="u3" class="ax_default">

        <!-- Unnamed (单元格) -->
        <div id="u4" class="ax_default table_cell">
          <img id="u4_img" class="img " src="images/首页/u4.png"/>
          <div id="u4_text" class="text ">
            <a href="ShouYeNew.aspx">首页</a>
          </div>
        </div>

        <!-- Unnamed (单元格) -->
        <div id="u5" class="ax_default table_cell">
          <img id="u5_img" class="img " src="images/首页/u5.png"/>
          <div id="u5_text" class="text ">
            <a href="ShouYeNew.aspx">我的蚂蚁</a>
          </div>
        </div>

        <!-- Unnamed (单元格) -->
        <div id="u6" class="ax_default table_cell">
          <img id="u6_img" class="img " src="images/首页/u6.png"/>
          <div id="u6_text" class="text ">
            <a href="ShouYeNew.aspx">职位浏览</a>
          </div>
        </div>

        <!-- Unnamed (单元格) -->
        <div id="u7" class="ax_default table_cell">
          <img id="u7_img" class="img " src="images/首页/u7.png"/>
          <div id="u7_text" class="text ">
            <a href="ShouYeNew.aspx">我要求职</a>
          </div>
        </div>

        <!-- Unnamed (单元格) -->
        <div id="u8" class="ax_default table_cell">
          <img id="u8_img" class="img " src="images/首页/u8.png"/>
          <div id="u8_text" class="text ">
            <a href="ShouYeNew.aspx">我要招聘</a>
          </div>
        </div>

          <!-- Unnamed (单元格) -->
        <div id="u9" class="ax_default table_cell">
          <img id="u8_img" class="img " src="images/首页/u8.png"/>
          <div id="u9_text" class="text ">
            <a href="ShouYeNew.aspx">我要招聘</a>
          </div>
        </div>
      </div>--%>
        <div id="u0">
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
        <a href="ShouYeNew.aspx" style="color: #000000; font-size: large; font-weight: 700;">首页</a>&nbsp;
        <a href="公司页面.aspx" style="color: #000000; background-color: #FFFFFF; font-size: large; font-weight: 700;">公司信息</a>&nbsp;
        <a href="Job.aspx" style="color: #000000; font-size: large; font-weight: 700;">职位浏览</a>&nbsp;
        <a href="我的求职.aspx" style="color: #000000; font-size: large; font-weight: 700;">我要求职</a>&nbsp;
        <a href="我要招聘.aspx" style="color: #000000; font-size: large; font-weight: 700;">我要招聘</a>&nbsp;
        <a href="求职档案.aspx" style="color: #000000; font-size: large; font-weight: 700;">求职档案</a>&nbsp;
        <a href="关于我们.aspx" style="color: #000000; font-size: large; font-weight: 700;">关于我们</a>
      </div>

      <!-- Unnamed (图片) -->
      <div id="u54" class="ax_default _图片">
        <img id="u54_img" class="img " src="images/首页/u54.png"/>
      </div>

        <%--轮播图片--%>
        <div id="u55" class="banner" style="margin-left:150px;overflow:hidden;margin-top:-180px;height:350px;">
        <ul id="imgs">
          <li>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <img src="images/首页/img1%20(1).png" width="540" height="320"/></li>
          <li>
              <img src="images/首页/img1%20(2).png" width="540" height="320"/></li>
          <li>
              <img src="images/首页/img1%20(3).png" width="540" height="320"/></li>
        </ul>
        <ul id="numbers">
          <li>1</li>
          <li>2</li>
          <li>3</li>
        </ul>
            </div>

      <!-- Unnamed (图片) -->
      <div id="u56" class="ax_default _图片">
        <img id="u56_img" class="img " src="images/首页/u56.png"/>
      </div>

      <!-- Unnamed (文本框) -->
      <%--<div id="u57" class="ax_default text_field">
        <input id="u57_input" type="text" value=""/>
      </div>--%>
        <asp:TextBox ID="u57" runat="server"></asp:TextBox>

      <!-- Unnamed (提交按钮) -->
      <%--<div id="u58" class="ax_default html_button">
        <input id="u58_input" type="submit" value="搜索"/>--%>
          <asp:Button ID="u58" runat="server" Text="搜索" OnClick="u58_Click" />
     <%-- </div>--%>

      <!-- Unnamed (矩形) -->
      <div id="u59" class="ax_default box_2">
        <div id="u59_div" class=""></div>
      </div>

      <!-- Unnamed (图片) -->
      <div id="u60" class="ax_default _图片">
        <img id="u60_img" class="img " src="images/首页/u60.gif"/>
      </div>

      <!-- Unnamed (图片) -->
      <div id="u61" class="ax_default _图片">
        <img id="u61_img" class="img " src="images/首页/u61.gif"/>
      </div>

      <!-- Unnamed (图片) -->
      <div id="u62" class="ax_default _图片">
        <img id="u62_img" class="img " src="images/首页/u62.gif"/>
      </div>

      <!-- Unnamed (图片) -->
      <div id="u63" class="ax_default _图片">
        <img id="u63_img" class="img " src="images/首页/u63.gif"/>
      </div>

      <!-- Unnamed (图片) -->
      <div id="u64" class="ax_default _图片">
        <img id="u64_img" class="img " src="images/首页/u64.gif"/>
      </div>

      <!-- Unnamed (图片) -->
      <div id="u65" class="ax_default _图片">
        <img id="u65_img" class="img " src="images/首页/u65.gif"/>
      </div>

      <!-- Unnamed (图片) -->
      <div id="u66" class="ax_default _图片">
        <img id="u66_img" class="img " src="images/首页/u66.gif"/>
      </div>

      <!-- Unnamed (图片) -->
      <div id="u67" class="ax_default _图片">
        <img id="u67_img" class="img " src="images/首页/u67.gif"/>
      </div>

      <!-- Unnamed (图片) -->
      <div id="u68" class="ax_default _图片">
        <img id="u68_img" class="img " src="images/首页/u68.gif"/>
      </div>

      <!-- Unnamed (图片) -->
      <div id="u69" class="ax_default _图片">
        <img id="u69_img" class="img " src="images/首页/u69.gif"/>
      </div>

      <!-- Unnamed (图片) -->
      <div id="u70" class="ax_default _图片">
        <img id="u70_img" class="img " src="images/首页/u70.gif"/>
      </div>

      

      
      

      <!-- Unnamed (矩形) -->
      <div id="u83" class="ax_default label">
        <div id="u83_div" class=""></div>
        <div id="u83_text" class="text ">
          <p><span><a href="#">·广东高云半导体科技股份有限公司</a> </span></p><p><span><a href="#">·上海霄腾机电设备有限公司</a>·上海霄腾机电设备有限公司</span></p><p><span><a href="#">·四川蓝漂日用品有限公司 电商推广</a></span></p><p><span><a href="#">·金帝集团有限公司 经理助理</a></span></p><p><span><a href="#">·杭州银行股份有限公司</span></p><p><span><a href="#">·艺星医疗美容集团股份有限公司</a></span></p><p><span><a href="#">·安徽古井集团有限责任公司 业务主管</a></span></p><p><span><br /></span></p>
        </div>
      </div>

      <!-- Unnamed (矩形) -->
      <div id="u84" class="ax_default _三级标题">
        <div id="u84_div" class=""></div>
        <div id="u84_text" class="text ">
          <p><span>知名企业</span></p>
        </div>
      </div>

      <!-- Unnamed (矩形) -->
      <div id="u85" class="ax_default box_2">
        <div id="u85_div" class=""></div>
      </div>

      <!-- Unnamed (图片) -->
      <div id="u86" class="ax_default _图片">
        <img id="u86_img" class="img " src="images/首页/u86.png"/>
      </div>

      <!-- Unnamed (图片) -->
      <div id="u87" class="ax_default _图片">
        <img id="u87_img" class="img " src="images/首页/u87.png"/>
      </div>
    </div>
    </form>
</body>
</html>
