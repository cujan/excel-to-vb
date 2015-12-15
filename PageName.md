<?php

$link = mysqli\_connect('localhost','mkocan','mkocan', "playground");
if (!$link) {
> die('Could not connect to MySQL: ' . mysql\_error());
}

$query = "select cislo, datum from jqplot ";

$result = mysqli\_query($link, $query);

while($row = mysqli\_fetch\_array($result)) {
$jsArray[.md](.md)=array($row["datum"], (float)$row["cislo"]);
}

$dataArray=json\_encode($jsArray);

echo '<!DOCTYPE html>



&lt;html&gt;




&lt;head&gt;



> 

&lt;title&gt;

Vaha

&lt;/title&gt;



> 

&lt;link class="include" rel="stylesheet" type="text/css" href="./jqplot/jquery.jqplot.min.css" /&gt;


> <!--[lt IE 9](if.md)>

&lt;script language="javascript" type="text/javascript" src="./jqplot/excanvas.js"&gt;



&lt;/script&gt;

<![endif](endif.md)-->
> 

&lt;script class="include" type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"&gt;



&lt;/script&gt;






&lt;/head&gt;




&lt;body&gt;


> <div></li></ul>

<blockquote><div></div>



&lt;script type="text/javascript"&gt;


$(document).ready(function(){
> vaha = '.$dataArray.';
'."
> var plot1 = $.jqplot('chart1', [vaha](vaha.md), {
> > title: 'Vaha',
> > series: [{
> > > label: 'Vaha',
> > > neighborThreshold: -1

> > }],
> > axes: {
> > > xaxis: {
> > > > renderer:$.jqplot.DateAxisRenderer,
> > > > tickRenderer: $.jqplot.CanvasAxisTickRenderer,
> > > > tickOptions: {
> > > > > angle: -30

> > > > }

> > > },
> > > yaxis: {
> > > > renderer: $.jqplot.LogAxisRenderer,
> > > > tickOptions:{ prefix: '$' }

> > > }

> > },
> > cursor:{
> > > show: true,
> > > zoom: true

> > }

> });
});


&lt;/script&gt;


".'
> 

&lt;script class="include" type="text/javascript" src="./jqplot/jquery.jqplot.min.js"&gt;



&lt;/script&gt;


> 

&lt;script class="include" type="text/javascript" src="./jqplot/plugins/jqplot.cursor.min.js"&gt;



&lt;/script&gt;


> 

&lt;script class="include" type="text/javascript" src="./jqplot/plugins/jqplot.dateAxisRenderer.min.js"&gt;



&lt;/script&gt;


> 

&lt;script class="include" type="text/javascript" src="./jqplot/plugins/jqplot.logAxisRenderer.min.js"&gt;



&lt;/script&gt;


> 

&lt;script class="include" type="text/javascript" src="./jqplot/plugins/jqplot.canvasTextRenderer.min.js"&gt;



&lt;/script&gt;


> 

&lt;script class="include" type="text/javascript" src="./jqplot/plugins/jqplot.canvasAxisTickRenderer.min.js"&gt;



&lt;/script&gt;



> </div></blockquote>

<br>
<br>
</body><br>
<br>
<br>
<br>
<br>
<br>
<br>
</html><br>
<br>
';<br>
?>