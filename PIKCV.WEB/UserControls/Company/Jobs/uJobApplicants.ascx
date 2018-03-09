<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uJobApplicants.ascx.cs" Inherits="UserControls_Company_Jobs_uJobApplicants" %>
<%@ Register Src="../../Common/uList.ascx" TagName="uList" TagPrefix="uc1" %>

<div class="contentPad">
    <div class="HeaderPB floatLeft">
        <h2 class="sIFRHeader">
            Baþvurular
        </h2>
    </div>
    <div class="SectionCombo">
        <asp:DropDownList ID="ddlCompanyJobs" runat="server" OnSelectedIndexChanged="ddlCompanyJobs_SelectedIndexChanged" AutoPostBack="true">
        </asp:DropDownList>
        </div>
    <div class="brclear">
    </div>
    <div class="BoxContentTop">
    </div>
    <uc1:uList ID="UList1" runat="server" />
</div>
