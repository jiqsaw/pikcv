<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uCVPreview.ascx.cs" Inherits="UserControls_Company_Membership_uCVPreview" %>
<%@ Register Src="~/UserControls/Company/Search/SearchResults/uRightMenuTop.ascx" TagName="uRightMenuTop" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/Employee/Membership/uCVPreview.ascx" TagName="uCVPreview" TagPrefix="uc3" %>

<uc1:uRightMenuTop ID="URightMenuTop1" runat="server" />
<br />
<uc3:uCVPreview ID="UCVPreview1" runat="server" />