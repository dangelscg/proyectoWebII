﻿@ModelType IEnumerable(Of musica.cancion)

@Code
    ViewData("Title") = "Index"
End Code

<!DOCTYPE HTML>
<html lang="en">
<head>
    <meta charset="UTF-8">
<title></title>
<link href="~/css/style.css" rel="stylesheet" type="text/css" />
<link href="~/css/layout.css" rel="stylesheet" type="text/css" />
    <link rel="~/stylesheet" href="css/prettyPhoto.css" type="text/css">
    <script src="~/js/jquery.min.js" type="text/javascript"></script>
    <script src="~/js/cufon-yui.js" type="text/javascript"></script>
    <script src="~/js/cufon-replace.js" type="text/javascript"></script>
    <script type="~/text/javascript" src="js/Josefin_Sans_600.font.js"></script>
    <script type="~/text/javascript" src="js/Lobster_400.font.js"></script>
    <script type="~/text/javascript" src="js/sprites.js"></script>
    <script type="~/text/javascript" src="js/jquery.jplayer.min.js"></script>
    <script type="~/text/javascript" src="js/jquery.jplayer.settings.js"></script>
    <script type="~/text/javascript" src="js/gSlider.js"></script>
    <script type="~/text/javascript" src="js/jquery.easing.1.3.js"></script>
    <script type="~/text/javascript" src="js/jquery.prettyPhoto.js"></script>
<!--[if lt IE 7]> <div style=' clear: both; height: 59px; padding:0 0 0 15px; position: relative;'> <a href="http://www.microsoft.com/windows/internet-explorer/default.aspx?ocid=ie6_countdown_bannercode"><img src="http://www.theie6countdown.com/images/upgrade.jpg" border="0" height="42" width="820" alt="You are using an outdated browser. For a faster, safer browsing experience, upgrade for free today." /></a></div> <![endif]-->
<!--[if lt IE 9]><script src="js/html5.js" type="text/javascript"></script><![endif]-->
<!--[if IE]><link href="css/ie_style.css" rel="stylesheet" type="text/css" /><![endif]-->
</head>
<body id="page1">


<h2>Principal</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table>
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.id_cancion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.interprete)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.album)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.duracion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.tamaño)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.id_cancion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.nombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.interprete)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.album)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.duracion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.tamaño)
        </td>
        <td>
            @*@Html.ActionLink("Edit", "Edit", New With {.id = currentItem.PrimaryKey}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.PrimaryKey})*@
        </td>
    </tr>
Next

</table>


<div id="main">
	<header>
		<nav>
			<ul>
			<li class="active"><a href="~/cancion">Inicio</a></li>
			<li><a href="~/artista">Artista</a></li>
			<li><a href="~/genero">Video</a></li>
			<li><a href="~/reciente">Reciente</a></li>
			<li><a href="~/persona">Amigos</a></li>
		</ul>
	</nav>
	<h1><a href="index.html">FRANK Z F</a></h1>
	<div class="header-slider">
		<ul>
			<li>This is one of <a href="http://blog.templatemonster.com/free-website-templates/">free website templates</a> created by TemplateMonster.com team. This website template is optimized for 1024X768 screen resolution.</li>
			<li>This website template has several pages: About, Audio, Video, Gallery, Tour Dates, Contacts (note that contact us form – doesn’t work).</li>
			<li>This <a href="http://blog.templatemonster.com/2011/04/12/free-music-website-template/">Free Music Website Template</a> goes with two packages – with PSD source files and without them. PSD source files are available for free.</li>
		</ul>
	</div>
        <a href="~/#" class="hs-prev"><img src="~/images/prev.png" alt=""></a>
        <a href="~/#" class="hs-next"><img src="~/images/next.png" alt=""></a>
        
