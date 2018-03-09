<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uBuyContactInfoResult.ascx.cs" Inherits="UserControls_Company_BuyContactInfo_uBuyContactInfoResult" %>
<div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">Ýletiþim Bilgisi Satýn Alma</h2>
      </div>
      <div class="brclear"></div>
      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
      <div class="BoxContent">
        <div class="BoxPadder">
          <div class="ArticleItem">
          
            <div class="TemplateContent">
            <asp:Literal ID="ltlBuyContactInfoResult" runat="server"></asp:Literal>
            <br /><br />
            <asp:ImageButton runat="server" ID="btnContinue" ImageUrl="~/Images/Buttons/corp_buy_and_continue.png" OnClick="btnContinue_Click" />
            &nbsp;&nbsp;&nbsp;<asp:ImageButton runat="server" ID="btnContinueWithoutBuyContactInfo" ImageUrl="~/Images/Buttons/corp_dont_buy_and_continue.png" OnClick="btnContinueWithoutBuyContactInfo_Click" Visible="false"/>
            &nbsp;&nbsp;&nbsp;<asp:HyperLink ID="hlBack" runat="server" Width="80" Text="Geri Dön" ImageUrl="~/Images/Buttons/corp_go_back.png" NavigateUrl="javascript:history.back()"></asp:HyperLink>
            </div>
          </div>
          <div class="brclear"></div>
        </div>
      </div>
      <div class="BoxContentBottom"></div>
      <!-- finish roundcornered box -->
      <p>&nbsp;</p>
</div>