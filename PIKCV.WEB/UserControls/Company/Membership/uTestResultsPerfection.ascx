<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uTestResultsPerfection.ascx.cs" Inherits="UserControls_Company_Membership_uTestResultsPerfection" %>
<%@ Register Src="~/UserControls/Company/Search/SearchResults/uRightMenuTop.ascx" TagName="uRightMenuTop" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/Employee/Membership/uTestResultsPerfection.ascx" TagName="uTestResultsPerfection" TagPrefix="uc3" %>

<uc1:uRightMenuTop ID="URightMenuTop1" runat="server" />
<br />
<uc3:uTestResultsPerfection ID="UTestResultsPerfection1" runat="server" />