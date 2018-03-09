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
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

public partial class RandomImage : BasePage
{
    protected BaseUserControl uc = new BaseUserControl();


    protected new void Page_Load(object sender, EventArgs e)
    {
        const int UZUNLUK = 9;
        string[] m_Karakterler = new string[] {
                    "A" , "B" , "C" , "D" , "E" , "F" , "G" , "Ð", "H" , "I" , "Ý",
                    "J" , "K" , "L" , "M" , "N" , "O" , "P" , "Q" , "R" ,
                    "S" , "Þ", "T" , "U" , "V" , "W" , "X" , "Y" , "Z" , "0" 
                    //"1" , "2" , "3" , "4" , "5" , "6" , "7" , "8" , "9" 
                };
        /*string[] m_Karakterler = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };*/

        Random m_Random = new Random();
        string m_GuvenlikKelimesi = string.Empty;

        for (int i = 0; i < UZUNLUK; i++)
        {
            m_GuvenlikKelimesi += m_Karakterler[m_Random.Next(m_Karakterler.Length - 1)];
        }

        m_GuvenlikKelimesi = "BURAK";

        uc.smSecurityImage = m_GuvenlikKelimesi;

        Response.ContentType = "image/jpeg";
        CreateImage(uc.smSecurityImage, 35, 115, Response.OutputStream);
    }

    protected void CreateImage(String salt, int height, int width, System.IO.Stream stream)
    {
        Random r = new Random();
        Bitmap bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);
        Graphics objGrafik = Graphics.FromImage(bmp);
        Matrix mymat = new Matrix();
        System.IO.MemoryStream ms = new System.IO.MemoryStream();
        objGrafik.TextRenderingHint = TextRenderingHint.AntiAlias;
        objGrafik.Clear(Color.White);
        objGrafik.DrawRectangle(Pens.White, 1, 1, width - 3, height - 3);
        objGrafik.DrawRectangle(Pens.White, 0, 0, width, height);
        for (int i = 0; i < salt.Length; i++)
        {
            //mymat.Reset();
            //mymat.RotateAt(Convert.ToSingle(r.Next(-15, 0)), new PointF((Convert.ToSingle(width) * (0.12f * Convert.ToSingle(i))), (Convert.ToSingle(height) * 0.5f)));

            objGrafik.Transform = mymat;
            objGrafik.DrawString(salt[i].ToString(), new Font("Tr President", 30, FontStyle.Regular), Brushes.Black, Convert.ToSingle(width) * (0.12f * i), Convert.ToSingle(height) * 0.15f);
            objGrafik.ResetTransform();
        }
        bmp.Save(stream, ImageFormat.Jpeg);
        objGrafik.Dispose();
        bmp.Dispose();
    }
}
