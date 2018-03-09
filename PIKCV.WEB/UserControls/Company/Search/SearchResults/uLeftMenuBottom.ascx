<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uLeftMenuBottom.ascx.cs" Inherits="UserControls_Company_Search_SearchResults_uLeftMenuBottom" %>

    <div class="p7ABtrig">
        <h4><a href="javascript:;" id="p7ABt2_2">Kayýtlý Filtreler</a></h4>
    </div>
    <div id="p7ABw2_2">
        <div id="p7ABc2_2" class="p7ABcontent">
            <ul class="ResultsNav">
                <asp:Repeater runat="server" ID="rptFilters" OnItemCommand="rptFilters_ItemCommand">
                    <ItemTemplate>
                        <li>
                            <asp:LinkButton runat="server" ID="lnkFilterName" CssClass="detailLink" CommandName="Detail"
                                CommandArgument='<%#DataBinder.Eval(Container.DataItem, "FilterID") %>' Text='<%#DataBinder.Eval(Container.DataItem, "FilterName") %>'></asp:LinkButton>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
    </div>

    </div>

<script type="text/javascript">
    P7_opAB(2,1,1,1,1);
</script>