@import "../../../css/mfn-icons.css"; 
@import "../../../css/pretty.css"; 
/*
|--------------------------------------------------------------------------
| Be
| Structure styles
| http://BeantownThemes.com
| http://themeforest.net/user/BeantownThemes
|--------------------------------------------------------------------------
| 1.0 Grid
| 2.0 Layout
| 3.0 Responsive-1240
| 4.0 Responsive
|
*/


/*
|--------------------------------------------------------------------------
|  1.0 Grid
|  
|--------------------------------------------------------------------------
|
| 
|
*/


/* #Base 1200 Grid
================================================== */

body {
	min-width: 1240px;
	padding: 25px 0;
}
#Wrapper {
	width: 1240px;
	margin: 0px auto;
	overflow: hidden;
}
.layout-full-width {
	padding: 0;
}
.layout-full-width #Wrapper {
	width: 100% !important;
	margin: 0 !important;
}

/* #Content
=============================== */

#Content {
	width: 100%;
}
body:not(.template-slider) #Content {
	padding-top: 30px;
}
.section {
	position: relative;
}
.section_wrapper, .container {
	width: 1200px;
	margin: 0 auto;
	position: relative;
}
.section_wrapper:after, .container:after {
	clear: both;
	content: " ";
	display: block;
	height: 0;
	visibility: hidden;
}
.column, .columns {
	float: left;
	margin: 0 1% 40px;
}
.column.column_divider, .column-margin-0px .column {
	margin-bottom: 0;
}
.column-margin-10px .column {
	margin-bottom: 10px;
}
.column-margin-20px .column {
	margin-bottom: 20px;
}
.column-margin-30px .column {
	margin-bottom: 30px;
}
.column-margin-40px .column {
	margin-bottom: 40px;
}
.column-margin-50px .column {
	margin-bottom: 50px;
}
.the_content_wrapper {
	margin: 0 1%;
}
.column_content .the_content_wrapper {
	margin: 0;
}
.column_attr.align_left {
	text-align: left;
}
.column_attr.align_right {
	text-align: right;
}
.column_attr.align_center {
	text-align: center;
}
.column_attr.align_justify {
	text-align: justify;
}
.extra_content .the_content_wrapper {
	margin: 0 1% 40px;
}

/* .with_aside */

.with_aside .content_wrapper {
	width: 1200px;
	margin: 0 auto;
}
.with_aside .sections_group {
	width: 75%;
	float: left;
}
.with_aside .section_wrapper {
	width: 100%;
}
.with_aside .four.columns {
	float: right;
}
.aside_left .sections_group {
	float: right;
}
.aside_left .four.columns {
	float: left;
}

/* both sidebars | .aside_both */

.aside_both .sections_group {
	width: 60%;
	margin-left: 20%;
}
.aside_both .sidebar.columns {
	width: 18%;
}
.aside_both .sidebar-1 {
	float: left !important;
	margin-left: -79%;
}

/* sidebars for sections */

.right-sidebar .items_group {
	width: 75%;
	float: left;
}
.right-sidebar .four.columns {
	float: right;
}
.left-sidebar .items_group {
	width: 75%;
	float: right;
}
.left-sidebar .four.columns {
	float: left;
}

/* #Base Grid
=============================== */

.one-sixth.column {
	width: 14.666%;
}

/* 1/6 */

.one-fifth.column {
	width: 18%;
}

/* 1/5 */

.four.columns, .one-fourth.column {
	width: 23%;
}

/* 1/4 */

.one-third.column {
	width: 31.333%;
}

/* 1/3 */

.one-second.column {
	width: 48%;
}

/* 1/2 */

.two-third.column {
	width: 64.666%;
}

/* 2/3 */

.three-fourth.column {
	width: 73%;
}

/* 3/4 */

.one.column {
	width: 98%;
}

/* 1/1 */


/* without horizontal margin */

.no-margin-h .column {
	margin-left: 0;
	margin-right: 0;
}
.no-margin-h .one-sixth.column {
	width: 16.666%;
}

/* 1/6 */

.no-margin-h .one-fifth.column {
	width: 20%;
}

/* 1/5 */

.no-margin-h .one-fourth.column {
	width: 25%;
}

/* 1/4 */

.no-margin-h .one-third.column {
	width: 33.333%;
}

/* 1/3 */

.no-margin-h .one-second.column {
	width: 50%;
}

/* 1/2 */

.no-margin-h .two-third.column {
	width: 66.666%;
}

/* 2/3 */

.no-margin-h .three-fourth.column {
	width: 75%;
}

/* 3/4 */

.no-margin-h .one.column {
	width: 100%;
}

/* 1/1 */


/* #Clearing
================================================== */


/* Self Clearing Goodness */

.container:after {
	content: "\0020";
	display: block;
	height: 0;
	clear: both;
	visibility: hidden;
}

/* Use clearfix class on parent to clear nested columns, or wrap each row of columns in a <div class="row"> */

.clearfix:before, .clearfix:after, .row:before, .row:after {
	content: '\0020';
	display: block;
	overflow: hidden;
	visibility: hidden;
	width: 0;
	height: 0;
}
.row:after, .clearfix:after {
	clear: both;
}
.row, .clearfix {
	zoom: 1;
}

/* You can also use a <br class="clear" /> to clear columns */

.clear {
	clear: both;
	display: block;
	overflow: hidden;
	visibility: hidden;
	width: 0;
	height: 0;
}

/*
|--------------------------------------------------------------------------
|  2.0 Layout
|  
|--------------------------------------------------------------------------
|
| 
|
*/


/* #Global
================================================== */

.the_content_wrapper pre {
	margin-bottom: 20px
}
.rev_slider iframe {
	max-width: 1220px;
}
.rev_slider ul {
	margin: 0 !important;
}
.tp-static-layers {
	z-index: 200;
}
.ls-yourlogo {
	z-index: 28;
}
.section.center {
	text-align: center;
}
.section.no-margin .column, .section.no-margin-v .column {
	margin-bottom: 0;
}
#Wrapper {
	-webkit-box-shadow: 0px 0px 15px rgba(0, 0, 0, .06);
	box-shadow: 0px 0px 15px rgba(0, 0, 0, .06);
}

/* #Blank & #UnderConstruction
================================================== */

.page.hide-title-area:not(.with_aside) #Content, .no-content-padding:not(.with_aside) #Content, .template-blank #Content, .under-construction #Content {
	padding: 0 !important;
}
.under-construction .section-uc-1 {
	padding-top: 40px;
	background-color: #fff;
}
.under-construction .section-uc-2 {
	padding-top: 40px;
	background-color: #f5f5f5;
	background: url(../../../images/stripes/stripes_3_b.png) repeat center;
}
.under-construction .section-uc-3 {
	padding-top: 40px;
}
.under-construction .section-border-top {
	border-top: 1px solid rgba(0, 0, 0, 0.08);
}

/* Nice Scroll | .nice-scroll
================================================== */

body.nice-scroll {
	position: relative;
}
body.nice-scroll:not(.layout-boxed) {
	padding-right: 10px !important;
}
.nice-scroll #configurator, .nice-scroll #Sliding-top a.sliding-top-control, .nice-scroll .fixed-nav.fixed-nav-next {
	margin-right: 10px;
}
.nice-scroll .nicescroll-rails {
	background: #666;
	z-index: 9001 !important;
}

/* Slider | Pagination
================================================== */

.slider_pagination, .tp-bullets.simplebullets.round {
	text-align: center;
	line-height: 0;
}
.slider_pagination a, .tp-bullets.simplebullets.round .bullet {
	display: inline-block;
	width: 12px;
	height: 12px;
	text-indent: -9999px;
	margin: 0 9px;
	background: rgba(0, 0, 0, .15);
	-webkit-border-radius: 100%;
	border-radius: 100%;
	position: relative;
}
.slider_pagination a:hover {
	background: rgba(0, 0, 0, .25);
}
.slider_pagination a.selected, .tp-bullets.simplebullets.round .bullet.selected {
	width: 10px;
	height: 8px;
	margin: 0px 10px 0;
	position: relative;
	top: 4px;
	background: rgba(0, 0, 0, .15);
	-webkit-border-radius: 2px;
	border-radius: 2px;
}
.slider_pagination a.selected:after, .tp-bullets.simplebullets.round .bullet.selected:after {
	content: "";
	display: block;
	width: 8px;
	height: 8px;
	-webkit-border-radius: 1px;
	border-radius: 1px;
	position: absolute;
	left: 1px;
	top: -3px;
	-webkit-transform: rotate(45deg);
	-moz-transform: rotate(45deg);
	-o-transform: rotate(45deg);
	-ms-transform: rotate(45deg);
	transform: rotate(45deg);
}
.tp-bullets.simplebullets.round .bullet {
	background: #fff;
}
.offer_thumb .slider_pagination a img {
	-webkit-transition: all 0.4s ease-in-out;
	-moz-transition: all 0.4s ease-in-out;
	-o-transition: all 0.4s ease-in-out;
	transition: all 0.4s ease-in-out;
}
.offer_thumb .slider_pagination a:before, .offer_thumb .slider_pagination a:after {
	-webkit-transition: all 0.2s ease-in-out;
	-moz-transition: all 0.2s ease-in-out;
	-o-transition: all 0.2s ease-in-out;
	transition: all 0.2s ease-in-out;
}
@media only screen and (min-width: 768px) {
	.offer_thumb .slider_pagination {
		position: absolute;
		left: 0;
		top: 0;
		border-width: 1px;
		border-style: solid;
	}
	.offer_thumb .slider_pagination a {
		display: block;
		margin: 0;
		width: 85px;
		height: 85px;
		line-height: 85px;
		text-align: center;
		padding: 8px;
		text-indent: 0;
		border-bottom-width: 1px;
		border-style: solid;
		border-radius: 0;
		-moz-border-radius: 0;
		-webkit-border-radius: 0;
	}
	.offer_thumb .slider_pagination a:not(.selected):hover img {
		filter: alpha(opacity=60);
		opacity: 0.6;
	}
	.offer_thumb .slider_pagination a.selected {
		top: 0;
	}
	.offer_thumb .slider_pagination a:last-child {
		border: 0;
	}
	.offer_thumb .slider_pagination a:before {
		content: "";
		display: block;
		width: 5px;
		height: 100%;
		right: -5px;
		top: 0;
		position: absolute;
		filter: alpha(opacity=0);
		opacity: 0;
	}
	.offer_thumb .slider_pagination a.selected:before {
		filter: alpha(opacity=100);
		opacity: 1;
	}
	.offer_thumb .slider_pagination a:after {
		content: "";
		left: auto;
		right: -9px;
		top: 50%;
		margin-top: -4px;
		width: 8px;
		height: 8px;
		filter: alpha(opacity=0);
		opacity: 0;
		border-radius: 0;
		-moz-border-radius: 0;
		-webkit-border-radius: 0;
	}
	.offer_thumb .slider_pagination a.selected:after {
		filter: alpha(opacity=100);
		opacity: 1;
	}
	.offer_thumb .slider_pagination a {
		background-color: #fff;
	}
	.offer_thumb .slider_pagination a.selected {
		background-color: #fff;
		background-image: url(../../../images/stripes/stripes_3_b.png);
	}
	.offer_thumb .slider_pagination a img {
		vertical-align: middle;
	}
}

/* Slider Revolution | Navigation
================================================== */

.tp-bullets.tp-thumbs {
	z-index: 29;
}
.fullwidthbanner-container .tp-thumbs {
	padding: 0 !important;
}
.tp-bullets.tp-thumbs .tp-mask, .tp-bullets.tp-thumbs .bullet {
	overflow: visible;
}
.tp-bullets.tp-thumbs .bullet.selected:after {
	bottom: -7px;
	content: "";
	display: block;
	height: 7px;
	left: 0;
	position: absolute;
	width: 100%;
}

/* Arrows */

.tparrows.round, .tparrows.navbar {
	display: inline-block;
	padding: 0;
	width: 46px;
	height: 46px;
	cursor: pointer;
	border: 0;
	-webkit-border-radius: 5px;
	border-radius: 5px;
	position: relative;
	overflow: hidden;
	-webkit-box-shadow: inset 0 0 0 1px rgba(0, 0, 0, .03);
	box-shadow: inset 0 0 0 1px rgba(0, 0, 0, .03);
	background-repeat: no-repeat;
	background-position: center center;
}
.tp-leftarrow.round, .tp-leftarrow.navbar {
	background-image: url(../../../images/tp-leftarrow.png);
}
.tp-rightarrow.round, .tp-rightarrow.navbar {
	background-image: url(../../../images/tp-rightarrow.png);
}
.tparrows.round:after {
	content: "";
	position: absolute;
	left: 0;
	top: 0;
	height: 100%;
	width: 0;
	z-index: 1;
	text-decoration: none;
	background: rgba(0, 0, 0, .05);
	-webkit-transition: all 0.3s;
	-moz-transition: all 0.3s;
	transition: all 0.3s;
}
.tparrows.round:hover:after {
	width: 100%;
}
.tparrows.default.preview1, .tparrows.default.preview4 {
	background: transparent;
}

/* #Sliding top
================================================== */

#Sliding-top {
	position: absolute;
	left: 0;
	top: 0;
	width: 100%;
	z-index: 800;
}
#Sliding-top:after {
	content: "";
	height: 3px;
	width: 100%;
	display: block;
	position: absolute;
	left: 0;
	bottom: -3px;
	z-index: 1;
	background: url(../../../images/box_shadow.png) repeat-x left top;
}
#Sliding-top .widgets_wrapper {
	padding: 15px 0;
	display: none;
}
#Sliding-top .widgets_wrapper .column {
	margin-bottom: 0;
}
#Sliding-top .widgets_wrapper .widget {
	margin-bottom: 0;
	padding: 15px 0;
}
#Sliding-top .widgets_wrapper .widget:after {
	display: none;
}
#Sliding-top a.sliding-top-control {
	display: block;
	width: 0;
	height: 0;
	border-style: solid;
	border-width: 0 45px 45px 0;
	border-color: transparent transparent transparent transparent;
	position: absolute;
	z-index: 801;
	right: 0;
	bottom: -45px;
}
#Sliding-top a.sliding-top-control span {
	display: block;
	width: 26px;
	height: 30px;
	line-height: 25px;
	text-align: center;
	position: absolute;
	right: -45px;
	top: 0;
	color: #fff;
	font-size: 18px;
}
#Sliding-top a.sliding-top-control .minus {
	display: none;
}
#Sliding-top a.sliding-top-control .plus {
	display: block;
}
#Sliding-top.active a.sliding-top-control .minus {
	display: block;
}
#Sliding-top.active a.sliding-top-control .plus {
	display: none;
}

/* 
	#Sliding-top .widgets_wrapper .widget ul { margin: 0 0 15px 30px; line-height: 21px; }
	#Sliding-top .widgets_wrapper .widget ul li { list-style:disc outside; padding: 3px 0; }
	*/


/* Widgets */

#Sliding-top .Recent_posts ul li .desc {
	background: rgba(0, 0, 0, .1);
}
#Sliding-top .widget_mfn_menu ul li a {
	background: rgba(0, 0, 0, .1);
	color: #ccc;
}
#Sliding-top .widget_recent_entries ul li {
	background: rgba(0, 0, 0, .1);
}
#Sliding-top ul.list_mixed li:after, #Sliding-top ul.list_check li:after, #Sliding-top ul.list_star li:after, #Sliding-top ul.list_idea li:after {
	background: rgba(255, 255, 255, .08);
}
#Sliding-top .widget_mfn_recent_comments ul li .date_label {
	background-color: rgba(0, 0, 0, .07);
}
#Sliding-top .widget_mfn_recent_comments ul li .date_label:after {
	border-left-color: rgba(0, 0, 0, .07);
}

/* #Pager
================================================== */

.pager_wrapper {
	margin-bottom: 0;
}
.pager {
	text-align: center;
}
.pager .pages {
	display: inline-block;
	margin: 0 30px;
	padding: 4px 3px;
	-webkit-border-radius: 5px;
	border-radius: 5px;
	background-color: #f8f8f8;
	background-image: url(../../../images/stripes/stripes_3_b.png);
}
.pager .pages a, .pager .pages span.page-numbers {
	display: inline-block;
	margin: 0 1px;
	width: 35px;
	height: 35px;
	line-height: 35px;
	text-align: center;
	-webkit-border-radius: 5px;
	border-radius: 5px;
}
.pager .pages a:hover {
	text-decoration: none;
}
.pager .pages a:hover, .pager .pages a.active, .pager .pages span.page-numbers.current {
	color: #fff;
}
.pager a.next_page, .pager a.prev_page {
	display: inline-block;
	line-height: 43px;
}

/* Animation */

.pager .pages a {
	-webkit-transition: all 0.3s ease-in-out;
	-moz-transition: all 0.3s ease-in-out;
	-o-transition: all 0.3s ease-in-out;
	transition: all 0.3s ease-in-out;
}

/* #Load more button
================================================== */

.pager_lm {
	background: url("../../../images/preloader.gif") no-repeat center 17px;
	text-align: center;
}
.pager_lm .pager_load_more {
	margin: 0;
}
.pager_lm.loading {
	min-height: 49px;
}
.pager_lm:not(.loading) {
	background: none;
}

/* #Pager single (blog post)
================================================== */

.pager-single {
	text-align: center;
	background: rgba(0, 0, 0, 0.02);
	margin-top: 15px;
}
.pager-single span {
	height: 45px;
	line-height: 45px;
	display: inline-block;
	padding: 0 9px;
	position: relative;
	font-weight: bold;
}
.pager-single a span {
	font-weight: normal;
}
.pager-single span:after {
	content: "";
	display: block;
	position: absolute;
	left: 0;
	bottom: -1px;
	width: 100%;
	height: 1px;
}
.pager-single a span:after {
	display: none;
}

/* #Fixed nav
================================================== */

.post-nav .fixed-nav {
	display: none;
}
.fixed-nav {
	position: fixed;
	bottom: 40px;
	height: 80px;
	z-index: 90;
}
.fixed-nav.fixed-nav-prev {
	left: 0;
}
.fixed-nav.fixed-nav-next {
	right: 0;
}
.fixed-nav .arrow {
	display: block;
	width: 35px;
	height: 80px;
	font-size: 15px;
	position: relative;
	z-index: 92;
	color: #fff;
	line-height: 80px;
	text-align: center;
}
.fixed-nav .photo {
	height: 80px;
	width: 80px;
	position: relative;
	z-index: 92;
	overflow: hidden;
	line-height: 0;
}
.fixed-nav .desc {
	width: 190px;
	padding: 6px 15px;
	min-height: 68px;
	background: #fff;
	z-index: 91;
}
.fixed-nav .desc h6 {
	margin-bottom: 3px;
	padding-bottom: 3px;
	border-bottom-width: 1px;
	border-style: solid;
}
.fixed-nav .desc i {
	display: inline-block;
	margin-right: 2px;
}
.fixed-nav .desc i:before {
	margin-left: 0;
}
.fixed-nav-prev .arrow, .fixed-nav-prev .photo, .fixed-nav-prev .desc {
	float: left;
}
.fixed-nav-prev .desc {
	margin-left: -335px;
}
.fixed-nav-prev:hover .desc {
	margin-left: 0px;
}
.fixed-nav-next .arrow, .fixed-nav-next .photo, .fixed-nav-next .desc {
	float: right;
}
.fixed-nav-next .desc {
	margin-right: -335px;
}
.fixed-nav-next:hover .desc {
	margin-right: 0px;
}

/* Animation */

.fixed-nav .photo, .fixed-nav .desc {
	-webkit-transition: all 0.3s ease-in-out;
	-moz-transition: all 0.3s ease-in-out;
	-o-transition: all 0.3s ease-in-out;
	-ms-transition: all 0.3s ease-in-out;
	transition: all 0.3s ease-in-out;
}

/* Format */

.fixed-nav.format-quote .desc {
	display: none;
}
.fixed-nav.format-quote .photo {
	background-color: #eee;
	background-image: url("../../../images/blockquote.png");
	background-position: center center;
	background-repeat: no-repeat;
	background-size: 50% auto;
}
.fixed-nav.format-link .photo img {
	display: none;
}
.fixed-nav.format-link .photo {
	background-color: #eee;
	background-image: url("../../../images/link.png");
	background-position: center center;
	background-repeat: no-repeat;
}
@media only screen and (max-width: 1430px) {
	.fixed-nav-prev .photo {
		position: static;
		margin-left: -115px;
	}
	.fixed-nav-prev:hover .photo {
		margin-left: 0;
	}
	.fixed-nav-next .photo {
		position: static;
		margin-right: -115px;
	}
	.fixed-nav-next:hover .photo {
		margin-right: 0;
	}
}

/* #Filters
================================================== */

#Filters {
	margin-bottom: 30px;
}
#Filters .filters_buttons {
	padding: 15px 15px;
	background-image: url(../../../images/stripes/stripes_5_b.png);
	-webkit-box-sizing: border-box;
	-moz-box-sizing: border-box;
	box-sizing: border-box;
	overflow: hidden;
}
#Filters .filters_buttons li {
	float: left;
	margin-right: 15px;
}
#Filters .filters_buttons li.categories i, #Filters .filters_buttons li.tags i {
	margin-right: 3px;
}
#Filters .filters_buttons li.reset {
	float: right;
	margin-right: 0;
}
#Filters .filters_wrapper {
	display: none;
	margin-top: 20px;
}
#Filters .filters_wrapper ul {
	display: none;
	overflow: hidden;
}
#Filters .filters_wrapper ul li {
	float: left;
	width: 19%;
	margin: 0.5%;
}
#Filters .filters_wrapper ul li a {
	display: block;
	padding: 7px 10px;
	background: #fff;
	border: 1px solid #F7F7F7;
	color: #858585;
}
#Filters .filters_wrapper ul li a:hover, #Filters .filters_wrapper ul li.current-cat a {
	text-decoration: none;
	color: #fff;
}
#Filters .filters_wrapper ul li.close a {
	text-align: center;
	width: 38px;
	padding: 7px 0;
	background: #8B8B8B;
	border: 1px solid #F7F7F7 !important;
	color: #fff;
}
#Filters .filters_wrapper ul li.close a:hover {
	background: #545454;
}

/* Animations */

#Filters .filters_wrapper ul li a {
	-webkit-transition: all 0.2s ease-in-out;
	-moz-transition: all 0.2s ease-in-out;
	-o-transition: all 0.2s ease-in-out;
	-ms-transition: all 0.2s ease-in-out;
	transition: all 0.2s ease-in-out;
}

/* #Owl-pagination
================================================== */


/* #NEXT / PREV NAVI 
================================================== */


/* Section: Highlight
================================================== */

.highlight-left, .highlight-right {
	position: relative;
}
.highlight-left:after, .highlight-right:after {
	content: "";
	position: absolute;
	width: 50%;
	height: 100%;
	top: 0;
}
.highlight-left:after {
	left: 0;
}
.highlight-right:after {
	right: 0;
}
.highlight-left .section_wrapper, .highlight-right .section_wrapper {
	z-index: 2;
}
@media only screen and (max-width: 767px) {
	.highlight-left:after, .highlight-right:after {
		content: none;
	}
}

/* Section: Portfolio
================================================== */

.section.full-width .section_wrapper {
	width: 100% !important;
}
.section.full-width .section_wrapper .column.one {
	width: 100%;
	margin: 0 !important;
}

/* #Header
================================================== */

body:not(.template-slider) #Header_wrapper {
	background-repeat: no-repeat;
	background-position: top center;
}
body:not(.template-slider) #Header_wrapper.bg-fixed {
	background-attachment: fixed;
}
#Header_wrapper {
	position: relative;
}
#Header {
	position: relative;
}
body:not(.template-slider) #Header {
	min-height: 250px;
}
.header-transparent .header_placeholder, .header-empty .header_placeholder {
	height: 0 !important;
}

/* Minimalist Header */

body.minimalist-header:not(.template-slider) #Header {
	min-height: 0;
	background-image: none !important;
}
body.minimalist-header.header-modern:not(.template-slider) #Header {
	min-height: 147px;
}
body.minimalist-header.header-simple:not(.template-slider) #Header {
	min-height: 130px;
}
body.minimalist-header.header-stack:not(.template-slider) #Header {
	min-height: 0;
}
body.minimalist-header.header-fixed:not(.template-slider) #Header {
	min-height: 60px;
}
body.minimalist-header.header-below:not(.template-slider) #Header {
	min-height: 90px;
	padding-top: 0;
}

/* #Action bar
================================================== */

#Action_bar {
	position: absolute;
	left: 0;
	top: 0;
	width: 100%;
	z-index: 30;
}
#Action_bar .column {
	margin-bottom: 0;
	overflow: hidden;
}
#Action_bar .contact_details {
	float: left;
}
#Action_bar .contact_details li {
	display: inline-block;
	margin-right: 10px;
	padding: 20px 0;
	color: rgba(255, 255, 255, 0.5);
}
#Action_bar .contact_details li>i {
	margin-right: 2px;
}
#Action_bar .contact_details li:last-child {
	margin-right: 0px;
}
#Action_bar .social {
	float: right;
	padding: 20px 0;
}
#Action_bar .social li {
	display: inline-block;
	margin-right: 6px;
}
#Action_bar .social li:last-child {
	margin-right: 0px;
}
#Action_bar .social li a {
	color: rgba(255, 255, 255, .3);
	font-size: 15px;
	line-height: 15px;
	-webkit-transition: all 0.3s ease-in-out;
	-moz-transition: all 0.3s ease-in-out;
	-o-transition: all 0.3s ease-in-out;
	-ms-transition: all 0.3s ease-in-out;
	transition: all 0.3s ease-in-out;
}
#Action_bar .social li a:hover {
	color: rgb(255, 255, 255);
}
#Action_bar .social-menu {
	float: right;
	padding: 20px 0;
}
#Action_bar .social-menu li {
	display: inline-block;
	margin-right: 6px;
	padding-right: 6px;
	border-right: 1px solid rgba(255, 255, 255, .1);
}
#Action_bar .social-menu li:last-child {
	margin-right: 0px;
	padding-right: 0;
	border-right: 0;
}

