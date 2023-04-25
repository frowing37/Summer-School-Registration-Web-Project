using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using EntityLayer0;

namespace YazOkuluKayıt_Projesi
{
    public partial class DersEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Kaydet_Click(object sender, EventArgs e)
        {
            EntityDers ders = new EntityDers();
            ders.Dersad = dad.Text;
            ders.Max = Convert.ToInt32(dmax.Text);
            ders.Min = Convert.ToInt32(dmin.Text);

            BLLDers.BLLDersEkle(ders);
            Response.Redirect("Dersler.aspx");
        }
    }
}