<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uPersonalPhoto.ascx.cs"
    Inherits="UserControls_Employee_Membership_CV_uPersonalPhoto" %>
<%@ Register Src="../../../Common/uImageUpload.ascx" TagName="uImageUpload" TagPrefix="uc2" %>
<%@ Register Src="../../Common/uCVTabs.ascx" TagName="uCVTabs" TagPrefix="uc1" %>
<div class="contentPad">
    <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">
            Yeni Üyelik</h2>
    </div>

    <uc1:uCVTabs ID="UCVTabs1" runat="server" />
    
    <div class="brclear">
    </div>
    <!-- start roundcornered box -->
    <div class="BoxContentTop">
    </div>
    <div class="BoxContent">
        <div class="BoxPadder">
            <table class="FormTable" width="100%">
                <tr>
                    <td colspan="2">
                        <div class="infoMsg">
                            <p> Bu sayfadan özgeçimiþinizde görünecek fotoðrafýnýzý yükleyebilirsiniz. </p>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td align="center" valign="top">
                        <asp:Image ID="imgUserPhoto" runat="server"/>
                    </td>
                    <td valign="top">
                    <asp:Panel ID="pnlUpdatePhoto" runat="server">
                        <h2>Fotoðraf ekleme</h2><p>&nbsp;</p>
                        <p>
                            Dosya fomatý, JPEG, BMP, GIF ya da PNG olabilir.<br />
                            Lütfen göndereceðiniz dosyanýn ebadý 1 Mb'tan daha fazla olmamasýna dikkat ediniz.<br />
                        </p>
                        <p class="mute">
                            Yüklenmesi Gereken Minimum: 262px*307px
                        </p>
                        <p>
                            &nbsp;
                        </p>

                        <p>
                            <uc2:uImageUpload ID="UImageUpload1" runat="server" />
                            &nbsp;</p>
                            <asp:HyperLink ID="hplContinue" runat="server" ImageUrl="~/Images/Buttons/continue.png" 
                            NavigateUrl="#Employee-Membership-Tests" Visible="false"></asp:HyperLink>
                        <asp:Panel ID="pnlMessage" runat="server" Visible="false"><br />
                            <asp:Label ID="lbMessage" runat="server"></asp:Label>
                        </asp:Panel>

                        <p>
                            &nbsp;</p>
                        <p>
                            &nbsp;</p>
                        <p>
                            &nbsp;</p>
                        <p>
                            &nbsp;</p>
                        <p>
                            &nbsp;</p>
                        <p>
                            &nbsp;</p>
                        <p>
                            &nbsp;</p>
                        <p>
                            &nbsp;
                        </p>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        
                    </td>
                </tr>
            </table>
            <div class="brclear">
            </div>
        </div>
    </div>
    <div class="BoxContentBottom">
    </div>
    <!-- finish roundcornered box -->
    <p>
        &nbsp;</p>
</div>
<div runat="server" id="dvScript"></div>