/* #Top_bar
================================================== */

#Top_bar {
	position: relative;
	left: 0;
	width: 100%;
	z-index: 30;
}
#Top_bar .column {
	margin-bottom: 0;
}
.layout-full-width.header-fw #Action_bar .container, .layout-full-width.header-fw #Top_bar .container {
	width: 100% !important;
	max-width: 100% !important;
	padding:0px;
}
#Top_bar .top_bar_left {
	position: relative;
	float: left;
}
#Top_bar .top_bar_right {
	float: right;
	height: 90px;
	position: relative;
	top: -4px;
	padding: 0 10px 0 20px;
}

.ie #Top_bar .top_bar_right:before {
	width: 11px;
}

/* Top bar width */

#Top_bar .top_bar_left {
	width: 990px;
}

/* Logo */

#Top_bar .logo {
	float: left;
	margin: 0 30px 0 20px;
}
#Top_bar .logo h1 {
	margin: 0;
}
#Top_bar .logo:not(.text-logo) h1 {
	line-height: 0;
	font-size: 0;
	margin: 0;
}
#Top_bar #logo {
	display: block;
	height: 60px;
	line-height: 60px;
	padding: 15px 0px;
}

/* overflow: hidden; */

#Top_bar #logo:hover {
	text-decoration: none;
}
#Top_bar #logo img {
	vertical-align: middle;
	max-height: 100%;
}
#Top_bar #logo img.logo-sticky {
	display: none;
}

/* Menu wrapper */

#Top_bar .menu_wrapper {
	float: left;
	z-index: 201;
}

/* Secondary menu wrapper */

#Top_bar .secondary_menu_wrapper {
	display: none;
}

/* Menu responsive */

#Top_bar a.responsive-menu-toggle {
	display: none;
}

/* Banner */

#Top_bar .banner_wrapper {
	display: none;
}

/* Search wrapper */

#Top_bar .search_wrapper {
	position: absolute;
	left: 0;
	top: 100%;
	display: none;
	z-index: 201;
	width: 100%;
	padding: 15px;
	-webkit-box-sizing: border-box;
	-moz-box-sizing: border-box;
	box-sizing: border-box;
}
#Top_bar .search_wrapper input[type="text"] {
	width: 100%;
	margin: 0;
	-webkit-box-shadow: 0 0 0;
	box-shadow: 0 0 0;
	padding-left: 35px;
	background: none;
	border-width: 0 0 1px 0;
	border-style: solid;
	border-color: rgba(255, 255, 255, .08) !important;
	font-size: 15px;
}
#Top_bar .search_wrapper input[type="text"]:focus {
	background-color: transparent !important;
}
#Top_bar .search_wrapper .icon_search, #Top_bar .search_wrapper .icon_close {
	position: absolute;
	top: 25px;
	font-size: 20px;
	line-height: 20px;
	display: block;
}
#Top_bar .search_wrapper .icon_search {
	left: 18px;
	color: rgba(0, 0, 0, .5);
}
#Top_bar .search_wrapper .icon_close {
	right: 18px;
	color: #fff;
	opacity: 0.3;
	filter: alpha(opacity=30);
	-webkit-transition: all 0.2s ease-in-out;
	-moz-transition: all 0.2s ease-in-out;
	-o-transition: all 0.2s ease-in-out;
	-ms-transition: all 0.2s ease-in-out;
	transition: all 0.2s ease-in-out;
}
#Top_bar .search_wrapper .icon_close:hover {
	right: 18px;
	opacity: 1;
	filter: alpha(opacity=100);
}

/* Cart */

#Top_bar a#header_cart {
	position: relative;
	top: 34px;
	display: block;
	float: left;
	font-size: 20px;
	line-height: 20px;
	margin-right: 15px;
}
#Top_bar a#header_cart span {
	position: absolute;
	right: -9px;
	top: -7px;
	display: block;
	-webkit-border-radius: 3px;
	border-radius: 3px;
	width: 17px;
	height: 17px;
	line-height: 17px;
	text-align: center;
	font-size: 11px;
	color: #fff;
}

/* Search */

#Top_bar a#search_button {
	position: relative;
	top: 34px;
	display: block;
	float: left;
	font-size: 20px;
	line-height: 20px;
	margin-right: 10px;
}
#Top_bar a.button.action_button {
	top: 13px;
	margin: 0 10px 0 0;
}

/* WPML */

#Top_bar .wpml-languages {
	display: block;
	float: left;
	position: relative;
	top: 25px;
	z-index: 210;
	margin-right: 10px;
}
#Top_bar .wpml-languages a.active {
	display: block;
	padding: 8px 6px 8px 10px;
	border-width: 1px;
	border-style: solid;
	border-color: #e8e8e8;
	-webkit-border-radius: 5px;
	border-radius: 5px;
}
#Top_bar .wpml-languages.disabled a.active {
	padding: 8px 10px;
}
#Top_bar .wpml-languages a.active i {
	font-size: 14px;
	line-height: 14px;
	margin: 0 0 0 5px;
}
#Top_bar .wpml-languages a.active i:before {
	margin: 0;
}
#Top_bar .wpml-languages a:hover.active {
	text-decoration: none;
}
#Top_bar .wpml-languages.enabled:hover a.active {
	-webkit-border-radius: 5px 5px 0 0;
	border-radius: 5px 5px 0 0;
	border-bottom: 0;
}
#Top_bar .wpml-languages ul.wpml-lang-dropdown {
	position: absolute;
	left: 0;
	top: 100%;
	width: 100%;
	-webkit-border-radius: 0 0 5px 5px;
	border-radius: 0 0 5px 5px;
	z-index: 205;
	overflow: hidden;
	display: none;
	border-width: 0 1px 1px 1px;
	border-style: solid;
	border-color: #e8e8e8;
	-webkit-box-sizing: border-box;
	-moz-box-sizing: border-box;
	box-sizing: border-box;
}
#Top_bar .wpml-languages ul.wpml-lang-dropdown li {
	border-bottom: 1px solid rgba(0, 0, 0, 0.05);
}
#Top_bar .wpml-languages ul.wpml-lang-dropdown li:last-child {
	border-bottom: 0;
}
#Top_bar .wpml-languages ul.wpml-lang-dropdown li a {
	font-size: 12px;
	display: block;
	text-align: center;
	padding: 4px 0px;
	color: #8B8B8B;
}
#Top_bar .wpml-languages ul.wpml-lang-dropdown li a:hover {
	text-decoration: none;
	color: #5F5F5F;
	background: rgba(0, 0, 0, .03);
}
#Top_bar .wpml-languages:hover {
	height: auto;
}
#Top_bar .wpml-languages:hover ul.wpml-lang-dropdown {
	display: block;
}
#Top_bar .wpml-languages a.active, #Top_bar .wpml-languages ul.wpml-lang-dropdown {
	background: #fff;
}
#Top_bar .wpml-languages.horizontal {
	display: block;
	padding: 8px 10px;
	border: 1px solid #e8e8e8;
	background: #fff;
	-webkit-border-radius: 5px;
	border-radius: 5px;
}
#Top_bar .wpml-languages.horizontal ul li {
	float: left;
	margin-right: 6px;
}
#Top_bar .wpml-languages.horizontal ul li:last-child {
	margin-right: 0;
}

/* #menu
================================================== */


/* main menu 1st level */

#Top_bar #menu {
	z-index: 201;
}
#Top_bar .menu {
	z-index: 202;
}
#Top_bar .menu>li {
	margin: 0;
	z-index: 203;
	display: block;
	float: left;
}
#Top_bar .menu>li:not(.mfn-megamenu-parent) {
	position: relative;
}
#Top_bar .menu>li.hover {
	z-index: 204;
}
#Top_bar .menu>li>a {
	display: block;
	line-height: 60px;
	padding: 15px 0;
	position: relative;
}
#Top_bar .page-menu>li>a {
	padding: 15px 20px;
}

/* default WP Pages Menu */

#Top_bar .menu>li>a:after {
	content: "";
	height: 4px;
	width: 100%;
	position: absolute;
	left: 0;
	top: -4px;
	z-index: 203;
	opacity: 0;
	filter: alpha(opacity=0);
}
#Top_bar .menu>li>a span:not(.description) {
	display: block;
	line-height: 60px;
	padding: 0 20px;
	white-space: nowrap;
	border-right-width: 1px;
	border-style: solid;
}
#Top_bar .menu>li>a span.description {
	font-size: 11px;
	line-height: 12px !important;
	margin: -15px -15px 0;
	color: #aaa;
	font-weight: 300;
	text-align: center;
	display: block;
}
#Top_bar .menu>li:last-child>a span {
	border: 0;
}
#Top_bar .menu>li>a:hover {
	text-decoration: none;
}
.menu-arrows #Top_bar .menu>li.submenu>a>span:not(.description) {
	padding-right: 30px;
}
.menu-arrows #Top_bar .menu>li.submenu>a>span:not(.description):after {
	content: "";
	display: block;
	width: 0;
	height: 0;
	position: absolute;
	top: 50%;
	right: 10px;
	margin-top: -2px;
	border-top: 5px solid #ccc;
	border-left: 5px solid transparent;
	border-right: 5px solid transparent;
}
.menu-highlight #Top_bar .menu>li.current-menu-item>a, .menu-highlight #Top_bar .menu>li.current_page_item>a, .menu-highlight #Top_bar .menu>li.current-menu-ancestor>a, .menu-highlight #Top_bar .menu>li.current_page_ancestor>a, .menu-highlight #Top_bar .menu>li.hover>a {
	color: #fff;
}

/* Animation */

#Top_bar .menu>li>a, #Top_bar .menu>li>a:after {
	-webkit-transition: all 0.4s ease-in-out;
	-moz-transition: all 0.3s ease-in-out;
	-o-transition: all 0.3s ease-in-out;
	-ms-transition: all 0.3s ease-in-out;
	transition: all 0.3s ease-in-out;
}
#Top_bar .menu>li.current-menu-item>a:after, #Top_bar .menu>li.current_page_item>a:after, #Top_bar .menu>li.current-menu-ancestor>a:after, #Top_bar .menu>li.current_page_ancestor>a:after, #Top_bar .menu>li.hover>a:after {
	opacity: 1;
	filter: alpha(opacity=100);
}

/* main menu 2nd level */

#Top_bar .menu li ul {
	position: absolute;
	left: 0px;
	top: 100%;
	z-index: 205;
	margin: 0;
	display: none;
	background-image: url(../../../images/box_shadow.png);
	background-repeat: repeat-x;
	background-position: left top;
}
#Top_bar .menu li>ul {
	box-shadow: 2px 2px 2px 0 rgba(0, 0, 0, 0.03);
	-webkit-box-shadow: 2px 2px 2px 0 rgba(0, 0, 0, 0.03);
}
#Top_bar .menu li ul li {
	padding: 0;
	width: 190px;
	position: relative;
	font-weight: normal;
}
#Top_bar .menu li ul li a {
	padding: 10px 10px 10px 20px;
	display: block;
	border-bottom: 1px solid rgba(0, 0, 0, 0.05);
}
#Top_bar .menu li ul li a span {
	display: inline-block;
	position: relative;
}
#Top_bar .menu li ul li a .menu-arrow {
	position: absolute;
	right: 7px;
	top: 11px;
	font-size: 12px;
	color: rgba(0, 0, 0, 0.35);
}
#Top_bar .menu>li ul li a:hover, #Top_bar .menu>li ul li.hover>a {
	text-decoration: none;
	background: rgba(0, 0, 0, .06);
}

/* main menu 3rd level */

#Top_bar .menu li ul li ul {
	position: absolute;
	left: 190px;
	top: 0px;
	z-index: 204;
}

/* Animation */

#Top_bar .menu li ul li a {
	-webkit-transition: all 0.2s ease-in-out;
	-moz-transition: all 0.2s ease-in-out;
	-o-transition: all 0.2s ease-in-out;
	-ms-transition: all 0.2s ease-in-out;
	transition: all 0.2s ease-in-out;
}

/* #secondary menu
================================================== */

#Header #menu-secondary-menu {
	z-index: 220;
}
#Header .secondary-menu {
	z-index: 221;
}
#Header .secondary-menu>li {
	margin: 0;
	z-index: 222;
	display: block;
	float: left;
	position: relative;
	padding: 8px 9px;
	line-height: 100%;
	-webkit-border-radius: 4px;
	border-radius: 4px;
}
#Header .secondary-menu>li.submenu {
	-webkit-border-radius: 4px 4px 0 0;
	border-radius: 4px 4px 0 0;
}
#Header .secondary-menu>li>a {
	display: block;
}
#Header .secondary-menu>li>a:hover {
	text-decoration: none;
}
#Header .secondary-menu li ul {
	position: absolute;
	left: 0px;
	padding: 7px;
	top: 100%;
	z-index: 223;
	margin: 0;
	display: none;
	-webkit-border-radius: 0px 4px 4px 4px;
	border-radius: 0 4px 4px 4px;
}
#Header .secondary-menu li ul li {}
#Header .secondary-menu li ul li:last-child {
	border-bottom: 0;
}
#Header .secondary-menu li ul li a {
	display: block;
	text-align: center;
	white-space: nowrap;
	padding: 6px 8px;
}
#Header .secondary-menu li ul li a:hover {
	text-decoration: none;
}
#Header .secondary-menu>li>a {
	color: #A8A8A8;
}
#Header .secondary-menu>li.hover, #Header .secondary-menu li ul {
	background: #F9F9F9;
}
#Header .secondary-menu li ul li {
	border-bottom: 1px solid rgba(0, 0, 0, 0.05);
}
#Header .secondary-menu li ul li a {
	color: #8B8B8B;
}
#Header .secondary-menu li ul li a:hover {
	color: #5F5F5F;
	background: rgba(255, 255, 255, 0.8);
}

/* #Header styles
================================================== */

.header-fixed #Action_bar {
	display: none;
}
@media only screen and (min-width: 768px) {
	.header-fixed #Top_bar {
		position: fixed;
		width: 100%;
		left: 0;
		top: 0 !important;
		height: 60px;
		z-index: 701;
		background: #fff;
		opacity: .97;
		filter: alpha(opacity=97);
		-webkit-box-shadow: 0px 2px 5px 0px rgba(0, 0, 0, 0.1);
		-moz-box-shadow: 0px 2px 5px 0px rgba(0, 0, 0, 0.1);
		box-shadow: 0px 2px 5px 0px rgba(0, 0, 0, 0.1);
	}
	.header-fixed #Top_bar .top_bar_left, .header-fixed #Top_bar .top_bar_right, .header-fixed #Top_bar .top_bar_right:before {
		background: none;
	}
	.header-fixed #Top_bar .top_bar_right {
		top: -4px;
	}
	.header-fixed #Top_bar .logo {
		width: auto;
		margin: 0 30px 0 20px;
		padding: 0;
	}
	.header-fixed #Top_bar #logo {
		padding: 5px 0;
		height: 50px;
		line-height: 50px;
	}
	.header-fixed #Top_bar #logo img {
		max-height: 35px;
	}
	.header-fixed #Top_bar .menu_wrapper {
		clear: none;
	}
	.header-fixed #Top_bar .menu_wrapper .menu>li>a {
		padding: 15px 0;
	}
	.header-fixed #Top_bar .menu>li>a, .header-fixed #Top_bar .menu>li>a span {
		line-height: 30px;
	}
	.header-fixed #Top_bar .menu>li>a:after {
		top: auto;
		bottom: -4px;
	}
	.header-fixed #Top_bar .menu>li>a span.description {
		margin-top: -5px;
	}
	.header-fixed #Top_bar #header_cart {
		top: 27px;
	}
	.header-fixed #Top_bar #search_button {
		top: 25px;
	}
	.header-fixed #Top_bar .wpml-languages {
		top: 15px;
	}
	.header-fixed #Top_bar .secondary_menu_wrapper {
		display: none;
	}
	.header-fixed #Top_bar .responsive-menu-toggle {
		top: 12px;
	}
}
.header-below {}
.header-below #Header .top_bar_left, .header-below #Header .top_bar_right {
	background-color: transparent;
}
.header-below #Top_bar {
	position: static;
}
.header-below #Top_bar .top_bar_right {
	top: 0;
}
.header-below #Top_bar .top_bar_right:before {
	display: none;
}
.header-below #Action_bar {
	display: none;
}
body.header-below:not(.template-slider) #Header {
	min-height: 90px;
	padding-top: 160px;
}
.header-below #Top_bar {
	background-color: #fff;
}
.header-classic {}
.header-classic #Header .top_bar_left, .header-classic #Header .top_bar_right {
	background-color: transparent;
}
.header-classic #Top_bar {
	position: static;
}
.header-classic #Top_bar .top_bar_right {
	top: 0;
}
.header-classic #Top_bar .top_bar_right:before {
	display: none;
}
.header-classic #Action_bar {
	position: static;
}
.header-classic #Action_bar .contact_details li, .header-classic #Action_bar .social, .header-classic #Action_bar .social-menu {
	padding: 12px 0;
}
.header-classic #Action_bar {
	background-color: #2C2C2C;
}
.header-classic #Top_bar {
	background-color: #fff;
}
.header-split {}
.header-split #Header .top_bar_left {
	width: 100% !important;
}
.header-split #Header .top_bar_left, .header-split #Header .top_bar_right {
	background-color: transparent;
}
.header-split #Header .top_bar_left .menu_wrapper {
	width: 100%;
}
.header-split #Header .top_bar_left .menu_left {
	float: left;
	width: 38%;
	text-align: center;
}
.header-split #Header .top_bar_left .menu_right {
	float: right;
	width: 38%;
	text-align: center;
}
.header-split #Header .top_bar_left .menu>li {
	display: inline-block;
	float: none;
}
.header-split #Header .top_bar_left .logo {
	width: 100%;
	margin: 0;
	text-align: center;
}
@media only screen and (min-width: 1240px) {
	.header-split #Header .top_bar_left .logo {
		position: absolute;
		left: 38%;
		width: 24%;
	}
}
.header-split #Top_bar .top_bar_right {
	position: absolute;
	top: 0;
	right: -28px;
	padding: 0;
}
.header-split #Top_bar a.action_button, .header-split #Top_bar a#header_cart, .header-split #Top_bar .wpml-languages {
	display: none;
}
.header-split #Top_bar .top_bar_right:before {
	display: none;
}
.header-split #Top_bar {
	position: static;
	background-color: #fff;
}
.header-split #Action_bar {
	position: static;
	background-color: #2C2C2C;
}
.header-split #Action_bar .contact_details li, .header-split #Action_bar .social, .header-split #Action_bar .social-menu {
	padding: 12px 0;
}
.header-stack {}
.header-stack #Header .top_bar_left {
	width: 100% !important;
}

/**/

.header-stack #Header .top_bar_left, .header-stack #Header .top_bar_right {
	background-color: transparent;
}
.header-stack #Top_bar {
	position: static;
}
.header-stack #Top_bar .logo {
	width: 100%;
	margin: 0;
	padding: 0 30px;
	text-align: left;
	border-bottom-width: 1px;
	border-style: solid;
	-webkit-box-sizing: border-box;
	-moz-box-sizing: border-box;
	box-sizing: border-box;
}

/**/

.header-stack.header-center #Top_bar .logo {
	text-align: center;
}
.header-stack.header-right #Top_bar .logo {
	text-align: right;
}
.header-stack #Top_bar .logo #logo {
	display: inline-block;
	height: auto;
}

/**/

.header-stack #Top_bar .menu_wrapper {
	clear: both;
}

/**/

.header-stack #Top_bar .menu_wrapper .menu>li>a {
	padding: 0;
}

/**/

.header-stack #Top_bar .menu>li>a span.description {
	margin-bottom: 10px;
}
.header-stack #Top_bar .top_bar_right {
	position: absolute;
	right: 0;
	bottom: -16px;
	top: auto;
}

/**/

.header-stack #Top_bar .top_bar_right:before {
	display: none;
}
.header-stack #Top_bar .secondary_menu_wrapper {
	position: absolute;
	right: 20px;
	top: 35px;
	display: block;
}

/**/

.header-stack.header-right #Top_bar .secondary_menu_wrapper {
	left: 20px;
	right: auto;
}

/**/

.header-stack #Action_bar {
	position: static;
}
.header-stack #Action_bar .contact_details li, .header-stack #Action_bar .social, .header-stack #Action_bar .social-menu {
	padding: 12px 0;
}
body.header-stack:not(.template-slider) #Header {
	min-height: 315px;
}
.header-stack #Action_bar {
	background-color: #2C2C2C;
}
.header-stack #Top_bar {
	background-color: #fff;
}
.header-magazine #Top_bar .logo {
	border: 0;
}
.header-magazine #Top_bar .top_bar_right {
	display: none;
}
.header-magazine #Top_bar .secondary_menu_wrapper {
	display: none;
}
.header-magazine #Top_bar .banner_wrapper {
	display: block;
	position: absolute;
	right: 20px;
	top: 20px;
	width: 468px;
	height: 60px;
	text-align: right;
}
.header-magazine #Top_bar .banner_wrapper a {
	display: block;
	line-height: 0;
}
.header-magazine #Top_bar .banner_wrapper img {
	display: inline-block;
	max-width: 100%;
	height: auto;
	max-height: 60px;
}
.header-simple {}
.header-simple #Action_bar {
	display: none;
}
.header-simple #Top_bar .top_bar_left {
	width: 100% !important;
	background: none;
}
.header-simple #Top_bar:not(.is-sticky) .top_bar_left {
	top: -40px;
}
.header-simple #Top_bar .top_bar_right, .header-simple #Top_bar .top_bar_right:before {
	display: none;
}
.header-simple #Top_bar .menu>li>a span.description {
	margin: 0 0 0 5px;
}
.header-empty #Header {
	position: static;
	min-height: 0 !important;
}
.header-empty #Subheader {
	display: none;
}
.header-empty #Content {
	padding: 0 !important;
}
.header-transparent #Top_bar .top_bar_left, .header-transparent #Top_bar .top_bar_right, .header-transparent #Top_bar .top_bar_right:before {
	background: none;
}
.header-transparent #Top_bar .top_bar_right {
	top: -15px;
}
.header-transparent #Top_bar #logo {
	padding: 0;
}
.header-transparent #Top_bar .menu>li>a:after {
	background: none;
}
.header-transparent #Top_bar .menu>li>a span {
	border-color: rgba(0, 0, 0, 0.03);
}
.header-transparent #Top_bar .menu li>ul:not(.mfn-megamenu-bg) {
	background-image: none;
}
.header-overlay .top_bar_right {
	display: none;
}
.header-overlay #Top_bar.is-sticky {
	display: none;
}
.header-overlay .overlay-menu-toggle {
	position: absolute;
	right: 30px;
	top: 30px;
	font-size: 30px;
	z-index: 9911;
}
.header-overlay .overlay-menu-toggle.focus {
	color: #fff;
	-webkit-transition: all 0.3s;
	-moz-transition: all 0.3s;
	transition: all 0.3s;
}
.header-overlay .overlay-menu-toggle .close {
	display: none;
}
.header-overlay .overlay-menu-toggle.focus .open {
	display: none;
}
.header-overlay .overlay-menu-toggle.focus .close {
	display: block;
}
.header-overlay.sticky-header .overlay-menu-toggle {
	position: fixed;
	margin-right: 10px;
}

/* #Overlay Menu
================================================== */

#Overlay {
	position: fixed;
	top: 0;
	left: 0;
	width: 100%;
	height: 100%;
	z-index: 9910;
	background: rgba(41, 145, 214, .95);
	display: none;
}
#overlay-menu {
	position: absolute;
	width: 700px;
	left: 50%;
	margin-left: -350px;
	top: 50%;
	margin-top: -150px;
}
#overlay-menu ul li {
	text-align: center;
}
#overlay-menu ul li a {
	color: #fff;
	font-size: 34px;
	line-height: 52px;
	letter-spacing: 3px;
	text-decoration: none;
}
#overlay-menu ul li a:hover {
	opacity: .8;
}
#overlay-menu ul li a:before, #overlay-menu ul li a:after {
	display: inline-block;
	opacity: 0;
	-webkit-transition: -webkit-transform 0.3s, opacity 0.2s;
	-moz-transition: -moz-transform 0.3s, opacity 0.2s;
	transition: transform 0.3s, opacity 0.2s;
}
#overlay-menu ul li a:before {
	margin-right: 20px;
	content: '[';
	-webkit-transform: translateX(20px);
	-moz-transform: translateX(20px);
	transform: translateX(20px);
}
#overlay-menu ul li a:after {
	margin-left: 20px;
	content: ']';
	-webkit-transform: translateX(-20px);
	-moz-transform: translateX(-20px);
	transform: translateX(-20px);
}
#overlay-menu ul li a:hover:before, #overlay-menu ul li a:hover:after, #overlay-menu ul li a:hover:before, #overlay-menu ul li a:hover:after {
	opacity: 1;
	-webkit-transform: translateX(0px);
	-moz-transform: translateX(0px);
	transform: translateX(0px);
}

