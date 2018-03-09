<%@ Control Language="C#" AutoEventWireup="true" CodeFile="uTest.ascx.cs" Inherits="UserControls_Employee_Membership_Test_uTest" %>

<script type="text/javascript">

    var QuestionCount = 30;
    var ActiveQuestion = 1;
    var PrevQuestion = 0;
    var PrevQuestionClass = '';
    var arrAnswers = new Array(31);
    var hdAnswerID = '<%=hdAnswers.ClientID %>';
    
    for (i=1;i<=QuestionCount;i++) { arrAnswers[i] = -1; }

    function ShowHideDv(QuestionNo) {
        if (QuestionNo>QuestionCount) { QuestionNo = 30; }
        for (i=1; i<=QuestionCount; i++) {
            document.getElementById('dv' + i).style.display = 'none';
            if (i==PrevQuestion) {
                document.getElementById('dvLink' + i).className = PrevQuestionClass;
            }
        }
        
        PrevQuestion = QuestionNo;
        PrevQuestionClass = document.getElementById('dvLink' + QuestionNo).className;
        
        document.getElementById('dv' + QuestionNo).style.display = 'block';
        document.getElementById('dvLink' + QuestionNo).className = 'selected';
        
        ActiveQuestion = QuestionNo;
    }
    
    function SetAnswer(QuestionNo, AnswerValue) {
        var NextQuestion = QuestionNo + 1;
        if (AnswerValue != -1) {
            arrAnswers[QuestionNo] = AnswerValue;
        }
        
        ShowHideDv(QuestionNo + 1);
        NavigasyonClasses();
    }
    
    function NavigasyonClasses() {
        for (i=1; i<=QuestionCount; i++) {
            if ((i != ActiveQuestion) && (arrAnswers[i] != "-1")) {
                document.getElementById('dvLink' + i).className = 'answered';
            }
        }
    }

    function TestFinish(Expired) {
        if (!Expired) {
            if (!(confirm("Testi Bitirmek Ýstediðinizden Emin misiniz?"))) {
                return false;
            }
        }
        JsToHidden();
    }
    
    function JsToHidden() {
        var strAnswers = "";
        for (i=1;i<=QuestionCount;i++) { 
            strAnswers += arrAnswers[i] + ",";
        }
        document.getElementById(hdAnswerID).value = Left(strAnswers, strAnswers.length - 1)
    }

</script>

<!-- KRONOMETRE -->
<script type="text/javascript">
    function Display() 
    { 
        rtime = etime - ctime; 
        if (rtime>60) m=parseInt(rtime/60); 
        else m=0; 

        s=parseInt(rtime - m * 60); 

        if(s<10) s = "0" + s ;

        //window.status = m + ":" + s 
        aTime.innerText = m + ":" + s ;
        window.setTimeout("CheckTime()",1000);
    }

    function SetTimes()
    { 
        //alert("Süreniz 30 Dakikadýr Ýyi Þanslar") 
        var time = new Date(); 
        hours = time.getHours(); 
        mins = time.getMinutes(); 
        secs = time.getSeconds(); 
        etime=hours * 3600 + mins * 60 + secs; 
        etime+=1800; //30 Dakika [Saniye Cinsinden] 
        CheckTime(); 
    }

    function CheckTime() 
    { 
        var time= new Date(); 
        hours = time.getHours(); 
        mins = time.getMinutes(); 
        secs = time.getSeconds(); 
        ctime=hours * 3600 + mins * 60 + secs 
        
        if (ctime>=etime) Expired(); 
        else  Display(); 
    }

    function Expired() 
    {
        TestFinish(true);
        theForm.submit();
    } 
</script>
<!---------------->

<asp:Panel runat="server" ID="pnlTest">

    <div class="testMsg">
    <%-- <p class="floatRight">Soru: <strong>14 / 30</strong></p> --%>
    <p>Kalan süre: <strong>
    <span id="aTime"></span>
    <%--<a id="aTime"></a>--%></strong></p>
    <div class="brclear"></div>
  </div>
  
    <div class="BoxPadder">
      <div class="ContentColA">
        <table class="TestQuestionsNav">
            <tr>
                <td>
                    <p>Test sorularýnýz:</p>

                    <asp:Literal runat="server" ID="ltlNav"></asp:Literal>

                    <div class="brclear"></div>
                </td>
            </tr>
        </table>
        <img alt="" src="Images/misc/test_legend.png" />
      </div>
      
      <div class="ContentColB3" style="text-align: center; padding-top: 15px;">
      
        <div runat="server" id="dvGenerateHTML"></div>

      </div>
      
      <p style="float: right;">
        <asp:ImageButton OnClientClick="return TestFinish(false);" runat="server" ID="ImgBtnTestFinish" ImageUrl="~/Images/buttons/TestFinish.png" />
      </p>
      
      <div class="brclear"></div>
    </div>
    
    <asp:HiddenField runat="server" ID="hdQuestions" />
    <asp:HiddenField runat="server" ID="hdAnswers" />

</asp:Panel>

<%--<br />
<asp:Repeater runat="server" ID="rptReport">
<HeaderTemplate>
<table cellpadding="2" cellspacing="2" width="100%">
</HeaderTemplate>
<ItemTemplate>
    <tr>
        <td>
         <br />
        Grup Adý: <%#Eval("GroupName")%></td>
        <td>soru: <%#Eval("Question") %></td>
    </tr>
</ItemTemplate>
<SeparatorTemplate>
    <tr>
        <td colspan="2" height="30"><hr /></td>
    </tr>
</SeparatorTemplate>
<FooterTemplate>
</table>
</FooterTemplate>
</asp:Repeater>--%>

<script type="text/javascript">

    ShowHideDv('1'); //Ýlk soruyu aktifleþtir
    SetTimes();     //Sayacý Baþlat
</script>