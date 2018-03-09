<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uLeftMenuTop.ascx.cs" Inherits="UserControls_Company_Search_SearchResults_uLeftMenuTop" %>
  

  
	<div class="SignupBtn">
	    <asp:ImageButton runat="server" ID="btnHomePage" ImageUrl="~/Images/buttons/corp_go_home.png" 
	    BorderWidth="0" OnClick="btnHomePage_Click" />
	</div>

	<div id="p7ABW2" class="p7AB" style="width:202px;">

    <div class="p7ABtrig">
        <h4><a href="javascript:;" id="p7ABt2_1">Arama sonucu</a></h4>
      </div>
    <div id="p7ABw2_1">
        <div id="p7ABc2_1" class="p7ABcontent" style="padding-bottom:5px;">
		<p>Yaptýðýnýz aramaya uygun<br />toplam &nbsp; <asp:Label ID="lblEmployeeCount" runat="server" Text="" Font-Bold="True"></asp:Label> &nbsp; bulundu.</p>
		

		    <ul class="FamLinks">
		        <li>
		            <input type="checkbox" id="chSelectAll" onclick="CheckListAll()" />
		            <a href="javascript:CheckListAll(true)">Tümünü Seç</a>
			    </li>
		    </ul> 
          <div id="dvResultList" class="CandidateResultList">         
            <ul>
<%--                <asp:Repeater ID="rptEmployees" runat="server" OnItemCommand="rptEmployees_ItemCommand" OnItemDataBound="rptEmployees_ItemDataBound">
                    <ItemTemplate>
                        <li id='liItem<%#DataBinder.Eval(Container.DataItem, "UserID") %>'>
                            <asp:CheckBox ID="CheckBox" runat="server"/>
                            <asp:LinkButton ID="lbEmployees" runat="server" CommandName="Select">
                            <%#DataBinder.Eval(Container.DataItem, "UserName") %>
                            </asp:LinkButton>
                            
                            <asp:Literal Visible="false" runat="server" ID="ltlRate" Text='<%#DataBinder.Eval(Container.DataItem, "Rate","({0})") %>'></asp:Literal>
                             
                            <asp:Literal runat="server" ID="ltlUserID" Text='<%#DataBinder.Eval(Container.DataItem, "UserID") %>' Visible="false"></asp:Literal>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>--%>
                
                <asp:Repeater ID="rptEmployees" runat="server" OnItemDataBound="rptEmployees_ItemDataBound" OnItemCommand="rptEmployees_ItemCommand">
                    <ItemTemplate>
                        <li id='liItem<%#DataBinder.Eval(Container.DataItem, "UserID") %>'>
                            <asp:CheckBox ID="CheckBox" runat="server"/>
                            
                            <asp:LinkButton ID="lbEmployees" runat="server" CommandName="Select"
                            CommandArgument='<%#DataBinder.Eval(Container.DataItem, "UserID") %>'>
                            <%#DataBinder.Eval(Container.DataItem, "UserName") %>
                            </asp:LinkButton>

                            <asp:Literal Visible="false" runat="server" ID="ltlRate" Text='<%#DataBinder.Eval(Container.DataItem, "Rate","({0})") %>'></asp:Literal>
                             
                            <asp:Literal runat="server" ID="ltlUserID" Text='<%#DataBinder.Eval(Container.DataItem, "UserID") %>' Visible="false"></asp:Literal>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
                                
            </ul>
          </div>

			<ul class="FamLinks">
                <asp:DropDownList ID="ddlCompanyFolders" runat="server" ValidationGroup="vgSelectFolder"></asp:DropDownList>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="SingleParagraph"
                    ShowMessageBox="True" ShowSummary="False" ValidationGroup="vgSelectFolder" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlCompanyFolders"
                    CssClass="Error" Display="None" ErrorMessage="Lütfen klasör seçiniz" InitialValue="0"
                    ValidationGroup="vgSelectFolder"></asp:RequiredFieldValidator><li class="SendToFile">
				    <asp:LinkButton ID="SendToFolder" runat="server" OnClick="SendToFolder_Click" ValidationGroup="vgSelectFolder">Seçili Klasöre Gönder</asp:LinkButton>
				</li>
				<li class="Buy"><asp:LinkButton ID="lbBuyContactInfo" runat="server" OnClick="lbBuyContactInfo_Click">Ýletiþim Bilgisini Satýn Al</asp:LinkButton></li>
				<li class="Interview">
				     <asp:LinkButton ID="lbInterview" runat="server" OnClick="lbInterview_Click">Mülakata Çaðýr</asp:LinkButton>
                </li>
                <li class="SendMessage">
                    <asp:LinkButton ID="lbSendMessage" runat="server" OnClick="lbSendMessage_Click">Mesaj Gönder</asp:LinkButton>
                </li>
				<li class="Search">
				    <asp:HyperLink runat="server" ID="hlAgainSearch">
				    Tekrar ara...
				    </asp:HyperLink>
				</li>
			</ul>
        </div>
      </div>
      
<script type="text/javascript">
    function SetClass(UserID) {
        $get('liItem' + UserID).className='selected';
    }
</script>

<div id="dvScript" runat="server"></div>

<script type="text/javascript">
function CheckListAll(IsLink) {
    
    var IsCheck = $get('chSelectAll');
    if (IsLink) { 
        if (IsCheck.checked) IsCheck.checked = false;
        else IsCheck.checked = true;
    }

    var chPanel = $get('dvResultList');
    var chPanel = chPanel.getElementsByTagName("input");
    for (i=0; i<chPanel.length; i++) {
        if (Right(chPanel[i].id, 8) == "CheckBox") {
               chPanel[i].checked = IsCheck.checked;
        }
    }
}
</script>  