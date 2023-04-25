using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using EntityLayer0;
using DataAccessLayer0;
using BusinessLogicLayer;

namespace YazOkuluKayıt_Projesi
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["OgrID"]);

            List<EntityOgrenci> OgrenciDetayGuncelle= BLLOgrenci.BLLOgrenciDetay(id);

            if(OgrenciDetayGuncelle.Count>0 && !Page.IsPostBack)
            {
                ad.Text = OgrenciDetayGuncelle[0].Ad.ToString();
                soyad.Text = OgrenciDetayGuncelle[0].Soyad.ToString();
                numara.Text = OgrenciDetayGuncelle[0].Numara.ToString();
                mail.Text = OgrenciDetayGuncelle[0].Mail.ToString();
                sifre.Text = OgrenciDetayGuncelle[0].Sifre.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["OgrID"]);

            List<EntityOgrenci> OgrenciDetayGuncelle = BLLOgrenci.BLLOgrenciDetay(id);

            OgrenciDetayGuncelle[0].Ad = ad.Text;
            OgrenciDetayGuncelle[0].Soyad = soyad.Text;
            OgrenciDetayGuncelle[0].Numara = numara.Text;
            OgrenciDetayGuncelle[0].Mail = mail.Text;
            OgrenciDetayGuncelle[0].Sifre = sifre.Text;
            OgrenciDetayGuncelle[0].Fotograf = "~/" + foto.FileName;

            BLLOgrenci.BLLOgrenciGuncelle(OgrenciDetayGuncelle[0], id);

            Response.Redirect("Ogrenciler.aspx");
        }

    }
}