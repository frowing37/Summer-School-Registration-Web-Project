using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer0;
using DataAccessLayer0;
using BusinessLogicLayer;

namespace YazOkuluKayıt_Projesi
{
    public partial class YeniKayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ogrenci = new EntityOgrenci();
            ogrenci.Ad = ad.Text;
            ogrenci.Soyad = soyad.Text;
            ogrenci.Numara = numara.Text;
            ogrenci.Mail = mail.Text;
            ogrenci.Sifre = sifre.Text;
            ogrenci.Fotograf = "~/" + foto.FileName;
            BLLOgrenci.OgrenciEkleBLL(ogrenci);
            Response.Redirect("Ogrenciler.aspx");
        }
    }
}