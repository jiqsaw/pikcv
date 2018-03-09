using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Drawing;
using PIKCV.BUS;

public partial class UserControls_Common_uImageUpload : BaseUserControl
{
    public delegate void ImageUploadedDelegate(string ImageURL);
    public delegate void ImageTooSmallDelegate();

    public event ImageUploadedDelegate ImageUploaded;
    public event ImageTooSmallDelegate ImageTooSmall;

    public bool RaiseEvents
    {
        get
        {
            if (ViewState["RE"] == null)
            {
                ViewState.Add("RE", false);
            }
            return (bool)ViewState["RE"];
        }
        set { ViewState.Add("RE", value); }
    }

    public PIKCV.COM.Enumerations.ImageSaveType ImageSaveType
    {
        get
        {
            return (ViewState["Ist"] == null ? PIKCV.COM.Enumerations.ImageSaveType.EmployeeBig : (PIKCV.COM.Enumerations.ImageSaveType)(ViewState["Ist"]));
        }
        set
        {
            ViewState["Ist"] = value;
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            switch (this.cookPageType)
            {
                case PIKCV.COM.Enumerations.PageType.Employee:
                    this.ImageSaveType = PIKCV.COM.Enumerations.ImageSaveType.EmployeeBig;
                    break;
                case PIKCV.COM.Enumerations.PageType.Company:
                    this.ImageSaveType = PIKCV.COM.Enumerations.ImageSaveType.Company;
                    break;
            }
        }
    }