/* #Subheader
================================================== */

#Subheader {
	background-color: rgba(0, 0, 0, .02);
	background-position: center top;
	background-repeat: no-repeat;
	padding: 30px 0;
	position: relative;
}
.subheader-transparent #Subheader {
	background: none;
}
.hide-title-area #Subheader {
	display: none;
}
#Subheader .column {
	margin-bottom: 0;
}
#Subheader .title {
	margin-bottom: 0;
	width: 70%;
	float: left;
}
#Subheader ul.breadcrumbs {
	display: block;
	width: 30%;
	margin: 1px 0 0;
	font-size: 1em !important;
	float: right;
	text-align: right;
}
#Subheader ul.breadcrumbs li {
	display: inline-block;
}
#Subheader ul.breadcrumbs li, #Subheader ul.breadcrumbs li a {
	color: rgba(0, 0, 0, .3);
}
#Subheader ul.breadcrumbs li span {
	margin: 0 10px;
	opacity: 0.4;
	filter: alpha(opacity=40);
}
#Subheader ul.woocommerce-breadcrumb li:last-child span {
	display: none;
}

/* subheader-style */

.subheader-title-right #Subheader .title {
	float: right;
	text-align: right;
}
.subheader-title-right #Subheader .breadcrumbs {
	float: left;
	text-align: left;
}
.subheader-both-left #Subheader .title {
	width: 100%;
}
.subheader-both-left #Subheader .breadcrumbs {
	width: 100%;
	text-align: left;
	margin-top: 10px;
}
.subheader-both-right #Subheader .title {
	width: 100%;
	text-align: right;
}
.subheader-both-right #Subheader .breadcrumbs {
	width: 100%;
	text-align: right;
	margin-top: 10px;
}
.subheader-both-center #Subheader .title {
	width: 100%;
	text-align: center;
}
.subheader-both-center #Subheader .breadcrumbs {
	width: 100%;
	text-align: center;
	margin-top: 10px;
}

/* #Post
================================================== */

.post-item {
	margin-bottom: 40px;
	position: relative;
	float: left;
	width: 100%;
}
.post-item .date_label {
	position: absolute;
	left: 0;
	top: 7px;
	display: none;
}
.post-photo-wrapper {
	width: 37%;
	float: left;
}
.post-photo-wrapper iframe {
	width: 100%;
}
.post-desc-wrapper {
	width: 63%;
	float: left;
}
.post-desc {
	padding: 15px 0 0 20px;
}
.format-standard.no-img .post-photo-wrapper {
	display: none;
}
.format-standard.no-img .post-desc-wrapper, .search-results .no-img .post-desc-wrapper {
	width: 100%;
}
.post-meta {
	margin-bottom: 8px;
}
.post-meta .author-date {
	float: left;
}
.post-meta .author-date a {
	border-bottom-width: 1px;
	border-style: dotted;
	text-decoration: none !important;
}
.post-meta .category {
	float: right;
	position: relative;
}
.post-meta .category.mata-tags {
	margin-right: 10px;
}
.post-meta .category .cat-btn {
	cursor: pointer;
}
.post-meta .category .cat-wrapper {
	position: absolute;
	right: 0;
	top: 100%;
	display: none;
	z-index: 21;
}
.post-meta .category:hover .cat-wrapper {
	display: block;
}
.post-meta .category .cat-wrapper ul {
	padding: 7px;
	min-width: 70px;
	background: #F9F9F9;
}
.post-meta .category .cat-wrapper ul li {
	border-bottom: 1px solid rgba(0, 0, 0, 0.05);
}
.post-meta .category .cat-wrapper ul li:last-child {
	border-bottom: 0;
}
.post-meta .category .cat-wrapper ul li a {
	display: block;
	text-align: center;
	padding: 1px 5px;
	color: #8B8B8B;
}
.post-meta .category .cat-wrapper ul li a:hover {
	text-decoration: none;
	color: #5F5F5F;
	background: rgba(255, 255, 255, 0.8);
}
.post-excerpt {
	margin-bottom: 15px;
}
.cat_description {
	margin-bottom: 40px;
}
.post-footer {
	background: rgba(0, 0, 0, .02);
	padding: 7px 15px;
	overflow: hidden;
	line-height: 30px;
}
.post-footer .button-love {
	float: left;
}
.post-footer .button-love a.mfn-love {
	display: inline-block;
	position: relative;
	padding-left: 24px;
	margin-left: 5px;
}
.post-footer .button-love a.mfn-love i {
	position: absolute;
	left: 0;
	top: 0;
	font-size: 16px;
}
.post-footer .button-love a.mfn-love:hover {
	text-decoration: none;
}
.post-footer .button-love a.mfn-love i:last-child {
	opacity: 0;
	filter: alpha(opacity=0);
	-webkit-transition: all 0.3s ease-in-out;
	-moz-transition: all 0.3s ease-in-out;
	-o-transition: all 0.3s ease-in-out;
	-ms-transition: all 0.3s ease-in-out;
	transition: all 0.3s ease-in-out;
}
.post-footer .button-love a:hover.mfn-love i:last-child, .post-footer .button-love a.loved.mfn-love i:last-child {
	opacity: 1;
	filter: alpha(opacity=100);
}
.post-footer .post-links {
	float: right;
	border-left-width: 1px;
	border-style: solid;
	padding-left: 10px;
}
.post-footer .post-links .post-comments {
	margin-right: 10px;
}
.hide-more .post-footer .post-links .icon-doc-text, .hide-more .post-footer .post-links .post-more {
	display: none;
}
.blog_slider.hide-more .item_wrapper .hr_color, .blog_slider.hide-more .item_wrapper .button {
	display: none;
}

/* Masonry */

.masonry {}
.masonry .post-item {
	width: 31.2%;
	margin: 0 1% 20px;
	background: #fff;
}
.masonry .post-photo-wrapper {
	width: 100%;
	float: none;
}
.masonry .post-desc-wrapper {
	width: 100%;
	float: none;
}
.masonry .post-desc-wrapper .post-desc {
	padding: 20px 20px 0;
}
.masonry .post-footer {
	margin: 0 -20px;
	-webkit-box-sizing: border-box;
	-moz-box-sizing: border-box;
	box-sizing: border-box;
}
.masonry .post-meta .author-date .author span.label {
	display: none;
}
.masonry .post-desc-wrapper .post-meta .category .cat-btn {
	display: none;
}
.masonry .post-desc-wrapper .post-footer .button-love .love-text {
	display: none;
}

/* Timeline */

.timeline .post-item {
	float: none;
	width: auto;
	padding-left: 200px;
	margin-bottom: 0;
	padding-bottom: 40px;
	background: url(../../../images/timeline_right.png) no-repeat 90px top;
}
.timeline .post-item:last-child {
	padding-bottom: 20px;
	margin-bottom: 20px;
}
.timeline .format-quote .post-meta, .timeline .format-link .post-meta {
	padding-top: 7px;
}
.timeline .post-item:before {
	content: "";
	width: 7px;
	height: 7px;
	border-width: 4px;
	border-style: solid;
	-webkit-border-radius: 100%;
	border-radius: 100%;
	position: absolute;
	left: 126px;
	top: 11px;
	display: block;
	visibility: visible;
	z-index: 1;
}
.timeline .date_label {
	display: block;
}
.timeline .post-meta .author-date .date {
	display: none;
}

/* Post types =========================================== */

.format-quote .post-photo-wrapper {
	display: none;
}
.format-quote .post-desc {
	padding: 0;
}
.format-quote .post-desc-wrapper {
	width: 100%;
	float: none;
}
.format-video {}
.format-video .image_frame .image_wrapper img {
	margin-bottom: 0 !important;
}
.format-video .image_frame:hover .image_wrapper img {
	top: 0px;
}
.format-link .post-photo-wrapper {
	display: none;
}
.format-link .post-desc-wrapper {
	width: 100%;
	float: none;
}
.format-link .post-desc {
	padding: 0;
}
.format-link .post-title {
	overflow: hidden;
}
.format-link .post-title .icon-link {
	display: block;
	width: 80px;
	height: 80px;
	font-size: 60px;
	line-height: 80px;
	border-right-width: 1px;
	border-style: solid;
	float: left;
	text-align: center;
}
.format-link .post-title .link-wrapper {
	margin-left: 100px;
	padding-top: 14px;
}
.format-link .post-title .link-wrapper h4 {
	margin-bottom: 7px;
	font-size: 20px;
	line-height: 22px;
}

/* #Single post
================================================== */

.post-nav {
	padding: 10px 10px 4px 130px;
	margin-bottom: 20px;
	background-image: url(../../../images/stripes/stripes_5_b.png);
	-webkit-box-sizing: border-box;
	-moz-box-sizing: border-box;
	box-sizing: border-box;
	overflow: hidden;
}
.post-nav .next-prev-nav {
	float: left;
}
.post-nav .next-prev-nav li {
	float: left;
	margin-right: 5px;
}
.post-nav .next-prev-nav a.button {
	margin: 0;
}
.post-nav .list-nav {
	float: right;
	line-height: 49px;
}
.post-header {
	margin-bottom: 20px;
}
.post-header .button-love {
	width: 99px;
	float: left;
	text-align: center;
}
.post-header .button-love a.mfn-love {
	display: inline-block;
	position: relative;
	padding-left: 28px;
	font-size: 17px;
	margin-top: 25px;
}
.no-title .post-header .button-love a.mfn-love {
	margin-top: 0;
}
.post-header .button-love a.mfn-love i {
	position: absolute;
	left: 0;
	top: 0;
	font-size: 18px;
}
.post-header .button-love a.mfn-love:hover {
	text-decoration: none;
}
.post-header .button-love a.mfn-love i:last-child {
	opacity: 0;
	filter: alpha(opacity=0);
	-webkit-transition: all 0.3s ease-in-out;
	-moz-transition: all 0.3s ease-in-out;
	-o-transition: all 0.3s ease-in-out;
	-ms-transition: all 0.3s ease-in-out;
	transition: all 0.3s ease-in-out;
}
.post-header .button-love a:hover.mfn-love i:last-child, .post-header .button-love a.loved.mfn-love i:last-child {
	opacity: 1;
	filter: alpha(opacity=100);
}
.post-header .title_wrapper {
	margin-left: 99px;
	border-left-width: 1px;
	border-style: solid;
	padding-left: 30px;
}
.post-header .title_wrapper h1 {
	font-size: 35px;
	line-height: 35px;
}
.single-photo-wrapper {}
.single-photo-wrapper .share_wrapper {
	float: left;
}
.single-photo-wrapper .image_frame {
	margin-left: 130px;
}
.no-share .single-photo-wrapper .image_frame {
	margin-left: 0px;
}
.single-photo-wrapper .image_frame iframe {
	width: 100%;
}
.format-image .single-photo-wrapper {
	text-align: center;
}
.format-image .single-photo-wrapper .image_frame {
	display: inline-block;
	margin-left: 0;
}
.share_wrapper {
	background: #fff;
	border-width: 1px;
	border-style: solid;
	width: 98px;
	text-align: center;
	padding: 10px 0 5px;
}
.share_wrapper .stButton {
	margin-bottom: 10px;
}
.author-box {}
.author-box .avatar-wrapper {
	width: 64px;
	height: 64px;
	float: left;
	border-width: 8px;
	border-style: solid;
	display: block;
	line-height: 0;
	-webkit-border-radius: 100%;
	border-radius: 100%;
	overflow: hidden;
}
.author-box .desc-wrapper {
	background: rgba(0, 0, 0, .02);
	padding: 20px;
	position: relative;
	margin-left: 105px;
}
.author-box .desc-wrapper:after {
	content: "";
	display: block;
	position: absolute;
	left: -6px;
	top: 35px;
	width: 0px;
	height: 0px;
	border-style: solid;
	border-width: 6px 6px 6px 0;
	border-color: transparent rgba(0, 0, 0, .02) transparent transparent;
}
.author-box .desc-wrapper h5 {
	margin-bottom: 5px;
}

/* Post related */

.section-post-related {}
.section-post-related .section-related-adjustment {
	border-top-width: 1px;
	border-style: solid;
	padding-top: 20px;
}
.section-post-related .post-related {
	position: relative;
}
.section-post-related .post-related .image_frame {
	margin-left: 30px;
	margin-bottom: 15px;
}
.section-post-related .post-related .fullscreen-container {
	height: 180px !important;
}
.section-post-related .post-related .date_label {
	position: absolute;
	left: 0;
	top: 30px;
	z-index: 20;
}
.section-post-related .post-related hr {
	margin-left: 30px;
	width: 40%;
}
.section-post-related .post-related a.button {
	margin-left: 30px;
	margin-bottom: 0;
}
.section-post-related .format-quote blockquote {
	margin-top: 70px;
	margin-left: 40px;
}
.section-post-related .format-link {}
.section-post-related .format-link .image_frame {
	height: 180px;
	background-color: rgba(255, 255, 255, .5);
	background-image: url("../../../images/link.png");
	background-position: center center;
	background-repeat: no-repeat;
}
.section-post-related .format-standard.no-img .image_frame {
	display: block;
	height: 180px;
	background-color: rgba(255, 255, 255, .5);
	background-image: url("../../../images/photo.png");
	background-position: center center;
	background-repeat: no-repeat;
}

/* single-format-link */

.single-format-link .single-photo-wrapper .share_wrapper {
	float: none;
	width: auto;
	padding: 10px 15px 15px;
}
.single-format-link .single-photo-wrapper .share_wrapper .stButton {
	margin: 0 10px 0 0;
}
.single-format-link .single-photo-wrapper .image_frame {
	display: none;
}

/* single-format-quote */

.single-format-quote #Subheader .title {
	width: 100%;
}
.single-format-quote #Subheader ul.breadcrumbs {
	display: none;
}
.single-format-quote .single-photo-wrapper .share_wrapper {
	float: none;
	width: auto;
	padding: 10px 15px 15px;
}
.single-format-quote .single-photo-wrapper .share_wrapper .stButton {
	margin: 0 10px 0 0;
}
.single-format-quote .single-photo-wrapper .image_frame {
	display: none;
}

/* no-img */

.portfolio.no-img .single-photo-wrapper .share_wrapper, .format-standard.no-img .single-photo-wrapper .share_wrapper {
	float: none;
	width: auto;
	padding: 10px 15px 15px;
}
.portfolio.no-img .single-photo-wrapper .share_wrapper .stButton, .format-standard.no-img .single-photo-wrapper .share_wrapper .stButton {
	margin: 0 10px 0 0;
}
.portfolio.no-img .single-photo-wrapper .image_frame, .format-standard.no-img .single-photo-wrapper .image_frame {
	display: none;
}

/* Project decription */

.project-description {}
.project-description li {
	width: 99.9%;
	clear: both;
	padding: 7px 10px;
	background: rgba(0, 0, 0, .01);
	border-style: solid;
	border-color: rgba(0, 0, 0, .03);
	-webkit-box-sizing: border-box;
	-moz-box-sizing: border-box;
	box-sizing: border-box;
}
.project-description li .label {
	font-weight: bold;
	min-width: 50px;
	display: inline-block;
}
.project-description li.one-third {
	float: left;
	width: 33.3%;
	clear: none;
	padding-right: 15px;
	border-width: 0 1px 1px 0;
}
.project-description li:nth-child(3) {
	border-right-color: transparent;
}

/* Share Item | .share_item */

.share_item {
	float: none;
	width: auto;
	padding: 10px 15px 15px;
}
.share_item .stButton {
	margin: 0 10px 0 0;
}

/* #Widget area
================================================== */

.with_aside .four.columns {
	margin-bottom: 0;
}
.widget-area {
	border-style: solid;
	padding: 30px 0 20px;
	position: relative;
}
body:not(.template-slider) .widget-area {
	margin-top: -30px;
}
.widget-area:before {
	content: "";
	display: block;
	position: absolute;
	top: 0;
	width: 1500px;
	height: 100%;
	background: rgba(0, 0, 0, .01);
	visibility: visible;
}
.aside_left .widget-area {
	border-right-width: 1px;
	padding-right: 25px;
}
.aside_left .widget-area:before {
	right: 0;
}
.aside_right .widget-area {
	border-left-width: 1px;
	padding-left: 25px;
}
.aside_right .widget-area:before {
	left: 0;
}
.widget-area.lines-boxed .widget:after {
	width: 100%;
}
.widget-area.lines-hidden .widget:after {
	display: none;
}
.widget {
	padding-bottom: 30px;
	margin-bottom: 30px;
	position: relative;
}
.widget:last-child {
	margin-bottom: 0;
	padding-bottom: 0;
}
.widget:last-child:after {
	display: none;
}
.widget:after {
	content: "";
	display: block;
	position: absolute;
	bottom: 0;
	width: 1500px;
	height: 0;
	visibility: visible;
	border-width: 1px 0 0 0;
	border-style: solid;
}
.widget>h3 {
	font-size: 18px;
	line-height: 22px;
}
.aside_left .widget:after {
	right: 0;
}
.aside_right .widget:after {
	left: 0;
}
.with_aside.aside_both .sidebar-1 .widget-area {
	border-right-width: 1px;
	padding-right: 25px;
}
.with_aside.aside_both .sidebar-1 .widget-area:before {
	right: 0;
}
.with_aside.aside_both .sidebar-1 .widget-area .widget:after {
	right: 0;
}
.with_aside.aside_both .sidebar-2 .widget-area {
	border-left-width: 1px;
	padding-left: 25px;
}
.with_aside.aside_both .sidebar-2 .widget-area:before {
	left: 0;
}
.with_aside.aside_both .sidebar-2 .widget-area .widget:after {
	left: 0;
}

/* Recent posts */

.Recent_posts {}
.Recent_posts ul {}
.Recent_posts ul li {
	margin-bottom: 10px;
}
.Recent_posts ul li:last-child {
	margin-bottom: 0;
}
.Recent_posts ul li a {
	text-decoration: none;
}
.Recent_posts ul li .desc {
	margin-right: 80px;
	padding: 5px 15px;
	background: #fff;
	position: relative;
	min-height: 70px;
}
.Recent_posts ul li .desc:after {
	content: "";
	display: block;
	position: absolute;
	right: 0;
	top: 0;
	width: 4px;
	height: 100%;
}
.Recent_posts ul li .desc h6 {
	position: relative;
	z-index: 2;
	margin-bottom: 3px;
	padding-bottom: 3px;
	border-bottom-width: 1px;
	border-style: solid;
}
.Recent_posts ul li .desc .date {
	position: relative;
	z-index: 2;
}
.Recent_posts ul li .desc .date i {
	display: inline-block;
	margin-right: 2px;
}
.Recent_posts ul li.no-img {
	position: relative;
}
.Recent_posts ul li.no-img .photo {
	width: 0;
	position: static;
}
.Recent_posts ul li.no-img .desc {
	margin-right: 0;
	min-height: inherit;
}
.Recent_posts ul li .photo {
	width: 80px;
	height: 80px;
	line-height: 0;
	text-align: center;
	float: right;
	position: relative;
}
.Recent_posts ul li .photo .c {
	width: 25px;
	height: 25px;
	line-height: 25px;
	z-index: 3;
	text-align: center;
	color: #fff;
	position: absolute;
	right: -12px;
	bottom: 12px;
	font-size: 11px;
	-webkit-border-radius: 3px;
	border-radius: 3px;
}
.Recent_posts ul li a:hover h6, .Recent_posts ul li a:hover .desc .date {
	color: #fff !important;
}
.Recent_posts ul li a:hover .desc:after {
	width: 100%;
}

/* Link */

.Recent_posts ul li.format-link .photo {
	background-color: #eee;
	background-image: url("../../../images/link.png");
	background-position: center center;
	background-repeat: no-repeat;
}
.Recent_posts ul li.format-quote .photo {
	background-color: #eee;
	background-image: url("../../../images/blockquote.png");
	background-position: center center;
	background-repeat: no-repeat;
	background-size: 40% auto;
}

/* Animation */

.Recent_posts ul li a:hover h6, .Recent_posts ul li a:hover .desc .date, .Recent_posts ul li a:hover .desc:after {
	-webkit-transition: all 0.3s ease-in-out;
	-moz-transition: all 0.3s ease-in-out;
	-o-transition: all 0.3s ease-in-out;
	transition: all 0.3s ease-in-out;
}

/* Recent posts wordress */

.widget_recent_entries {}
.widget_recent_entries ul {}
.widget_recent_entries ul li {
	padding: 5px 15px;
	background: #fff;
	position: relative;
	margin-bottom: 10px;
}
.widget_recent_entries ul li a {
	display: block;
	text-decoration: none;
	position: relative;
	z-index: 2;
	margin-bottom: 3px;
	padding-bottom: 3px;
	border-bottom-width: 1px;
	border-style: solid;
}
.widget_recent_entries ul li:last-child {
	margin-bottom: 0;
}
.widget_recent_entries ul li:after {
	content: "";
	display: block;
	position: absolute;
	right: 0;
	top: 0;
	width: 4px;
	height: 100%;
}
.widget_recent_entries ul li:hover:after {
	width: 100%;
}
.widget_recent_entries ul li .post-date {
	display: block;
	position: relative;
	z-index: 2;
}
.widget_recent_entries ul li:hover a, .widget_recent_entries ul li:hover .post-date {
	color: #fff;
}

/* Animation */

.widget_recent_entries ul li:hover a, .widget_recent_entries ul li:hover .post-date, .widget_recent_entries ul li:hover:after {
	-webkit-transition: all 0.3s ease-in-out;
	-moz-transition: all 0.3s ease-in-out;
	-o-transition: all 0.3s ease-in-out;
	transition: all 0.3s ease-in-out;
}

/* Categories */

.widget_categories {}
.widget_categories ul {
	list-style-type: square;
	color: #fff;
	padding: 5px 10px 5px 30px;
}
.widget_categories ul li {
	position: relative;
}
.widget_categories ul li:after {
	content: "";
	display: block;
	width: 70px;
	border-width: 0 0 1px 0;
	border-style: solid;
	border-color: rgba(255, 255, 255, .2);
	position: absolute;
	left: -30px;
	bottom: 0;
}
.widget_categories ul li:last-child:after {
	display: none;
}
.widget_categories ul li a {
	color: #fff !important;
	display: block;
	padding: 7px 0 7px 3px;
}

/* Archives, Custom menu */

.widget_archive, .widget_nav_menu {}
.widget_archive ul, .widget_nav_menu ul {
	list-style-type: square;
	padding: 5px 10px 5px 30px;
	background: rgba(0, 0, 0, .03);
}
.widget_archive ul li, .widget_nav_menu ul li {
	position: relative;
}
.widget_archive ul li:after, .widget_nav_menu ul li:after {
	content: "";
	display: block;
	width: 70px;
	border-width: 0 0 1px 0;
	border-style: solid;
	border-color: rgba(0, 0, 0, .1);
	position: absolute;
	left: -30px;
	bottom: 0;
}
.widget_archive ul li:last-child:after, .widget_nav_menu ul li:last-child:after {
	display: none;
}
.widget_archive ul li a, .widget_nav_menu ul li a {
	display: block;
	padding: 8px 0 9px 3px;
}

/* Meta, Pages, RSS */

.widget_meta, .widget_pages, .widget_rss {}
.widget_meta ul, .widget_pages ul, .widget_rss ul {
	list-style-type: square;
	padding: 0 0 0 30px;
}
.widget_meta ul li, .widget_pages ul li, .widget_rss ul li {}
.widget_meta ul li a, .widget_pages ul li a, .widget_rss ul li a {
	display: block;
	padding: 4px 0 7px 4px;
}

/* Recent comments */

.widget_mfn_recent_comments {}
.widget_mfn_recent_comments ul {}
.widget_mfn_recent_comments ul li {
	padding-bottom: 15px;
	background: url(../../../images/recent_comments.png) no-repeat 4px top;
	padding-left: 40px;
	position: relative;
}
.widget_mfn_recent_comments ul li:last-child {
	padding-bottom: 5px;
}
.widget_mfn_recent_comments ul li .date_label {
	background-color: rgba(0, 0, 0, .03);
	margin-top: 7px;
	margin-bottom: 5px;
	position: relative;
}
.widget_mfn_recent_comments ul li .date_label:after {
	border-left-color: rgba(0, 0, 0, .03);
}
.widget_mfn_recent_comments ul li:after {
	content: "";
	width: 7px;
	height: 7px;
	border-width: 4px;
	border-style: solid;
	-webkit-border-radius: 100%;
	border-radius: 100%;
	position: absolute;
	left: 0px;
	top: 11px;
	display: block;
	z-index: 1;
}
.widget_mfn_recent_comments ul li p {
	margin-bottom: 0;
}

/* Recent comments wordpress */

.widget_recent_comments {}
.widget_recent_comments ul li {
	padding-bottom: 5px;
	padding-top: 6px;
	background: url(../../../images/recent_comments.png) no-repeat 4px top;
	padding-left: 40px;
	position: relative;
}
.widget_recent_comments ul li:last-child {
	padding-bottom: 5px;
}
.widget_recent_comments ul li:after {
	content: "";
	width: 7px;
	height: 7px;
	border-width: 4px;
	border-style: solid;
	-webkit-border-radius: 100%;
	border-radius: 100%;
	position: absolute;
	left: 0px;
	top: 11px;
	display: block;
	z-index: 1;
}

