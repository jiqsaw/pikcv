<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uNoCredit.ascx.cs" Inherits="UserControls_Company_Jobs_Jobs_uNoCredit" %>
<div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">Pik Krediniz yeterli deðil</h2>
      </div>
      <div class="brclear"></div>
      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
      <div class="BoxContent">
        <div class="BoxPadder">
          <div class="ArticleItem">
          
            <div class="TemplateContent">
            <asp:Literal runat="server" ID="ltlPikCreditMsg">
            Yapmak istediðiniz iþlem için yeterli pik krediniz bulunmamaktadýr, iþlem öncesinde kredi almanýz gerekmektedir.
            </asp:Literal> <br /><br />» 
            <asp:HyperLink runat="server" ID="hlRedirectPikCredit" NavigateUrl="#Company-Credits-SelectCreditPackage">
            Pik kredi satýn almak için týklayýnýz...
            </asp:HyperLink>
            </div>
          </div>
          <div class="brclear"></div>
        </div>
      </div>
      <div class="BoxContentBottom"></div>
      <!-- finish roundcornered box -->
      <p>&nbsp;</p>
    </div>