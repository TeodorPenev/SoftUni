<?php
session_start();
?>
</<!doctype html>
<html>
<head>
    <title>04.HTML Tags Counter</title>
</head>
<body>
<form action="" method="get">
    <label for="tags">Enter HTML tags:</label><br>
    <input type="text" name="input" id="tags"/>
    <input type="submit" name="submit"/>
</form>
<?php if(isset($_GET['submit'])){
$tag=$_GET['input'];
    $tags = array("!doctype", "a", "abbr", "address", "area", "article", "aside", "audio", "b", "base", "bdi", "bdo", "big",
        "blockquote", "body", "br", "button", "canvas", "caption", "center", "cite", "code", "col", "colgroup", "command",
        "datalist", "dd", "del", "details", "dfn", "dir", "div", "dl", "dt", "em", "embed", "fieldset", "figcaption",
        "figure", "font", "footer", "form", "frame", "frameset", "h1", "h2", "h3", "h4", "h5", "h6", "head", "header",
        "hgroup", "hr", "html", "i", "iframe", "img", "input", "ins", "kbd", "keygen", "label", "legend", "li", "link",
        "map", "mark", "menu", "meta", "meter", "nav", "noframes", "noscript", "object", "ol", "optgroup", "option", "p",
        "param", "pre", "progress", "q", "rp", "rt", "ruby", "s", "samp", "script", "section", "select", "small", "source",
        "span", "strike", "strong", "style", "sub", "summary", "sup", "table", "tbody", "td", "textarea", "tfoot", "th",
        "time", "title", "tr", "track", "tt", "u", "ul", "var", "video", "wbr");

    if(in_array($tag,$tags)){
        $_SESSION["counter"]=$_SESSION["counter"]+1;
        echo 'Valid HTML tag!'.'<br>';
    }else{
      echo 'Invalid HTML tag!'.'<br>';
    }
    if($_SESSION["counter"]==null) {
        echo 'Score: 0';
    }
    else{
        echo $_SESSION["counter"];
    }
}
?>
</body>
</html>