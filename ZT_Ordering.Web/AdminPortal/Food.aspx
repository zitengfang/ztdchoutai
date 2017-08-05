<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Food.aspx.cs" Inherits="ZT_Ordering.Web.AdminPortal.Food" %>

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
		        Administry.progress("#progress1", 1, 6);

		        // validate form on keyup and submit
		        var validator = $("#sampleform").validate({
		            rules: {
		                firstname: "required",
		                lastname: "required",
		                username: {
		                    required: true,
		                    minlength: 2
		                },
		                password: {
		                    required: true,
		                    minlength: 5
		                },
		                password_confirm: {
		                    required: true,
		                    minlength: 5,
		                    equalTo: "#password"
		                },
		                email: {
		                    required: true,
		                    email: true
		                },
		                dateformat: "required",
		                terms: "required"
		            },
		            messages: {
		                firstname: "Enter your firstname",
		                lastname: "Enter your lastname",
		                username: {
		                    required: "Enter a username",
		                    minlength: jQuery.format("Enter at least {0} characters")
		                },
		                password: {
		                    required: "Provide a password",
		                    rangelength: jQuery.format("Enter at least {0} characters")
		                },
		                password_confirm: {
		                    required: "Repeat your password",
		                    minlength: jQuery.format("Enter at least {0} characters"),
		                    equalTo: "Enter the same password as above"
		                },
		                email: {
		                    required: "Please enter a valid email address",
		                    minlength: "Please enter a valid email address"
		                },
		                dateformat: "Choose your preferred dateformat",
		                terms: " "
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

		        // propose username by combining first- and lastname
		        $("#username").focus(function () {
		            var firstname = $("#firstname").val();
		            var lastname = $("#lastname").val();
		            if (firstname && lastname && !this.value) {
		                this.value = firstname + "." + lastname;
		            }
		        });

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

					<h3>Form validation example</h3>
					<div class="box box-info">
						All fields are required
					</div>

					<form id="sampleform" method="post" action="#">

						<fieldset>
							<legend>
								JQuery Form Validation
							</legend>

							<p>
								<label class="required" for="firstname">First name:</label>
								<br/>
								<input type="text" id="firstname" class="half" value="" name="firstname"/>
							</p>

							<p>
								<label class="required" for="lastname">Last name:</label>
								<br/>
								<input type="text" id="lastname" class="half" value="" name="lastname"/>
							</p>

							<p>
								<label class="required" for="username">Username:</label>
								<br/>
								<input type="text" id="username" class="half" value="" name="username"/>
								<small>e.g. ui.templates</small>
							</p>

							<p>
								<label class="required" for="password">Password:</label>
								<br/>
								<input type="password" id="password" class="half" value="" name="password"/>
							</p>

							<p>
								<label class="required" for="password_confirm">Confirm password:</label>
								<br/>
								<input type="password" id="password_confirm" class="half" value="" name="password_confirm"/>
							</p>

							<p>
								<label class="required" for="email">Email address:</label>
								<br/>
								<input type="text" id="email" class="half" value="" name="email"/>
							</p>

							<p>
								<label class="required">Date format:</label>
								<br/>
								<input type="radio" id="dateformat1" class="" value="dmy" name="dateformat"/>
								<label class="choice" for="dateformat1">dd/mm/yyyy</label>
								<input type="radio" id="dateformat2" class="" value="mdy" name="dateformat"/>
								<label class="choice" for="dateformat2">mm/dd/yyyy</label>
							</p>

							<p>
								<input type="checkbox" id="terms" class="" value="1" name="terms"/>
								<label class="choice" for="terms">I have read and accept the Terms of Use.</label>
							</p>

							<p class="box">
								<input type="submit" class="btn btn-green big" value="Validate"/>
								or
								<input type="reset" class="btn" value="Reset"/>
							</p>

						</fieldset>

					</form>

					<h3>Form elements</h3>

					<h5>Step 1/6</h5>
					<div id="progress1" class="progress full progress-green">
						<span><b></b></span>
					</div>

					<form id="sampleform2" method="post" action="#" onSubmit="return false;">

						<fieldset>
							<legend>
								Error message
							</legend>
							<div class="box box-error">
								Invalid credit card info
							</div>
							<div class="box box-error-msg">
								<ol>
									<li>
										Credit card number entered is invalid
									</li>
									<li>
										Credit card verification number must be a valid number
									</li>
								</ol>
							</div>
						</fieldset>

						<fieldset>
							<legend>
								Text fields
							</legend>
							<p>
								<label for="input2">Big title:</label>
								<br/>
								<input type="text" id="input2" class="half title" value="" name="input2"/>
								<small>class="half title"</small>
							</p>
							<p>
								<label for="input1">Full textbox:</label>
								<br/>
								<input type="text" id="input1" class="full" value="" name="input1"/>
								<small>class="full"</small>
							</p>
						</fieldset>

						<fieldset>
							<legend>
								Text area
							</legend>
							<p>
								<label for="area1">Small textarea:</label>
								<br/>
								<textarea id="area1" class="small" name="area1"></textarea>
								<small>class="small"</small>
							</p>
							<p>
								<label for="area1">Medium textarea:</label>
								<br/>
								<textarea id="area2" class="medium half" name="area2"></textarea>
								<small>class="medium half"</small>
							</p>
							<p>
								<label for="area1">Large textarea:</label>
								<br/>
								<textarea id="area3" class="large full" name="area3"></textarea>
								<small>class="large full"</small>
							</p>
						</fieldset>

						<fieldset>
							<legend>
								Selections
							</legend>
							<div class="clearfix">
								<div class="column width3 first">
									<p>
										<label>Radio buttons:</label>
										<br/>
										<input type="radio" id="rb1" class="" value="" name="rb"/>
										<label class="choice" for="rb1">Lorem ipsum dolor sit amet</label>
										<br/>
										<input type="radio" id="rb2" class="" value="" name="rb"/>
										<label class="choice" for="rb2">Lorem ipsum dolor sit amet</label>
									</p>
									<p>
										<label for="select1">Single selection:</label>
										<br/>
										<select id="select1" class="half" name="select1">
											<option value="1">Lorem</option>
											<option value="2">Ipsum</option>
											<option value="3">Dolor</option>
											<option value="4">Sit</option>
											<option value="5">Amet</option>
										</select>
									</p>
								</div>
								<div class="column width3">
									<p>
										<label>Check boxes:</label>
										<br/>
										<input type="checkbox" id="cb1" class="" value="" name="cb"/>
										<label class="choice" for="cb1">Lorem ipsum dolor sit amet</label>
										<br/>
										<input type="checkbox" id="cb2" class="" value="" name="cb"/>
										<label class="choice" for="cb2">Lorem ipsum dolor sit amet</label>
									</p>
									<p>
										<label for="select2">Multiple selection:</label>
										<br/>
										<select id="select2" class="half" multiple="multiple" size="6" name="select2">
											<optgroup label="Set 1">
												<option value="1" selected>Lorem</option>
												<option value="2">Ipsum</option>
											</optgroup>
											<optgroup label="Set 2">
												<option value="3">Dolor</option>
												<option value="4">Sit</option>
												<option value="5">Amet</option>
											</optgroup>
										</select>
									</p>
								</div>
							</div>
						</fieldset>

						<fieldset>
							<legend>
								Buttons
							</legend>
							<label>Some combinations</label>
							<p class="">
								<input type="submit" class="btn btn-green big" value="Big green"/>
								<input type="submit" class="btn btn-red" value="Standard red"/>
								or
								<input type="reset" class="btn" value="Simple gray"/>
							</p>
						</fieldset>

					</form>

				</section>
				<!-- End of Left column/section -->

				<!-- Right column/section -->
				<aside class="column width2">
					<p class="leading">
						<a href="#" class="btn btn-special btn-green"><img SRC="img/add.png" class="icon" alt=""/>添加新菜品</a>
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
