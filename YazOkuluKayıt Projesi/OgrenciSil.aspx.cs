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
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["OgrID"]);

            BLLOgrenci.BLLOgrenciSil(id);
            Response.Redirect("Ogrenciler.aspx");
        }
    }
}