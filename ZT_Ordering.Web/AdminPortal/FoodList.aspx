<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FoodList.aspx.cs" Inherits="ZT_Ordering.Web.AdminPortal.FoodList" %>

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
				<h1>菜品列表</h1>
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
								查询菜品
							</legend>
                            <p>
								<label >所属商户:</label>
								<br/>
								<input type="text" id="shop" class="half" value="嘉和一品粥" name="shop"/> 
							</p>
								
							 <p>
								<label >菜品名称:</label>
								<br/>
								<input type="text" id="foodname" class="half" value="" name="shop"/> 
							</p>

							<p>
								<label>菜品状态:</label>
								<br/>
								<select id="foodstatus" class="half" name="foodstatus">
                                            <option value="0">请选择</option>
											<option value="1">销售中</option>
											<option value="2">已下架</option>
											
							   </select>
							</p>

							<p class="box">
								<input type="submit" class="btn btn-green big" value="查询"/>
								
							</p>

						</fieldset>

					</form>


					<div id="tabs">
						<ul>
							<li>
								<a class="corner-tl" href="#tabs-1">粥类</a>
							</li>
                            <li>
								<a class="corner-tr" href="#tabs-2">小吃类</a>
							</li>
                             <li>
								<a class="corner-tr" href="#tabs-3">热菜</a>
							</li>
						</ul>
						<div id="tabs-1">
							<div class="colgroup">
								<div class="width3 column first">
									<p>
										共<b>3</b>条结果
									</p>
								</div>
							</div>

							<div class="clearfix"></div>
							<hr />

						
							<div class="colgroup leading">
								<div class="width1 column first ta-center">
									<img SRC="img/preview-not-available.gif" alt="" />
								</div>
								<div class="width5 column">
									<a href="#" title=""><b class="big">八宝粥</b></a>
									<br/>
									<small><b>月售270件&nbsp;&nbsp;|&nbsp;&nbsp;好评率90% &nbsp;&nbsp;|&nbsp;&nbsp;￥15.00&nbsp;&nbsp;</b></small>
									<br/>
									<a href="#">查看</a> &middot; <a href="#">编辑</a> &middot; <a href="#">删除</a>
								</div>
							</div>
                            	<div class="colgroup leading">
								<div class="width1 column first ta-center">
									<img SRC="img/preview-not-available.gif" alt="" />
								</div>
								<div class="width5 column">
									<a href="#" title=""><b class="big">荷叶冰粥</b></a>
									<br/>
									<small><b>月售55件&nbsp;&nbsp;|&nbsp;&nbsp;好评率90% &nbsp;&nbsp;|&nbsp;&nbsp;￥17.00&nbsp;&nbsp;</b></small>
									<br/>
									<a href="#">查看</a> &middot; <a href="#">编辑</a> &middot; <a href="#">删除</a>
								</div>
							</div>
                            		<div class="clearfix"></div>

							<hr/>
							<div class="colgroup leading">
								<div class="width3 column first">
									<p>
										共<b>1</b>条结果
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
						<div id="tabs-2">
							<div class="colgroup">
								<div class="width3 column first">
									<p>
										共<b>1</b>条结果
									</p>
								</div>
							</div>

							<div class="clearfix"></div>
							<hr />

						
							<div class="colgroup leading">
								<div class="width1 column first ta-center">
									<img SRC="img/preview-not-available.gif" alt="" />
								</div>
								<div class="width5 column">
									<a href="#" title=""><b class="big">鸡翅</b></a>
									<br/>
									<small><b>月售30件&nbsp;&nbsp;|&nbsp;&nbsp;好评率90% &nbsp;&nbsp;|&nbsp;&nbsp;￥15.00&nbsp;&nbsp;</b></small>
									<br/>
									<a href="#">查看</a> &middot; <a href="#">编辑</a> &middot; <a href="#">删除</a>
								</div>
							</div>
							

						</div>
                        <div id="tabs-3">
							<div class="colgroup">
								<div class="width3 column first">
									<p>
										共<b>1</b>条结果
									</p>
								</div>
							</div>

							<div class="clearfix"></div>
							<hr />

						
							<div class="colgroup leading">
								<div class="width1 column first ta-center">
									<img SRC="img/preview-not-available.gif" alt="" />
								</div>
								<div class="width5 column">
									<a href="#" title=""><b class="big">红烧肉</b></a>
									<br/>
									<small><b>月售33件&nbsp;&nbsp;|&nbsp;&nbsp;好评率90% &nbsp;&nbsp;|&nbsp;&nbsp;￥48.00&nbsp;&nbsp;</b></small>
									<br/>
									<a href="#">查看</a> &middot; <a href="#">编辑</a> &middot; <a href="#">删除</a>
								</div>
							</div>
						</div>


					</div>

				</section>
				<!-- End of Left column/section -->

				<!-- Right column/section -->
				<aside class="column width2">
					<p class="leading">
						<a href="AddFood.aspx" target="_blank" class="btn btn-special btn-green"><img SRC="img/add.png" class="icon" alt=""/>添加新菜品</a>
					</p>
					<div class="box">
						当前有 <b class="big">72%</b> 的菜品被用户点过。
						<div id="capacity" class="progress progress-green">
							<span><b></b></span>
						</div>
					</div>
					<div class="content-box">
						<header>
							<h3>小技巧</h3>
						</header>
						<section>
							<div class="tagcloud">
								暂时不销售的菜品，不用删掉，直接设置为下架即可
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