/* Search */

.widget_search {}
.widget_search input[type="text"] {
	margin-bottom: 0;
	width: 100%;
}
.widget_search input[type="submit"] {
	display: none;
}

/* Calendar */

.widget_calendar td, .widget_calendar th {
	padding: 4px 3px;
}
.widget_calendar caption {
	padding: 5px;
	font-size: 14px;
}
.widget_calendar table tfoot tr:hover td {
	background: none !important;
}

/* Flickr */

.Flickr {
	overflow: hidden;
}
.Flickr .flickr_badge_image {
	margin: 0;
	padding: 0;
	float: left;
	margin: 0 1% 2% 1%;
	width: 23%;
}
.Flickr .flickr_badge_image a {
	display: block;
	line-height: 0;
}

/* Recent tweets */

.widget_tp_widget_recent_tweets {}
.widget_tp_widget_recent_tweets .tp_recent_tweets {
	clear: none;
	float: none;
}
.widget_tp_widget_recent_tweets ul {
	overflow: hidden;
}
.widget_tp_widget_recent_tweets ul li:last-child {
	padding-bottom: 0;
}

/* Tag cloud */

.widget_mfn_tag_cloud {}
.widget_mfn_tag_cloud ul {
	margin-bottom: 0;
	overflow: hidden;
}
.widget_mfn_tag_cloud ul li {
	margin: 0;
	padding: 0;
	float: left;
	margin: 0 5px 2px 0;
}
.widget_mfn_tag_cloud a {
	overflow: hidden;
	white-space: nowrap;
	display: inline-block;
	height: 22px;
	text-shadow: 1px 1px 0 #fff;
	font-size: 12px;
	padding-right: 8px;
	margin-right: 1px;
}
.widget_mfn_tag_cloud a:hover {
	text-decoration: none;
}
.widget_mfn_tag_cloud a span {
	padding-left: 8px;
	height: 22px;
	line-height: 22px;
	display: block;
	float: left;
}

/* Muffin menu */

.widget_mfn_menu {}
.widget_mfn_menu ul li a {
	display: block;
	padding: 7px 10px;
	margin-bottom: 5px;
	background: #fff;
	border: 1px solid rgba(0, 0, 0, .04);
	color: #858585;
}
.widget_mfn_menu ul li a:hover, .widget_mfn_menu ul li.current_page_item a {
	text-decoration: none;
	color: #fff !important;
}
.widget_mfn_menu ul li ul li a {
	padding-left: 20px;
}
.widget_mfn_menu ul li ul li a:before {
	content: "-";
	margin-right: 5px;
}
.widget_mfn_menu ul li ul li ul li a {
	padding-left: 40px;
}

/* Animation */

.widget_mfn_menu ul li a {
	-webkit-transition: all 0.3s ease-in-out;
	-moz-transition: all 0.3s ease-in-out;
	-o-transition: all 0.3s ease-in-out;
	transition: all 0.3s ease-in-out;
}

/* Muffin login */

.mfn-login {
	overflow: hidden;
}
.mfn-login form p {
	margin-bottom: 5px;
}
.mfn-login form input {
	margin-bottom: 0;
}
.mfn-login .sep {
	margin: 0 7px;
}
.mfn-login .avatar-wrapper {
	float: left;
	width: 64px;
	margin: 0 10px 10px 0;
}
.mfn-login .author {
	float: left;
}
.mfn-login .alert {
	padding: 5px 10px;
	margin-bottom: 5px;
}

/* #Portfolio
================================================== */

.portfolio_group {
	margin: 0 !important;
}
.portfolio_group .portfolio-item {
	list-style: none !important;
	float: left;
}
.portfolio_group:not(.list) .portfolio-item {
	background: none !important;
}
.portfolio_group .portfolio-item .list_style_header {
	display: none;
	overflow: hidden;
	margin-bottom: 20px;
	position: relative;
	min-height: 43px;
	padding-right: 275px;
}
.portfolio_group .portfolio-item .list_style_header h3 {
	margin-bottom: 0;
	margin-top: 7px;
}
.portfolio_group .portfolio-item .list_style_header .links_wrapper {
	position: absolute;
	right: 0;
	top: 0;
}
.portfolio_group .portfolio-item .list_style_header .links_wrapper a {
	margin-bottom: 0;
}
.portfolio_group .portfolio-item .list_style_header .links_wrapper a:last-child {
	margin-right: 0;
}
.portfolio_group .portfolio-item:first-child .list_style_header .links_wrapper a.portfolio_prev_js {
	display: none;
}
.portfolio_group .portfolio-item:last-child .list_style_header .links_wrapper a.portfolio_next_js {
	display: none;
}
.portfolio_group .portfolio-item .image_frame {
	width: 100%;
}
.portfolio_group .portfolio-item .desc {
	padding: 20px;
	background: #fff;
	overflow: hidden;
}
.portfolio_group .portfolio-item .desc .title_wrapper {
	position: relative;
	padding-right: 43px;
}
.portfolio_group .portfolio-item .desc .title_wrapper h5 {
	margin-bottom: 0;
}
.portfolio_group .portfolio-item .desc .title_wrapper .button-love {
	position: absolute;
	right: 0;
	top: 0;
}
.portfolio_group .portfolio-item .desc .title_wrapper .button-love a.mfn-love {
	display: inline-block;
	position: relative;
	padding-left: 24px;
}
.portfolio_group .portfolio-item .desc .title_wrapper .button-love a.mfn-love i {
	position: absolute;
	left: 0;
	top: 0;
	font-size: 16px;
}
.portfolio_group .portfolio-item .desc .title_wrapper .button-love a.mfn-love:hover {
	text-decoration: none;
}
.portfolio_group .portfolio-item .desc .title_wrapper .button-love a.mfn-love i:last-child {
	opacity: 0;
	filter: alpha(opacity=0);
	-webkit-transition: all 0.3s ease-in-out;
	-moz-transition: all 0.3s ease-in-out;
	-o-transition: all 0.3s ease-in-out;
	-ms-transition: all 0.3s ease-in-out;
	transition: all 0.3s ease-in-out;
}
.portfolio_group .portfolio-item .desc .title_wrapper .button-love a:hover.mfn-love i:last-child, .portfolio_group .portfolio-item .desc .title_wrapper .button-love a.loved.mfn-love i:last-child {
	opacity: 1;
	filter: alpha(opacity=100);
}
.portfolio_group .portfolio-item .desc .desc-wrapper {
	margin-right: 280px;
}
.portfolio_group .portfolio-item .desc .details-wrapper {
	float: right;
	width: 240px;
	padding-left: 19px;
	border-left-width: 1px;
	border-style: solid;
}
.portfolio_group .portfolio-item .desc .details-wrapper dl {
	margin-bottom: 0;
}
.portfolio_group .portfolio-item .desc .details-wrapper dl>dt {
	padding: 2px 0;
	border: 0;
	width: 80px;
}
.portfolio_group .portfolio-item .desc .details-wrapper dl>dd {
	padding: 2px 0;
	border: 0;
	margin-left: 90px;
}

/* List */

.portfolio_group.list .portfolio-item {
	width: 100%;
	border-bottom-width: 0px;
	border-style: solid;
}
.portfolio_group.list .portfolio-item .portfolio-item-fw-bg {
	background-position: top center;
	background-repeat: repeat;
	padding: 35px 0;
}
body:not(.with_aside) .portfolio_group.list .portfolio-item .portfolio-item-fw-wrapper {
	width: 1176px;
	margin: 0 auto;
}
.portfolio_group.list .portfolio-item .list_style_header {
	display: block;
}
.portfolio_group.list .portfolio-item .desc {
	background: none;
	padding: 20px 0 0;
}
.portfolio_group.list .portfolio-item .desc .title_wrapper {
	display: none;
}

/* Flat */

.portfolio_group.flat .portfolio-item {
	width: 33.3%;
}
.portfolio_group.flat .portfolio-item .image_frame {
	border: 0;
}
.portfolio_group.flat .portfolio-item .image_frame .mask {
	box-shadow: 0 0 0 0;
	-webkit-box-shadow: 0 0 0 0;
}
.portfolio_group.flat .portfolio-item .desc {
	display: none;
}
.portfolio_group.flat.col-4 .portfolio-item {
	width: 24.99%;
}

/* Grid */

.portfolio_group.grid .portfolio-item {
	width: 31.2%;
	margin: 0 1% 20px;
}
.portfolio_group.grid .portfolio-item .desc .desc-wrapper, .portfolio_group.grid .portfolio-item .desc .details-wrapper {
	display: none;
}

/* Masonry */

.portfolio_group.masonry .portfolio-item {
	width: 31.2%;
	margin: 0 1% 20px;
}
.portfolio_group.masonry .portfolio-item .desc .title_wrapper {
	margin-bottom: 15px;
}
.portfolio_group.masonry .portfolio-item .desc .desc-wrapper {
	display: block;
	margin-right: 0;
}
.portfolio_group.masonry .portfolio-item .desc .details-wrapper {
	display: none;
}

/* Masonry Flat */

.portfolio_group.masonry-flat .portfolio-item {
	width: 24.99%;
}
.portfolio_group.masonry-flat .portfolio-item.wide {
	width: 49.99%;
}
.portfolio_group.masonry-flat .portfolio-item.tall {
	margin-bottom: -1px;
}
.portfolio_group.masonry-flat .portfolio-item .image_frame {
	border: 0;
}
.portfolio_group.masonry-flat .portfolio-item .image_frame .mask {
	box-shadow: 0 0 0 0;
	-webkit-box-shadow: 0 0 0 0;
}
.portfolio_group.masonry-flat .portfolio-item .image_frame img {
	margin: 0 !important;
	top: 0 !important;
}
.portfolio_group.masonry-flat .portfolio-item .desc {
	display: none;
}
.section_wrapper .portfolio_wrapper .column.one.pager_wrapper {
	margin: 40px 0 !important;
}
.template-slider .section-portfolio-header {
	margin-top: 30px;
}

/* #Filters
================================================== */


/* #Footer
================================================== */

#Footer {
	background-position: center top;
	background-repeat: no-repeat;
}
#Footer .footer_action {
	background: rgba(0, 0, 0, .1);
}
#Footer .footer_action .one {
	margin-bottom: 30px;
	padding-top: 30px;
	text-align: center;
	font-size: 110%;
	line-height: 180%;
}
#Footer .widgets_wrapper {
	padding: 15px 0;
}
#Footer .widgets_wrapper .column {
	margin-bottom: 0;
}
#Footer .widgets_wrapper .widget {
	padding: 15px 0;
	margin-bottom: 0;
}
#Footer .widgets_wrapper .widget:after {
	display: none;
}
#Footer .footer_copy {
	border-top: 1px solid rgba(255, 255, 255, .1);
}
#Footer .footer_copy .one {
	margin-bottom: 20px;
	padding-top: 30px;
}
#Footer .footer_copy .copyright {
	float: left;
}
#Footer .footer_copy .social {
	float: right;
	margin-right: 20px;
}
#Footer .footer_copy .social li {
	display: inline-block;
	margin-right: 6px;
}
#Footer .footer_copy .social li:last-child {
	margin-right: 0px;
}
#Footer .footer_copy .social li a {
	color: rgba(255, 255, 255, .3);
	font-size: 15px;
	line-height: 15px;
	-webkit-transition: all 0.3s ease-in-out;
	-moz-transition: all 0.3s ease-in-out;
	-o-transition: all 0.3s ease-in-out;
	-ms-transition: all 0.3s ease-in-out;
	transition: all 0.3s ease-in-out;
}
#Footer .footer_copy .social li a:hover {
	color: rgb(255, 255, 255);
}
#Footer .footer_copy .social-menu {
	float: right;
	margin-right: 20px;
}
#Footer .footer_copy .social-menu li {
	display: inline-block;
	margin-right: 6px;
	padding-right: 6px;
	border-right: 1px solid rgba(255, 255, 255, .1);
}
#Footer .footer_copy .social-menu li:last-child {
	margin-right: 0px;
	padding-right: 0px;
	border-right: 0px;
}

/* .footer-copy-center */

.footer-copy-center #Footer .footer_copy {
	text-align: center;
}
.footer-copy-center #Footer .footer_copy .copyright {
	float: none;
	margin: 0 0 10px 0;
}
.footer-copy-center #Footer .footer_copy a#back_to_top {
	float: none;
	margin: -10px 0 10px;
}
.footer-copy-center #Footer .footer_copy .social {
	float: none;
	margin: 0;
}
.footer-copy-center #Footer .footer_copy .social-menu {
	float: none;
	margin: 0;
}

/* Widgets */

#Footer .Recent_posts ul li .desc {
	background: rgba(0, 0, 0, .1);
}
#Footer .widget_mfn_menu ul li a {
	background: rgba(0, 0, 0, .1);
	color: #ccc;
}
#Footer .widget_recent_entries ul li {
	background: rgba(0, 0, 0, .1);
}
#Footer ul.list_mixed li:after, #Footer ul.list_check li:after, #Footer ul.list_star li:after, #Footer ul.list_idea li:after {
	background: rgba(255, 255, 255, .08);
}
#Footer .widget_mfn_recent_comments ul li .date_label {
	background-color: rgba(0, 0, 0, .07);
}
#Footer .widget_mfn_recent_comments ul li .date_label:after {
	border-left-color: rgba(0, 0, 0, .07);
}

/* .footer-sliding
================================================== */

.footer-fixed #Header_wrapper, .footer-sliding #Header_wrapper {
	z-index: 29;
}
.footer-fixed #Content, .footer-sliding #Content {
	position: relative;
	z-index: 2;
}
.footer-fixed #Footer, .footer-sliding #Footer {
	position: fixed;
	width: 100%;
	bottom: 0;
	left: 0;
	z-index: 1;
}
.footer-fixed #Footer {
	z-index: 3;
}

/* #Comments
================================================== */

.comments {
	margin-bottom: 0;
}
#comments> :first-child {
	border-top-width: 1px;
	border-style: solid;
	padding-top: 20px;
}
.page #comments> :first-child {
	margin-top: 20px;
}
#comments .commentlist {
	margin-left: 0;
	list-style-type: none;
}
#comments .commentlist>li {
	margin-bottom: 30px;
}
#comments .commentlist>li .comment-body {
	position: relative;
	background: #fff;
	padding: 20px 20px 20px 20px;
	margin-bottom: 20px;
	margin-left: 105px;
}
#comments .commentlist>li .comment-body:after {
	content: "";
	display: block;
	position: absolute;
	left: -6px;
	top: 35px;
	width: 0px;
	height: 0px;
	border-style: solid;
	border-width: 6px 6px 6px 0;
	border-color: transparent #fff transparent transparent;
}
#comments .commentlist>li .children {
	margin-bottom: 15px;
	padding-left: 40px;
	border-left: 1px solid #ddd;
}
#comments .commentlist>li .photo {
	display: block;
	width: 64px;
	height: 64px;
	overflow: hidden;
	line-height: 0;
	position: absolute;
	left: -105px;
	top: 0px;
	border-width: 8px;
	border-style: solid;
	-webkit-border-radius: 100%;
	border-radius: 100%;
}
#comments .commentlist>li .comment-author {
	font-size: 15px;
	color: #444;
}
#comments .commentlist>li .comment-author a {}
#comments .commentlist>li .comment-author .fn {
	font-weight: bold;
}
#comments .commentlist>li .comment-meta {
	font-size: 12px;
	font-style: italic;
}
#comments .commentlist>li .comment-meta a {}
#comments .commentlist>li .comment-meta a.comment-edit-link {
	float: right;
	padding-right: 52px;
	position: relative;
	top: -19px;
}
#comments .commentlist>li p {
	margin: 4px 0 10px;
}
#comments .commentlist>li .reply {
	position: absolute;
	right: 20px;
	top: 20px;
}
#comments .commentlist>li .reply a.comment-reply-link {
	font-size: 11px;
	color: #fff;
	padding: 3px 6px;
	-webkit-border-radius: 1px;
	-moz-border-radius: 1px;
	border-radius: 3px;
	background-image: url(../../../images/stripes/stripes_10_w.png);
}
#comments .commentlist>li .reply a:hover.comment-reply-link {
	text-decoration: none;
}
#comments .commentlist li {}
#comments .commentlist li .comment-body {}
#comments .commentlist li .comment-body.last {}
#comments .commentlist li .comment-body.lastBorder {
	border-bottom: 0;
}
#comments .commentlist .children {
	margin-bottom: 0px;
	margin-left: 30px;
	padding-left: 50px;
}
#comments .commentlist .children li {
	margin-bottom: 0;
}
#comments #comments-title {
	margin-bottom: 20px;
}
#comments #comments-title span {
	font-style: italic;
}

/* #Respond
================================================== */

#respond {
	overflow: hidden;
	margin-bottom: 40px;
}
#respond .comment-reply-title {
	font-size: 21px;
	line-height: 25px;
}
#respond p {
	margin-bottom: 15px;
	padding-left: 0 !important;
}
#respond .comment-notes .required {
	position: static;
}
#respond input[type="text"] {
	margin-bottom: 0;
}
#respond label {
	margin-bottom: 3px;
}
#respond .required {
	position: absolute;
	right: 20px;
	top: 40px;
}
#respond .comment-form-author {
	width: 31.3%;
	margin-right: 2% !important;
	float: left;
	position: relative;
}
#respond .comment-form-email {
	width: 31.3%;
	margin-right: 2% !important;
	float: left;
	position: relative;
}
#respond .comment-form-url {
	width: 33.3%;
	float: left;
	position: relative;
}
#respond input[type="text"], #respond input[type="password"], #respond input[type="email"], #respond select {
	width: 100%;
}
#respond .comment-form-comment {
	width: 100%;
}
#respond .comment-form-comment textarea {
	width: 100%;
	margin-bottom: 10px;
}
#respond .form-submit {
	overflow: hidden;
	margin: 0;
}
#respond .form-submit input[type="submit"] {
	float: right !important;
	margin: 0 !important;
}
#respond .form-allowed-tags {
	display: none;
}
#respond .form-allowed-tags code {
	margin-top: 10px;
}

/* #Error_404
================================================== */

body.error404 {
	height: 100%;
}
body.error404.custom-404, body.error404.events-archive {
	height: auto;
}
body.error404:not(.events-archive) #Content {
	padding: 0 !important;
}
#Error_404 {
	overflow: hidden;
	position: absolute;
	top: 50%;
	margin-top: -150px;
	left: 30px;
}
#Error_404 .error_pic {
	width: 30%;
	float: left;
	text-align: center;
}
#Error_404 .error_pic i {
	font-size: 250px;
	line-height: 250px;
}
#Error_404 .error_desk {
	width: 70%;
	float: left;
	padding-top: 40px;
}
#Error_404 .error_desk h2 {
	font-size: 45px;
	line-height: 45px;
	color: rgba(0, 0, 0, .7);
}
#Error_404 .error_desk h4 {
	font-size: 26px;
	line-height: 30px;
	color: rgba(0, 0, 0, .7);
}
#Error_404 .error_desk p .check {
	line-height: 45px;
	font-size: 16px;
	color: rgba(0, 0, 0, .5);
}
#Error_404 .error_desk p em {
	font-style: italic;
	font-size: 17px;
	font-family: Georgia, serif;
	padding: 0 15px;
}
#Error_404 .error_desk p .button {
	margin: 0;
	display: inline;
	margin-left: 20px;
}

/* #Contact form
================================================== */

.wpcf7-form .column {
	margin-bottom: 10px;
}
.wpcf7-not-valid-tip {
	position: absolute !important;
	left: -50px !important;
	top: 0 !important;
	width: 50px !important;
	height: 44px !important;
	padding: 0 !important;
	background: url("../../../images/contact_form_error.png") !important;
	overflow: hidden;
	text-indent: -9999px !important;
	padding: 0;
	border: none !important;
}
.wpcf7-validation-errors {
	border: 0;
	display: none !important;
}
.wpcf7-mail-sent-ok {
	border: none !important;
	margin: 25px 0 0 0 !important;
	padding: 7px 0 !important;
	background: #7DCC68 !important;
	color: #fff;
	font-size: 14px;
	text-align: center;
	float: left;
	width: 100%;
}
.wpcf7-captchar {
	margin-bottom: 0;
}
span.wpcf7-form-control-wrap {
	width: 100%;
	position: relative !important;
	display: inline-block;
	margin-bottom: 3px;
}
span.wpcf7-form-control-wrap .wpcf7-quiz, span.wpcf7-form-control-wrap .wpcf7-select, span.wpcf7-form-control-wrap .wpcf7-text, span.wpcf7-form-control-wrap .wpcf7-textarea {
	width: 100%;
	-webkit-box-sizing: border-box;
	-moz-box-sizing: border-box;
	box-sizing: border-box;
	margin-bottom: 0;
}
.wpcf7-submit {
	margin-bottom: 0 !important;
}
#popup_contact {
	position: fixed;
	right: 20px;
	bottom: 15px;
	z-index: 9001;
}
.nice-scroll #popup_contact {
	right: 30px;
}
#popup_contact>a.button {
	width: 45px;
	height: 45px;
	line-height: 45px;
	font-size: 20px;
	margin: 0;
	text-align: center;
	color: rgba(0, 0, 0, .5);
	background: #f7f7f7;
}
#popup_contact>a.button:hover {
	text-decoration: none;
}
#popup_contact .popup_contact_wrapper {
	width: 250px;
	padding: 20px;
	background: #fbfbfb;
	position: absolute;
	bottom: 65px;
	right: 0;
	display: none;
}
#popup_contact.focus .popup_contact_wrapper {
	display: block;
}
#popup_contact .popup_contact_wrapper span.arrow {
	position: absolute;
	right: 15px;
	bottom: -8px;
	margin: 0 auto;
	width: 0px;
	height: 0px;
	display: block;
	border-top: 8px solid #fbfbfb;
	border-right: 8px solid transparent;
	border-left: 8px solid transparent;
}
#popup_contact .popup_contact_wrapper form {}
#popup_contact .popup_contact_wrapper form input[type="text"], #popup_contact .popup_contact_wrapper form input[type="email"], #popup_contact .popup_contact_wrapper form textarea {
	background: #fff;
	margin-bottom: 10px;
}
#popup_contact .popup_contact_wrapper form textarea {
	resize: vertical;
	min-height: 100px;
}
#popup_contact .popup_contact_wrapper form input[type="submit"] {
	margin: 0;
	float: right;
}
#popup_contact .wpcf7-form.invalid>p:after {
	display: block;
}
#popup_contact .wpcf7-form-control-wrap {
	display: inline-block;
	margin-right: 0;
	width: 100%;
}
#popup_contact div.wpcf7 img.ajax-loader {
	margin-top: 10px;
}

/* #Preloader
================================================== */

.portfolio_slider_ul, ul.testimonials-slider {
	background: url("../../../images/preloader.gif") no-repeat center center;
}
ul.testimonials-slider {
	max-height: 260px;
}
.caroufredsel_wrapper .portfolio_slider_ul, ul.owl-carousel {
	background: none;
	max-height: none;
}
.caroufredsel_wrapper .portfolio_slider_ul li, ul.owl-carousel>* {
	visibility: visible;
}

/* #BuddyPress
================================================== */

#buddypress {
	margin-bottom: 40px;
}
#buddypress #whats-new-options {
	height: auto !important;
	overflow: visible !important;
}
#buddypress div.dir-search {
	margin: 0;
}
#buddypress #search-members-form>* {
	float: left;
}
#buddypress div.dir-search input[type="text"], #buddypress li.groups-members-search input[type="text"] {
	padding: 2px 3px;
	font-size: 100%;
	margin-right: 5px;
	font-weight: normal;
}
#buddypress div#subnav.item-list-tabs ul li>* {
	float: left;
}
#buddypress div#subnav.item-list-tabs ul li label {
	margin: 10px 5px 0 0;
	font-weight: normal;
}
#buddypress div#item-header div#item-meta {
	font-size: 100%;
}

/* #Dark
================================================== */

.dark, .dark ul.timeline_items, .dark .icon_box a .desc, .dark .icon_box a:hover .desc, .dark .feature_list ul li a, .dark .list_item a, .dark .list_item a:hover, .dark .widget_recent_entries ul li a {
	color: #fff !important;
}
.dark .ui-tabs .ui-tabs-panel, .dark .accordion .question .answer {
	color: #626262;
}

/* Headings font */

.dark h1, .dark h1 a, .dark h1 a:hover {
	color: #fff;
}
.dark h2, .dark h2 a, .dark h2 a:hover {
	color: #fff;
}
.dark h3, .dark h3 a, .dark h3 a:hover {
	color: #fff;
}
.dark h4, .dark h4 a, .dark h4 a:hover {
	color: #fff;
}
.dark h5, .dark h5 a, .dark h5 a:hover {
	color: #fff;
}
.dark h6, .dark h6 a, .dark h6 a:hover, .dark a.content_link .title {
	color: #fff;
}

/* Borders */

