<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uUserInfo.ascx.cs" Inherits="UserControls_Company_Membership_uUserInfo" %>
<%@ Register Src="~/UserControls/Company/Search/SearchResults/uRightMenuTop.ascx" TagName="uRightMenuTop" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/Employee/Membership/uUserInfo.ascx" TagName="uUserInfo" TagPrefix="uc3" %>

<uc1:uRightMenuTop ID="URightMenuTop1" runat="server" />
<br />
<uc3:uUserInfo ID="uUserInfo1" runat="server" />