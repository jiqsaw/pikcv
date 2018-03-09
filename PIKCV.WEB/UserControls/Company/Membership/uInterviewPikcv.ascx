<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uInterviewPikcv.ascx.cs" Inherits="UserControls_Company_Membership_uInterviewPikcv" %>
<%@ Register Src="~/UserControls/Company/Search/SearchResults/uRightMenuTop.ascx" TagName="uRightMenuTop" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/Employee/Membership/uInterviewPikcv.ascx" TagName="uInterviewPikcv" TagPrefix="uc3" %>

<uc1:uRightMenuTop ID="URightMenuTop1" runat="server" />
<br />
<uc3:uInterviewPikcv ID="UInterviewPikcv" runat="server" />