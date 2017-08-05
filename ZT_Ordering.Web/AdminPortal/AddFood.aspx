<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddFood.aspx.cs" Inherits="ZT_Ordering.Web.AdminPortal.AddFood" %>

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

		        // validate form on keyup and submit
		        var validator = $("#sampleform").validate({
		            rules: {
		                foodname: "required",
		                price: {
		                    required: true,
		                    number: true
		                },
		                foodcategory: {
		                    min: 1
		                },
		                shop: "required",
		                description: "required",
		                foodstatus: {
		                    min: 1
		                }

		            },
		            messages: {
		                foodname: "请填写菜品名称",
		                price: {
		                    required: "请填写菜品价格",
		                    number: jQuery.format("请输入合法数字")
		                },
		                foodcategory: {
		                    min: "请选择菜品种类"
		                },
		                shop: "请填写所属商家",
		                description: "请填写描述说明",
		                foodstatus: {
		                    min: "请选择菜状态"
		                }
		            },
		            // the errorPlacement has to take the layout into account
		            errorPlacement: function (error, element) {
		                error.insertAfter(element.parent().find('label:first'));
		            },
		            // specifying a submitHandler prevents the default submit, good for the demo
		            submitHandler: function () {
		                alert("Data submitted!");
		            },
		            // set new class to error-labels to indicate valid fields
		            success: function (label) {
		                // set &nbsp; as text for IE
		                label.html("&nbsp;").addClass("ok");
		            }
		        });

		    });
		</script>
	</head>
    <body>
		<!-- Page title -->
		<div id="pagetitle">
			<div class="wrapper">
				<h1>添加新菜品</h1>
			</div>
		</div>
		<!-- End of Page title -->

		<!-- Page content -->
		<div id="page">
			<!-- Wrapper -->
			<div class="wrapper">
				<!-- Left column/section -->
				<section class="column width8 first">
					<div class="box box-info">
						所有条目均为必填
					</div>
					<form id="sampleform" method="post" action="#">

						<fieldset>
							<legend>
								New Food
							</legend>

							<p>
								<label class="required" for="foodname">名称:</label>
								<br/>
								<input type="text" id="foodname" class="half" value="" name="foodname"/>
							</p>

							<p>
								<label class="required" for="price">售价:</label>
								<br/>
								<input type="text" id="price" class="half" value="" name="price"/>
                                <small>e.g. 10.00</small>
							</p>
                            <p>
								<label class="required" for="foodcategory">类别:</label>
								<br/>
								<select id="foodcategory" class="half" name="foodcategory">
                                            <option value="0">请选择</option>
											<option value="1">凉菜</option>
											<option value="2">粥类</option>
							   </select>
							</p>
							<p>
								<label class="required" for="shop">所属商家:</label>
								<br/>
								<input type="text" id="shop" class="half" readonly="readonly" value="" name="shop"/><a>选择商家（管理账户存在多商家）</a>
								
							</p>

							<p>
								<label class="required" for="description">描述说明:</label>
								<br/>
								<input type="text" id="description" class="half" value="" name="description"/>
                              
							</p>
							<p>
								<label class="required" for="foodstatus">菜品状态:</label>
								<br/>
								<select id="foodstatus" class="half" name="foodstatus">
                                            <option value="0">请选择</option>
											<option value="1">销售中</option>
											<option value="2">下架</option>
							   </select>
							</p>

							<p class="box">
								<input type="submit" class="btn btn-green big" value="确认"/>
								
								<input type="reset" class="btn" value="重置"/>
							</p>

						</fieldset>

					</form>
				</section>
				<!-- End of Left column/section -->
			</div>
			<!-- End of Wrapper -->
		</div>
		<!-- End of Page content -->
        <script type="text/javascript" SRC="js/administry.js"></script>
        <script type="text/javascript" src="js/iframeresize.js"></script>
	</body>

</html>
