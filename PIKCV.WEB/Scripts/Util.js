// JScript File
/* ---- :: Left Fonksiyonu :: ------------------------------------------------------------------------- */

/* 
str = Kelime
n = Soldan Kaç Karakter ?
*/
function Left(str, n){
	if (n <= 0)
	    return "";
	else if (n > String(str).length)
	    return str;
	else
	    return String(str).substring(0,n);
}



/* ---- :: Right Fonksiyonu :: ------------------------------------------------------------------------ */

/* 
str = Kelime
n = Sağdan Kaç Karakter ?
*/
function Right(str, n){
    if (n <= 0)
       return "";
    else if (n > String(str).length)
       return str;
    else {
       var iLen = String(str).length;
       return String(str).substring(iLen, iLen - n);
    }
}


/* ---- :: Giriş Sayfası Yap Fonksiyonu :: ------------------------------------------------------------------------ */
/* 
this.style.behavior='url(#default#homepage)';this.setHomePage('http://www.link.com')
*/

/* ---- :: Favorilere Ekle Fonksiyonu :: ------------------------------------------------------------------------ */

/* 
Link = Link
Title = Görüntülenen Başlık
*/
function AddFavorites(Link, Title) {
	window.external.AddFavorite(Link, Title)
}


/* ---- :: Randum Numara Üretme :: ------------------------------------------------------------------------ */

/* 
MaxNumber = Kaça kadar bir sayı tutsun 
*/
function RandomNumber(MaxNumber) {
	return Math.floor(Math.random() * MaxNumber +1);
}


function Trim(str, chars) {
    return ltrim(rtrim(str, chars), chars);
}

function Ltrim(str, chars) {
    chars = chars || "\\s";
    return str.replace(new RegExp("^[" + chars + "]+", "g"), "");
}

function Rtrim(str, chars) {
    chars = chars || "\\s";
    return str.replace(new RegExp("[" + chars + "]+$", "g"), "");
}

function RdListSelectedValue(RadiButtonListID) {
	var obj = document.forms[0][RadiButtonListID];
	for (i=0;i<obj.length;i++) {
		if (obj[i].checked) {
			return obj[i].value;
		}
	}
	return -1;
}

function ddlSelectedValue(ddlID) {
    return $get(ddlID).options[$get(ddlID).selectedIndex].value;
}