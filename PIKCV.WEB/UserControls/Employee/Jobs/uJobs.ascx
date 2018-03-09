<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uJobs.ascx.cs" Inherits="UserControls_Employee_Jobs_uJobs" %>
<%@ Register Src="../../Common/ModalPopup/ModalPopup.ascx" TagName="ModalPopup" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/Common/uList.ascx" TagName="uList" TagPrefix="uc2" %>

<div class="contentPad">
    <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">
            Ýlan Arama Sonuçlarý</h2>
    </div>
    <div id="dvUserFilters" runat="server" class="floatRight">
        <asp:DropDownList AutoPostBack="true" runat="server" ID="ddlFilters" OnSelectedIndexChanged="ddlFilters_SelectedIndexChanged">
        </asp:DropDownList>
       
        <asp:TextBox runat="server" ID="txtFilterName" MaxLength="128" Visible="false"></asp:TextBox>
        <asp:ImageButton Visible="false" runat="server" ID="btnSave" ImageUrl="~/Images/buttons/add_filter.png" OnClick="btnSave_Click" ValidationGroup="vgNewFilter" />
    </div>
    <div class="brclear">
    </div>
    
    <uc2:uList id="UList1" runat="server"></uc2:uList>
    
    <div class="brclear">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFilterName"
            Display="None" ErrorMessage="Lütfen Filtre Ýsmini Giriniz" ValidationGroup="vgNewFilter"></asp:RequiredFieldValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
            ShowSummary="False" ValidationGroup="vgNewFilter" />
    </div>
    
</div>
<uc1:ModalPopup ID="ShowModal" runat="server" Visible="false"/>



