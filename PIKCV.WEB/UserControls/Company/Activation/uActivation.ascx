<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uActivation.ascx.cs" Inherits="UserControls_Company_Activation_uActivation" %>
<div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">�yelik ��lemleri</h2>
      </div>
      <div class="brclear"></div>
      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
      <div class="BoxContent">
        <div class="BoxPadder">
          <div class="ArticleItem">
          
            <div class="TemplateContent">
            <asp:Literal runat="server" ID="ltlActivateYES" Visible="false">
            �yelik e-posta aktivasyonunuz ba�ar� ile tamamlanm��t�r.
            </asp:Literal>
            <br /><br />
            <asp:HyperLink Visible="false" runat="server" ID="hlDownload" Target="_blank" NavigateUrl="~/Files/Contract.doc">
            Dan��manl�k s�zle�mesini yazd�rmak i�in t�klay�n�z.
            </asp:HyperLink>
            <br /><br />
            <asp:Literal runat="server" ID="ltlActivateMsg" Visible="false">
            S�zle�me P�K Dan��manl�k taraf�ndan teslim al�nd�ktan ve onayland�ktan sonra kullan�c� 
            ad� ve �ifreniz  e-posta adresinize g�nderilecektir.
            </asp:Literal>
            
            <asp:Literal runat="server" ID="ltlActivateNO" Visible="false">
            Email aktivasyonunda HATA Olu�tu !..
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