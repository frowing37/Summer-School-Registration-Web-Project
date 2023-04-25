using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer0;
using BusinessLogicLayer;

namespace YazOkuluKayıt_Projesi
{
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                List<EntityDers> Dersler = BLLDers.BLLDersListele();
                DropDownList1.DataSource = Dersler;
                DropDownList1.DataTextField = "Dersad";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();

                List<EntityOgrenci> Ogrenciler = BLLOgrenci.BLLOgrenciListele();
                DropDownList2.DataSource = Ogrenciler;
                DropDownList2.DataTextField = "Ad";
                DropDownList2.DataValueField = "Id";
                DropDownList2.DataBind();
            }

        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            EntityBasvuruForm basvuru = new EntityBasvuruForm();
            basvuru.Basogrid = Convert.ToInt32(DropDownList2.SelectedValue);
            basvuru.Basdersid = Convert.ToInt32(DropDownList1.SelectedValue);
            BLLBasvuruForm.BLLBasvuruEkle(basvuru);
            Response.Redirect("Dersler.aspx");
        }
    }
}