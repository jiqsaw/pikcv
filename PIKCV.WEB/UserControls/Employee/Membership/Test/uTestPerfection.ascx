<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uTestPerfection.ascx.cs" Inherits="UserControls_Employee_Membership_Test_uTestPerfection" %>

<script type="text/javascript">

    var arrAnswers = new Array(37);
    var hdAnswerID = '<%=hdAnswers.ClientID %>'
    
    function SetAnswer() {
        var ddlPoint;
        for (i=1;i<=36;i++) {
            ddlPoint = document.getElementById('ddlPoint|' + i);
            arrAnswers[i] = ddlPoint.options[ddlPoint.selectedIndex].value;
        }
    }

    function JsToHidden() {
        var strAnswers = "";
        for (i=1;i<=36;i++) { 
            strAnswers += arrAnswers[i] + ",";
        }
        document.getElementById(hdAnswerID).value = Left(strAnswers, strAnswers.length - 1)
    }
    
    function TestFinish() {
//        if (!(confirm("Testi Bitirmek Ýstediðinizden Emin misiniz?"))) {
//            return false;
//        }
        SetAnswer();
        JsToHidden();
    }
    
    function IsSelected(StartNo) {
        var value1 = ddlSelectedValue('ddlPoint|' + StartNo);
        var value2 = ddlSelectedValue('ddlPoint|' + (StartNo + 1));
        var value3 = ddlSelectedValue('ddlPoint|' + (StartNo + 2));
        var value4 = ddlSelectedValue('ddlPoint|' + (StartNo + 3));
        var value5 = ddlSelectedValue('ddlPoint|' + (StartNo + 4));
        var value6 = ddlSelectedValue('ddlPoint|' + (StartNo + 5));
        if ((value1 == value2) || (value1 == value3) || (value1 == value4) || (value1 == value5) || (value1 == value6)) {
            return false;
        }
        if ((value2 == value3) || (value2 == value4) || (value2 == value5) || (value2 == value6)) {
            return false;
        }
        if ((value3 == value4) || (value3 == value5) || (value3 == value6)) {
            return false;
        }
        if ((value4 == value5) || (value4 == value6)) {
            return false;
        }
        if ((value5 == value6)) {
            return false;
        }
        return true;
    }
    
    function PointValidation(FocusNo, StatementNo) {
        var StartNo = (FocusNo-1);
        var EndNo = (FocusNo-6);
        
        for (i=StartNo;i>=EndNo;i--) {
            if (ddlSelectedValue('ddlPoint|' + i)==0) {
                alert('Lütfen her ifadeye puan veriniz');
                return false;
            }
        }

        if (!IsSelected(EndNo)) {
            alert('Lütfen her ifadeye AYRI puanlar veriniz');
            return false;
        }
    
        ShowHideTr(StatementNo);
    }

    function ShowHideTr(StatementNo) {
        $get('trStatement' + StatementNo).style.display='none';
        if (StatementNo < 6) $get('trStatement' + (StatementNo + 1)).style.display='block';
        else { TestFinish(); theForm.submit(); } //pFinish.style.display='block';
    }

</script>

<asp:Panel runat="server" ID="pnlTest">

    <div class="testMsg">
        <p>
            Lütfen aþaðýdaki gruplardaki tüm ifadeleri dikkatlice okuyunuz. 
            Bu 6 ifadeyi sizi ne ölçüde tanýmladýklarýna göre 6 ve 1 puan arasýnda deðerlendiriniz. 
            Her ifade grubunda sizin davranýþ biçimini en iyi yansýttýðýný düþündüðünüze 6 puan, 
            en az yansýttýðýný düþündüðünüze 1 puan veriniz. 
            Geriye kalan puanlarý (2, 3, 4, 5) sizin davranýþlarýnýzý yansýtma durumunuza göre her ifadeye daðýtýnýz. 
            Her bir puaný <b>sadece bir kez</b> kullanýnýz.        
        </p>
        <div class="brclear"></div>
    </div>
  
    <div class="BoxPadder" style="text-align: center; padding-top: 30px;">
    
        <div class="ContentColB3">

            <asp:Repeater runat="server" ID="rptTest" OnItemDataBound="rptTest_ItemDataBound">
                <HeaderTemplate>
                    <table width="90%" class="FormTable" style="text-align: left;">
                </HeaderTemplate>
                <ItemTemplate>
				    <tr id='trStatement<%=this.StatementNo%>' style="display: none;">
				        <td>
					        <strong><asp:Literal runat="server" ID="ltlGroupName"></asp:Literal>
					        <asp:Literal runat="server" ID="ltlGorupNO" Visible="false"
					        Text='<%#DataBinder.Eval(Container.DataItem, "PerfectionID") %>'></asp:Literal>
					        :</strong>				        
				            <asp:Repeater runat="server" ID="rptStatement">
				            <HeaderTemplate>
						        <table width="100%" cellpadding="2" cellspacing="2">
						    </HeaderTemplate>
						    <ItemTemplate>
						        <tr>
							        <td> <%#DataBinder.Eval(Container.DataItem, "Statement") %> </td>
							        <td> 
							            <select id='ddlPoint|<%=this.ddlNo%>'>
							            <option value="0">Puan</option>
							            <option value="1">1</option>
							            <option value="2">2</option>
							            <option value="3">3</option>
							            <option value="4">4</option>
							            <option value="5">5</option>
							            <option value="6">6</option>
							            </select>
							            <% this.ddlNo++; %>
							        </td>
							    </tr>
							</ItemTemplate>
							<FooterTemplate>
						        </table>
						    </FooterTemplate>
						    </asp:Repeater>
						    <p style="float: right;"><br />
						        <img style="cursor: pointer;" 
						        onclick="PointValidation(<%=this.ddlNo%>, <%=this.StatementNo%>);"
						        alt="" src='Images/buttons/save.png' width='113' height='27' /></p>
						<% this.StatementNo++; %>
				        </td>
				    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
			
        </div>
    
        <div class="brclear"></div> 
        
        <p id="pFinish" style="float: right; display: none;">
            
            <asp:ImageButton OnClientClick="TestFinish();" OnClick="ImgBtnTestFinish_Click"
            runat="server" ID="ImgBtnTestFinish" ImageUrl="~/Images/buttons/TestFinish.png" /></p>

           <br /><br />
    </div>
    
    <asp:HiddenField runat="server" ID="hdQuestions" />
    <asp:HiddenField runat="server" ID="hdAnswers" />
    
</asp:Panel>

<script type="text/javascript">
    $get('trStatement1').style.display='block';
</script>