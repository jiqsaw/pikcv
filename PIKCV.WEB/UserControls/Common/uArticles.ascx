<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uArticles.ascx.cs" Inherits="UserControls_Common_uArticles" %>

<div class="BoxBlueGradient">
    <div class="BoxPadder">
        <div class="HeaderPR">
            <h3 class="sIFRHeader"> Makaleler </h3>
        </div>
        
        <asp:Repeater runat="server" ID="rptTopArticles">
        <ItemTemplate>
            <p class="articleHeader">
                <asp:HyperLink runat="server" ID="hlArticleDetail" 
                Text='<%#DataBinder.Eval(Container.DataItem, "ArticleAbstract") %>'
                NavigateUrl='<%#DataBinder.Eval(Container.DataItem, "ArticleID", "#Common-ArticleDetail&ArticleID={0}") %>' />
            </p>
        </ItemTemplate>
        </asp:Repeater>
        
        <p>
            <asp:HyperLink CssClass="detailLink" runat="server" ID="hlAllArticles" NavigateUrl="#Common-ArticlesAll">Tüm makaleler</asp:HyperLink>
        </p>
    </div>
</div>
<div class="BoxBlueGradientShadow"></div>