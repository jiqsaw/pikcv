<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uNotification.ascx.cs" Inherits="UserControls_Employee_Common_uNotification" %>
<asp:Panel ID="pnlNotification" runat="server" CssClass="alertMsg">
        <asp:Panel runat="server" ID="pnlCVCtrl" Visible="false">
            <p> <strong> 
                <asp:Literal runat="server" ID="ltlCVCtrlTitle"></asp:Literal> </strong><br />
                <asp:Literal runat="server" ID="ltlCVCtrlMessage"></asp:Literal>
            </p>  <br />
        </asp:Panel>    
        <asp:Panel runat="server" ID="pnlActualCtrl" Visible="false">
            <p> <strong> 
                <asp:Literal runat="server" ID="ltlActualTitle"></asp:Literal> </strong><br />
                <asp:Literal runat="server" ID="ltlActualMessage"></asp:Literal> <br />
                
                <a href="#Employee-Membership-CV">
                <asp:Image runat="server" ID="ImgYes" ImageUrl="~/Images/buttons/yes.png" AlternateText="Evet" /></a>
                <asp:ImageButton runat="server" ID="ImgBtnCvModify" ImageUrl="~/Images/buttons/cv_modify.png" AlternateText="Hayýr, CV'im günceldir." OnClick="ImgBtnCvModify_Click" />
          
            </p> <br />
        </asp:Panel>
        <asp:Panel runat="server" ID="pnlTestCtrl" Visible="false">
            <p> <strong> 
                <asp:Literal runat="server" ID="ltlTestTitle"></asp:Literal> </strong><br />
                <asp:Literal runat="server" ID="ltlTestMessage"></asp:Literal>
            </p>  <br />
        </asp:Panel>
        <asp:Panel runat="server" ID="pnlCVActive" Visible="false">
            <p> <strong> 
                <asp:Literal runat="server" ID="ltlCVActiveTitle"></asp:Literal> </strong><br />
                <asp:Literal runat="server" ID="ltlCVActiveMessage"></asp:Literal> 
            </p>
        </asp:Panel>        
    </asp:Panel>