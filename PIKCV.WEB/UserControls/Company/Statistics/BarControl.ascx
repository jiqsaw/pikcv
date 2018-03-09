<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BarControl.ascx.cs" Inherits="UserControls_Company_Statistics_BarControl" %>

<table class="StatTable">
    <tr>
        <td align="right" style="width: 100px" rowspan="2">
            <p id="txtDescription" runat="server">
                Çalýþmýyor</p>
        </td>
        <td style="height: 16px">
            <div class="ChartHorizontalBar">
                <div id="divBar" runat="server" class="ChartBar" style="width: 80px">
                </div>
                &nbsp;<span style="color: rgb(153,153,153)" id="txtCount" runat="server"></span></div>
        </td>
    </tr>
    <tr>
        <td id="txtPercentage" runat="server">
            &nbsp;&nbsp; %38 &nbsp;<span style="color: rgb(153,153,153)" id="Span1" runat="server">(40 kiþi)</span></td>
    </tr>
</table>