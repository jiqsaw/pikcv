<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs
        CARETTA.COM.Mailing objMail = new CARETTA.COM.Mailing();

        Exception ex = Server.GetLastError().GetBaseException();
        string msgBody = ex.ToString();    
        
        objMail.Send_SimpleHtml("burak.ucakan@caretta.net", "burak.ucakan@caretta.net", "pikcv hata maili", msgBody, "", "", System.Net.Mail.MailPriority.High, "burak.ucakan@caretta.net", "burakcaretta1");
    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started
    }

    void Session_End(object sender, EventArgs e)
    {
        if ((Session["MemberType"] != null) && (Session["UserID"] != null))
        {
            PIKCV.COM.EnumDB.MemberTypes MemberType = (PIKCV.COM.EnumDB.MemberTypes)((int)Session["MemberType"]);
            int MemberID;
            if (MemberType == PIKCV.COM.EnumDB.MemberTypes.Company) {
                MemberID = Convert.ToInt32(Session["CompanyID"]);
            }
            else { MemberID = Convert.ToInt32(Session["UserID"]); }
            Application.Remove(Session["MemberType"].ToString() + "||" + Session["UserID"].ToString());
        }
    }
       
</script>