</header><div class="innercopy">More <a href="http://www.templatemonster.com/">Website Templates</a> at TemplateMonster.com!</div>
  <div class="tumbvr">
	<div class="tumbvr-mask"></div>
	<ul>
		<li><img src="images/01.jpg" alt=""></li>
		<li><img src="images/02.jpg" alt=""></li>
		<li><img src="images/03.jpg" alt=""></li>
		<li><img src="images/04.jpg" alt=""></li>
		<li><img src="images/05.jpg" alt=""></li>
		<li><img src="images/06.jpg" alt=""></li>
		<li><img src="images/07.jpg" alt=""></li>
		<li><img src="images/08.jpg" alt=""></li>
		<li><img src="images/09.jpg" alt=""></li>
		<li><img src="images/10.jpg" alt=""></li>
	</ul>
  </div>
  <article id="content">
	<div class="col-1">
		<div class="p2">
		<h2>New Album</h2>
		<img src="images/col-1-img1.png" class="p1" alt=""> <a href="#" class="more">Read More</a></div>
		<div class="p2">
		<h2>New Video</h2>
		<a href="video/video_AS3.swf?width=512&amp;height=288&amp;fileVideo=temp_video.flv" rel="prettyPhoto"><img class="p1" src="images/col1-video-thumb1.jpg" alt=""></a>
		<div class="alc"><a href="index-2.html">More Videos</a></div>
		</div>
	</div>
	<div class="col-2">
		<!-- audio player begin -->
		<div id="jplayer"></div>
		<div class="jp-audio">
		<h2>New Song</h2>
		<div class="jp-type-single">
			<div id="jp_interface_1" class="jp-interface">
			<ul class="jp-controls">
				<li><a href="#" class="jp-play"></a></li>
				<li><a href="#" class="jp-pause"></a></li>
				<li><a href="#" class="jp-prev">Previous Track</a></li>
				<li><a href="#" class="jp-next">Next Track</a></li>
				<li><a href="#" class="jp-more-songs">Listen to More Songs</a></li>
			</ul>
			<div class="jp-progress">
				<div class="jp-seek-bar">
				<div class="jp-play-bar"></div>
				</div>
			</div>
			<div class="jp-title"></div>
			</div>
		</div>
		</div>
		<!-- audio player end -->
		<h2 class="pl">Upcoming Tour Dates</h2>
		<div class="table-border">
		<table class="dates" cellpadding="0" cellspacing="0" border="0">
			<tr class="thead">
			<td class="col1">Date / Venue</td>
			<td class="col2">Location</td>
			<td class="col3">Information</td>
			</tr>
			<tr class="even">
			<td class="col1">April 6, 2011<br>
				<a href="#" class="name">Motorpint Arena</a><br>
				<a href="#" class="facebook-event">Facebook Event</a></td>
			<td>416 S. 9th St. 83702<br>
				Boise, ID</td>
			<td>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium dolorlaudantium, totam rem aperiam.</td>
			</tr>
			<tr>
			<td class="col1">April 6, 2011<br>
				<a href="#" class="name">Echo Arena</a><br>
				<a href="#" class="facebook-event">Facebook Event</a></td>
			<td>416 S. 9th St. 83702<br>
				Boise, ID</td>
			<td>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium dolorlaudantium, totam rem aperiam.</td>
			</tr>
			<tr class="even">
			<td class="col1">April 6, 2011<br>
				<a href="#" class="name">Motorpint Arena</a><br>
				<a href="#" class="facebook-event">Facebook Event</a></td>
			<td>416 S. 9th St. 83702<br>
				Boise, ID</td>
			<td>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium dolorlaudantium, totam rem aperiam.</td>
			</tr>
			<tr>
			<td class="col1">April 6, 2011<br>
				<a href="#" class="name">The NEC Arena</a><br>
				<a href="#" class="facebook-event">Facebook Event</a></td>
			<td>416 S. 9th St. 83702<br>
				Boise, ID</td>
			<td>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium dolorlaudantium, totam rem aperiam.</td>
			</tr>
		</table>
		</div>
	</div>
	<div class="col-3">
		<h2>Latest Tweets</h2>
		<div class="und">
		<p>At vero eos et accusamus et iusto odio dignissimos ducimus blanditiis.<br>
			<a href="#">1 hour ago</a></p>
		<p>Praesentium voluptatumdel enititque corrupti quos.<br>
			<a href="#">3 hours ago</a></p>
		<p>dolores et quas molestias excepturi sint occaecati cupiditate.<br>
			<a href="#">7 hours ago</a></p>
		<p>Non provident, similiqusunt in culpa qui officia.<br>
			<a href="#">12 hours ago</a></p>
		<p>At vero eos et accusamus et iusto odio dignissimos ducimus blanditiis.<br>
			<a href="#">16 hours ago</a></p>
		</div>
		<h2>Newsletter</h2>
		<form action="" id="subscribe">
		<fieldset>
			<label>
			<input type="text">
			</label>
			<input type="submit" value="">
		</fieldset>
		</form>
		<h2>Find Me</h2>
		<ul class="soc-ico">
		<li><a href="#"><img src="images/facebook.png" alt=""></a></li>
		<li><a href="#"><img src="images/twitter.png" alt=""></a></li>
		<li><a href="#"><img src="images/myspace.png" alt=""></a></li>
		<li><a href="#"><img src="images/linkedin.png" alt=""></a></li>
		</ul>
	</div>
  </article>
  <div class="af clear"></div>
</div>
<footer>
	<span>
    	<a rel="~/nofollow" href="http://www.templatemonster.com/" target="_blank">Website template</a> designed by TemplateMonster.com<br>
		<a href="~/http://www.templates.com/product/illustrations/" target="_blank">Vector Illustration</a> provided by Templates.com
	</span>
</footer>
<script type="text/javascript">Cufon.now()
$(function(){
	$('nav,.more,.header-more').sprites()

	$('.header-slider').gSlider({
		prevBu:'.hs-prev',
		nextBu:'.hs-next'
	})
})
$(window).load(function(){
	$('.tumbvr')._fw({tumbvr:{
		duration:2000,
		easing:'easeOutQuart'
	}})
	.bind('click',function(){
		location="index-3.html"
	})
	
	$('a[rel=prettyPhoto]').each(function(){
		var th=$(this),
			pb
		th
			.append(pb=$('<span class="playbutt"></span>').css({opacity:.7}))
		pb
			.bind('mouseenter',function(){
				$(this)
					.stop()
					.animate({opacity:.9})
			})
			.bind('mouseleave',function(){
				$(this)
					.stop()
					.animate({opacity:.7})
			})
	})
	.prettyPhoto({theme:'dark_square'})
})
</script>
</body>
</html>