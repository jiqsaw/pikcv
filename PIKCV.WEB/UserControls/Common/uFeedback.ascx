<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uFeedback.ascx.cs" Inherits="UserControls_Common_uFeedback" %>
<div class="contentPad">
    <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">
            <asp:Literal runat="server" ID="ltlTitle"></asp:Literal> </h2>
    </div>
    <div class="brclear"></div>
    
    <!-- start roundcornered box -->
    <div class="BoxContentTop"></div>
    <div class="BoxContent">
        <div class="BoxPadder">
            <div class="TemplateContent">
                <asp:Literal runat="server" ID="ltlMessage">
                </asp:Literal>
                <p>&nbsp;</p><p>&nbsp;</p>
            </div>
        </div>
        <div class="brclear"></div>
    </div>
    
</div>

<div class="BoxContentBottom"></div>

<!-- finish roundcornered box -->
<p>
    &nbsp;</p>