.dark .idea_box, .dark table th, .dark table td, .dark .list_item .circle, .dark input[type="text"], .dark input[type="tel"], .dark input[type="password"], .dark input[type="email"], .dark textarea, .dark select, .dark .promo_box.has_border:after, .dark dl>dt, .dark dl>dd, .dark .article_box .desc_wrapper p, .dark a.icon_bar, .dark a.content_link, .dark .how_it_works .image, .dark .opening_hours, .dark .opening_hours .opening_hours_wrapper li, .dark .icon_box.has_border:after, .dark .chart_box:before, .dark .pricing-box, .dark .team_list .bq_wrapper, .dark .post-footer .post-links, .dark .format-link .post-title .icon-link, .dark .share_wrapper, .dark .post-header .title_wrapper, .dark .section-post-related .section-related-adjustment, .dark .comments, .dark .widget-area, .dark .widget:after, .dark .fixed-nav .desc h6, .dark .portfolio_group.list .portfolio-item, .dark .portfolio_group .portfolio-item .desc .details-wrapper, .dark .Recent_posts ul li .desc h6, .dark .widget_recent_entries ul li a, .dark .woocommerce .widget_best_sellers li, .dark .woocommerce .widget_featured_products li, .dark .woocommerce .widget_recent_reviews li, .dark .woocommerce .widget_recent_products li, .dark .woocommerce .widget_recently_viewed_products li, .dark .woocommerce .widget_random_products li, .dark .woocommerce .widget_top_rated_products li, .dark .woocommerce .widget_onsale li, .dark .woocommerce .widget_layered_nav li, .dark .woocommerce .widget_shopping_cart ul.product_list_widget li, .dark .woocommerce .widget_products li, .dark .woocommerce .product .related.products, .dark .woocommerce .product div.entry-summary h1.product_title:after, .dark .woocommerce .quantity input.qty {
	border-color: rgba(255, 255, 255, .08);
}

/* Grey */

.dark .blockquote p.author span, .dark .counter .desc_wrapper .title, .dark .article_box .desc_wrapper p, .dark .team .desc_wrapper p.subtitle, .dark .pricing-box .plan-header p.subtitle, .dark .pricing-box .plan-header .price sup.period, .dark .chart_box p, .dark .fancy_heading .inside, .dark .fancy_heading_line .slogan, .dark .post-meta, .dark .post-meta a, .dark .post-footer, .dark .post-footer a span.label, .dark .pager .pages a, .dark .button-love a .label, .dark .pager-single a, .dark #comments .commentlist>li .comment-author .says, .dark .fixed-nav .desc .date, .dark .filters_buttons li.label, .dark .Recent_posts ul li a .desc .date, .dark .widget_recent_entries ul li .post-date, .dark .tp_recent_tweets .twitter_time, .dark .widget_price_filter .price_label, .dark .shop-filters .woocommerce-result-count, .dark .woocommerce ul.product_list_widget li .quantity, .dark .widget_shopping_cart ul.product_list_widget li dl, .dark .product_meta .posted_in, .dark .woocommerce .shop_table .product-name .variation>dd, .dark .shipping-calculator-button:after, .dark .shop_slider .shop_slider_ul li .item_wrapper .price del, .dark .testimonials_slider .testimonials_slider_ul li .author span, .dark .testimonials_slider .testimonials_slider_ul li .author span a {
	color: #DEDEDE;
}

/* Dividers */

.dark hr {
	background-color: rgba(255, 255, 255, .08);
	color: rgba(255, 255, 255, .08);
}

/* Others */

.dark blockquote {
	color: #fff;
}
.dark .article_box .desc_wrapper h4 {
	color: #444;
}
.dark .progress_bars .bars_list li h6 .label {
	color: rgba(255, 255, 255, 0.35);
	background: rgba(255, 255, 255, 0.05);
}
.dark .faq .question .title {
	color: #fff;
}
.dark .counter .desc_wrapper .number {
	color: #fff;
}
.dark a.content_link .title {
	color: #444;
}
.dark .opening_hours, .dark .opening_hours h3 {
	color: #444444;
}
.dark .Recent_posts ul li .desc {
	background: rgba(0, 0, 0, .1);
}

/* Pricing box */

.dark .pricing-box-box {
	background: rgba(0, 0, 0, 0.1);
}
.dark .pricing-box .plan-inside ul li {
	border-bottom: 1px solid rgba(255, 255, 255, 0.1);
}

/* Lists */

.dark .column_column ul, .dark .column_column ol, .dark .the_content_wrapper ul, .dark .the_content_wrapper ol {
	color: #fff;
}

/* List item */

.dark .list_item.lists_2 .list_icon i {
	color: #fff;
}

/* Pricing table */

.dark .pricing-box-table.pricing-box-featured {
	background: rgba(0, 0, 0, .1);
}
.dark .pricing-box .plan-header .price sup.period {
	color: rgba(255, 255, 255, 0.5) !important;
}

/* Call to action */

.dark .call_to_action .call_left h3 {
	color: rgba(0, 0, 0, .65);
}
.dark .call_to_action .call_center a {
	color: #fff;
}

/* Fancy heading */

.dark .fancy_heading_line {
	background-image: url(../../../images/fancy_heading_hr_dark.png);
}

/* Content slider */

.dark .content_slider.flat a.button .button_icon i {
	color: #fff;
}

/* Fancy links */

.dark a.mfn-link, .dark a:hover.mfn-link {
	color: #fff;
}
.dark a.hover.mfn-link-2 span:before, .dark a.mfn-link-8:after, .dark a.mfn-link-8:before {
	background: #fff;
}
.dark a.mfn-link-4:hover:before, .dark a.mfn-link-4:hover:after, .dark a.hover.mfn-link-4:before, .dark a.hover.mfn-link-4:after, .dark a.mfn-link-7:after, .dark a.mfn-link-7:before {
	background: #fff;
}
.dark a.mfn-link-6:before {
	border-bottom-color: #fff;
}

/* #Video Section
================================================== */

.section.has-video {
	position: relative;
	overflow: hidden;
}
.section.has-video .section_video {
	position: absolute;
	top: 0;
	left: 0;
	min-height: 100%;
	min-width: 100%;
	overflow: hidden;
	z-index: 1;
}
.section.has-video .section_video .mask {
	position: absolute;
	top: 0;
	left: 0;
	height: 100%;
	width: 100%;
	z-index: 3;
	background: url(../../../images/videomask.png) repeat center;
}
.section.has-video .section_video video {
	position: absolute;
	top: 0;
	left: 0;
	min-height: 100%;
	min-width: 100%;
	z-index: 2;
}
.section.has-video .section_wrapper {
	position: relative;
	z-index: 10;
}
@media only screen and (min-device-width:481px) and (max-device-width:1024px) {
	.section.has-video .section_video {
		display: none !important;
	}
}

/* #Section Navigation
================================================== */

.section.has-navi .section-nav {
	position: absolute;
	left: 50%;
	z-index: 2;
	cursor: pointer;
	font-size: 38px;
	width: 50px;
	height: 50px;
	line-height: 50px;
	margin: 0 0 0 -25px;
	text-align: center;
	color: rgba(0, 0, 0, .2);
}
.section.has-navi .section-nav:hover {
	color: rgba(0, 0, 0, .8);
}
.section.has-navi .section-nav.prev {
	top: 75px;
}
.section.has-navi .section-nav.next {
	bottom: 75px;
}
.section.has-navi:first-child .section-nav.prev, .section.has-navi:nth-last-child(2) .section-nav.next {
	display: none;
}
.section.has-navi .section-nav {
	color: rgba(0, 0, 0, .2);
}
.section.has-navi .section-nav:hover {
	color: rgba(0, 0, 0, .8);
}
.section.has-navi.dark .section-nav {
	color: rgba(255, 255, 255, .2);
}
.section.has-navi.dark .section-nav:hover {
	color: rgba(255, 255, 255, .8);
}

/* Animation */

.section.has-navi .section-nav {
	-webkit-transition: all 0.5s ease-in-out;
	-moz-transition: all 0.5s ease-in-out;
	-o-transition: all 0.5s ease-in-out;
	transition: all 0.5s ease-in-out;
}

/* Visual Composer | Frontend Editor
================================================== */

.wpb_wrapper>div {
	margin-bottom: 35px;
}
.wpb_wrapper.ui-sortable .vc_call_to_action {
	background: none;
	border: none;
	padding: 0;
}
body.layout-boxed .vc_row[data-vc-stretch-content="true"] {
	left: 0 !important;
	width: auto !important;
	margin-left: -2.7%;
	margin-right: -2.7%;
}
body.layout-boxed .vc_row-no-padding .wpb_column {
	padding: 0;
}
.vc_images_carousel {
	width: auto !important;
}

/*
|--------------------------------------------------------------------------
|  3.0 Responsive-1240
|  
|--------------------------------------------------------------------------
|
| 
|
*/

html, body {
	overflow-x: hidden;
}

/*																								> 1240
===================================================================================================== */

@media only screen and (min-width: 1240px) {
	body:not(.header-simple) #Top_bar #menu {
		display: block !important;
	}
	/* main menu 2nd level - MegaMenu */
	#Top_bar .menu>li>ul.mfn-megamenu {
		width: 984px;
	}
	#Top_bar .menu>li>ul.mfn-megamenu>li {
		float: left;
	}
	#Top_bar .menu>li>ul.mfn-megamenu>li.mfn-megamenu-cols-1 {
		width: 100%;
	}
	#Top_bar .menu>li>ul.mfn-megamenu>li.mfn-megamenu-cols-2 {
		width: 50%;
	}
	#Top_bar .menu>li>ul.mfn-megamenu>li.mfn-megamenu-cols-3 {
		width: 33.33%;
	}
	#Top_bar .menu>li>ul.mfn-megamenu>li.mfn-megamenu-cols-4 {
		width: 25%;
	}
	#Top_bar .menu>li>ul.mfn-megamenu>li.mfn-megamenu-cols-5 {
		width: 20%;
	}
	#Top_bar .menu>li>ul.mfn-megamenu>li.mfn-megamenu-cols-6 {
		width: 16.66%;
	}
	#Top_bar .menu>li>ul.mfn-megamenu>li>ul {
		display: block !important;
		position: inherit;
		left: auto;
		top: auto;
		border-width: 0 1px 0 0;
	}
	#Top_bar .menu>li>ul.mfn-megamenu>li:last-child>ul {
		border: 0;
	}
	#Top_bar .menu>li>ul.mfn-megamenu>li>ul li {
		width: auto;
	}
	#Top_bar .menu>li>ul.mfn-megamenu a.mfn-megamenu-title {
		text-transform: uppercase;
		font-weight: 400;
	}
	#Top_bar .menu>li>ul.mfn-megamenu a.mfn-megamenu-title:hover {
		background: none;
	}
	#Top_bar .menu>li>ul.mfn-megamenu a .menu-arrow {
		display: none;
	}
	/* MegaMenu with Background */
	#Top_bar .menu>li>ul.mfn-megamenu-bg {
		padding: 20px 166px 20px 20px;
		background-repeat: no-repeat;
		background-position: bottom right;
	}
	#Top_bar .menu>li>ul.mfn-megamenu-bg>li {
		background: none;
	}
	#Top_bar .menu>li>ul.mfn-megamenu-bg>li a {
		border: none;
	}
	#Top_bar .menu>li>ul.mfn-megamenu-bg>li>ul {
		background: none !important;
		-webkit-box-shadow: 0 0 0 0;
		-moz-box-shadow: 0 0 0 0;
		box-shadow: 0 0 0 0;
	}
	/* #Header.is-sticky */
	#Top_bar.is-sticky {
		position: fixed;
		width: 100%;
		left: 0;
		top: -60px;
		height: 60px;
		z-index: 701;
		background: #fff;
		opacity: .97;
		filter: alpha(opacity=97);
		-webkit-box-shadow: 0px 2px 5px 0px rgba(0, 0, 0, 0.1);
		-moz-box-shadow: 0px 2px 5px 0px rgba(0, 0, 0, 0.1);
		box-shadow: 0px 2px 5px 0px rgba(0, 0, 0, 0.1);
	}
	#Top_bar.is-sticky .top_bar_left, #Top_bar.is-sticky .top_bar_right, #Top_bar.is-sticky .top_bar_right:before {
		background: none;
	}
	#Top_bar.is-sticky .top_bar_right {
		top: -4px;
	}
	#Top_bar.is-sticky .logo {
		width: auto;
		margin: 0 30px 0 20px;
		padding: 0;
	}
	#Top_bar.is-sticky #logo {
		padding: 5px 0;
		height: 50px;
		line-height: 50px;
	}
	#Top_bar.is-sticky #logo img {
		max-height: 35px;
		width: auto !important;
	}
	#Top_bar.is-sticky #logo img.logo-main {
		display: none;
	}
	#Top_bar.is-sticky #logo img.logo-sticky {
		display: inline;
	}
	#Top_bar.is-sticky .menu_wrapper {
		clear: none;
	}
	#Top_bar.is-sticky .menu_wrapper .menu>li>a {
		padding: 15px 0;
	}
	#Top_bar.is-sticky .menu>li>a, #Top_bar.is-sticky .menu>li>a span {
		line-height: 30px;
	}
	#Top_bar.is-sticky .menu>li>a:after {
		top: auto;
		bottom: -4px;
	}
	#Top_bar.is-sticky .menu>li>a span.description {
		display: none;
	}
	#Top_bar.is-sticky #header_cart {
		top: 27px;
	}
	#Top_bar.is-sticky #search_button {
		top: 25px;
	}
	#Top_bar.is-sticky a.button.action_button {
		top: 13px;
	}
	#Top_bar.is-sticky .wpml-languages {
		top: 15px;
	}
	#Top_bar.is-sticky .secondary_menu_wrapper, #Top_bar.is-sticky .banner_wrapper {
		display: none;
	}
	.header-simple #Top_bar.is-sticky .responsive-menu-toggle {
		top: 12px;
	}
	/* Sticky dark */
	.sticky-dark #Top_bar.is-sticky {
		background: rgba(0, 0, 0, .8);
	}
	.sticky-dark #Top_bar.is-sticky .menu>li>a {
		color: #fff;
	}
	.sticky-dark #Top_bar.is-sticky .top_bar_right a {
		color: rgba(255, 255, 255, .5);
	}
	.sticky-dark #Top_bar.is-sticky .wpml-languages a.active, .sticky-dark #Top_bar.is-sticky .wpml-languages ul.wpml-lang-dropdown {
		background: rgba(0, 0, 0, 0.3);
		border-color: rgba(0, 0, 0, 0.1);
	}
	/* .header-simple | Mobile Menu */
	.header-simple #Top_bar #menu {
		display: none;
		height: auto;
		width: 300px;
		bottom: auto;
		top: 60px;
		right: 1px;
		position: absolute;
		margin: 0px;
		background: #fff;
	}
	.header-simple #Header a.responsive-menu-toggle {
		display: block;
		width: 35px;
		height: 35px;
		line-height: 35px;
		font-size: 25px;
		text-align: center;
		position: absolute;
		top: 28px;
		right: 10px;
		-webkit-border-radius: 3px;
		border-radius: 3px;
	}
	.header-simple #Header a:hover.responsive-menu-toggle {
		text-decoration: none;
	}
	/* main menu 1st level */
	.header-simple #Top_bar #menu>ul {
		width: 100%;
		float: left;
	}
	.header-simple #Top_bar #menu ul li {
		width: 100%;
		padding-bottom: 0;
		border-right: 0;
		position: relative;
	}
	.header-simple #Top_bar #menu ul li a {
		padding: 0 20px;
		margin: 0;
		display: block;
		height: auto;
		line-height: normal;
		border: none;
	}
	.header-simple #Top_bar #menu ul li a:after {
		display: none;
	}
	.header-simple #Top_bar #menu ul li a span {
		border: none;
		line-height: 48px;
		display: inline;
		padding: 0;
	}
	.header-simple #Top_bar #menu ul li.submenu .menu-toggle {
		width: 48px;
		height: 48px;
		display: block;
		position: absolute;
		right: 0;
		top: 0;
		border-left: 1px solid rgba(0, 0, 0, 0.03);
		background: url(../../../images/menu-plus.png) center no-repeat;
	}
	.header-simple #Top_bar #menu ul li.hover>.menu-toggle {
		background: none !important;
	}
	.header-simple #Top_bar #menu ul li.hover a {
		border-bottom: 0;
	}
	.header-simple #Top_bar #menu ul.mfn-megamenu li .menu-toggle {
		display: none;
	}
	/* main menu 2nd level */
	.header-simple #Top_bar #menu ul li ul {
		position: relative !important;
		left: 0 !important;
		top: 0;
		padding: 0;
		margin-left: 0 !important;
		width: auto !important;
		background-image: none;
	}
	.header-simple #Top_bar #menu ul li ul li {
		width: 100% !important;
	}
	.header-simple #Top_bar #menu ul li ul li a {
		padding: 0 20px 0 30px;
	}
	.header-simple #Top_bar #menu ul li ul li a .menu-arrow {
		display: none;
	}
	.header-simple #Top_bar #menu ul li ul li a span {
		padding: 0;
	}
	.header-simple #Top_bar #menu ul li ul li a span:after {
		display: none !important;
	}
	.header-simple #Top_bar .menu>li>ul.mfn-megamenu a.mfn-megamenu-title {
		text-transform: uppercase;
		font-weight: 400;
	}
	.header-simple #Top_bar .menu>li>ul.mfn-megamenu>li>ul {
		display: block !important;
		position: inherit;
		left: auto;
		top: auto;
	}
	/* main menu 3rd level */
	.header-simple #Top_bar #menu ul li ul li ul {
		border-left: 0 !important;
		padding: 0;
		top: 0;
	}
	.header-simple #Top_bar #menu ul li ul li ul li a {
		padding: 0 20px 0 40px;
	}
	/* Header Creative */
	body.header-creative {
		padding-left: 50px;
	}
	body.header-creative.header-open {
		padding-left: 250px;
	}
	body.error404, body.under-construction, body.template-blank {
		padding-left: 0 !important;
	}
	#Header_creative {
		background: #fff;
	}
	#Header_creative {
		position: fixed;
		width: 250px;
		height: 100%;
		left: -200px;
		top: 0;
		z-index: 1001;
		-webkit-box-shadow: 2px 0 4px 2px rgba(0, 0, 0, .15);
		box-shadow: 2px 0 4px 2px rgba(0, 0, 0, .15);
	}
	#Header_creative .container {
		width: 100%;
	}
	#Header_creative .creative-wrapper {
		display: none;
	}
	#Header_creative a.creative-menu-toggle {
		display: block;
		width: 35px;
		height: 35px;
		line-height: 35px;
		font-size: 25px;
		text-align: center;
		position: absolute;
		top: 10px;
		right: 8px;
		-webkit-border-radius: 3px;
		border-radius: 3px;
	}
	.admin-bar #Header_creative a.creative-menu-toggle {
		top: 42px;
	}
	#Header_creative #Top_bar {
		position: static;
	}
	#Header_creative #Top_bar {
		width: 100%;
	}
	#Header_creative #Top_bar .top_bar_left {
		width: 100% !important;
		float: none;
	}
	#Header_creative #Top_bar .top_bar_right {
		width: 100% !important;
		float: none;
		height: auto;
		margin-bottom: 35px;
		text-align: center;
		padding: 0 20px;
		-webkit-box-sizing: border-box;
		-moz-box-sizing: border-box;
		box-sizing: border-box;
	}
	#Header_creative #Top_bar .top_bar_right:before {
		display: none;
	}
	#Header_creative #Top_bar .logo {
		float: none;
		text-align: center;
		margin: 15px 0;
	}
	#Header_creative #Top_bar .menu_wrapper {
		float: none;
		margin-bottom: 40px;
	}
	#Header_creative #Top_bar .menu>li {
		width: 100%;
		float: none;
		position: relative;
	}
	#Header_creative #Top_bar .menu>li>a {
		padding: 0;
		text-align: center;
	}
	#Header_creative #Top_bar .menu>li>a:after {
		display: none;
	}
	#Header_creative #Top_bar .menu>li>a span {
		border-right: 0;
		border-bottom-width: 1px;
		line-height: 38px;
	}
	#Header_creative #Top_bar .menu li ul {
		left: 100%;
		top: 0;
	}
	#Header_creative #Top_bar .menu>li>ul.mfn-megamenu {
		width: 700px !important;
	}
	#Header_creative #Top_bar .menu>li>ul.mfn-megamenu>li>ul {
		left: 0;
	}
	#Header_creative #Top_bar .menu li ul li a {
		padding-top: 9px;
		padding-bottom: 8px;
	}
	#Header_creative #Top_bar .menu li ul li ul {
		top: 0 !important;
	}
	#Header_creative #Top_bar .menu>li>a span.description {
		display: block;
		font-size: 13px;
		line-height: 28px !important;
		clear: both;
	}
	#Header_creative #Top_bar .search_wrapper {
		left: 100%;
		top: auto;
		bottom: -90px;
	}
	#Header_creative #Top_bar a#header_cart {
		display: inline-block;
		float: none;
		top: 3px;
	}
	#Header_creative #Top_bar a#search_button {
		display: inline-block;
		float: none;
		top: 3px;
	}
	#Header_creative #Top_bar a.button.action_button {
		display: inline-block;
		float: none;
		top: 0;
		margin-bottom: 0;
		margin-top: 10px;
	}
	#Header_creative #Top_bar .wpml-languages {
		display: inline-block;
		float: none;
		top: 0;
	}
	#Header_creative #Top_bar .wpml-languages.enabled:hover a.active {
		padding-bottom: 9px;
	}
	#Header_creative #Top_bar .banner_wrapper {
		display: block;
		text-align: center;
	}
	#Header_creative #Top_bar .banner_wrapper img {
		max-width: 100%;
		height: auto;
		display: inline-block;
	}
	#Header_creative #Action_bar {
		position: absolute;
		bottom: 0;
		top: auto;
		clear: both;
		padding: 0 20px;
		-webkit-box-sizing: border-box;
		-moz-box-sizing: border-box;
		box-sizing: border-box;
	}
	#Header_creative #Action_bar .social {
		float: none;
		text-align: center;
	}
	#Header_creative #Action_bar .social li {
		margin-bottom: 2px;
	}
	#Header_creative .social li a {
		color: rgba(0, 0, 0, .5);
	}
	#Header_creative .social li a:hover {
		color: rgb(0, 0, 0);
	}
	#Header_creative .creative-social {
		position: absolute;
		bottom: 10px;
		right: 0;
		width: 50px;
	}
	#Header_creative .creative-social li {
		display: block;
		float: none;
		width: 100%;
		text-align: center;
		margin-bottom: 5px;
	}
	.header-menu-right #Top_bar .menu_wrapper {
		float: right;
	}
	.header-menu-right.header-stack #Top_bar .menu_wrapper {
		margin-right: 150px;
	}
	.header-creative .fixed-nav.fixed-nav-prev {
		margin-left: 50px;
	}
	.header-creative.header-open .fixed-nav.fixed-nav-prev {
		margin-left: 250px;
	}
	/* Always Open */
	.header-open #Header_creative {
		left: 0;
	}
	.header-open #Header_creative .creative-wrapper {
		display: block;
	}
	.header-open #Header_creative .creative-menu-toggle, .header-open #Header_creative .creative-social {
		display: none;
	}
	/* Menu highlight */
	.menu-highlight #Top_bar .menu>li {
		margin: 0 2px;
	}
	.menu-highlight:not(.header-creative) #Top_bar .menu>li>a {
		margin: 20px 0;
		padding: 0;
		-webkit-border-radius: 5px;
		border-radius: 5px;
	}
	.menu-highlight #Top_bar .menu>li>a:after {
		display: none;
	}
	.menu-highlight #Top_bar .menu>li>a span:not(.description) {
		border-right-width: 0;
		line-height: 50px;
	}
	.menu-highlight #Top_bar .menu>li>a span.description {
		display: none;
	}
	.menu-highlight.header-stack #Top_bar .menu>li>a {
		margin: 10px 0;
	}
	.menu-highlight.header-stack #Top_bar .menu>li>a span:not(.description) {
		line-height: 40px;
	}
	.menu-highlight.header-fixed #Top_bar .menu>li>a {
		margin: 10px 0;
		padding: 5px 0;
	}
	.menu-highlight.header-fixed #Top_bar .menu>li>a span {
		line-height: 30px;
	}
	.menu-highlight.header-transparent #Top_bar .menu>li>a {
		margin: 5px 0;
	}
	.menu-highlight.header-simple #Top_bar #menu ul li, .menu-highlight.header-creative #Top_bar #menu ul li {
		margin: 0;
	}
	.menu-highlight.header-simple #Top_bar #menu ul li>a, .menu-highlight.header-creative #Top_bar #menu ul li>a {
		-webkit-border-radius: 0;
		border-radius: 0;
	}
	.menu-highlight:not(.header-simple) #Top_bar.is-sticky .menu>li>a {
		margin: 10px 0 !important;
		padding: 5px 0 !important;
	}
	.menu-highlight:not(.header-simple) #Top_bar.is-sticky .menu>li>a span {
		line-height: 30px !important;
	}
}

/* 																								< 1240
===================================================================================================== */

