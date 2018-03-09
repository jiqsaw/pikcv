<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uList.ascx.cs" Inherits="UserControls_Common_uList" %>
<%@ Register Src="uPaging.ascx" TagName="uPaging" TagPrefix="uc1" %>

<asp:Panel runat="server" ID="pnlList">
    <div class="BoxContentTop"></div>
    <div class="BoxContent">
        <div class="BoxPadder">
            <div id="dvList" runat="server"> </div>
        
            <div class="pager">

        <table class="SearchFooter">
            <tr>
                <td class="RecordCountCell">
                    <asp:Literal runat="server" ID="ltlRecordCountTitle" Text="Toplam Kayýt" />:
                    <asp:Label CssClass="RecordCountText" runat="server" ID="lblRecordCount" />
                </td>
                <td class="PageNumberCell">
                    <%--<asp:HyperLink runat="server" CssClass="NextPrevLink" ID="hlPrevious" Enabled="False">«« &nbsp;Önceki</asp:HyperLink> &nbsp;&nbsp;--%>
                    
                    <asp:Literal runat="server" ID="ltlPage" Text="Sayfa"></asp:Literal>&nbsp;&nbsp;
                    
                    <asp:DropDownList runat="server" CssClass="DropDownList" ID="ddlPageNumber" /> &nbsp;&nbsp;
                    <%-- <asp:HyperLink runat="server" CssClass="NextPrevLink" ID="hlNext" Enabled="False">Sonraki&nbsp; »»</asp:HyperLink>--%>
                    
                </td>
            </tr>
        </table>    

    </div>
        
        </div>
    </div>
    <div class="BoxContentBottom"></div>
</asp:Panel>

<asp:Panel runat="server" ID="pnlNoRecord" Visible="false">
    <div class="BoxContentTop"></div>
    <div class="BoxContent">
        <div class="BoxPadder">
          <div class="ArticleItem">
          
            <asp:Label CssClass="TemplateContent" runat="server" ID="lblNoRecord">
            </asp:Label>
          
          </div>
          <div class="brclear"></div>
        </div>
      </div>
      <div class="BoxContentBottom"></div>
</asp:Panel>

<script type="text/javascript">
    function ddlSelected(ddlID, selectedValue) {
        for (var i = 1; i<document.getElementById(ddlID).length; i++) {
            document.getElementById(ddlID).options[i].selected = (document.getElementById(ddlID).options[i].value == selectedValue);
        }
    }
</script>

<div runat="server" id="dvScript"></div>
