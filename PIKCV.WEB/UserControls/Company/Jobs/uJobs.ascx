<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uJobs.ascx.cs" Inherits="UserControls_Company_Jobs_uJobs" %>
<%@ Register Src="../Common/uJobsTabs.ascx" TagName="uJobsTabs" TagPrefix="uc1" %>



 <div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">
            <asp:Literal runat="server" ID="ltlTitleNewJob" Visible="false">Yeni �lan Giri�i</asp:Literal>
            <asp:Literal runat="server" ID="ltlTitleEditJob" Visible="false">�lan G�ncelleme</asp:Literal>
        </h2>
      </div>

            <uc1:uJobsTabs id="UJobsTabs1" runat="server"></uc1:uJobsTabs>
      
      <div class="brclear"></div>

      <!-- start roundcornered box -->
      <div class="BoxContentTop"></div>
           
        <div class="BoxContent">
            <div class="BoxPadder">
                <ul class="SubTab">
                    <li runat="server" id="li1">
                        <asp:HyperLink runat="server" ID="hlJobType" Text="�lan Tipi"
                        NavigateUrl="#Company-Jobs-Jobs&JobFocus=||FocusNo||"></asp:HyperLink>
                    </li>
                    <li runat="server" id="li2">
                        <asp:HyperLink runat="server" ID="hlPositionDefinition" Text="Pozisyon Tan�m�"
                        NavigateUrl="#Company-Jobs-Jobs&JobFocus=||FocusNo||"></asp:HyperLink>
                    </li>
                    <li runat="server" id="li3">
                        <asp:HyperLink runat="server" ID="hlEducationLevel" Text="E�itim Durumu"
                        NavigateUrl="#Company-Jobs-Jobs&JobFocus=||FocusNo||"></asp:HyperLink>
                    </li>
                    <li runat="server" id="li4">
                        <asp:HyperLink runat="server" ID="hlSeekingQuality" Text="Aranan Nitelikler"
                        NavigateUrl="#Company-Jobs-Jobs&JobFocus=||FocusNo||"></asp:HyperLink>
                    </li>
                    <li runat="server" id="li5">
                        <asp:HyperLink runat="server" ID="hlPreferencePriority" Text="Tercih Puanlamas�"
                        NavigateUrl="#Company-Jobs-Jobs&JobFocus=||FocusNo||"></asp:HyperLink>
                    </li>
                    <li runat="server" id="li6">
                        <asp:HyperLink runat="server" ID="hlApproval" Text="Onay"
                        NavigateUrl="#Company-Jobs-Jobs&JobFocus=||FocusNo||"></asp:HyperLink>
                    </li>
                </ul>
<%--                <asp:Panel runat="server" ID="pnlNoEmailConfirmed">
                  <p class="ErrorMsg" style="text-align: center;">
                        <br /><br /><br /><br />
                        <asp:Label CssClass="Error" runat="server" ID="ltlError">
                        Bu b�l�me ge�mek i�in email aktivasyonu yap�p login olman�z gerekmektedir.
                        </asp:Label>
                        <br /><br />
                  </p>
                </asp:Panel>  --%>  
                  
                <div class="brclear"></div>
                <p>&nbsp;</p><p>&nbsp;</p>
                
                <asp:PlaceHolder runat="server" ID="PHCVFocus"></asp:PlaceHolder>
                
                <div class="brclear">
                </div>
            </div>
        </div>
        <div class="BoxContentBottom"></div>
      <!-- finish roundcornered box -->
      <p>&nbsp;</p>
      
    </div>