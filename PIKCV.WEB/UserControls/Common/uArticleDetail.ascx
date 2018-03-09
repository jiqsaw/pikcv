<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uArticleDetail.ascx.cs" Inherits="UserControls_Common_uArticleDetail" %>



    <div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">Makaleler</h2>
      </div>
      <div class="brclear"></div>
      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
      <div class="BoxContent">
        <div class="BoxPadder">
          <div class="ArticleItem">
            <p class="mute"><asp:Label ID="lbArticleDate" runat="server"></asp:Label></p>
            <h2><asp:Label ID="lbArticleTitle" runat="server"></asp:Label></h2>
            <br />
            <asp:Literal ID="ltlArticleBody" runat="server"></asp:Literal>
            <ul class="FamLinks">
              <%--<li class="SendToFriend"><a href="javascript:;">Arkadaþýma Gönder</a></li>--%>
              <li class="Print"><a href="javascript:window.print();">Yazdýr</a></li>
              <li class="GoBack"><a href="#Common-ArticlesAll"><asp:Literal runat="server" ID="ltlAllArticles" Text="Tüm makaleler"></asp:Literal></a></li>
            </ul>
          </div>
          <div class="brclear"></div>
        </div>
      </div>
      <div class="BoxContentBottom"></div>
      <!-- finish roundcornered box -->
      <p>&nbsp;</p>
    </div>