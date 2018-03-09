<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uActivation.ascx.cs" Inherits="UserControls_Company_Activation_uActivation" %>
<div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">Üyelik Ýþlemleri</h2>
      </div>
      <div class="brclear"></div>
      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
      <div class="BoxContent">
        <div class="BoxPadder">
          <div class="ArticleItem">
          
            <div class="TemplateContent">
            <asp:Literal runat="server" ID="ltlActivateYES" Visible="false">
            Üyelik e-posta aktivasyonunuz baþarý ile tamamlanmýþtýr.
            </asp:Literal>
            <br /><br />
            <asp:HyperLink Visible="false" runat="server" ID="hlDownload" Target="_blank" NavigateUrl="~/Files/Contract.doc">
            Danýþmanlýk sözleþmesini yazdýrmak için týklayýnýz.
            </asp:HyperLink>
            <br /><br />
            <asp:Literal runat="server" ID="ltlActivateMsg" Visible="false">
            Sözleþme PÝK Danýþmanlýk tarafýndan teslim alýndýktan ve onaylandýktan sonra kullanýcý 
            adý ve þifreniz  e-posta adresinize gönderilecektir.
            </asp:Literal>
            
            <asp:Literal runat="server" ID="ltlActivateNO" Visible="false">
            Email aktivasyonunda HATA Oluþtu !..
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