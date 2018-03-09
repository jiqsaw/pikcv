var Links = document.getElementsByTagName("a");
var Link = "";
var CharIndex;
for (var i = Links.length; --i >= 0;) {
    CharIndex = Links[i].href.indexOf('#');
    if (CharIndex!=-1) {
        Link = Links[i].href;
        Link = Link.substring(CharIndex + 1);
//      Link = (Link.substring(0, Link.lastIndexOf('-') + 1) + 'u' + Link.substring(Link.lastIndexOf('-') + 1)).replace(/-/gi,"/");
        Links[i].href = "javascript:Pik('" + Link + "')";
    }
}