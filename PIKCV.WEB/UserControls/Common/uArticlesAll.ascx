<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uArticlesAll.ascx.cs"
    Inherits="UserControls_Common_uArticlesAll" %>
<%@ Register Src="uPaging.ascx" TagName="uPaging" TagPrefix="uc1" %>
<div class="contentPad">
    <div class="HeaderPR floatLeft">
        <h2 class="sIFRHeader">
            Makaleler</h2>
    </div>
    <div class="brclear">
    </div>
    <!-- start roundcornered box -->
    <div class="BoxContentTop">
    </div>
    <div class="BoxContent">
        <div class="BoxPadder">
            <asp:Repeater ID="rptArticles" runat="server">
                <ItemTemplate>
                    
                        <div class="ArticleItem">

                            <h6>
                                <span class="mute">
                                (<asp:Label ID="lblDate" runat="server" Text='<%# String.Format("{0:d}", DataBinder.Eval(Container.DataItem, "ModifyDate"))%>'></asp:Label>)
                                </span>
                                <asp:HyperLink runat="server" ID="hlTitle" Text='<%#DataBinder.Eval(Container.DataItem, "ArticleAbstract") %>'
                                    NavigateUrl='<%#DataBinder.Eval(Container.DataItem, "ArticleID", "#Common-ArticleDetail&ArticleID={0}") %>' />
                            </h6>
                            
                            <p style="display: none;">
                                <asp:Literal ID="ltlArticleBody" runat="server" Text='<%#CARETTA.COM.Util.Left(CARETTA.COM.Util.ClearHtmlTags(DataBinder.Eval(Container.DataItem, "ArticleBody").ToString()), 200) + "..."%>'></asp:Literal>
                            </p>
                            <p class="floatRight" style="display: none;">
                                <asp:HyperLink runat="server" ID="HyperLink1" Text="Devamý..." NavigateUrl='<%#DataBinder.Eval(Container.DataItem, "ArticleID", "#Common-ArticleDetail&ArticleID={0}") %>' /></p>
                        </div>
                        <div class="hr"><hr /></div>
                </ItemTemplate>
            </asp:Repeater> 
        </div>
    </div>   
    <uc1:uPaging ID="UPaging1" runat="server" />
</div>

