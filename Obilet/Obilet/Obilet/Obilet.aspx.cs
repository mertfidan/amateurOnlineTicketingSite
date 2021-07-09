using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Obilet
{
    public partial class Obilet : System.Web.UI.Page
    {
        internal static string nereden = "";
        internal static string nereye = "";
        internal static string yolcusayisi = "";
        internal static string tarih = "";
        internal static string gun = "";
        internal static string ay = "";
        internal static string yil = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Enabled = false;
        }

        protected void sfrlistele_Click(object sender, EventArgs e)
        {
            nereden = DropDownList1.SelectedItem.ToString();
            nereye = DropDownList2.SelectedItem.ToString();
            yolcusayisi = TextBox1.Text;
            tarih = Calendar1.SelectedDate.ToLongDateString();
            gun = Calendar1.SelectedDate.Day.ToString();
            ay = Calendar1.SelectedDate.Month.ToString();
            yil = Calendar1.SelectedDate.Year.ToString();

            if (DropDownList1.SelectedItem.ToString() == "Bir şehir seçin...")
            {
                Response.Write("<script>alert('Lütfen nereden gideceğinizi seçin...')</script>");
                return;
            }
            if (DropDownList2.SelectedItem.ToString() == "Bir şehir seçin...")
            {

                Response.Write("<script>alert('Lütfen nereye gideceğiniz şehri seçin...')</script>");
                return;
            }



            if (Calendar1.SelectedDate.ToShortDateString() == "01.01.0001")
            {
                Response.Write("<script>alert('Bir tarih seçin ...')</script>");
                return;
            }
            if (Calendar1.SelectedDate.ToShortDateString() != DateTime.Now.ToShortDateString() &&
                Calendar1.SelectedDate.ToShortDateString() != DateTime.Now.AddDays(1).ToShortDateString())
            {

                Label1.Text = "SEFER BULUNAMADI!";
                return;
            }


            Label1.Text = nereden + "-" + nereye + " Yolcu sayısı : " + yolcusayisi + " Tarih : " + tarih;
            Response.Redirect("Obilet1.aspx");
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
