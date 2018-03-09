<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uTestResults.ascx.cs" Inherits="UserControls_Company_Membership_uTestResults" %>
<%@ Register Src="~/UserControls/Company/Search/SearchResults/uRightMenuTop.ascx" TagName="uRightMenuTop" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/Employee/Membership/uTestResults.ascx" TagName="uTestResults" TagPrefix="uc3" %>

<uc1:uRightMenuTop ID="URightMenuTop1" runat="server" />
<br />
<uc3:uTestResults ID="UTestResults1" runat="server" />