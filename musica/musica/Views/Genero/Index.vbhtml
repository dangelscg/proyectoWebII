﻿@ModelType IEnumerable(Of musica.genero)

@Code
    ViewData("Title") = "Index"
End Code
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title></title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <link href="css/layout.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="css/prettyPhoto.css" type="text/css">
    <script src="js/jquery.min.js" type="text/javascript"></script>
    <script src="js/cufon-yui.js" type="text/javascript"></script>
    <script src="js/cufon-replace.js" type="text/javascript"></script>
    <script type="text/javascript" src="js/Josefin_Sans_600.font.js"></script>
    <script type="text/javascript" src="js/Lobster_400.font.js"></script>
    <script type="text/javascript" src="js/sprites.js"></script>
    <script type="text/javascript" src="js/jquery.jplayer.min.js"></script>
    <script type="text/javascript" src="js/jquery.jplayer.settings.js"></script>
    <script type="text/javascript" src="js/gSlider.js"></script>
    <script type="text/javascript" src="js/jquery.easing.1.3.js"></script>
    <script type="text/javascript" src="js/jquery.prettyPhoto.js"></script>
    <!--[if lt IE 7]> <div style=' clear: both; height: 59px; padding:0 0 0 15px; position: relative;'> <a href="http://www.microsoft.com/windows/internet-explorer/default.aspx?ocid=ie6_countdown_bannercode"><img src="http://www.theie6countdown.com/images/upgrade.jpg" border="0" height="42" width="820" alt="You are using an outdated browser. For a faster, safer browsing experience, upgrade for free today." /></a></div> <![endif]-->
    <!--[if lt IE 9]><script src="js/html5.js" type="text/javascript"></script><![endif]-->
    <!--[if IE]><link href="css/ie_style.css" rel="stylesheet" type="text/css" /><![endif]-->
</head>
<body id="page2">
    <h2>Genero</h2>

    <p>
        @Html.ActionLink("Create New", "Create")
    </p>
    <table>
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.id_genero)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.tipo)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.tema)
            </th>
            <th></th>
        </tr>

        @For Each item In Model
            Dim currentItem = item
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) currentItem.id_genero)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) currentItem.tipo)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) currentItem.tema)
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

                    <li><a href="~/cancion">Inicio</a></li>
                    <li><a href="~/artista">Artista</a></li>
                    <li class="active"><a href="~/genero">Video</a></li>
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
            <a href="#" class="hs-prev"><img src="images/prev.png" alt=""></a>
            <a href="#" class="hs-next"><img src="images/next.png" alt=""></a>
            
        </header><div class="innercopy">More <a href="http://www.templatemonster.com/">Website Templates</a> at TemplateMonster.com!</div>
        <article id="content">
            <div class="col-1">
                <div class="p2">
                    <h2>New Album</h2>
                    <img src="images/col-1-img1.png" class="p1" alt=""> <a href="#" class="more">Read More</a>
                </div>
                <div class="p2">
                    <h2>New Video</h2>
                    <a href="video/video_AS3.swf?width=512&amp;height=288&amp;fileVideo=temp_video.flv" rel="prettyPhoto"><img class="p1" src="images/col1-video-thumb1.jpg" alt=""></a>
                    <div class="alc"><a href="#">More Videos</a></div>
                </div>
                <div class="p2">
                    <h2>Latest Photos</h2>
                    <a href="index-4.html"><img class="p1" src="images/col1-img2.jpg" alt=""></a>
                    <div class="alc"><a href="index-4.html">View Gallery</a></div>
                </div>
            </div>
            <div class="col-2">
                <h2>Audio</h2>
                <p>Deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumique nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. </p>
                <ul class="audio">
                    <li><a href="#">Lilly Watson - Right Now</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#">Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - Right Now</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - Let Me Know</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - Sing a Song</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - Impressd feat. Jessy</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - Count on Me</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - One More Chance</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - Right Now</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - Let Me Know</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - Sing a Song</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - Impressd feat. Jessy</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - Count on Me</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - One More Chance</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - Right Now</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - Let Me Know</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - Sing a Song</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - Impressd feat. Jessy</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - Count on Me</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - One More Chance</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - Right Now</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#"> Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                    <li><a href="#">Lilly Watson - Let Me Know</a> <span class="info">(4.4 mb, 491 downloads)</span> <a href="#">Lyrics</a><div class="cntrls"><a href="#" class="mute"></a><span class="separator"></span><a href="#" class="play"></a></div></li>
                </ul>
            </div>
            <div class="col-3">
                <h2>Latest Tweets</h2>
                <div class="und">
                    <p>
                        At vero eos et accusamus et iusto odio dignissimos ducimus blanditiis.<br>
                        <a href="#">1 hour ago</a>
                    </p>
                    <p>
                        Praesentium voluptatumdel enititque corrupti quos.<br>
                        <a href="#">3 hours ago</a>
                    </p>
                    <p>
                        dolores et quas molestias excepturi sint occaecati cupiditate.<br>
                        <a href="#">7 hours ago</a>
                    </p>
                    <p>
                        Non provident, similiqusunt in culpa qui officia.<br>
                        <a href="#">12 hours ago</a>
                    </p>
                    <p>
                        At vero eos et accusamus et iusto odio dignissimos ducimus blanditiis.<br>
                        <a href="#">16 hours ago</a>
                    </p>
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
            <a rel="nofollow" href="http://www.templatemonster.com/" target="_blank">Website template</a> designed by TemplateMonster.com<br>
            <a href="http://www.templates.com/product/illustrations/" target="_blank">Vector Illustration</a> provided by Templates.com
        </span>
    </footer>
    <script type="text/javascript">
Cufon.now()
        $(function () {
            $('nav,.more,.header-more').sprites()

            $('.header-slider').gSlider({
                prevBu: '.hs-prev',
                nextBu: '.hs-next'
            })

            $('a[rel=prettyPhoto]').each(function () {
                var th = $(this),
                    pb
                th
                    .append(pb = $('<span class="playbutt"></span>').css({ opacity: .7 }))
                pb
                    .bind('mouseenter', function () {
                        $(this)
                            .stop()
                            .animate({ opacity: .9 })
                    })
                    .bind('mouseleave', function () {
                        $(this)
                            .stop()
                            .animate({ opacity: .7 })
                    })
            })
            .prettyPhoto({ theme: 'dark_square' })
        })
    </script>
</body>
</html>