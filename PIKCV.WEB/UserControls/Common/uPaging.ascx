<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uPaging.ascx.cs" Inherits="UserControls_Common_uPaging" %>

<script type="text/javascript">
	function ChangePage(PageValue, ValueType) {
		var chr = "&";
	    var path = String(location.href);        
	    if (path.indexOf(ValueType + "=") != "-1") { path = path.substring(0, eval(path.indexOf(ValueType + "=") - 1)) ; }
        if (path.indexOf("?") == "-1") { chr = "?"; } 
	    path = path + chr + ValueType + "=" + PageValue;
		location.href = path;
	}
</script>

<table class="SearchFooter">
    <tr>
        <td class="RecordCountCell">
            <asp:Literal runat="server" ID="ltlRecordCountTitle" Text="Toplam Kay�t" />:
            <asp:Label CssClass="RecordCountText" runat="server" ID="lblRecordCount" />
        </td>
        <td class="PageSizeCell">
            <asp:Literal runat="server" ID="ltlPageSize" Text="G�sterim Adedi:" /> 
            <asp:DropDownList runat="server" ID="ddlPageSize" CssClass="DropDownList" />
        </td>
        <td class="PageNumberCell">
            <asp:HyperLink runat="server" CssClass="NextPrevLink" ID="hlPrevious" Enabled="False">�� &nbsp;�nceki</asp:HyperLink> &nbsp;&nbsp;
            <asp:DropDownList runat="server" CssClass="DropDownList" ID="ddlPageNumber" /> &nbsp;&nbsp;
            <asp:HyperLink runat="server" CssClass="NextPrevLink" ID="hlNext" Enabled="False">Sonraki&nbsp; ��</asp:HyperLink>
        </td>
    </tr>
</table>