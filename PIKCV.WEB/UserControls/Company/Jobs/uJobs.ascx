<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uJobs.ascx.cs" Inherits="UserControls_Company_Jobs_uJobs" %>
<%@ Register Src="../Common/uJobsTabs.ascx" TagName="uJobsTabs" TagPrefix="uc1" %>



 <div class="contentPad">
      <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">
            <asp:Literal runat="server" ID="ltlTitleNewJob" Visible="false">Yeni Ýlan Giriþi</asp:Literal>
            <asp:Literal runat="server" ID="ltlTitleEditJob" Visible="false">Ýlan Güncelleme</asp:Literal>
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
                        <asp:HyperLink runat="server" ID="hlJobType" Text="Ýlan Tipi"
                        NavigateUrl="#Company-Jobs-Jobs&JobFocus=||FocusNo||"></asp:HyperLink>
                    </li>
                    <li runat="server" id="li2">
                        <asp:HyperLink runat="server" ID="hlPositionDefinition" Text="Pozisyon Tanýmý"
                        NavigateUrl="#Company-Jobs-Jobs&JobFocus=||FocusNo||"></asp:HyperLink>
                    </li>
                    <li runat="server" id="li3">
                        <asp:HyperLink runat="server" ID="hlEducationLevel" Text="Eðitim Durumu"
                        NavigateUrl="#Company-Jobs-Jobs&JobFocus=||FocusNo||"></asp:HyperLink>
                    </li>
                    <li runat="server" id="li4">
                        <asp:HyperLink runat="server" ID="hlSeekingQuality" Text="Aranan Nitelikler"
                        NavigateUrl="#Company-Jobs-Jobs&JobFocus=||FocusNo||"></asp:HyperLink>
                    </li>
                    <li runat="server" id="li5">
                        <asp:HyperLink runat="server" ID="hlPreferencePriority" Text="Tercih Puanlamasý"
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
                        Bu bölüme geçmek için email aktivasyonu yapýp login olmanýz gerekmektedir.
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