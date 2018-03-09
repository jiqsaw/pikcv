<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uDate.ascx.cs" Inherits="UserControls_Common_uDate" %>

 <script type="text/javascript"> 
function cvDateControl(source, args) 
{   
    args.IsValid = false;
    
    var ddlDayID = '<%=ddlDays.ClientID %>';
    var ddlMonthID = '<%=ddlMonths.ClientID %>';
    var ddlYearID = '<%=ddlYears.ClientID %>';
    
    if (DateControl(ddlDayID, ddlMonthID, ddlYearID)) { args.IsValid = true; }
}

function SetMinDate() {
    var ddlDayID = '<%=ddlDays.ClientID %>';
    var ddlMonthID = '<%=ddlMonths.ClientID %>';
    var ddlYearID = '<%=ddlYears.ClientID %>';
    document.getElementById(ddlDayID).options[1].selected = true;
    document.getElementById(ddlMonthID).options[1].selected = true;
    document.getElementById(ddlYearID).options[1].selected = true;
}
</script>

<asp:DropDownList runat="server" ID="ddlDays"></asp:DropDownList>
<asp:DropDownList runat="server" ID="ddlMonths"></asp:DropDownList>
<asp:DropDownList runat="server" ID="ddlYears"></asp:DropDownList>

<asp:CustomValidator ID="CustomValidatorDate" runat="server" Display="dynamic" 
ClientValidationFunction="cvDateControl" ValidationGroup="vgForm"  
ErrorMessage="Lütfen Düzgün Tarih Seçiniz" CssClass="Error">
</asp:CustomValidator>
                 