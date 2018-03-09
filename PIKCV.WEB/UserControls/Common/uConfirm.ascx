<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uConfirm.ascx.cs" Inherits="UserControls_Common_uConfirm" %>

<script type="text/javascript">
    function Cancel() {
        if (navigator.appName.indexOf("Microsoft") != -1)  {; 
            var vReturnValue = new Object();
            vReturnValue.IsReload = 1;
            window.returnValue = vReturnValue;
        }
        else window.opener.location.reload(); 
        window.close();
    }
</script>

<asp:Panel ID="pnlModal" runat="server">
    <table id="TableBack">
	<tr>
		<td valign="top">

			<table width="100%">
			<tr>
				<td class="Header">
				
				    <asp:Panel ID="pnlHeader" runat="server">
					    <table align="center" width="92%">
					    <tr>
						    <td align="left">
						        <asp:Label runat="server" id="lblTitle" CssClass="HeaderText" /></td>
						    <td align="right">
							    <asp:image Visible="false" runat="server" id="imgClose" ImageUrl="~/UserControls/Common/ModalPopup/Images/Close.gif"></asp:image></td>
					    </tr>
					    </table>
					</asp:Panel>
					
				</td>
			</tr>
			<tr>
				<td>
				    <br />	
					<table runat="server" id="tblConfirm" align="center" width="90%">
					<tr>
						<td align="center" width="60">
							<asp:image runat="server" ID="imgIcon" ImageUrl="~/UserControls/Common/ModalPopup/Images/alert.png"></asp:image></td>
						<td align="left">
						    <div id="dvMessage" class="MessageText" runat="server"></div>
                        </td>
					</tr>
					<tr>
						<td colspan="2" align="right">
							<asp:Button CausesValidation="False" runat="server" CssClass="btnOK" id="btnOK" OnClick="btnOK_Click" Text="Evet"></asp:Button>
							<input type="button" class="btnOK" title="Hayýr" value="Hayýr" onclick="self.close();" />
						</td>
					</tr>
					</table>
					
					<table visible="false" runat="server" id="tblFinish" align="center" width="90%">
					<tr>
						<td>
						    <div id="dvMessageFinish" class="MessageText" runat="server"></div>
                        </td>
					</tr>
					<tr>
						<td colspan="2" align="right">
							<input visible="false" type="button" class="btnOK" title="Tamam" value="Tamam" onclick="Cancel()" />
						</td>
					</tr>					
					</table>					
					
					<br />
				</td>
			</tr>
			</table>
		</td>
	</tr>
</table>
</asp:Panel>