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
    public partial class OgrtSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EntityOgrt ogrt = new EntityOgrt();
            ogrt.Ogrtid = Convert.ToInt32(Request.QueryString["Ogrtid"]);
            BLLOgrt.BLLOgrtSil(ogrt);
            Response.Redirect("Ogrt.aspx");
        }
    }
}