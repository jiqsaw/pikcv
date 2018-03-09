<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uJobsTabs.ascx.cs" Inherits="UserControls_Company_Common_uJobsTabs" %>

  <div id="Tab">
    <ul>
      <li runat="server" id="liNewJobEntry"><a href="#Company-Jobs-Jobs&JobID=0"><span>Ýlan Bilgileri</span></a></li>
      <li runat="server" id="liPublicJobs"><asp:LinkButton ID="lnbActiveJobs" runat="server" OnClick="lnbActiveJobs_Click"><span>Yayýndaki Ýlanlar</span></asp:LinkButton></li>
      <li runat="server" id="liSketch"><asp:LinkButton ID="lnbDraftJobs" runat="server" OnClick="lnbDraftJobs_Click"><span>Taslaklar</span></asp:LinkButton></li>
      <li runat="server" id="liJobArchive"><asp:LinkButton ID="lnbArchivedJobs" runat="server" OnClick="lnbArchivedJobs_Click"><span>Ýlan Arþivi</span></asp:LinkButton></li>
    </ul>
  </div>