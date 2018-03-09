<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uPublicJobs.ascx.cs" Inherits="UserControls_Company_Jobs_uPublicJobs" %>
<%@ Register Src="../Common/uJobsTabs.ascx" TagName="uJobsTabs" TagPrefix="uc2" %>
<%@ Register Src="../../Common/uList.ascx" TagName="uList" TagPrefix="uc1" %>
<script type="text/javascript">
    function DraftDeleteCtrl(JobStatusID, JobID) {
        if(confirm('Ýlaný silmek istediðinize emin misiniz'))
            window.location.href('pikcv.aspx?Pik=Company-Jobs-PublicJobs&JobStatus=' + JobStatusID + '&JobID=' + JobID);
    }
</script>
<div class="contentPad">

    <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader" style="width: 200px;">
            <asp:Literal runat="server" ID="ltlMessages">Ýlanlarým</asp:Literal>
        </h2>
    </div>
    
    <uc2:uJobsTabs id="UJobsTabs1" runat="server">
    </uc2:uJobsTabs>
           
    <div class="brclear"></div>
        <uc1:uList ID="UList1" runat="server" />
    <div class="brclear"></div>
    
</div>

<div id="dvScript" runat="server"></div>