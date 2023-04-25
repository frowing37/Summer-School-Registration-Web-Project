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
    public partial class OgrtEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                List<EntityDers> DersListesi = BLLDers.BLLDersListele();
                drop1.DataSource = DersListesi;
                drop1.DataTextField = "Dersad";
                drop1.DataValueField = "Id";
                drop1.DataBind();
            }
        }

        protected void click_Load(object sender, EventArgs e)
        {
            EntityOgrt ogrt = new EntityOgrt();
            ogrt.Ogrtad = oad.Text;
            ogrt.Ogrtbrans = drop1.SelectedValue;
            BLLOgrt.BLLOgrEkle(ogrt);
            Response.Redirect("Ogrt.aspx");
        }

    }
}