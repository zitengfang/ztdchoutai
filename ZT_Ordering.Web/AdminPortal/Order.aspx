<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="ZT_Ordering.Web.AdminPortal.Order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
		<meta charset="utf-8" />
		<title>list</title>
		<meta name="description" content="Administry - Admin Template by www.865171.cn" />
		<meta name="keywords" content="Admin,Template" />
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
		<!-- jQuery popup box -->
		<script type="text/javascript" SRC="js/jquery.nyroModal.pack.js"></script>
		<!-- jQuery form validation -->
		<script type="text/javascript" SRC="js/jquery.validate_pack.js"></script>
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
		        Administry.progress("#capacity", 72, 100);

		        /* tabs */
		        $("#tabs").tabs();

		    });
		</script>
	</head>
    <body>
		<!-- Page title -->
		<div id="pagetitle">
			<div class="wrapper">
				<h1>订单管理</h1>
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
                    
                    <form id="sampleform" method="post" action="#">

					<fieldset>
							<legend>
								查询订单
							</legend>
                            <p>
								<labe>订单号:</label>
								<br/>
								<input type="text" id="ordernumber" class="half" value="" name="ordernumber"/>
								
							</p>
							<p>
								<label > 下单时间:</label>
								<br/>
								<input type="text" id="ordertimebegin" class="small" value="" name="ordertimebegin"/>&nbsp;至&nbsp;<input type="text" id="ordertimeend" class="small" value="" name="ordertimeend"/>
                                <small>e.g. 2017-01-01</small>
							</p>

							<p>
								<label>订单状态:</label>
								<br/>
								<select id="orderstatus" class="half" name="orderstatus">
                                            <option value="0">请选择</option>
											<option value="1">已下单</option>
											<option value="2">待商户确认</option>
											<option value="3">已确认</option>
											<option value="4">备餐中</option>
											<option value="5">待支付</option>
                                            <option value="6">已支付</option>
                                            <option value="7">已完成</option>
                                            <option value="8">已超时</option>
							   </select>
							</p>
                             <p>
								<label>支付方式:</label>
								<br/>
								<select id="paymentmethod" class="half" name="paymentmethod">
                                            <option value="0">请选择</option>
											<option value="1">现金</option>
											<option value="2">支付宝</option>
											<option value="3">微信支付</option>
											<option value="4">其他</option>
							   </select>
							</p>
							

							<p>
								<label >所属商户:</label>
								<br/>
								<input type="text" id="shop" class="half" value="" name="shop"/>
							</p>

							<p class="box">
								<input type="submit" class="btn btn-green big" value="查询"/>
								
							</p>

						</fieldset>

					</form>


					<div id="tabs">
						<ul>
							<li>
								<a class="corner-tl" href="#tabs-date">结果列表</a>
							</li>
							
						</ul>
						<div id="tabs-date">
							<div class="colgroup">
								<div class="width3 column first">
									<p>
										共<b>100</b>条结果
									</p>
								</div>
								<div class="width3 column">
									<p class="pagination ta-right">
										<a href="#">«</a>
										<a class="pagination-active" href="#">1</a>
										<a href="#">2</a>
										<a href="#">3</a>
										...
										<a href="#">12</a>
										<a href="#">13</a>
										<a href="#">14</a>
										<a href="#">»</a>
									</p>
								</div>
							</div>
							<div class="clearfix"></div>
							<hr />

							<h5>2017-07-29,星期六</h5>

							<div class="colgroup leading">
								<div class="width1 column first ta-center">
									<img SRC="img/preview-not-available.gif" alt="" />
								</div>
								<div class="width5 column">
									<a href="#" title=""><b class="big">AH-123-123-001</b></a>
									<br/>
									<small><b><a href="#">望湘园</a>&nbsp;&nbsp;|&nbsp;&nbsp;鱼香肉丝等8件商品 &nbsp;&nbsp;|&nbsp;&nbsp;￥308.00&nbsp;&nbsp;|&nbsp;&nbsp;订单已完成</b></small>
									<br/>
									<a href="#">查看</a> &middot; <a href="#">编辑</a> &middot; <a href="#">删除</a>
								</div>
							</div>
                            <div class="colgroup leading">
								<div class="width1 column first ta-center">
									<img SRC="img/preview-not-available.gif" alt="" />
								</div>
								<div class="width5 column">
									<a href="#" title=""><b class="big">AH-123-123-002</b></a>
									<br/>
									<small><b><a href="#">嘉合一品粥</a>&nbsp;&nbsp;|&nbsp;&nbsp;八宝粥等5件商品 &nbsp;&nbsp;|&nbsp;&nbsp;￥108.00&nbsp;&nbsp;|&nbsp;&nbsp;订单已完成</b></small>
									<br/>
									<a href="#">查看</a> &middot; <a href="#">编辑</a> &middot; <a href="#">删除</a>
								</div>
							</div>
                            	<h5>2017-07-30,星期日</h5>

							<div class="colgroup leading">
								<div class="width1 column first ta-center">
									<img SRC="img/preview-not-available.gif" alt="" />
								</div>
								<div class="width5 column">
									<a href="#" title=""><b class="big">AH-123-123-003</b></a>
									<br/>
									<small><b><a href="#">永和豆浆</a>&nbsp;&nbsp;|&nbsp;&nbsp;油条套餐等2件商品 &nbsp;&nbsp;|&nbsp;&nbsp;￥58.00&nbsp;&nbsp;|&nbsp;&nbsp;订单已完成</b></small>
									<br/>
									<a href="#">查看</a> &middot; <a href="#">编辑</a> &middot; <a href="#">删除</a>
								</div>
							</div>

							<div class="clearfix"></div>

							<hr/>
							<div class="colgroup leading">
								<div class="width3 column first">
									<p>
										共<b>100</b>条结果
									</p>
								</div>
								<div class="width3 column">
									<p class="pagination ta-right">
										<a href="#">«</a>
										<a class="pagination-active" href="#">1</a>
										<a href="#">2</a>
										<a href="#">3</a>
										...
										<a href="#">12</a>
										<a href="#">13</a>
										<a href="#">14</a>
										<a href="#">»</a>
									</p>
								</div>
							</div>
							<div class="clearfix"></div>

						</div>
						
					</div>

				</section>
				<!-- End of Left column/section -->

				<!-- Right column/section -->
				<aside class="column width2">
					<p class="leading">
						<a href="#" class="btn btn-special btn-green"><img SRC="img/add.png" class="icon" alt=""/>Upload new file</a>
					</p>
					<div class="box">
						You are now using <b class="big">72%</b> of your allowed storage capacity.
						<div id="capacity" class="progress progress-green">
							<span><b></b></span>
						</div>
					</div>
					<div class="content-box">
						<header>
							<h3>Tags</h3>
						</header>
						<section>
							<div class="tagcloud">
								<a href="#" class="tag1">lorem</a><a href="#" class="tag5">ipsum</a><a href="#" class="tag1">dolor</a><a href="#" class="tag3">sit</a><a href="#" class="tag1">amet</a>
							</div>
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
