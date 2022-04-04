using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MuzikKursi
{
    public partial class Anasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_KullaniciTableAdapter dt = new DataSet1TableAdapters.Tbl_KullaniciTableAdapter();
            dt.KullaniciEkle(TextBox1.Text, TextBox3.Text, TextBox4.Text,DropDownList1.SelectedValue.ToString(),DropDownList2.SelectedValue.ToString());
        }
    }
}