@media only screen and (max-width: 1239px) {
	/* Header */
	#Top_bar #menu {
		display: none;
		height: auto;
		width: 300px;
		bottom: auto;
		top: 100%;
		right: 1px;
		position: absolute;
		margin: 0px;
		background: #fff;
	}
	#Top_bar a.responsive-menu-toggle {
		display: block;
		width: 35px;
		height: 35px;
		text-align: center;
		position: absolute;
		top: 28px;
		right: 10px;
		-webkit-border-radius: 3px;
		border-radius: 3px;
	}
	#Top_bar a:hover.responsive-menu-toggle {
		text-decoration: none;
	}
	#Top_bar a.responsive-menu-toggle i {
		font-size: 25px;
		line-height: 35px;
	}
	#Top_bar a.responsive-menu-toggle span {
		float: right;
		padding: 10px 5px;
		line-height: 14px;
	}
	/* main menu 1st level */
	#Top_bar #menu>ul {
		width: 100%;
		float: left;
	}
	#Top_bar #menu ul li {
		width: 100%;
		padding-bottom: 0;
		border-right: 0;
		position: relative;
	}
	#Top_bar #menu ul li a {
		padding: 0 20px;
		margin: 0;
		display: block;
		height: auto;
		line-height: normal;
		border: none;
	}
	#Top_bar #menu ul li a:after {
		display: none;
	}
	#Top_bar #menu ul li a span {
		border: none;
		line-height: 48px;
		display: inline;
		padding: 0;
	}
	#Top_bar #menu ul li a span.description {
		margin: 0 0 0 5px;
	}
	#Top_bar #menu ul li.submenu .menu-toggle {
		width: 48px;
		height: 48px;
		display: block;
		position: absolute;
		right: 0;
		top: 0;
		border-left: 1px solid rgba(0, 0, 0, 0.03);
		background: url(../../../images/menu-plus.png) center no-repeat;
	}
	#Top_bar #menu ul li.hover>.menu-toggle {
		background: none !important;
	}
	#Top_bar #menu ul li.hover a {
		border-bottom: 0;
	}
	#Top_bar #menu ul li a span:after {
		display: none !important;
	}
	#Top_bar #menu ul.mfn-megamenu li .menu-toggle {
		display: none;
	}
	/* main menu 2nd level */
	#Top_bar #menu ul li ul {
		position: relative !important;
		left: 0 !important;
		top: 0;
		padding: 0;
		margin-left: 0 !important;
		width: auto !important;
		background-image: none !important;
	}
	#Top_bar #menu ul li ul li {
		width: 100% !important;
	}
	#Top_bar #menu ul li ul li a {
		padding: 0 20px 0 30px;
	}
	#Top_bar #menu ul li ul li a .menu-arrow {
		display: none;
	}
	#Top_bar #menu ul li ul li a span {
		padding: 0;
	}
	#Top_bar #menu ul li ul li a span:after {
		display: none !important;
	}
	#Top_bar .menu>li>ul.mfn-megamenu a.mfn-megamenu-title {
		text-transform: uppercase;
		font-weight: 400;
	}
	#Top_bar .menu>li>ul.mfn-megamenu>li>ul {
		display: block !important;
		position: inherit;
		left: auto;
		top: auto;
	}
	/* main menu 3rd level */
	#Top_bar #menu ul li ul li ul {
		border-left: 0 !important;
		padding: 0;
		top: 0;
	}
	#Top_bar #menu ul li ul li ul li a {
		padding: 0 20px 0 40px;
	}
	/* Header Creative */
	.header-creative #Wrapper {
		padding-top: 60px;
	}
	#Header_creative {
		position: fixed;
		width: 100%;
		left: 0px !important;
		z-index: 1001;
	}
	#Header_creative .creative-wrapper {
		display: block !important;
		opacity: 1 !important;
		filter: alpha(opacity=100) !important;
	}
	#Header_creative .creative-menu-toggle, #Header_creative .creative-social {
		display: none !important;
		opacity: 1 !important;
		filter: alpha(opacity=100) !important;
	}
	#Header_creative #Top_bar {
		position: static;
		margin: 0 8%;
		width: 84%;
	}
	#Header_creative #Top_bar #logo {
		height: 50px;
		line-height: 50px;
		padding: 5px 0;
	}
	#Header_creative #Top_bar #logo img {
		max-height: 40px;
	}
	#Header_creative #Top_bar .responsive-menu-toggle {
		top: 12px;
	}
	#Header_creative #Top_bar #header_cart {
		top: 21px;
	}
	#Header_creative #Top_bar #search_button {
		top: 20px;
	}
	#Header_creative #Top_bar .wpml-languages {
		top: 11px;
	}
	#Header_creative #Top_bar .action_button {
		top: 9px;
	}
	#Header_creative #Top_bar .top_bar_right {
		height: 60px;
		top: 0;
	}
	#Header_creative #Top_bar .top_bar_right:before {
		display: none;
	}
	#Header_creative #Action_bar {
		display: none;
	}
	.header_placeholder {
		height: 0 !important;
	}
	/* Stack header */
	.header-stack #Top_bar {}
	.header-stack .menu_wrapper a.responsive-menu-toggle {
		position: static !important;
		margin: 11px 0;
	}
	.header-stack .menu_wrapper #menu {
		left: 0;
		right: auto;
	}
	/* Responsive | Hover Effect */
	.no-hover-tablet a.button:after, .no-hover-tablet a.tp-button:after, .no-hover-tablet button:after, .no-hover-tablet input:after {
		display: none;
	}
	.no-hover-tablet .image_frame:not(.no_link) .image_wrapper img:not(.ls-l) {
		margin-bottom: 0 !important;
	}
	.no-hover-tablet .image_frame .image_wrapper img {
		top: 0 !important;
	}
	.no-hover-tablet .image_frame .image_wrapper .mask, .no-hover-tablet .image_frame .image_wrapper .image_links {
		display: none !important;
	}
	.no-hover-tablet .Recent_posts ul li .desc:after {
		display: none;
	}
	.no-hover-tablet .Recent_posts ul li a:hover h6, .no-hover-tablet .Recent_posts ul li a:hover .desc .date {
		color: inherit !important;
	}
	/* Responsive | Section Background Image */
	.no-section-bg-tablet .section {
		background-image: none !important;
	}
}

/* #Desktop 																				960 - 1239
====================================================================================================== */

@media only screen and (min-width: 960px) and (max-width: 1239px) {
	body {
		min-width: 0;
	}
	#Wrapper {
		width: 960px;
	}
	.section_wrapper, .container, .with_aside .content_wrapper {
		width: 940px;
	}
	/* ======================================================= */
	/* Top bar width */
	#Top_bar .top_bar_left {
		width: 729px;
	}
	/* Google maps */
	.column_map .google-map-contact-wrapper {
		width: 921px;
		margin-left: -460px;
	}
	/* Portfolio list */
	body:not(.with_aside) .portfolio_group.list .portfolio-item .portfolio-item-fw-wrapper {
		width: 921px;
	}
	/* Error 404 */
	#Error_404 .error_pic i {
		font-size: 220px;
		line-height: 260px;
	}
	#Error_404 .error_desk {
		padding-top: 40px;
	}
	/* Offer slider */
	.offer .offer_li .desc_wrapper {
		width: 436px;
	}
	/* Recent posts */
	.Recent_posts ul li .desc {
		margin-right: 60px;
	}
	.Recent_posts ul li .photo {
		width: 60px;
		height: 60px;
	}
	.Recent_posts ul li .photo .c {
		width: 20px;
		height: 20px;
		line-height: 20px;
		bottom: 5px;
		right: -8px;
	}
}

/* #Header Creative always Open 															1240 - 1489
====================================================================================================== */

@media only screen and (min-width: 1240px) and (max-width: 1489px) {
	body.header-open {
		min-width: 0;
	}
	.header-open #Wrapper {
		width: 960px;
	}
	.header-open .section_wrapper, .header-open .container, .header-open.with_aside .content_wrapper {
		width: 940px;
	}
	.header-open.with_aside .section_wrapper {
		width: 100%;
	}
	/* ======================================================= */
	/* Google maps */
	.header-open .column_map .google-map-contact-wrapper {
		width: 921px;
		margin-left: -460px;
	}
	/* Portfolio list */
	body.header-open:not(.with_aside) .portfolio_group.list .portfolio-item .portfolio-item-fw-wrapper {
		width: 921px;
	}
	/* Error 404 */
	.header-open #Error_404 .error_pic i {
		font-size: 220px;
		line-height: 260px;
	}
	.header-open #Error_404 .error_desk {
		padding-top: 40px;
	}
	/* Offer slider */
	.header-open .offer .offer_li .desc_wrapper {
		width: 436px;
	}
	/* Recent posts */
	.header-open .Recent_posts ul li .desc {
		margin-right: 60px;
	}
	.header-open .Recent_posts ul li .photo {
		width: 60px;
		height: 60px;
	}
	.header-open .Recent_posts ul li .photo .c {
		width: 20px;
		height: 20px;
		line-height: 20px;
		bottom: 5px;
		right: -8px;
	}
}

/*
|--------------------------------------------------------------------------
|  4.0 Responsive
|  
|--------------------------------------------------------------------------
|
| 
|
*/

html, body {
	overflow-x: hidden
}

/* > 1240 ------------------------------------------------------------------------------------------------------------- > 1240 */

@media only screen and (min-width: 1240px) {
	.layout-boxed {
		padding: 25px
	}
	.layout-boxed.nice-scroll {
		padding: 25px 25px 25px 15px
	}
	.layout-boxed.boxed-no-margin {
		padding: 0;
	}
	#Top_bar.loading {
		display: none
	}
}

/* #Header Creative always Open	1240 - 1489 ----------------------------------------- #Header Creative always Open 1240 - 1489 */

@media only screen and (min-width: 1240px) and (max-width: 1489px) {
	body.header-open {
		min-width: 0;
	}
	.header-open #Wrapper {
		max-width: 960px;
	}
	.header-open .section_wrapper, .header-open .container, .header-open.with_aside .content_wrapper {
		max-width: 940px;
	}
	.header-open.with_aside .section_wrapper {
		max-width: 100%;
	}
	/* -------------------- */
	/* Error 404 */
	.header-open #Error_404 .error_pic i {
		font-size: 220px;
		line-height: 260px
	}
	.header-open #Error_404 .error_desk {
		padding-top: 40px
	}
	/* Google maps */
	.header-open .section.full-width .wrap.one .column_map.one .google-map-contact-wrapper {
		left: auto;
		right: 50px;
	}
	/* Offer slider */
	.header-open .offer .offer_li .desc_wrapper {
		width: 436px;
		width: calc(50% - 42px)
	}
	/* Portfolio list */
	body.header-open:not(.with_aside) .portfolio_group.list .portfolio-item .portfolio-item-fw-wrapper {
		width: 921px
	}
	/* Recent posts */
	.header-open .Recent_posts ul li .desc {
		margin-right: 60px
	}
	.header-open .Recent_posts ul li .photo {
		width: 60px;
		height: 60px
	}
	.header-open .Recent_posts ul li .photo .c {
		width: 20px;
		height: 20px;
		line-height: 20px;
		bottom: 5px;
		right: -8px
	}
}

/* < 1240 ------------------------------------------------------------------------------------------------------------- < 1240 */

@media only screen and (max-width: 1239px) {
	/* Hover Effect */
	.no-hover-tablet a.button:after, .no-hover-tablet a.tp-button:after, .no-hover-tablet button:after, .no-hover-tablet input:after {
		display: none
	}
	.no-hover-tablet .image_frame:not(.no_link) .image_wrapper img:not(.ls-l) {
		margin-bottom: 0!important
	}
	.no-hover-tablet .image_frame .image_wrapper img {
		top: 0!important
	}
	.no-hover-tablet .image_frame .image_wrapper .mask, .no-hover-tablet .image_frame .image_wrapper .image_links {
		display: none!important
	}
	.no-hover-tablet .Recent_posts ul li .desc:after {
		display: none
	}
	.no-hover-tablet .Recent_posts ul li a:hover h6, .no-hover-tablet .Recent_posts ul li a:hover .desc .date {
		color: inherit!important
	}
	/* Portfolio masonry hover */
	.with_aside .portfolio_group.masonry-hover .portfolio-item:not(.no-thumbnail) .masonry-hover-wrapper .hover-desc .desc-inner .desc-wrappper {
		display: none
	}
	/* Section Background Image */
	.no-section-bg-tablet .section {
		background-image: none!important
	}
	/* Google maps */
	.section.full-width .wrap.one .column_map.one .google-map-contact-wrapper {
		left: auto;
		right: 50px;
	}
}

/* #Desktop	960 - 1239 ---------------------------------------------------------------------------------- #Desktop	960 - 1239 */

@media only screen and (min-width: 960px) and (max-width: 1239px) {
	body {
		min-width: 0;
	}
	.section_wrapper, .container, .with_aside .content_wrapper {
		max-width: 940px;
	}
	/* -------------------- */
	/* Top bar width */
	#Top_bar .top_bar_left {
		width: 729px
	}
	/* Blog | Columns | Grid, Masonry */
	.posts_group.grid.col-5 .post-item, .posts_group.masonry.col-5 .post-item, .posts_group.grid.col-6 .post-item, .posts_group.masonry.col-6 .post-item {
		width: 22.99%
	}
	.posts_group.grid.col-5 .post-item:nth-child(5n+1) {
		clear: none
	}
	.posts_group.grid.col-6 .post-item:nth-child(6n+1) {
		clear: none
	}
	.posts_group.grid.col-5 .post-item:nth-child(4n+1) {
		clear: both
	}
	.posts_group.grid.col-6 .post-item:nth-child(4n+1) {
		clear: both
	}
	/* Latest News */
	.column.one-fourth .Latest_news ul .desc .date i {
		display: none
	}
	.column.one-second .Latest_news.featured ul .desc .date i {
		display: none
	}
	.wrap.two-third .column.three-fifth .Latest_news.featured ul, .wrap.two-third .column.one-second .Latest_news.featured ul, .wrap.three-fifth .column.three-fifth .Latest_news.featured ul, .wrap.three-fifth .column.one-second .Latest_news.featured ul, .wrap.one-second .column.three-fourth .Latest_news.featured ul {
		width: 100%
	}
	.wrap.two-fifth .Latest_news.featured ul, .wrap.one-third .Latest_news.featured ul, .wrap.one-fourth .Latest_news.featured ul {
		width: 100%
	}
	/* Blog Teaser */
	.blog-teaser li:not(:first-child) .desc-wrapper .desc {
		padding: 70px 20px 25px;
	}
	.column.two-third .blog-teaser li:not(:first-child) .desc-wrapper .desc .post-meta, .column.three-fifth .blog-teaser li:not(:first-child) .desc-wrapper .desc .post-meta {
		display: none;
	}
	.wrap.two-third .blog-teaser li:not(:first-child) .desc-wrapper .desc .post-meta, .wrap.three-fifth .blog-teaser li:not(:first-child) .desc-wrapper .desc .post-meta {
		display: none;
	}
	/* Portfolio | List */
	body:not(.with_aside) .portfolio_group.list .portfolio-item .portfolio-item-fw-wrapper {
		width: 921px
	}
	/* Portfolio | Columns | Grid, Masonry, Masonry Hover */
	.portfolio_group.grid.col-5 .portfolio-item, .portfolio_group.masonry.col-5 .portfolio-item, .portfolio_group.masonry-hover.col-5 .portfolio-item, .portfolio_group.masonry-minimal.col-5 .portfolio-item, .portfolio_group.grid.col-6 .portfolio-item, .portfolio_group.masonry.col-6 .portfolio-item, .portfolio_group.masonry-hover.col-6 .portfolio-item, .portfolio_group.masonry-minimal.col-6 .portfolio-item {
		width: 22.99%
	}
	/* Portfolio | Columns | Flat */
	.portfolio_group.flat.col-5 .portfolio-item, .portfolio_group.flat.col-6 .portfolio-item {
		width: 24.99%
	}
	/* Error 404 */
	#Error_404 .error_pic i {
		font-size: 220px;
		line-height: 260px
	}
	#Error_404 .error_desk {
		padding-top: 40px
	}
	/* Offer slider */
	.offer .offer_li .desc_wrapper {
		width: 436px;
		width: calc(50% - 42px)
	}
	/* Recent posts */
	.Recent_posts ul li .desc {
		margin-right: 60px
	}
	.Recent_posts ul li .photo {
		width: 60px;
		height: 60px
	}
	.Recent_posts ul li .photo .c {
		width: 20px;
		height: 20px;
		line-height: 20px;
		bottom: 5px;
		right: -8px
	}
	/* Zoom Box */
	.zoom_box .desc .desc_txt {
		font-size: 22px;
		line-height: 26px
	}
}

/* #Desktop	> 960 -------------------------------------------------------------------------------------------- #Desktop	> 960 */

@media only screen and (min-width: 960px) {
	.hide-desktop {
		display: none!important
	}
}

/* #Tablet (Landscape) 768 - 959 --------------------------------------------------------------- #Tablet (Landscape) 768 - 959 */

@media only screen and (min-width: 768px) and (max-width: 959px) {
	body {
		min-width: 0;
	}
	.section_wrapper, .container, .with_aside .content_wrapper {
		max-width: 708px;
	}
	/* -------------------- */
	.hide-tablet {
		display: none!important
	}
	/* Header magazine */
	.header-magazine #Top_bar .banner_wrapper {
		width: 300px;
		top: 27px
	}
	/* Top bar width */
	#Top_bar .top_bar_left {
		width: 501px
	}
	.logo-overflow #Top_bar #logo img {
		max-width: 150px!important
	}
	/* .footer-sliding */
	.footer-fixed #Content, .footer-sliding #Content {
		margin-bottom: 0!important
	}
	.footer-fixed #Footer, .footer-sliding #Footer {
		position: static
	}
	/* Subheader */
	#Subheader .title {
		width: 100%
	}
	#Subheader ul.breadcrumbs {
		display: none
	}
	/* Filters */
	#Filters .filters_wrapper ul li {
		float: left;
		width: 24%;
		margin: .5%
	}
	/* Blog */
	.with_aside .classic .post-meta .author-date .author .label {
		display: none
	}
	.with_aside .classic .post-meta .category {
		display: none
	}
	/* Grid, Masonry */
	.grid .post-item, .masonry .post-item {
		width: 47.9%
	}
	/* Timeline */
	.timeline .post-photo-wrapper {
		width: 100%;
		float: none
	}
	.timeline .post-desc-wrapper {
		width: 100%;
		float: none
	}
	/* Blog | Columns | Grid, Masonry */
	.posts_group.grid.col-4 .post-item, .posts_group.masonry.col-4 .post-item, .posts_group.grid.col-5 .post-item, .posts_group.masonry.col-5 .post-item, .posts_group.grid.col-6 .post-item, .posts_group.masonry.col-6 .post-item {
		width: 31.33%
	}
	.posts_group.grid.col-4 .post-item:nth-child(4n+1) {
		clear: none
	}
	.posts_group.grid.col-5 .post-item:nth-child(5n+1) {
		clear: none
	}
	.posts_group.grid.col-6 .post-item:nth-child(6n+1) {
		clear: none
	}
	.posts_group.grid.col-4 .post-item:nth-child(3n+1) {
		clear: both
	}
	.posts_group.grid.col-5 .post-item:nth-child(3n+1) {
		clear: both
	}
	.posts_group.grid.col-6 .post-item:nth-child(3n+1) {
		clear: both
	}
	/* Blog | Columns | Masonry tiles */
	.posts_group.masonry.tiles.col-4 .post-item, .posts_group.masonry.tiles.col-5 .post-item, .posts_group.masonry.tiles.col-6 .post-item {
		width: 49.9%
	}
	.posts_group.masonry.margin.col-4 .post-item, .posts_group.masonry.margin.col-5 .post-item, .posts_group.masonry.margin.col-6 .post-item {
		width: 48.9%
	}
	/* Latest News */
	.column.one-third .Latest_news ul .desc .date i {
		display: none
	}
	.column.one-second .Latest_news.featured ul {
		width: 100%
	}
	.column.one-third .Latest_news.featured ul .desc .date i, .column.one-fourth .Latest_news.featured ul .desc .date i {
		display: none
	}
	.wrap.five-sixth .column.three-fifth .Latest_news.featured ul, .wrap.four-fifth .column.three-fifth .Latest_news.featured ul, .wrap.three-fourth .column.three-fifth .Latest_news.featured ul, .wrap.two-third .column.three-fifth .Latest_news.featured ul, .wrap.two-third .column.one-second .Latest_news.featured ul, .wrap.two-third .column.three-fourth .Latest_news.featured ul, .wrap.three-fifth .column.three-fifth .Latest_news.featured ul, .wrap.three-fifth .column.one-second .Latest_news.featured ul, .wrap.three-fifth .column.three-fourth .Latest_news.featured ul {
		width: 100%
	}
	.wrap.one-second .Latest_news.featured ul, .wrap.two-fifth .Latest_news.featured ul, .wrap.one-third .Latest_news.featured ul, .wrap.one-fourth .Latest_news.featured ul {
		width: 100%
	}
	/* Blog Teaser */
	.blog-teaser li .desc-wrapper .desc {
		padding: 70px 25px 25px;
	}
	.blog-teaser li:not(:first-child) .desc-wrapper .desc {
		padding: 70px 20px 20px;
	}
	.blog-teaser li:not(:first-child) .desc-wrapper .desc .post-meta {
		display: none;
	}
	.column.three-fifth .blog-teaser li .desc-wrapper .desc .post-meta .comments {
		display: none;
	}
	.wrap.three-fifth .blog-teaser li .desc-wrapper .desc .post-meta .comments {
		display: none;
	}
	/* Recent posts */
	.Recent_posts ul li .desc {
		margin-right: 40px
	}
	.Recent_posts ul li .photo {
		width: 40px;
		height: 40px
	}
	.Recent_posts ul li.format-link .photo {
		background-size: 40% auto
	}
	.Recent_posts ul li .photo .c {
		width: 20px;
		height: 20px;
		line-height: 20px;
		bottom: 5px;
		right: -8px
	}
	/* Portfolio list */
	body:not(.with_aside) .portfolio_group.list .portfolio-item .portfolio-item-fw-wrapper {
		width: 694px
	}
	/* Grid, Masonry, Masonry Hover */
	.portfolio_group.grid.col-4 .portfolio-item, .portfolio_group.masonry.col-4 .portfolio-item, .portfolio_group.masonry-hover.col-4 .portfolio-item, .portfolio_group.masonry-minimal.col-4 .portfolio-item, .portfolio_group.grid.col-5 .portfolio-item, .portfolio_group.masonry.col-5 .portfolio-item, .portfolio_group.masonry-hover.col-5 .portfolio-item, .portfolio_group.masonry-minimal.col-5 .portfolio-item, .portfolio_group.grid.col-6 .portfolio-item, .portfolio_group.masonry.col-6 .portfolio-item, .portfolio_group.masonry-hover.col-6 .portfolio-item, .portfolio_group.masonry-minimal.col-6 .portfolio-item {
		width: 31.33%
	}
	/* Flat */
	.portfolio_group.flat.col-4 .portfolio-item, .portfolio_group.flat.col-5 .portfolio-item, .portfolio_group.flat.col-6 .portfolio-item {
		width: 33.33%
	}
	/* Tabs */
	.tabs_vertical.ui-tabs .ui-tabs-nav {
		width: 33%!important
	}
	.tabs_vertical.ui-tabs .ui-tabs-panel {
		width: 66.7%!important
	}
	/* Counter */
	.one-fourth .counter.counter_horizontal, .one-fifth .counter.counter_horizontal, .one-sixth .counter.counter_horizontal {
		text-align: center
	}
	.one-fourth .counter.counter_horizontal .icon_wrapper, .one-fifth .counter.counter_horizontal .icon_wrapper, .one-sixth .counter.counter_horizontal .icon_wrapper {
		position: static;
		margin: 0 auto;
		margin-bottom: 15px
	}
	.one-fourth .counter.counter_horizontal .desc_wrapper, .one-fifth .counter.counter_horizontal .desc_wrapper, .one-sixth .counter.counter_horizontal .desc_wrapper {
		padding-left: 0
	}
	/* Article box */
	.one-third .article_box .photo_wrapper {
		width: 100%;
		float: none;
		text-align: center
	}
	.one-third .article_box .desc_wrapper {
		width: 100%;
		min-height: auto;
		float: none
	}
	/* Pricing table */
	.pricing-box .plan-header h2 {
		word-wrap: break-word
	}
	.pricing-box .plan-header .price sup.period {
		position: static;
		top: 0;
		display: block
	}
	/* Infobox */
	.infobox {
		padding-left: 20px;
		word-wrap: break-word
	}
	.infobox ul li {
		padding-left: 0;
		padding-right: 0
	}
	.infobox ul li:before {
		display: none
	}
	.style-simple .infobox ul li {
		padding-left: 0
	}
	/* Portfolio photo */
	.portfolio-photo .portfolio-item .portfolio-details:hover .details {
		opacity: 1
	}
	.portfolio-photo .portfolio-item .portfolio-details .more {
		display: none
	}
	/* Get in touch */
	.get_in_touch {
		padding-left: 20px;
		word-wrap: break-word
	}
	.get_in_touch ul li {
		padding-left: 0;
		padding-right: 0
	}
	.get_in_touch ul li .icon {
		display: none
	}
	/* Hover color */
	.hover_color {
		word-wrap: break-word
	}
	/* How it works */
	.how_it_works .image {
		width: 120px;
		height: 120px;
		line-height: 120px
	}
	.how_it_works .image img {
		max-width: 66px!important;
		max-height: 66px!important
	}
	.how_it_works .image .number {
		bottom: 0;
		right: 0
	}
	.how_it_works.has_border:after {
		top: 60px
	}
	/* Opening Hours */
	.opening_hours {
		padding-left: 20px;
		word-wrap: break-word
	}
	.opening_hours .opening_hours_wrapper li span {
		font-size: 16px;
		line-height: 16px
	}
	/* Icon box */
	.icon_box.icon_position_left {
		min-height: auto;
		padding-left: 0;
		padding-right: 0
	}
	.icon_box.icon_position_left .icon_wrapper {
		position: static;
		margin-bottom: 15px
	}
	.icon_box.icon_position_left .desc_wrapper {
		text-align: center;
		padding-top: 0
	}
	.icon_box.icon_position_left .image_wrapper {
		position: static;
		left: 0;
		margin-bottom: 15px;
		width: auto;
		height: auto
	}
	/* List item */
	/* Flat box */
	.flat_box .photo_wrapper .icon {
		width: 50px
	}
	.flat_box .photo_wrapper .icon i {
		height: 40px;
		line-height: 40px;
		font-size: 30px;
		margin-top: -20px
	}
	.flat_box a:hover .photo_wrapper .icon {
		-webkit-transform: translateX(-50px);
		transform: translateX(-50px)
	}
	.flat_box .desc_wrapper {
		margin: 0
	}
	.rtl .flat_box a:hover .photo_wrapper .icon {
		-webkit-transform: translateX(50px);
		transform: translateX(50px)
	}
	/* Offer thumb */
	.offer_thumb_ul li.offer_thumb_li .image_wrapper {
		width: 100%;
		float: none
	}
	.offer_thumb_ul li.offer_thumb_li .desc_wrapper {
		width: 100%;
		float: none
	}
	.offer_thumb.bottom .offer_thumb_ul li.offer_thumb_li .image_wrapper {
		width: 100%
	}
	.offer_thumb.bottom .offer_thumb_ul li.offer_thumb_li .desc_wrapper {
		margin-right: 0;
		width: 100%
	}
	/* Trailer box */
	.trailer_box .desc h2 {
		font-size: 22px;
		line-height: 22px
	}
	/* Offer slider */
	.offer .offer_li .desc_wrapper {
		width: 324px;
		width: calc(50% - 42px)
	}
	/* Error 404 */
	#Error_404 {
		position: static;
		padding-top: 50px;
		margin-top: 0
	}
	#Error_404 .error_pic {
		width: 100%;
		float: none
	}
	#Error_404 .error_pic i {
		font-size: 260px;
		line-height: 260px
	}
	#Error_404 .error_desk {
		width: 100%;
		float: none;
		padding-top: 20px;
		text-align: center
	}
	/* Buttons */
	a.kill_the_icon .button_icon, .widget-area a.button .button_icon {
		display: none
	}
	.button-stroke a.button_left.button.kill_the_icon .button_label {
		padding-left: 20px
	}
	.button-stroke a.button_left.button_large.kill_the_icon .button_label {
		padding-left: 30px
	}
	.button-stroke a.button_right.button.kill_the_icon .button_label {
		padding-right: 20px
	}
	.button-stroke a.button_right.button_large.kill_the_icon .button_label {
		padding-right: 30px
	}
	.button-flat a.button_left.button.kill_the_icon .button_label {
		padding-left: 20px
	}
	.button-flat a.button_left.button_large.kill_the_icon .button_label {
		padding-left: 30px
	}
	.button-flat a.button_right.button.kill_the_icon .button_label {
		padding-right: 20px
	}
	.button-flat a.button_right.button_large.kill_the_icon .button_label {
		padding-right: 30px
	}
	/* Zoom Box */
	.zoom_box .desc .desc_txt {
		font-size: 18px;
		line-height: 22px
	}
	/* Easy Digital Downloads */
	.edd_downloads_list .edd_download {
		width: 50%!important
	}
	.edd_downloads_list .edd_download:nth-child(5n+3) {
		clear: both
	}
	.edd_downloads_list .edd_download .edd_download_inner {
		margin: 0 5% 20px
	}
}

