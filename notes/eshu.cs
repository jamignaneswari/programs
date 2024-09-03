<!DOCTYPE html>
<html>
<head>
    <title>Web Page Layout</title>
</head>
<frameset rows="100px,*" cols="200px,*" border="0">
    <!-- Top Frame -->
    <frame src="top.html" name="topFrame" noresize="noresize">
    
    <!-- Main Content Frames -->
    <frameset cols="200px,*" border="0">
        <!-- Left Frame -->
        <frame src="left.html" name="leftFrame" noresize="noresize">
        
        <!-- Right Frame -->
        <frame src="right.html" name="rightFrame">
    </frameset>
</frameset>

<noframes>
    <body>
        <p>Your browser does not support frames. You may need to update your browser or use a different one.</p>
    </body>
</noframes>
</html>

