<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="ZT_Ordering.Web.AdminPortal.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
		<meta charset="utf-8" />
		<title> 紫藤坊点餐系统V1.0</title>
		<meta name="description" content="网站后台管理系统" />
		<meta name="keywords" content="网站后台" />
		<!-- We need to emulate IE7 only when we are to use excanvas -->
		<!--[if IE]>
		<meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
		<![endif]-->
		<!-- Favicons -->
		<link rel="shortcut icon" type="image/png" HREF="img/favicons/favicon.png"/>
		<link rel="icon" type="image/png" HREF="img/favicons/favicon.png"/>
		<link rel="apple-touch-icon" HREF="img/favicons/apple.png" />
		<!-- Main Stylesheet -->
		<link rel="stylesheet" href="css/style.css" type="text/css" />
		<!-- Colour Schemes
		Default colour scheme is blue. Uncomment prefered stylesheet to use it.
		<link rel="stylesheet" href="css/brown.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="css/gray.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="css/green.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="css/pink.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="css/red.css" type="text/css" media="screen" />
		-->
		<!-- Your Custom Stylesheet -->
		<link rel="stylesheet" href="css/custom.css" type="text/css" />
		<!--swfobject - needed only if you require <video> tag support for older browsers -->
		<script type="text/javascript" SRC="js/swfobject.js"></script>
		<!-- jQuery with plugins -->
		<script type="text/javascript" SRC="js/jquery-1.4.2.min.js"></script>
		<!-- Could be loaded remotely from Google CDN : <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script> -->
		<script type="text/javascript" SRC="js/jquery.ui.core.min.js"></script>
		<script type="text/javascript" SRC="js/jquery.ui.widget.min.js"></script>
		<script type="text/javascript" SRC="js/jquery.ui.tabs.min.js"></script>
		<!-- jQuery tooltips -->
		<script type="text/javascript" SRC="js/jquery.tipTip.min.js"></script>
		<!-- Superfish navigation -->
		<script type="text/javascript" SRC="js/jquery.superfish.min.js"></script>
		<script type="text/javascript" SRC="js/jquery.supersubs.min.js"></script>
		<!-- jQuery form validation -->
		<script type="text/javascript" SRC="js/jquery.validate_pack.js"></script>
		<!-- jQuery popup box -->
		<script type="text/javascript" SRC="js/jquery.nyroModal.pack.js"></script>
		<!-- jQuery graph plugins -->
		<!--[if IE]><script type="text/javascript" src="js/flot/excanvas.min.js"></script><![endif]-->
		<script type="text/javascript" SRC="js/flot/jquery.flot.min.js"></script>
		<!-- Internet Explorer Fixes -->
		<!--[if IE]>
		<link rel="stylesheet" type="text/css" media="all" href="css/ie.css"/>
		<script src="js/html5.js"></script>
		<![endif]-->
		<!--Upgrade MSIE5.5-7 to be compatible with MSIE8: http://ie7-js.googlecode.com/svn/version/2.1(beta3)/IE8.js -->
		<!--[if lt IE 8]>
		<script src="js/IE8.js"></script>
		<![endif]-->
		<script type="text/javascript">
		    $(document).ready(function () {
		        /* setup navigation, content boxes, etc... */
		        Administry.setup();
                
		        $("#menu a").click(function () {
		            $("#menu li").removeClass("current");
		            $(this).parents("li").addClass("current");
		           // $("#title").focus();
		            document.getElementById("title").click();
                    
		        });
		    });
		</script>
	</head>
	<body>
		<!-- Header -->
		<header id="top">
			<div class="wrapper">
				<!-- Title/Logo - can use text instead of image -->
				<div id="title"><!--<img SRC="img/logo.png" alt="Administry" />--><small>紫藤坊</small>&nbsp;<span>点餐系统</span> 
				</div>
				<!-- Top navigation -->
				<div id="topnav">
					<a href="#"><img class="avatar" SRC="img/user_32.png" alt="" /></a>
					当前用户 <b>Admin</b>
					<span>|</span><a href="#">设置</a>
					<span>|</span><a href="#">退出</a>
					<br />
					<small>您有<a href="#" class="high"><b>XXXX</b>新消息!</a></small>
				</div>
				<!-- End of Top navigation -->
				<!-- Main navigation -->
				<nav id="menu">
					<ul class="sf-menu">
						<li class="current">
							<a HREF="Dashboard.aspx" target="iframepage">实时</a>
						</li>
                       
                        <li>
                            <a href="Order.aspx" target="iframepage">订单管理</a>
                        </li>
                         <li>
                            <a HREF="Food.aspx" target="iframepage">菜品管理</a>
                        </li>
						<li>
							<a HREF="styles.html"  target="iframepage">样式</a>
							<ul>
								<li>
									<a HREF="styles.html"  target="iframepage">基础样式</a>
								</li>
								<li>
									<a href="#">示例页面</a>
									<ul>
										<li>
											<a HREF="samples-files.html">文件</a>
										</li>
										<li>
											<a HREF="samples-products.html">产品</a>
										</li>
									</ul>
								</li>
							</ul>
						</li>
						<li>
							<a HREF="tables.html">表格</a>
						</li>
						<li>
							<a HREF="forms.html">论坛</a>
						</li>
						<li>
							<a HREF="graphs.html">图表</a>
						</li>
					</ul>
				</nav>
				<!-- End of Main navigation -->
				<!-- Aside links -->
				<aside>
					<b>简体中文</b> &middot; <a href="#">English</a>
				</aside>
				<!-- End of Aside links -->
			</div>
		</header>
		<!-- End of Header -->

        <iframe id="iframepage" name="iframepage" src="Dashboard.aspx" frameborder="0" scrolling="no" width="100%"></iframe>

		<!-- Page footer -->
		<footer id="bottom">
			<div class="wrapper">
				<nav>
					<a href="#">仪表盘</a> &middot; <a href="#">内容</a> &middot; <a href="#">报表</a> &middot; <a href="#">用户</a> &middot; <a href="#">媒体</a> &middot; <a href="#">事件</a> &middot; <a href="#">通讯</a> &middot; <a href="#">设置</a>
				</nav>
				<p>
					Copyright &copy; 2017 <b><a HREF="#" title="紫藤坊科技">紫藤坊科技</a></b>
				</p>
			</div>
		</footer>
		<!-- End of Page footer -->

		<!-- Animated footer -->
		<footer id="animated">
			<ul>
				<li>
					<a href="#">仪表盘</a>
				</li>
				<li>
					<a href="#">内容</a>
				</li>
				<li>
					<a href="#">报表</a>
				</li>
				<li>
					<a href="#">用户</a>
				</li>
				<li>
					<a href="#">媒体</a>
				</li>
				<li>
					<a href="#">事件</a>
				</li>
				<li>
					<a href="#">通讯</a>
				</li>
				<li>
					<a href="#">设置</a>
				</li>
			</ul>
		</footer>
		<!-- End of Animated footer -->

		<!-- Scroll to top link -->
		<a href="#" id="totop">^ 滚动至顶部</a>

		<!-- Admin template javascript load -->
         <script type="text/javascript" SRC="js/administry.js"></script>
         <script  type="text/javascript">

             function changeFrameHeight() {
                 var ifm = document.getElementById("iframepage");
                // ifm.height = 0;
                 ifm.height = ifm.document.documentElement.clientHeight-390;
                // document.getElementById("iframe").height = 0;
                // document.getElementById("iframe").height = document.getElementById("iframe").contentWindow.document.body.scrollHeight;
             }
             
             //window.onresize = function () {
             //    changeFrameHeight();
             //}
         </script>
	</body>
   
</html>
