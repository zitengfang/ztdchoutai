<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="ZT_Ordering.Web.AdminPortal.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
		<meta charset="utf-8" />
		<title>仪表盘 - 网站后台管理系统V1.0.1</title>
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

		        /* progress bar animations - setting initial values */
		        Administry.progress("#progress1", 1, 5);
		        Administry.progress("#progress2", 2, 5);
		        Administry.progress("#progress3", 2, 5);

		        /* flot graphs */
		        var sales = [{
		            label: 'Total Paid',
		            data: [[1, 0], [2, 0], [3, 0], [4, 0], [5, 0], [6, 0], [7, 900], [8, 0], [9, 0], [10, 0], [11, 0], [12, 0]]
		        }, {
		            label: 'Total Due',
		            data: [[1, 0], [2, 0], [3, 0], [4, 0], [5, 0], [6, 422.10], [7, 0], [8, 0], [9, 0], [10, 0], [11, 0], [12, 0]]
		        }];

		        var plot = $.plot($("#placeholder"), sales, {
		            bars: {
		                show: true,
		                lineWidth: 1
		            },
		            legend: {
		                position: "nw"
		            },
		            xaxis: {
		                ticks: [[1, "Jan"], [2, "Feb"], [3, "Mar"], [4, "Apr"], [5, "May"], [6, "Jun"], [7, "Jul"], [8, "Aug"], [9, "Sep"], [10, "Oct"], [11, "Nov"], [12, "Dec"]]
		            },
		            yaxis: {
		                min: 0,
		                max: 1000
		            },
		            grid: {
		                color: "#666"
		            },
		            colors: ["#0a0", "#f00"]
		        });

		    });
		</script>
	</head>
	<body>
	
		<!-- Page title -->
		<div id="pagetitle">
			<div class="wrapper">
				<h1>仪表盘</h1>
				<!-- Quick search box -->
				<form action="" method="get">
					<input class="" type="text" id="q" name="q" />
				</form>
			</div>
		</div>
		<!-- End of Page title -->

		<!-- Page content -->
		<div id="page">
			<!-- Wrapper -->
			<div class="wrapper">
				<!-- Left column/section -->
				<section class="column width6 first">

					<div class="colgroup leading">
						<div class="column width3 first">
							<h3>欢迎来到管理平台, <a href="#">Admin</a></h3>
							<p>
								今天是 <b>2017年1月1日，星期八</b>.
							
								
							</p>
						</div>
						<div class="column width3">
							<h4>最后登录</h4>
							<p>
								Monday July 12th, 2010 at 11:32am from 127.0.0.1
								<br />
								No error login attempts.
							</p>
						</div>
					</div>

					<div class="colgroup leading">
						<div class="column width3 first">
							<h4>进行中的订单: <a href="#">10</a></h4>
							<hr/>
							<table class="no-style full">
								<tbody>
									<tr>
										<td>Total Invoices</td>
										<td class="ta-right"><a href="#">10</a></td>
										<td class="ta-right">1,322.10 &euro;</td>
									</tr>
									<tr>
										<td>Total Paid</td>
										<td class="ta-right"><a href="#">9</a></td>
										<td class="ta-right">900.00 &euro;</td>
									</tr>
									<tr>
										<td>Total Due</td>
										<td class="ta-right"><a href="#">1</a></td>
										<td class="ta-right">422.10 &euro;</td>
									</tr>
									<tr>
										<td>Total Overdue</td>
										<td class="ta-right">0</td>
										<td class="ta-right">0.00 &euro;</td>
									</tr>
								</tbody>
							</table>
						</div>
						<div class="column width3">
							<h4>菜品库存量: <a href="#">1</a></h4>
							<hr/>
							<table class="no-style full">
								<tbody>
									<tr>
										<td>Clients This Month</td>
										<td class="ta-right"><a href="#">1</a></td>
										<td class="ta-right"></td>
									</tr>
									<tr>
										<td>Sales This Month</td>
										<td class="ta-right"><a href="#">9</a></td>
										<td class="ta-right">900.00 &euro;</td>
									</tr>
									<tr>
										<td>Clients Total</td>
										<td class="ta-right"><a href="#">5</a></td>
										<td class="ta-right"></td>
									</tr>
									<tr>
										<td>Sales Total</td>
										<td class="ta-right"><a href="#">9</a></td>
										<td class="ta-right">900.00 &euro;</td>
									</tr>
								</tbody>
							</table>
						</div>
					</div>

					<div class="colgroup leading">
						<div class="column width3 first">
							<h4>客户端统计</h4>
							<hr/>
							<table class="no-style full">
								<tbody>
									<tr>
										<td>Active</td>
										<td class="ta-right">1/5</td>
										<td>
										<div id="progress1" class="progress full progress-green">
											<span><b></b></span>
										</div></td>
									</tr>
									<tr>
										<td>Pending</td>
										<td class="ta-right">2/5</td>
										<td>
										<div id="progress2" class="progress full progress-blue">
											<span><b></b></span>
										</div></td>
									</tr>
									<tr>
										<td>Suspended</td>
										<td class="ta-right">2/5</td>
										<td>
										<div id="progress3" class="progress full progress-red">
											<span><b></b></span>
										</div></td>
									</tr>
								</tbody>
							</table>
						</div>
						<div class="column width3">
							<h4>报表</h4>
							<hr/>
							<p>
								<b>今年的销售额</b>
							</p>
							<div id="placeholder" style="height:100px"></div>
						</div>
					</div>
					<div class="clear">
						&nbsp;
					</div>

				</section>
				<!-- End of Left column/section -->

				<!-- Right column/section -->
				<aside class="column width2">
					<div id="rightmenu">
						<header>
							<h3>您的账户</h3>
						</header>
						<dl class="first">
							<dt><img width="16" height="16" alt="" SRC="img/key.png">
							</dt>
							<dd>
								<a href="#">Administry (admin)</a>
							</dd>
							<dd class="last">
								免费帐户.
							</dd>

							<dt><img width="16" height="16" alt="" SRC="img/help.png">
							</dt>
							<dd>
								<a href="#">支持</a>
							</dd>
							<dd class="last">
								文档和常见问题
							</dd>
						</dl>
					</div>
					<div class="content-box">
						<header>
							<h3>最后在社区</h3>
						</header>
						<section>
							<dl>
								<dt>
									Maximize every interaction with a client
								</dt>
								<dd>
									<a href="#">Read more</a>
								</dd>
								<dt>
									Diversification for Small Business Owners
								</dt>
								<dd>
									<a href="#">Read more</a>
								</dd>
							</dl>
						</section>
					</div>
				</aside>
				<!-- End of Right column/section -->

			</div>
			<!-- End of Wrapper -->
		</div>
		<!-- End of Page content -->
        <script type="text/javascript" SRC="js/administry.js"></script>
        <script type="text/javascript" src="js/iframeresize.js"></script>

	</body>
</html>