    protected void btnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        string ImageUploded = SendFile();
    }

    public static bool DeleteImage(string FileName, string ImagePath)
    {
        try
        {
            if (File.Exists(ImagePath + FileName))
            {
                File.Delete(ImagePath + FileName);
                return true;
            }
            else
                return false;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public string SendFile()
    {
        try
        {
            string FilePath = "";
            string FileName = fupImg.FileName;
            string TempFilePath = "";
            string SaveFileName = "";
            string SaveFileSmallName = "";
            string FileSmallName = "";
            string FileExtention = "";

            switch (this.ImageSaveType)
            {
                case PIKCV.COM.Enumerations.ImageSaveType.EmployeeBig:
                    FilePath = Request.MapPath(this.Config(PIKCV.COM.EnumUtil.Config.UserImagePath));
                    TempFilePath = Request.MapPath(this.Config(PIKCV.COM.EnumUtil.Config.UserImagePath)); 
                    SaveFileSmallName = this.smUserID.ToString();
                    break;
                case PIKCV.COM.Enumerations.ImageSaveType.EmployeeSmall:
                    FilePath = Request.MapPath(this.Config(PIKCV.COM.EnumUtil.Config.UserImagePathSmall));
                    TempFilePath = Request.MapPath(this.Config(PIKCV.COM.EnumUtil.Config.UserImagePathSmall));
                    SaveFileSmallName = this.smUserID.ToString();
                    break;
                case PIKCV.COM.Enumerations.ImageSaveType.Company:
                    FilePath = Request.MapPath(this.Config(PIKCV.COM.EnumUtil.Config.CompanyImagePath));
                    TempFilePath = Request.MapPath(this.Config(PIKCV.COM.EnumUtil.Config.CompanyImagePath));
                    SaveFileSmallName = this.smCompanyID.ToString();
                    break;
                default:
                    break;
            }

            int iPoint = FileName.LastIndexOf(".");

            if (iPoint != -1)
            {
                FileExtention = FileName.Substring(iPoint);
                FileSmallName = FileName.Substring(0, iPoint);
            }

            SaveFileName = SaveFileSmallName + FileExtention;

            if (fupImg.PostedFile.ContentLength > int.Parse(this.Config(PIKCV.COM.EnumUtil.Config.ImageMaxLenght)))
            {
                //lbMessage.Text = "1 MB'dan Büyük Resim Giremessiniz. Lütfen Daha Küçük Boyutta Bir Fotoðraf Giriniz.";
                return "";
            }

            int verNum = 1;
            while (System.IO.File.Exists(FilePath + FileName))
            {
                FileName = FileSmallName + "_" + verNum.ToString() + FileExtention;
                verNum += 1;
            }

            verNum = 1;
            while (System.IO.File.Exists(FilePath + SaveFileName))
            {
                SaveFileName = SaveFileSmallName + "_" + verNum.ToString() + FileExtention;
                verNum += 1;
            }
            DeleteImage("Temp" + FileName, TempFilePath);


            fupImg.SaveAs(TempFilePath + ("Temp" + FileName));

            //boyut çok küçük mü kontrolü
            if (this.ImageSaveType == PIKCV.COM.Enumerations.ImageSaveType.EmployeeBig)
            {
                if (CheckIfSizeTooSmall(TempFilePath + ("Temp" + FileName)))
                {
                    ImageTooSmall();
                    return "";
                }
            }
            ////////////////////////////////

            ChangeSize(TempFilePath + ("Temp" + FileName), FilePath + SaveFileName);
            if (this.ImageSaveType == PIKCV.COM.Enumerations.ImageSaveType.EmployeeBig)
            {
                this.ImageSaveType = PIKCV.COM.Enumerations.ImageSaveType.EmployeeSmall;
                FilePath = Request.MapPath(this.Config(PIKCV.COM.EnumUtil.Config.UserImagePathSmall));
                ChangeSize(TempFilePath + ("Temp" + FileName), FilePath + SaveFileName);
            }
            DeleteImage(("Temp" + FileName), TempFilePath);
            if (RaiseEvents)
            {
                ImageUploaded(SaveFileName);
            }
            return SaveFileName;
        }
        catch (Exception)
        {
            return "";
        }
    }

    #region Image Size Changing Functions
    System.Drawing.Image imgConverted = null;

    private bool CheckIfSizeTooSmall(string filePath)
    {
        System.IO.FileStream fs = new System.IO.FileStream(filePath, FileMode.Open, FileAccess.Read);
        byte[] imgData = new byte[fs.Length];


        fs.Read(imgData, 0, int.Parse(fs.Length.ToString()));
        fs.Close();
        imgConverted = System.Drawing.Image.FromStream(new MemoryStream(imgData));
        int MinimumWidth =  int.Parse(this.Config(PIKCV.COM.EnumUtil.Config.UserImageWidth)) * 75 / 100;
        int MinimumHeight = int.Parse(this.Config(PIKCV.COM.EnumUtil.Config.UserImageHeight)) * 75 / 100;
        if (imgConverted.Width < MinimumWidth || imgConverted.Height < MinimumHeight)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void ChangeSize(string SourceFilePath, string DestFilePath)
    {
        if (System.IO.File.Exists(SourceFilePath))
            if (!System.IO.File.Exists(DestFilePath))
            {
                FromFile(SourceFilePath);
                Convert();
                ToFile(DestFilePath);

            }
    }

    private void FromFile(string filePath)
    {
        System.IO.FileStream fs = new System.IO.FileStream(filePath, FileMode.Open, FileAccess.Read);
        byte[] imgData = new byte[fs.Length];

        try
        {
            fs.Read(imgData, 0, int.Parse(fs.Length.ToString()));
            fs.Close();

            imgConverted = System.Drawing.Image.FromStream(new MemoryStream(imgData));
        }
        catch (Exception)
        {
        }
    }

    private void ToFile(string filePath)
    {
        MemoryStream ms = new MemoryStream();

        imgConverted.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        byte[] imgData = new byte[ms.Length];

        ms.Position = 0;
        ms.Read(imgData, 0, (int)ms.Length);

        FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);

        try
        {
            fs.Write(imgData, 0, int.Parse(ms.Length.ToString()));
            fs.Close();
        }
        catch (Exception)
        {
        }
    }

    private void Convert()
    {
        bool blnKeepAspectRation;
        bool blnFactorToWidth;
        decimal decFactor = 0;
        string strHeight;
        string strWidth;
        int intOriginalHeight;
        int intOriginalWidth;
        int intNewWidth;
        int intNewHeight;
        System.Drawing.Image imgNewImage;

        intOriginalHeight = imgConverted.Height;
        intOriginalWidth = imgConverted.Width;

        strWidth = "*";
        strHeight = "*";

        blnKeepAspectRation = false;
        blnFactorToWidth = false;

        switch (this.ImageSaveType)
        {
            case PIKCV.COM.Enumerations.ImageSaveType.EmployeeBig:
                if (intOriginalWidth > int.Parse(this.Config(PIKCV.COM.EnumUtil.Config.UserImageWidth)))
                {
                    int TestingHeight = 0;
                    decimal TestingdecFactor = 0;
                    strWidth = this.Config(PIKCV.COM.EnumUtil.Config.UserImageWidth);
                    TestingdecFactor = decimal.Parse(strWidth) / decimal.Parse(imgConverted.Width.ToString());
                    TestingHeight = (int)Math.Floor(intOriginalHeight * TestingdecFactor);
                    if (TestingHeight > int.Parse(this.Config(PIKCV.COM.EnumUtil.Config.UserImageHeight)))
                    {
                        strWidth = "*";
                        strHeight = this.Config(PIKCV.COM.EnumUtil.Config.UserImageHeight);
                    }
                }
                else if (intOriginalHeight > int.Parse(this.Config(PIKCV.COM.EnumUtil.Config.UserImageHeight)))
                {
                    strHeight = this.Config(PIKCV.COM.EnumUtil.Config.UserImageHeight);
                }
                break;
            case PIKCV.COM.Enumerations.ImageSaveType.EmployeeSmall:
                if (intOriginalWidth > int.Parse(this.Config(PIKCV.COM.EnumUtil.Config.UserImageWidthSmall)))
                {
                    int TestingHeight = 0;
                    decimal TestingdecFactor = 0;
                    strWidth = this.Config(PIKCV.COM.EnumUtil.Config.UserImageWidthSmall);
                    TestingdecFactor = decimal.Parse(strWidth) / decimal.Parse(imgConverted.Width.ToString());
                    TestingHeight = (int)Math.Floor(intOriginalHeight * TestingdecFactor);
                    if (TestingHeight > int.Parse(this.Config(PIKCV.COM.EnumUtil.Config.UserImageHeightSmall)))
                    {
                        strWidth = "*";
                        strHeight = this.Config(PIKCV.COM.EnumUtil.Config.UserImageHeightSmall);
                    }
                }
                else if (intOriginalHeight > int.Parse(this.Config(PIKCV.COM.EnumUtil.Config.UserImageHeightSmall)))
                {
                    strHeight = this.Config(PIKCV.COM.EnumUtil.Config.UserImageHeightSmall);
                }
                this.ImageSaveType = PIKCV.COM.Enumerations.ImageSaveType.EmployeeBig;
                break;
            case PIKCV.COM.Enumerations.ImageSaveType.Company:
                if (intOriginalWidth > int.Parse(this.Config(PIKCV.COM.EnumUtil.Config.CompanyImageWidth)))
                {
                    int TestingHeight = 0;
                    decimal TestingdecFactor = 0;
                    strWidth = this.Config(PIKCV.COM.EnumUtil.Config.CompanyImageWidth);
                    TestingdecFactor = decimal.Parse(strWidth) / decimal.Parse(imgConverted.Width.ToString());
                    TestingHeight = (int)Math.Floor(intOriginalHeight * TestingdecFactor);
                    if (TestingHeight > int.Parse(this.Config(PIKCV.COM.EnumUtil.Config.CompanyImageHeight)))
                    {
                        strWidth = "*";
                        strHeight = this.Config(PIKCV.COM.EnumUtil.Config.CompanyImageHeight);
                    }
                }
                else if (intOriginalHeight > int.Parse(this.Config(PIKCV.COM.EnumUtil.Config.CompanyImageHeight)))
                {
                    strHeight = this.Config(PIKCV.COM.EnumUtil.Config.CompanyImageHeight);
                }
                break;
        }

        if (!(strWidth == "*") & !(strHeight == "*"))
        {
            //Width Önemli deðil Height'a göre factor edilecek
            blnKeepAspectRation = false;
        }
        else if (!(strWidth == "*"))
        {
            blnFactorToWidth = true;
            decFactor = decimal.Parse(strWidth) / decimal.Parse(imgConverted.Width.ToString());
            blnKeepAspectRation = true;
        }
        //Width belli
        else if (!(strHeight == "*"))
        {
            blnFactorToWidth = false;
            decFactor = decimal.Parse(strHeight) / decimal.Parse(imgConverted.Height.ToString());
            blnKeepAspectRation = true;
        }

        if (blnKeepAspectRation)
        {
            if (blnFactorToWidth)
            {
                intNewWidth = int.Parse(strWidth);
                intNewHeight = (int)Math.Floor(intOriginalHeight * decFactor);
            }
            else
            {
                intNewWidth = (int)Math.Floor(intOriginalWidth * decFactor);
                intNewHeight = int.Parse(strHeight);
            }
        }
        else
        {
            //img = New Bitmap(img, New Size(CInt(strWidth), CInt(strHeight)))
            intNewWidth = intOriginalWidth;
            intNewHeight = intOriginalHeight;
        }



        //ms = New MemoryStream()

        imgNewImage = new Bitmap(intNewWidth, intNewHeight);
        System.Drawing.Graphics graphic;
        graphic = System.Drawing.Graphics.FromImage(imgNewImage);
        graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        graphic.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
        graphic.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
        graphic.DrawImage(imgConverted, 0, 0, intNewWidth, intNewHeight);
        imgConverted = imgNewImage;
    }
    #endregion
}