/* #Desktop & Tablet (Landscape) > 768 --------------------------------------------------- #Desktop & Tablet (Landscape) > 768 */

@media only screen and (min-width: 768px) {
	.section.full-width-ex-mobile>.section_wrapper {
		max-width: 100%!important
	}
	.section.full-width-ex-mobile>.one.column, .section.full-width-ex-mobile>.section_wrapper>.one.column, .section.full-width-ex-mobile .one.wrap .one.column {
		width: 100%;
		margin: 0
	}
	/* Transparent ---------- */
	.tr-menu #Top_bar .wpml-languages a.active, .tr-menu #Top_bar .wpml-languages ul.wpml-lang-dropdown {
		background-color: transparent
	}
	/* Header | Classic */
	.tr-menu.header-classic #Top_bar {
		position: absolute
	}
	.tr-menu.header-classic #Top_bar:not(.is-sticky) {
		top: 0!important;
		background: none!important
	}
	.tr-menu.header-classic.ab-show #Top_bar:not(.is-sticky) {
		top: 45px!important
	}
	.tr-menu.header-classic.minimalist-header:not(.template-slider) #Header {
		min-height: 135px
	}
	/* Header | Plain */
	.tr-menu.header-plain #Top_bar {
		position: absolute
	}
	.tr-menu.header-plain #Top_bar:not(.is-sticky) {
		top: 0!important;
		background: none!important
	}
	.tr-menu.header-plain.ab-show #Top_bar:not(.is-sticky) {
		top: 45px!important
	}
	.tr-menu.header-plain.minimalist-header:not(.template-slider) #Header {
		min-height: 125px
	}
	.header-plain #Top_bar, .header-plain #Top_bar .menu>li>a span:not(.description), .header-plain #Top_bar a#header_cart, .header-plain #Top_bar a#search_button, .header-plain #Top_bar .wpml-languages, .header-plain #Top_bar a.button.action_button {
		border-color: rgba(255, 255, 255, .1)
	}
	/* Header | Split */
	.tr-menu.header-split #Top_bar {
		position: absolute
	}
	.tr-menu.header-split #Top_bar:not(.is-sticky) {
		top: 0!important;
		background: none!important
	}
	.tr-menu.header-split.ab-show #Top_bar:not(.is-sticky) {
		top: 45px!important
	}
	.tr-menu.header-split.minimalist-header:not(.template-slider) #Header {
		min-height: 135px
	}
	/* Header | Semitransparent */
	.header-semi #Top_bar:not(.is-sticky) {
		position: absolute;
		background-color: rgba(255, 255, 255, 0.8)
	}
	.header-semi.ab-show #Top_bar:not(.is-sticky) {
		top: 45px!important
	}
	.header-semi.ab-hide #Top_bar:not(.is-sticky) {
		top: 0!important
	}
	/* Header | Stack */
	.tr-menu.header-stack #Top_bar {
		position: absolute
	}
	.tr-menu.header-stack #Top_bar:not(.is-sticky) {
		top: 0!important;
		background: none!important
	}
	.tr-menu.header-stack.ab-show #Top_bar:not(.is-sticky) {
		top: 45px!important
	}
	.tr-menu.header-stack.minimalist-header:not(.template-slider) #Header {
		min-height: 196px
	}
}

/* #Tablet (Portrait) & Mobile < 768 ------------------------------------------------------- #Tablet (Portrait) & Mobile < 768 */

