﻿
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ZT_Ordering.Web.AdminPortal.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
		<meta charset="utf-8" />
		<title>用户登录 - 网站后台管理系统V1.0.1</title>
		<meta name="description" content="网站后台管理系统登录页面" />
		<meta name="keywords" content="网站后台" />
		<!-- Favicons -->
		<link rel="shortcut icon" type="image/png" HREF="img/favicons/favicon.png"/>
		<link rel="icon" type="image/png" HREF="img/favicons/favicon.png"/>
		<link rel="apple-touch-icon" HREF="img/favicons/apple.png" />
		<!-- Main Stylesheet -->
		<link rel="stylesheet" href="css/style.css" type="text/css" />

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

		        // validate signup form on keyup and submit
		        var validator = $("#loginform").validate({
		            rules: {
		                username: "required",
		                password: "required"
		            },
		            messages: {
		                username: "Enter your username",
		                password: "Provide your password"
		            },
		            // the errorPlacement has to take the layout into account
		            errorPlacement: function (error, element) {
		                error.insertAfter(element.parent().find('label:first'));
		            },
		            // set new class to error-labels to indicate valid fields
		            success: function (label) {
		                // set &nbsp; as text for IE
		                label.html("&nbsp;").addClass("ok");
		            }
		        });

		    });
		</script>
		<style type="text/css">
			#unsupported-browser {
				background-color: #fae692;
				background-image: -moz-linear-gradient(#feefae, #fae692);
				background-image: -webkit-linear-gradient(#feefae, #fae692);
				background-image: linear-gradient(#feefae, #fae692);
				background-repeat: repeat-x;
				border-bottom: 1px solid #b3a569;
				color: #211e14;
				padding: 0.7em 0;
				height:80px;
			}
			#unsupported-browser .container {
				background: url(img/ie-notice.png) 0 3px no-repeat;
				background-size: 38px 34px;
				height: 64.6px;
				width: 890px;
				margin: 0px auto;
				padding-left: 76px;
			}
			#unsupported-browser h5 {
				font-size: 13px;
				padding-left: 48px
			}
			#unsupported-browser p {
				margin: 0;
				padding-left: 48px
			}
			#unsupported-browser .button {
				float: right;
				color: #211e14;
				border-color: #968a59;
				background-color: #f2e4ab;
				background-image: -moz-linear-gradient(#fef8db, #f2e4ab);
				background-image: -webkit-linear-gradient(#fef8db, #f2e4ab);
				background-image: linear-gradient(#fef8db, #f2e4ab);
				background-repeat: repeat-x;
				margin-top: 12px
			}
			#unsupported-browser .button:hover {
				background-color: #f1e1a2;
				background-image: -moz-linear-gradient(#fef6d1, #f1e1a2);
				background-image: -webkit-linear-gradient(#fef6d1, #f1e1a2);
				background-image: linear-gradient(#fef6d1, #f1e1a2);
				background-repeat: repeat-x;
				text-shadow: 0 1px rgba(255,255,255,0.9)
			}
			#unsupported-browser .classy {
				display: block;
				margin: 2px 0;
				text-align: center
			}
		</style>
	</head>
	<body>
		<!--提示用户升级浏览器-->
		<div id="unsupported-browser" style="display: none;">
			<div class="container">
				<a href="#" class="button classy">了解更多</a>
				<h5>请注意，我们的系统不再支持Internet Explorer7或8。</h5>
				<p>
					我们建议您升级到<a href="http://ie.microsoft.com/">Internet Explorer 9</a>, <a href="http://chrome.google.com">谷歌浏览器</a>, 或 <a href="http://mozilla.org/firefox/">火狐浏览器</a>.
				</p>
				<p>
					如果您使用的是IE 9，请确保您<a href="http://windows.microsoft.com/en-US/windows7/webpages-look-incorrect-in-Internet-Explorer">关闭“兼容性视图”</a>.
				</p>
			</div>
		</div>
		<!--end 提示用户升级浏览器-->

		<!-- Header -->
		<header id="top">
			<div class="wrapper-login">
				<!-- Title/Logo - can use text instead of image -->
				<div id="title"><img SRC="img/logo.png" alt="Administry" />
				</div>
				<!-- Main navigation -->
				<nav id="menu">
					<ul class="sf-menu">
						<li class="current">
							<a href="#">登录</a>
						</li>
						<li>
							<a href="#">注册</a>
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
		<!-- Page title -->
		<div id="pagetitle">
			<div class="wrapper-login"></div>
		</div>
		<!-- End of Page title -->

		<!-- Page content -->
		<div id="page">
			<!-- Wrapper -->
			<div class="wrapper-login">
				<!-- Login form -->
				<section class="full">

					<h3>登录</h3>

					<div class="box box-info">
						请输入用户名和密码登录系统。
					</div>

					<form id="loginform" method="post" action="Dashboard.aspx">

						<p>
							<label class="required" for="username">用户名:</label>
							<br/>
							<input type="text" id="username" class="full" value="" name="username"/>
						</p>

						<p>
							<label class="required" for="password">密码:</label>
							<br/>
							<input type="password" id="password" class="full" value="" name="password"/>
						</p>

						<p>
							<input type="checkbox" id="remember" class="" value="1" name="remember"/>
							<label class="choice" for="remember">记住登录?</label>
						</p>

						<p>
							<input type="submit" class="btn btn-green big" value="登录"/>
							&nbsp; <a href="#" onClick="$('#emailform').slideDown(); return false;">忘记密码?</a> 或 <a href="#">需要帮助?</a>
						</p>
						<div class="clear">
							&nbsp;
						</div>

					</form>

					<form id="emailform" style="display:none" method="post" action="#">
						<div class="box">
							<p id="emailinput">
								<label for="email">电子邮件:</label>
								<br/>
								<input type="text" id="email" class="full" value="" name="email"/>
							</p>
							<p>
								<input type="submit" class="btn" value="发送"/>
							</p>
						</div>
					</form>

				</section>
				<!-- End of login form -->

			</div>
			<!-- End of Wrapper -->
		</div>
		<!-- End of Page content -->

		<!-- Page footer -->
		<footer id="bottom">
			<div class="wrapper-login">
				<p>
					Copyright &copy; 2012 <b><a HREF="#" title="">紫藤坊科技</a></b>
				</p>
			</div>
		</footer>
		<!-- End of Page footer -->

		<!-- User interface javascript load -->
		<script type="text/javascript" SRC="js/administry.js"></script>
	</body>
</html>
