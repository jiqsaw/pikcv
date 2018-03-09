<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uJobApplicants.ascx.cs" Inherits="UserControls_Employee_JobApplicants_uJobApplicants" %>
<%@ Register Src="~/UserControls/Common/uList.ascx" TagName="uList" TagPrefix="uc2" %>

<div class="contentPad">
    <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader" style="width: 200px;">
            Baþvurularým</h2>
    </div>
    <div class="brclear">
    </div>
    
    <uc2:uList id="UList1" runat="server"></uc2:uList>
    
    <div class="brclear"></div>
    
</div>
