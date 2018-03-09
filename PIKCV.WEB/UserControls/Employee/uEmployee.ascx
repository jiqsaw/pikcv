<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uEmployee.ascx.cs" Inherits="UserControls_Employee_uEmployee" %>
<%@ Register Src="Common/uMainJobs.ascx" TagName="uMainJobs" TagPrefix="uc2" %>
<%@ Register Src="Common/uTeaser.ascx" TagName="uTeaser" TagPrefix="uc1" %>
<uc1:uTeaser ID="UTeaser1" runat="server" />
<uc2:uMainJobs id="UMainJobs1" runat="server" />