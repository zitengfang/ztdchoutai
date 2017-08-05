<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FoodCategory.aspx.cs" Inherits="ZT_Ordering.Web.AdminPortal.FoodCategory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
		<meta charset="utf-8" />
		<title>FoodCategory</title>
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
		        /* tabs */
		        $("#tabs").tabs();

		    });
		</script>
	</head>
    <body>
		<!-- Page title -->
		<div id="pagetitle">
			<div class="wrapper">
				<h1>菜品类别</h1>
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
								查询分类
							</legend>
                            <p>
								
							<p>
								<label >所属商户:</label>
								<br/>
								<input type="text" id="shop" class="half" value="嘉和一品粥" name="shop"/> &nbsp; &nbsp; &nbsp;<input type="submit" class="btn btn-green big" value="查询"/>
							</p>
						</fieldset>

					</form>
						
					<table class="stylized full">
					
						<thead> 
							<tr>
								<th>类别名称</th>
								<th>状态</th>
								<th>显示排序</th>
								<th>操作</th>
							</tr>
						</thead>
						<tbody>
							<tr>
								<td>粥类</td>
								<td>启用</td>
								<td>1</td>
								<td>删除/修改</td>
							</tr>
							<tr class="high">
								<td>热菜</td>
								<td>启用</td>
								<td>2</td>
								<td>删除/修改</td>
							</tr>
							<tr>
								<td>凉菜</td>
								<td>启用</td>
								<td>3</td>
								<td>删除/修改</td>
							</tr>
							
						</tbody>
						<tfoot>
							<tr>
								<td colspan="5">共有 3 条菜品类别</td>
							</tr>
						</tfoot>
					</table>

				</section>
				<!-- End of Left column/section -->

				<!-- Right column/section -->
				<aside class="column width2">
					<p class="leading">
						<a href="#" class="btn btn-special btn-green"><img SRC="img/add.png" class="icon" alt=""/>新增类别</a>
					</p>
					
					<div class="content-box">
						<header>
							<h3>注意事项</h3>
						</header>
						<section>
							<div class="tagcloud">
								显示排序为号越小，越靠前
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
