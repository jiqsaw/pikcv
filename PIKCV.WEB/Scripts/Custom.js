function Pik(PageName) {
    location.href = 'Pikcv.aspx?Pik=' + PageName;
}

function ShowDate(ddl, Value) {
    if (ddl.options[ddl.selectedIndex].value==Value) { trDate.style.display='block'; } 
    else { trDate.style.display='none'; SetMinDate();}
}

function MM_openBrWindow(theURL,winName,features) { //v2.0
  var pen = window.open(theURL,winName,features);
  pen.focus();
}

function DateControl(ddlDay, ddlMonth, ddlYear) {
    var Day = document.getElementById(ddlDay).value;
    var Month = document.getElementById(ddlMonth).value;
    var Year = document.getElementById(ddlYear).value;
    
    if ((Day == "0") || (Month == "0") || (Year == "0")) { return false; }

    switch(Month)
    {
    case "02":
        if ((Day > 29) || ((Year % 4 != 0) && (Day == 29)))  {
            //alert("Lütfen Doğru Tarih Giriniz");
            return false;
        }

    case "04":
        if (Day > 30) {        
            //alert("Lütfen Doğru Tarih Giriniz");
            return false;
        }

    case "06":
        if (Day > 30) {        
            //alert("Lütfen Doğru Tarih Giriniz");
            return false;
        }        

    case "09":
        if (Day > 30) {        
            //alert("Lütfen Doğru Tarih Giriniz");
            return false;
        }  

    case "11":
        if (Day > 30) {        
            //alert("Lütfen Doğru Tarih Giriniz");
            return false;
        } 
        
    default:
        return true;
    break;
    }
}


function BeginTest(TestType) {
    var wpen = window.open('Test.aspx?TestType=' + TestType, 'PIKCVTest', 'toolbar=no,resizable, scrollbars');
    wpen.focus();
}

function MainJobsTabChange() {
    if (li1.className == 'TabActive') {
        li1.className = '';
        li2.className = 'TabActive'
        MainJobs1.style.display='none';
        MainJobs2.style.display='block';
    } else {
        MainJobs1.style.display='block';
        MainJobs2.style.display='none';
        li1.className = 'TabActive';
        li2.className = '';
    }
}

function OpenSaveFolder(FolderID) {
    var wpen = window.open('SaveFolder.aspx?FolderID=' + FolderID, 'PikcvKlasörKaydetme', 'width=300,height=210,toolbar=no');
    wpen.focus();
    return;
}

function OpenJobStatistics(JobID) {
    var wpen = window.open('JobStatistics.aspx?JobID=' + JobID, 'JobStatistic', 'width=550,height=700,toolbar=no, scrollbars');
    wpen.focus();
}

function OpenAddTemporaryUsers(FolderID) {
    var wpen = window.open('AddTemporaryUsers.aspx?FolderID=' + FolderID, 'PikcvGeçiciKlasörEkleme', 'width=340,height=340,toolbar=no');
    wpen.focus();
}

function OpenInsertInterview() {
    var wpen = window.open('InsertInterview.aspx', 'PikcvMülakataÇağır', 'width=550,height=500,toolbar=no');
    wpen.focus();
}

function CheckAll(Check, chID) {
    for (var i = theForm.elements.length; --i>=0;) {
        if (theForm.elements[i].id == chID) {
            theForm.elements[i].checked = Check;   
        }
    }
}

function OpenJobPreview(JobID) {
    window.open('JobDetail.aspx?JobID=' + JobID, 'JobPreview', 'toolbar=no, scrollbars, width=830, height=650'); 
    return;
}

function SendFriend(SendFriendType, ID) {
    var wpen = window.open('SendFriend.aspx?SendFriendType=' + SendFriendType + '&ID=' + ID, 'PIKCVSendFriend', 'toolbar=no,resizable, scrollbars, width=700, height=400');
    wpen.focus();
    return;
}

function OpenUserDetail(UserID) {
    window.open('UserDetail.aspx?UserID=' + UserID, 'UserDetail', 'toolbar=no, scrollbars, width=830, height=620'); 
    return;
}

function OpenPrivacy() {
    var wpen = window.open('Privacy.aspx', 'Gizlilik', 'width=800,height=570,toolbar=no');
    wpen.focus();
}

function OpenConfirm(Code, ArgID, ArgStr) {
    var wpen;
    var bURL = 'Confirm.aspx?Code=' + Code + '&ArgID=' + ArgID + '&ArgStr=' + ArgStr;
    var bTitle = 'Confirm';
    var bWidth = 450;
    var bHeight = 182;
    
    if (navigator.appName.indexOf("Microsoft") != -1) {
        var Return = window.showModalDialog(bURL,bTitle,"dialogWidth: "+bWidth+"px; dialogHeight: "+bHeight+"px; center: Yes; status: No; help: No; scroll: no;");    
        if (Return.IsReload != null) { 
            if (Return.IsReload == 1) { window.location.reload(); }
        }
    }
    else {
        wpen = window.open(bURL, bTitle, 'width=' + bWidth + ',height=' + bHeight + ',toolbar=no');
        wpen.focus();
    }
    return;
}

function OpenCloseOther(OtherID, ddlID, dvOtherID) {
    if (ddlSelectedValue(ddlID) == OtherID) { $get(dvOtherID).style.display='block'; }
    else $get(dvOtherID).style.display='none';
}