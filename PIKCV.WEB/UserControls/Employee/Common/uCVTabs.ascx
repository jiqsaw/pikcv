<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uCVTabs.ascx.cs" Inherits="UserControls_Employee_Common_uCVTabs" %>

  <div id="Tab">
    <ul>
      <li runat="server" id="liUserInfo"><a id="tdPersonelInfo" href="#Employee-Membership-UserInfo&esr=1"><span>Kiþisel Bilgiler</span></a></li>
      <li runat="server" id="liCV"><a href="#Employee-Membership-CV&esr=1"><span>Özgeçmiþ Bilgileri</span></a></li>
      <li runat="server" id="liPhoto"><a href="#Employee-Membership-CV-PersonalPhoto&esr=1"><span>Fotoðraf Ekleme</span></a></li>
      <li runat="server" id="liCVOutput"><a id="tdCV" href="#Employee-Membership-CVPreview&esr=1"><span>Özgeçmiþ Önizleme</span></a></li>
      <li runat="server" id="liPikInterview"><a id="tdPikInterview" href="#Employee-Membership-PikInterview&esr=1"><span>Pikcv Mülakatlarý</span></a></li>
      <li runat="server" id="liTest"><a href="#Employee-Membership-Tests&esr=1"><span>Testler</span></a></li>
      <li runat="server" id="liTestResults"><a id="dtTestResults" href="#Employee-Membership-TestResults&esr=1"><span>Test Sonuçlarý</span></a></li>
    </ul>
  </div>
  
<script type="text/javascript">
function TabLinkEsrReplace(IsEsr, IsCompany, IsTemporaryUser) {
    var tds = document.getElementsByTagName("a");
    for (var i = tds.length; --i >= 0;) {
       var td = tds[i];
       if (IsTemporaryUser)
       {
            if (td.id == 'tdPersonelInfo') td.href = '../TemporaryUsers/TemporaryUsersUserInfo.aspx';
            else if (td.id == 'tdCV') td.href = '../TemporaryUsers/TemporaryUsersCVPreview.aspx';
            else if (td.id == 'tdPikInterview') td.href = '../TemporaryUsers/temporaryUsersInterviewPikcv.aspx';
            else if (td.id == 'dtTestResults') td.href = '../TemporaryUsers/TemporaryUsersTestResults.aspx';
       }
       else
       {
        if (IsEsr) td.href = td.href.replace('&esr=1','');
        if (IsCompany) td.href = td.href.replace('Employee-','Company-');
       }
       
    }
}
</script> 

<div id="dvScript" runat="server">

</div>