@media only screen and (max-width: 767px) {
	body {
		min-width: 0;
	}
	.section_wrapper .mcb-wrap, .section_wrapper .column, .container .column, .sections_group, .four.columns {
		margin: 0;
		width: 100%!important;
		clear: both;
	}
	.aside_both .sections_group {
		margin: 0 auto!important;
	}
	.section_wrapper, .container, .four.columns .widget-area {
		max-width: 90%;
		max-width: calc(100% - 67px)!important;
	}
	.left-sidebar .items_group, .right-sidebar .items_group, .with_aside .content_wrapper {
		max-width: 100%;
	}
	.section_wrapper .column {
		margin: 0 0 20px;
		height: auto!important;
	}
	.four.columns {
		margin: auto 0!important;
	}
	/* -------------------- */
	.hide-mobile {
		display: none!important
	}
	.boxed2fw {
		padding: 0!important
	}
	.boxed2fw #Wrapper {
		margin: 0!important;
		max-width: 100%!important;
		width: 100%!important
	}
	.column_placeholder>.placeholder {
		height: 0
	}
	/* Sections */
	.section {
		background-attachment: scroll!important;
		height: auto!important
	}
	.highlight-left .section_wrapper, .highlight-right .section_wrapper {
		max-width: 100%!important
	}
	.highlight-left .section_wrapper .wrap, .highlight-right .section_wrapper .wrap {
		padding: 0 33px
	}
	.highlight-left.full-screen>.section_wrapper, .highlight-right.full-screen>.section_wrapper {
		padding: 0!important
	}
	.equal-height-wrap .mcb-wrap {
		height: auto!important
	}
	.equal-height-wrap .mcb-wrap .mcb-wrap-inner {
		top: 0!important;
		-webkit-transform: none!important;
		-moz-transform: none!important;
		-ms-transform: none!important;
		-o-transform: none!important;
		transform: none!important
	}
	.section.has-navi .section-nav.prev {
		top: 10px
	}
	.section.has-navi .section-nav.next {
		bottom: 10px
	}
	/* Sidebar */
	.widget-area {
		border: 0!important;
		padding: 0!important;
		margin: 30px auto!important;
		min-height: 0!important
	}
	.widget-area:after, .widget-area:before {
		display: none
	}
	.widget:after {
		width: 100%
	}
	/* Header --------------- */
	#Top_bar, #Action_bar {
		background: #fff!important;
		position: static
	}
	#Top_bar .container {
		max-width: 100%!important;
	}
	#Top_bar .top_bar_left {
		float: none;
		width: 100%!important;
		background: none!important
	}
	#Top_bar a.responsive-menu-toggle {
		right: 20px;
	}
	#Top_bar a.responsive-menu-toggle.is-sticky {
		position: fixed;
		top: 30px;
		left: 10px;
	}
	.admin-bar #Top_bar a.responsive-menu-toggle.is-sticky {
		top: 56px
	}
	#Top_bar .menu_wrapper {
		float: left!important;
		width: 100%;
		margin: 0!important
	}
	#Top_bar #menu {
		float: left;
		position: static!important;
		width: 100%!important;
		padding-bottom: 20px
	}
	#Top_bar .logo {
		position: static;
		float: left;
		width: 100%;
		text-align: center;
		margin: 0
	}
	#Top_bar .logo #logo {
		padding: 0!important;
		margin: 10px 50px
	}
	#Top_bar .logo #logo img {
		height: auto!important
	}
	#Top_bar #logo img.logo-main {
		display: none
	}
	#Top_bar #logo img.logo-mobile {
		display: inline-block
	}
	#Top_bar #logo img.logo-mobile-sticky {
		display: none
	}
	.mobile-sticky #Top_bar.is-sticky #logo img.logo-mobile {
		display: none
	}
	.mobile-sticky #Top_bar.is-sticky #logo img.logo-mobile-sticky {
		display: inline-block
	}
	.logo-overflow #Top_bar .logo {
		height: auto!important
	}
	#Top_bar .search_wrapper {
		top: auto;
		bottom: -129px
	}
	#Top_bar .top_bar_right {
		float: none;
		top: 0;
		height: 60px!important;
		padding: 0 10px
	}
	#Top_bar .top_bar_right .top_bar_right_wrapper {
		float: right;
		margin-right: -10px
	}
	#Top_bar .top_bar_right:before {
		display: none
	}
	#Top_bar .top_bar_right_wrapper {
		top: 0!important
	}
	#Top_bar a#header_cart {
		top: 20px
	}
	#Top_bar a#search_button {
		top: 19px
	}
	#Top_bar a.button.action_button {
		top: 9px
	}
	#Top_bar .wpml-languages {
		top: 11px
	}
	#Top_bar .wpml-languages a.active {
		height: 15px;
		line-height: 17px
	}
	.mobile-tb-left #Top_bar .top_bar_right .top_bar_right_wrapper {
		float: left
	}
	.mobile-tb-center #Top_bar .top_bar_right {
		text-align: center
	}
	.mobile-tb-center #Top_bar .top_bar_right .top_bar_right_wrapper {
		display: inline-block;
		float: none
	}
	.mobile-tb-hide #Top_bar .top_bar_right {
		display: none
	}
	/* Header | Below */
	body.header-below:not(.template-slider) #Header {
		padding-top: 0
	}
	/* Header | Creative */
	.header-creative #Header_creative {
		position: absolute
	}
	.header-creative.layout-boxed {
		padding-top: 0
	}
	.header-creative.layout-boxed #Wrapper {
		margin-top: 25px
	}
	.header-creative.layout-full-width #Wrapper {
		padding-top: 60px
	}
	#Header_creative #Top_bar .responsive-menu-toggle {
		top: 35px
	}
	#Header_creative #Top_bar .responsive-menu-toggle.is-sticky {
		position: fixed;
		top: 10px;
		left: 10px;
		margin-top: 0;
	}
	.admin-bar #Header_creative #Top_bar .responsive-menu-toggle.is-sticky {
		top: 56px
	}
	#Header_creative #Top_bar .top_bar_left {
		margin-top: 0;
		overflow: hidden
	}
	#Header_creative #Top_bar .logo #logo {
		padding: 0;
	}
	#Header_creative #Top_bar .logo #logo img {
		max-height: 50px
	}
	#Header_creative #Top_bar #menu {
		position: static;
		width: 100%
	}
	/* Header | Intro */
	#Intro {
		min-height: auto!important
	}
	#Intro .intro-inner {
		padding: 100px 30px!important
	}
	#Intro .intro-next {
		font-size: 25px;
		bottom: 10px
	}
	/* Header | Magazine */
	.header-magazine #Top_bar .banner_wrapper {
		width: 100%;
		height: auto;
		text-align: center;
		position: static;
		margin-bottom: 20px
	}
	/* Header | Minimalist */
	body.minimalist-header.header-classic:not(.template-slider) #Header, body.minimalist-header.header-creative:not(.template-slider) #Header, body.minimalist-header.header-plain:not(.template-slider) #Header, body.minimalist-header.header-split:not(.template-slider) #Header {
		min-height: 0
	}
	body.minimalist-header.header-simple:not(.template-slider) #Header {
		min-height: 90px
	}
	body.minimalist-header.header-transparent #Header {
		min-height: 0!important
	}
	.minimalist-header-no #Subheader {
		padding: 80px 0!important
	}
	/* Header | Overlay */
	.header-overlay .overlay-menu-toggle {
		top: 10px;
		right: 5px
	}
	#overlay-menu ul li a {
		font-size: 22px;
		line-height: 36px
	}
	/* Header | Plain */
	.header-plain #Top_bar .logo {
		text-align: left
	}
	.header-plain #Top_bar .logo #logo {
		padding: 5px 42px 15px 15px
	}
	.header-plain #Top_bar .top_bar_right .top_bar_right_wrapper {
		line-height: 0
	}
	.header-plain #Top_bar .top_bar_right {
		height: 50px!important
	}
	.header-plain #Top_bar a#header_cart, .header-plain #Top_bar a#search_button {
		padding: 0 10px;
		line-height: 50px!important
	}
	.header-plain #Top_bar .wpml-languages {
		padding: 0 10px;
		height: 50px!important
	}
	.header-plain #Top_bar .wpml-languages a.active {
		line-height: 50px
	}
	.header-plain #Top_bar a.button.action_button {
		height: 50px!important;
		line-height: 50px!important
	}
	.header-plain #Top_bar a.button.action_button .button_label {
		padding: 0 12px
	}
	.header-plain #Top_bar .top_bar_right_wrapper>*:last-child {
		border-right-width: 1px;
	}
	/* Header | Simple */
	.header-simple #Top_bar .top_bar_left {
		top: 0!important
	}
	/* Header | Split */
	.header-split #Top_bar a#search_button {
		display: none
	}
	/* Header | Stack */
	.header-stack #Top_bar .logo {
		padding: 0;
		text-align: center!important
	}
	.header-stack #Top_bar .logo #logo {
		display: block
	}
	.header-stack #Top_bar a.responsive-menu-toggle {
		position: absolute!important;
		margin-top: -17px!important
	}
	.header-stack #Top_bar a.responsive-menu-toggle.is-sticky {
		position: fixed!important;
		margin-top: 0!important
	}
	.header-stack #Top_bar .secondary_menu_wrapper {
		display: none
	}
	.header-stack #Top_bar .top_bar_right {
		position: static
	}
	/* Header mobile | minimal */
	.mobile-header-mini #Action_bar {
		display: none
	}
	.mobile-header-mini #Top_bar {
		top: 0
	}
	.mobile-header-mini #Top_bar .container {
		max-width: 100%!important;
	}
	.mobile-header-mini #Top_bar .top_bar_left {
		float: left;
		position: static;
	}
	.mobile-header-mini #Top_bar .logo {
		width: auto;
		float: left;
		margin-left: 15px;
		border: none;
	}
	.mobile-header-mini #Top_bar #logo {
		height: 60px!important;
		line-height: 60px!important;
		margin: 0
	}
	.mobile-header-mini #Top_bar a.responsive-menu-toggle {
		top: 30px!important;
		left: auto;
		right: 10px;
		margin-top: -17px;
	}
	.mobile-header-mini #Top_bar .top_bar_right {
		position: absolute;
		top: 0;
		right: 54px;
		background: none;
		padding: 0;
	}
	.mobile-header-mini #Top_bar a.button.action_button {
		display: none;
	}
	.mobile-header-mini #Top_bar #header_cart {
		margin-right: -1px;
	}
	.mobile-header-mini #Top_bar #search_button {
		margin-left: 0;
		margin-right: 0;
	}
	.mobile-header-mini #Top_bar .wpml-languages {
		top: 13px;
		margin-right: 0;
	}
	.mobile-header-mini #Top_bar .wpml-languages a.active, .mobile-header-mini #Top_bar .wpml-languages ul.wpml-lang-dropdown {
		border: none;
	}
	.mobile-header-mini #Top_bar #menu {
		padding-bottom: 10px;
	}
	.mobile-header-mini #Top_bar #menu ul li a span {
		line-height: 44px;
	}
	.mobile-header-mini #Top_bar #menu ul li.submenu .menu-toggle {
		line-height: 44px;
		right: 3px;
	}
	.mobile-header-mini #Top_bar .search_wrapper {
		bottom: -59px;
		padding: 10px;
		width: 100%;
	}
	.mobile-header-mini #Top_bar .search_wrapper .icon_search {
		left: 10px;
		top: 17px;
	}
	.mobile-header-mini #Top_bar .search_wrapper .icon_close {
		top: 17px;
	}
	/* Header mobile | minimal | style */
	.mobile-header-mini.mobile-mini-mr-lr #Top_bar .logo {
		float: right;
		margin-left: 0;
		margin-right: 54px;
	}
	.mobile-header-mini.mobile-mini-mr-lr #Top_bar .top_bar_right {
		left: 10px;
		right: auto;
	}
	.mobile-header-mini.mobile-mini-mr-lc #Top_bar .logo {
		float: none;
		margin-left: 0;
		margin-right: 0;
	}
	.mobile-header-mini.mobile-mini-mr-lc #Top_bar .top_bar_right {
		left: 10px;
		right: auto;
	}
	.mobile-header-mini.mobile-mini-ml-ll #Top_bar a.responsive-menu-toggle {
		left: 10px;
		right: 0;
	}
	.mobile-header-mini.mobile-mini-ml-ll #Top_bar .logo {
		margin-left: 54px
	}
	.mobile-header-mini.mobile-mini-ml-ll #Top_bar .top_bar_right {
		right: 15px;
	}
	.mobile-header-mini.mobile-mini-ml-lc #Top_bar a.responsive-menu-toggle {
		left: 10px;
		right: 0;
	}
	.mobile-header-mini.mobile-mini-ml-lc #Top_bar .logo {
		float: none;
		margin-left: 0;
		margin-right: 0;
	}
	.mobile-header-mini.mobile-mini-ml-lc #Top_bar .top_bar_right {
		right: 15px;
	}
	.mobile-header-mini.mobile-mini-ml-lr #Top_bar a.responsive-menu-toggle {
		left: 10px;
		right: 0;
	}
	.mobile-header-mini.mobile-mini-ml-lr #Top_bar .logo {
		float: right;
		margin-left: 0;
		margin-right: 15px;
	}
	.mobile-header-mini.mobile-mini-ml-lr #Top_bar .top_bar_right {
		left: 49px;
		right: auto;
	}
	/* Header mobile | minimal | headers compatibility */
	.mobile-header-mini.header-plain #Top_bar .top_bar_right {
		margin-right: 5px;
	}
	.mobile-header-mini.header-plain #Top_bar a#header_cart {
		line-height: 60px!important;
		border: none;
		padding: 0 5px;
	}
	.mobile-header-mini.header-plain #Top_bar a#search_button {
		line-height: 60px!important;
		border: none;
		padding: 0 3px;
	}
	.mobile-header-mini.header-plain #Top_bar .wpml-languages {
		height: 60px!important;
		border: none;
		padding: 0 5px 0 10px;
		top: 0;
	}
	.mobile-header-mini.header-plain #Top_bar .wpml-languages a.active {
		line-height: 60px!important
	}
	.mobile-header-mini.header-plain #Top_bar .wpml-languages:hover a.active {
		background: none;
	}
	.mobile-header-mini #Header_creative #Top_bar {
		width: 100%;
		margin: 0;
	}
	.mobile-header-mini #Header_creative #Top_bar #header_cart {
		top: 20px;
	}
	.mobile-header-mini #Header_creative #Top_bar #search_button {
		top: 19px;
	}
	.mobile-header-mini #Header_creative #Top_bar .wpml-languages {
		top: 13px;
	}
	.mobile-header-mini .overlay-menu-toggle {
		font-size: 22px;
		top: 8px;
		margin: 0!important;
	}
	/* Header mobile | sticky */
	.mobile-sticky #Top_bar.is-sticky {
		position: fixed !important;
	}
	.mobile-sticky #Top_bar.is-sticky #logo {
		margin-top: 0;
		margin-bottom: 0;
		height: 60px!important;
		line-height: 60px!important;
	}
	.mobile-sticky #Top_bar.is-sticky a.responsive-menu-toggle {
		top: 30px!important;
	}
	.mobile-sticky #Top_bar.is-sticky .top_bar_right {
		display: none;
	}
	.mobile-sticky #Top_bar #menu {
		overflow: auto;
		-webkit-box-sizing: border-box;
		box-sizing: border-box;
	}
	.mobile-header-mini.mobile-sticky #Top_bar .top_bar_right {
		display: block
	}
	/* Header mobile | transparent */
	.mobile-tr-header #Action_bar, .mobile-tr-header #Top_bar, .mobile-tr-header #Top_bar .top_bar_right {
		background: none!important
	}
	.mobile-tr-header #Top_bar {
		position: absolute;
		top: 50px
	}
	.mobile-tr-header.ab-hide #Top_bar {
		top: 0
	}
	.mobile-tr-header #Action_bar {
		position: absolute
	}
	.mobile-tr-header #Action_bar .contact_details li, .mobile-tr-header #Action_bar .social li a, .mobile-tr-header #Top_bar .top_bar_right a {
		color: rgba(255, 255, 255, 0.3)
	}
	.mobile-tr-header #Action_bar .social li a:hover, .mobile-tr-header #Top_bar .top_bar_right a:hover {
		color: #fff!important
	}
	.mobile-tr-header #Top_bar .wpml-languages a.active, .mobile-tr-header #Top_bar .wpml-languages ul.wpml-lang-dropdown {
		background: none
	}
	.mobile-tr-header.header-creative.layout-full-width #Wrapper {
		padding-top: 0
	}
	/* Header mobile | transparent | plain */
	.mobile-tr-header.header-plain #Top_bar, .mobile-tr-header.header-plain #Top_bar .top_bar_right_wrapper>* {
		border: none!important;
		background: none!important
	}
	/* Header mobile | transparent | creative */
	.mobile-tr-header #Header_creative {
		background: none!important;
		position: absolute
	}
	/* Action Bar */
	#Action_bar .contact_details li, #Action_bar .social {
		padding: 0!important
	}
	#Action_bar .contact_details {
		float: none;
		text-align: center;
		padding: 5px 0
	}
	#Action_bar .contact_details li {
		color: #000;
		padding: 0
	}
	#Action_bar .contact_details li.slogan {
		display: none
	}
	#Action_bar .social {
		float: none;
		text-align: center;
		padding: 5px 0 0
	}
	#Action_bar .social li {
		margin-right: 5px
	}
	#Action_bar .social li a {
		color: rgba(0, 0, 0, .3)
	}
	#Action_bar .social li a:hover {
		color: rgba(0, 0, 0, .8)
	}
	#Action_bar .social-menu {
		float: none;
		text-align: center;
		padding: 5px 0 0
	}
	/* Subheader */
	body:not(.template-slider):not(.header-simple) #Header {
		min-height: 350px;
		background-position: center 202px
	}
	#Subheader .title {
		width: 100%
	}
	#Subheader ul.breadcrumbs {
		display: none
	}
	/* Footer --------------- */
	#Footer .footer_copy {
		text-align: center
	}
	#Footer .footer_copy .copyright {
		float: none;
		margin: 10px 0 10px
	}
	#Footer .footer_copy .social {
		float: none;
		margin: 0
	}
	#Footer .footer_copy .social-menu {
		float: none;
		margin: 0
	}
	/* Footer | Sliding */
	.footer-fixed #Content, .footer-sliding #Content {
		margin-bottom: 0!important
	}
	.footer-fixed #Footer, .footer-sliding #Footer {
		position: static
	}
	/* Back to top */
	#back_to_top {
		float: none;
		margin: -10px 0 10px
	}
	#back_to_top.in_footer, #back_to_top.sticky {
		right: 20px!important;
		margin: 0
	}
	/* Blog --------------- */
	.classic .post-photo-wrapper {
		width: 100%;
		float: none
	}
	.classic .post-desc-wrapper {
		width: 100%;
		float: none
	}
	.classic .post-meta .author-date .author .label {
		display: none
	}
	.classic .post-meta .category {
		display: none
	}
	.classic .post-desc-wrapper .post-footer .button-love .love-text {
		display: none
	}
	.classic .post-desc-wrapper .post-desc {
		padding: 15px 0 0
	}
	/* Blog | Timeline */
	.timeline .post-item {
		padding-left: 0;
		background: none
	}
	.timeline .post-item:before {
		display: none
	}
	.timeline .post-photo-wrapper {
		width: 100%;
		float: none
	}
	.timeline .post-desc-wrapper {
		width: 100%;
		float: none
	}
	.timeline .post-item .date_label {
		display: inline-block;
		position: static;
		margin-bottom: 10px
	}
	.timeline .post-meta .category {
		display: none
	}
	.timeline .post-desc-wrapper .post-footer .button-love .love-text {
		display: none
	}
	.timeline .post-desc-wrapper .post-desc {
		padding: 15px 0 0
	}
	.style-simple .timeline_items li {
		width: 100%;
		padding: 0!important;
		background: none!important
	}
	.style-simple .timeline_items li h3 span {
		display: block;
		position: static
	}
	.style-simple .timeline_items li:nth-child(even) {
		padding: 0
	}
	.style-simple .timeline_items li:nth-child(even) .desc {
		text-align: right
	}
	/* Blog | Masonry */
	.grid .post-item, .masonry .post-item {
		width: 98%!important;
		margin: 0 1% 20px!important
	}
	/* Blog | Masonry tiles */
	.masonry.tiles .post-item {
		width: 100%!important
	}
	/* Blog | Photo */
	.photo .post-desc .post-head {
		margin-bottom: 5px
	}
	.photo .post-desc .post-head .post-meta .category {
		display: none
	}
	.photo .post-desc .post-head .post-meta .author-date {
		margin-right: 10px
	}
	/* Blog single */
	.single-post .format-image .single-photo-wrapper .image_frame {
		display: block
	}
	.single-post .format-link .single-photo-wrapper, .single-post .format-quote .single-photo-wrapper {
		display: none
	}
	/* Post header */
	.post-header .button-love {
		width: 69px
	}
	.post-header .title_wrapper {
		margin-left: 69px;
		padding-left: 20px
	}
	.post-header .title_wrapper h1 {
		font-size: 27px;
		line-height: 27px
	}
	.post-header .post-meta .category {
		display: none
	}
	/* Single photo wrapper */
	.single-photo-wrapper .image_frame {
		max-width: 100%!important;
		margin-left: 0
	}
	.single-photo-wrapper .share_wrapper {
		float: none;
		padding: 5px 15px 0;
		margin-bottom: 20px;
		width: auto
	}
	.no-share-mobile .single-photo-wrapper .share_wrapper {
		display: none
	}
	.wp-caption-text.hide-mobile {
		display: none
	}
	/* Post nav */
	.post-nav {
		padding: 10px 10px 4px 90px
	}
	/* Portfolio --------------- */
	.portfolio_group .portfolio-item {
		width: 100%!important;
		margin: 0 0 20px!important;
		float: none
	}
	.section.full-width .portfolio_group .portfolio-item {
		width: 100%!important
	}
	.portfolio_group .portfolio-item .list_style_header {
		padding-right: 0;
		min-height: inherit
	}
	.portfolio_group .portfolio-item .list_style_header h3 {
		margin: 0
	}
	.portfolio_group .portfolio-item .list_style_header .links_wrapper {
		display: none
	}
	.portfolio_group .portfolio-item .desc .desc-wrapper {
		margin-right: 0
	}
	.portfolio_group .portfolio-item .desc .details-wrapper {
		float: none;
		width: 100%;
		padding-left: 0;
		border-left-width: 0;
		border-bottom-width: 1px;
		padding-bottom: 15px;
		margin-bottom: 15px
	}
	.portfolio_group.list .portfolio-item .desc {
		padding-top: 10px
	}
	.portfolio_group.list .portfolio-item .portfolio-item-fw-bg {
		background-image: none!important;
		padding-bottom: 0
	}
	body:not(.with_aside) .portfolio_group.list .portfolio-item .portfolio-item-fw-wrapper {
		width: 380px
	}
	/* Project decription */
	.project-description li, .project-description li.one-third {
		width: 100%;
		border-width: 0 0 1px
	}
	.project-description li:last-child {
		border-bottom: 0
	}
	/* Portfolio | Exposure */
	.portfolio_group.exposure .portfolio-item {
		margin: 0!important;
		overflow: hidden
	}
	.portfolio_group.exposure .portfolio-item .desc-inner .desc-wrappper {
		display: none
	}
	.portfolio_group.exposure .portfolio-item .desc-inner .desc-wrapper-inner {
		padding: 0
	}
	.portfolio_group.exposure .portfolio-item .details-wrapper {
		display: none
	}
	.portfolio_group.exposure .portfolio-item .image-wrapper {
		margin: 0 -100px
	}
	.full-width .portfolio_group.exposure .portfolio-item .desc-inner {
		top: 30px
	}
	/* Portfolio | Flat */
	.portfolio_group.flat .portfolio-item {
		margin-bottom: 0!important
	}
	/* Portfolio | Grid */
	ul.portfolio_grid li {
		width: 100%!important;
		float: left
	}
	/* Portfolio | Masonry Flat */
	.portfolio_group.masonry-flat .portfolio-item {
		width: 49.9%!important;
		margin: 0!important
	}
	.portfolio_group.masonry-flat .portfolio-item.wide {
		width: 99.8%!important
	}
	.portfolio_group.masonry-flat .portfolio-item.tall .portfolio-item-fill {
		padding-bottom: calc(156% - 1px)
	}
	/* Portfolio | Photo */
	.portfolio-photo .portfolio-item .portfolio-details .details {
		display: none
	}
	.portfolio-photo .portfolio-item .portfolio-details .more {
		opacity: 1
	}
	/* Shortcodes --------------- */
	/* Blog Teaser */
	.blog-teaser li {
		width: 100%!important
	}
	.blog-teaser li:not(:first-child) {
		margin-top: 10px
	}
	.blog-teaser.margin-no li {
		margin-top: 0
	}
	/* Call to action */
	.call_to_action .call_left, .call_to_action .call_center, .call_to_action .call_right {
		display: block;
		width: 100%
	}
	.call_to_action .call_left {
		margin-bottom: 20px
	}
	.call_to_action .call_center {
		margin-bottom: 20px
	}
	.call_to_action .call_right {
		margin-bottom: 0;
		text-align: center
	}
	/* Clients */
	ul.clients:not(.clients_slider_ul) li {
		width: 50%!important
	}
	/* Content slider */
	.content_slider {
		padding: 0!important;
		margin: 10px 0
	}
	.content_slider .slider_pagination {
		padding: 0 20%;
		box-sizing: border-box;
	}
	.content_slider a.button {
		top: auto!important;
		bottom: -60px;
	}
	.content_slider a.slider_prev {
		left: 0!important
	}
	.content_slider a.slider_next {
		right: 0!important
	}
	.content_slider a.button .button_icon {
		padding: 7px 9px
	}
	.content_slider.flat a.button, .content_slider.carousel a.button {
		bottom: -50px
	}
	.content_slider.flat a.button .button_icon {
		font-size: 30px
	}
	/* Divider */
	.hr_full hr, .aside_left .hr_full hr, .aside_right .hr_full hr {
		position: absolute;
		left: -1000px;
		top: 0;
		width: 3000px
	}
	/* Fancy headings */
	.fancy_heading h2 {
		font-size: 30px;
		line-height: 30px
	}
	/* Features lists */
	.feature_list ul li {
		width: 100%!important;
		float: none;
		border-bottom: 1px solid rgba(0, 0, 0, 0.08)
	}
	.feature_list hr {
		display: none
	}
	/* Flat Box */
	.flat_box .desc_wrapper {
		margin: 0
	}
	/* Google maps */
	.google-map-contact-wrapper {
		position: static;
		margin-left: 0!important;
	}
	.google-map-contact-wrapper .get_in_touch {
		float: none;
		width: 100%;
		-webkit-box-sizing: border-box;
		box-sizing: border-box
	}
	.google-map-contact-wrapper .get_in_touch:after {
		display: none;
	}
	/* How it works */
	.how_it_works .image, .with_aside .how_it_works .image {
		width: 200px;
		height: 200px;
		line-height: 200px
	}
	.how_it_works .image img {
		max-width: 116px!important;
		max-height: 116px!important
	}
	.how_it_works .image .number, .with_aside .how_it_works .image .number {
		bottom: 10px;
		right: 10px
	}
	.how_it_works.has_border:after {
		display: none
	}
	/* Offer slider */
	.offer .offer_li .image_wrapper {
		width: 100%;
		float: none;
		margin-bottom: 15px;
		overflow: hidden
	}
	.offer .offer_li .desc_wrapper {
		width: 90%;
		width: calc(100% - 67px)!important;
		margin: 0 auto;
		float: none;
		clear: both
	}
	.offer .offer_li .desc_wrapper .title {
		padding-right: 0;
		margin-bottom: 15px
	}
	.offer .offer_li .desc_wrapper .title h3 {
		margin-bottom: 15px;
		font-size: 27px;
		line-height: 27px
	}
	.offer .offer_li .desc_wrapper .title a.button {
		position: relative
	}
	.offer a.slider_prev {
		left: 20px;
		top: 20px;
		margin: 0
	}
	.offer .slider_pagination {
		left: 20px;
		top: 65px;
		margin: 0
	}
	.offer a.slider_next {
		left: 20px;
		top: 111px;
		margin: 0
	}
	.button-stroke .offer a.slider_prev {
		margin-top: -8px
	}
	.button-stroke .offer a.slider_next {
		margin-top: 6px
	}
	/* Icon box */
	.icon_box.has_border:after {
		display: none
	}
	/* Image Frame */
	.image_frame {
		margin-top: 0!important
	}
	/* Offer thumb */
	.offer_thumb {
		padding-left: 0
	}
	.offer_thumb_ul li.offer_thumb_li {
		padding-left: 0
	}
	.offer_thumb_ul li.offer_thumb_li .image_wrapper {
		width: 100%;
		float: none
	}
	.offer_thumb_ul li.offer_thumb_li .desc_wrapper {
		width: 100%;
		float: none
	}
	.offer_thumb_ul li.offer_thumb_li .desc_wrapper .title {
		padding-right: 0
	}
	.offer_thumb_ul li.offer_thumb_li .desc_wrapper .title h3 {
		margin-bottom: 15px
	}
	.offer_thumb_ul li.offer_thumb_li .desc_wrapper .title a.button {
		position: relative
	}
	.offer_thumb .slider_pagination {
		margin-top: 20px;
		line-height: inherit
	}
	/* Offer thumb bottom */
	.offer_thumb.bottom .offer_thumb_ul li.offer_thumb_li .image_wrapper {
		width: 100%
	}
	.offer_thumb.bottom .offer_thumb_ul li.offer_thumb_li .desc_wrapper {
		margin-right: 0;
		width: 100%
	}
	/* Pricing table */
	.pricing-box-label .plan-header, .pricing-box-label .plan-footer {
		display: none
	}
	.pricing-box-label ul li {
		text-align: center!important
	}
	/* Promo box */
	.promo_box.has_border:after {
		display: none
	}
	.promo_box_wrapper {
		overflow: visible
	}
	.promo_box_wrapper .photo_wrapper {
		width: 100%;
		float: none;
		line-height: 0;
		margin-bottom: 15px
	}
	.promo_box_wrapper .desc_wrapper {
		width: 100%;
		margin: 0!important;
		float: none;
		padding-top: 0
	}
	/* Story Box */
	.story_box {
		padding: 0 11%!important
	}
	.story_box .desc_wrapper {
		margin-right: 0!important
	}
	/* Table */
	.table-responsive table {
		overflow-x: auto;
		display: block
	}
	.table-responsive table a.kill_the_icon .button_icon {
		display: none
	}
	/* Tabs */
	.ui-tabs .ui-tabs-nav {
		background: none
	}
	.ui-tabs .ui-tabs-nav li {
		float: none!important;
		width: 100%!important;
		border-width: 0 0 1px
	}
	.ui-tabs .ui-tabs-nav li:last-child {
		border-bottom: 0
	}
	.ui-tabs .ui-tabs-nav li a {
		text-align: center;
		background-image: url(../../../images/bg_panel.png);
		background-repeat: repeat-x;
		background-position: left top
	}
	.ui-tabs .ui-tabs-nav li.ui-tabs-selected a, .ui-tabs .ui-tabs-nav li.ui-state-active a {
		background-image: none
	}
	.ui-tabs .ui-tabs-nav li.ui-tabs-selected:after, .ui-tabs .ui-tabs-nav li.ui-state-active:after {
		display: none
	}
	.ui-tabs .ui-tabs-nav li.ui-tabs-selected a:after, .ui-tabs .ui-tabs-nav li.ui-state-disabled a:after, .ui-tabs .ui-tabs-nav li.ui-state-processing a:after, .ui-tabs .ui-tabs-nav li.ui-state-active a:after {
		display: none
	}
	/* Tabs: simple-style */
	.style-simple .ui-tabs .ui-tabs-nav li a {
		background-image: none
	}
	.style-simple .ui-tabs .ui-tabs-nav li.ui-tabs-selected a:after, .style-simple .ui-tabs .ui-tabs-nav li.ui-state-disabled a:after, .style-simple .ui-tabs .ui-tabs-nav li.ui-state-processing a:after, .style-simple .ui-tabs .ui-tabs-nav li.ui-state-active a:after {
		display: block
	}
	/* Tabs vertical: simple-style */
	.style-simple .tabs_vertical.ui-tabs .ui-tabs-nav li a {
		text-align: center;
		padding-right: 20px
	}
	.style-simple .tabs_vertical.ui-tabs .ui-tabs-panel {
		border-width: 1px 0 0!important
	}
	.style-simple .tabs_vertical.ui-tabs .ui-tabs-nav li.ui-tabs-selected a:after, .style-simple .tabs_vertical.ui-tabs .ui-tabs-nav li.ui-state-disabled a:after, .style-simple .tabs_vertical.ui-tabs .ui-tabs-nav li.ui-state-processing a:after, .style-simple .tabs_vertical.ui-tabs .ui-tabs-nav li.ui-state-active a:after {
		display: block;
		width: 100%;
		height: 2px;
		left: 0;
		top: auto;
		bottom: 0;
		right: auto
	}
	/* Testimonials list */
	.testimonials_list .item {
		margin-bottom: 30px
	}
	.testimonials_list .item .photo {
		width: 100%;
		float: none;
		margin-bottom: 10px
	}
	.testimonials_list .item .desc {
		width: 100%;
		float: none;
		margin-bottom: 0
	}
	/* Timeline */
	.timeline_items {
		background-position: 91px top
	}
	.timeline_items li {
		padding: 0 0 25px 150px !important;
		background: url(../../../images/timeline_right.png) no-repeat!important;
		background-position: 50px top!important;
		width: auto
	}
	.timeline_items li h3 span {
		left: 0!important;
		right: auto
	}
	.timeline_items li h3, .timeline_items li:nth-child(even) h3 {
		text-align: left
	}
	.timeline_items li h3:before {
		left: 93px
	}
	.timeline_items li .desc, .timeline_items li:nth-child(even) .desc {
		text-align: left
	}
	.timeline_items li .desc:before {
		display: none
	}
	.timeline_items:after {
		left: 93px
	}
	/* General -------------------- */
	/* Error 404 */
	#Error_404 {
		position: static;
		padding-top: 20px;
		margin-top: 0
	}
	#Error_404 .error_pic {
		width: 100%;
		float: none
	}
	#Error_404 .error_pic i {
		font-size: 160px;
		line-height: 160px
	}
	#Error_404 .error_desk {
		width: 100%;
		float: none;
		padding-top: 20px;
		text-align: center
	}
	#Error_404 .error_desk h2 {
		font-size: 30px;
		line-height: 30px
	}
	#Error_404 .error_desk h4 {
		font-size: 19px;
		line-height: 25px
	}
	#Error_404 .error_desk p .check {
		line-height: 22px;
		font-size: 16px;
		margin-bottom: 15px;
		display: block
	}
	/* Filters */
	#Filters .filters_wrapper ul li {
		float: left;
		width: 49%;
		margin: .5%
	}
	/* Fixed nav */
	.fixed-nav {
		display: none!important
	}
	/* Popup contact */
	#popup_contact {
		display: none
	}
	/* Search Results */
	.search-not-found .snf-pic {
		width: 100%;
		float: none
	}
	.search-not-found .snf-pic i {
		font-size: 260px;
		line-height: 260px
	}
	.search-not-found .snf-desc {
		width: 100%;
		float: none;
		padding-top: 20px;
		text-align: center
	}
	/* Video */
	/* In this case, the aspect ratio is 16:9, which means that the height will be 56.25% of the width. For a video with a 4:3 aspect ratio, we set padding-bottom to 75%. */
	.content_video.iframe {
		position: relative;
		padding-bottom: 56.25%;
		height: 0;
		overflow: hidden
	}
	.content_video.iframe iframe {
		position: absolute;
		top: 0;
		left: 0;
		width: 100%;
		height: 100%
	}
	/* Plugins --------------- */
	/* Pretty Photo Popup */
	/* Tiny popup on mobile | fix */
	.pp_pic_holder {
		width: 90%!important;
		left: 5%!important;
		overflow: hidden
	}
	.pp_content {
		width: 98%!important;
		height: auto!important
	}
	.pp_fade {
		width: 100%!important;
		height: 100%!important
	}
	a.pp_expand, a.pp_contract, .pp_hoverContainer, .pp_gallery {
		display: none!important
	}
	#pp_full_res img {
		width: 100%!important;
		height: auto!important
	}
	.pp_details {
		width: 100%!important;
		position: static!important;
		min-height: 25px
	}
	.pp_details a.pp_close {
		top: auto;
		right: 25px
	}
	div.pp_pic_holder, div.pp_content, div.pp_details {
		max-width: 100%
	}
	div.pp_content {
		overflow: auto
	}
}

/* #Tablet (Portrait) & Mobile (Landscape) 480 - 768 ----------------------- #Tablet (Portrait) & Mobile (Landscape) 480 - 768 */

@media only screen and (min-width: 480px) and (max-width: 767px) {
	/* Respond */
	#respond .comment-form-author {
		width: 100%;
		margin-right: 0;
		float: none
	}
	#respond .comment-form-email {
		width: 100%;
		margin-right: 0;
		float: none
	}
	#respond .comment-form-url {
		width: 100%;
		float: none
	}
	#respond input[type="text"], #respond input[type="password"], #respond input[type="email"], #respond select {
		width: 100%
	}
	#respond .comment-form-comment textarea {
		width: 100%
	}
	#respond .required {
		right: 15px
	}
	#comments .commentlist>li .comment-body {
		margin-left: 90px;
		padding: 10px
	}
	#comments .commentlist>li .photo {
		left: -90px
	}
	#comments .commentlist>li .children {
		margin-left: 0;
		padding-left: 10px
	}
	#comments .commentlist>li .reply {
		right: 10px;
		top: 10px
	}
	#comments .commentlist>li .comment-meta a.comment-edit-link {
		padding-right: 45px
	}
	.rtl #comments .commentlist>li .comment-body {
		margin-left: 0;
		margin-right: 90px
	}
	.rtl #comments .commentlist>li .photo {
		left: auto;
		right: -90px
	}
	.rtl #comments .commentlist>li .children {
		margin-right: 0;
		padding-left: 0;
		padding-right: 10px
	}
	.rtl #comments .commentlist>li .reply {
		left: 10px;
		right: auto
	}
	.rtl #comments .commentlist>li .comment-meta a.comment-edit-link {
		padding-left: 45px;
		padding-right: 0
	}
	/* Zoom Box */
	.zoom_box .desc .desc_txt {
		font-size: 18px;
		line-height: 22px
	}
	/* Gallery */
	#Content .gallery:not(.gallery-columns-1) .gallery-item {
		width: 50%;
		clear: none
	}
	#Content .gallery:not(.gallery-columns-1) .gallery-item:nth-child(2n+1) {
		clear: both
	}
	/* Latest News */
	.Latest_news.featured ul {
		width: 49%!important
	}
}

/* #Mobile (Portrait) < 480 ------------------------------------------------------------------------- #Mobile (Portrait) < 480 */

@media only screen and (max-width: 479px) {
	#Top_bar a.button.action_button {
		margin-right: 0
	}
	/* Post nav */
	.post-nav {
		padding: 10px 10px 4px
	}
	/* Portfolio list */
	body:not(.with_aside) .portfolio_group.list .portfolio-item .portfolio-item-fw-wrapper {
		width: 260px
	}
	/* Portfolio Masonry Flat */
	.portfolio_group.masonry-flat .portfolio-item, .portfolio_group.masonry-flat .portfolio-item.wide {
		width: 100%!important
	}
	/* Latest News */
	.Latest_news.featured ul {
		width: 100%!important
	}
	/* Filters */
	#Filters .filters_buttons li {
		margin-right: 10px
	}
	#Filters .filters_buttons li.label {
		display: none
	}
	#Filters .filters_buttons li i.icon-docs, #Filters .filters_buttons li i.icon-tag {
		display: none
	}
	/* Team */
	.team.team_horizontal .image_frame {
		width: 100%;
		margin: 0 0 15px;
		float: none
	}
	.team.team_horizontal .desc_wrapper {
		width: 100%;
		float: none
	}
	/* Timeline */
	.timeline_items {
		background-position: 21px top
	}
	.timeline_items li {
		padding: 0 0 25px 80px !important;
		background-position: -20px top!important
	}
	.timeline_items li h3 span {
		display: table;
		position: relative;
		margin-bottom: 20px;
		clear: both
	}
	.timeline_items li h3:before {
		left: 24px
	}
	.timeline_items:after {
		left: 23px
	}
	/* Testimonials slider */
	.testimonials_slider a.slider_prev {
		display: none!important
	}
	.testimonials_slider a.slider_next {
		display: none!important
	}
	.testimonials_slider .testimonials_slider_ul li {
		padding: 0
	}
	/* Respond */
	#respond .comment-form-author {
		width: 99%;
		margin-right: 0;
		float: none
	}
	#respond .comment-form-email {
		width: 99%;
		margin-right: 0;
		float: none
	}
	#respond .comment-form-url {
		width: 99%;
		float: none
	}
	#respond input[type="text"], #respond input[type="password"], #respond input[type="email"], #respond select {
		width: 100%
	}
	#respond .comment-form-comment textarea {
		width: 100%
	}
	#respond .required {
		right: 11px
	}
	#comments .commentlist>li .comment-body {
		margin-left: 55px;
		padding: 10px
	}
	#comments .commentlist>li .photo {
		width: 32px;
		height: 32px;
		left: -55px
	}
	#comments .commentlist>li .children {
		margin-left: 0;
		padding-left: 10px
	}
	#comments .commentlist>li .reply {
		right: 10px;
		top: 10px
	}
	#comments .commentlist>li .comment-meta a.comment-edit-link {
		padding-right: 0;
		position: static;
		float: none
	}
	.rtl #comments .commentlist>li .comment-body {
		margin-left: 0;
		margin-right: 55px
	}
	.rtl #comments .commentlist>li .photo {
		left: auto;
		right: -55px
	}
	.rtl #comments .commentlist>li .children {
		margin-right: 0;
		padding-left: 0;
		padding-right: 10px
	}
	.rtl #comments .commentlist>li .reply {
		left: 10px;
		right: auto
	}
	.rtl #comments .commentlist>li .comment-meta a.comment-edit-link {
		padding: 0
	}
	/* Zoom Box */
	.zoom_box .desc .desc_img img {
		max-height: 60px;
		width: auto
	}
	.zoom_box .desc .desc_txt {
		font-size: 14px;
		line-height: 17px
	}
	/* Feature box */
	.feature_box .feature_box_wrapper {
		display: block
	}
	.feature_box .feature_box_wrapper .photo_wrapper, .feature_box .feature_box_wrapper .desc_wrapper {
		display: block;
		width: 100%;
		padding: 0
	}
	.feature_box .feature_box_wrapper .photo_wrapper {
		margin-bottom: 15px;
		text-align: center
	}
	.feature_box .feature_box_wrapper .photo_wrapper a {
		display: inline-block
	}
	/* Gallery */
	#Content .gallery .gallery-item {
		width: 100%
	}
}

/* Retina | iPad ----------------------------------------------------------------------------------------------- Retina | iPad */

@media only screen and (max-device-width: 1024px) {
	html.ios, .ios .section.bg-cover {
		background-attachment: scroll!important
	}
}
