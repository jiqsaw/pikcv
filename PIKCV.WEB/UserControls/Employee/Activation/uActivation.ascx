<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uActivation.ascx.cs" Inherits="UserControls_Employee_Activation_uActivation" %>
<div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">E-posta Giriþ</h2>
      </div>
      <div class="brclear"></div>
      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
      <div class="BoxContent">
        <div class="BoxPadder">
          <div class="ArticleItem">
          
            <div class="TemplateContent">
            <asp:Literal runat="server" ID="ltlActivateYES" Visible="false">
            Eposta aktivasyonunu baþarý ile tamamladýnýz. <br />
            Kullanýcý adý ve þifre ile sitemize login olabilirsiniz.
            </asp:Literal>

            <asp:Literal runat="server" ID="ltlActivateNO" Visible="false">
            Eposta aktivasyonunda HATA Oluþtu !..
            </asp:Literal>
            </div>
          
          </div>
          <div class="brclear"></div>
        </div>
      </div>
      <div class="BoxContentBottom"></div>
      <!-- finish roundcornered box -->
      <p>&nbsp;</p>
    </div>