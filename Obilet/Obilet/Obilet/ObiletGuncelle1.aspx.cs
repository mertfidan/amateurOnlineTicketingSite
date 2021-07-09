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
using System.Data.SqlClient;


namespace Obilet
{
    public partial class ObiletGuncelle1 : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-G95B3IK\\SQLEXPRESS; Database=obilet; Integrated Security=SSPI; User ID=DESKTOP-G95B3IK\\username; Password=Password");
        internal static string gsaat = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = ObiletGuncelle.gtarih;
            Label2.Text = ObiletGuncelle.gtarih;
            Label3.Text = ObiletGuncelle.gtarih;
            kalkvar1.Text = ObiletGuncelle.gnereden + "-" + ObiletGuncelle.gnereye;
            kalkvar2.Text = ObiletGuncelle.gnereden + "-" + ObiletGuncelle.gnereye;
            kalkvar3.Text = ObiletGuncelle.gnereden + "-" + ObiletGuncelle.gnereye;

            baglanti.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = baglanti;
            string saat1 = "Select Count(kalksaat) from sefer WHERE kalkvar = '" + ObiletGuncelle.gnereden + "_" + ObiletGuncelle.gnereye + "' AND kalksaat = '13:00' AND kalktar ='" + ObiletGuncelle.gtarih + "' ";
            string saat2 = "Select Count(kalksaat) from sefer WHERE kalkvar = '" + ObiletGuncelle.gnereden + "_" + ObiletGuncelle.gnereye + "' AND kalksaat = '17:00' AND kalktar ='" + ObiletGuncelle.gtarih + "'";
            string saat3 = "Select Count(kalksaat) from sefer WHERE kalkvar = '" + ObiletGuncelle.gnereden + "_" + ObiletGuncelle.gnereye + "' AND kalksaat = '19:00' AND kalktar ='" + ObiletGuncelle.gtarih + "'";
            command.CommandText = saat1;
            SqlDataReader dr;
            dr = command.ExecuteReader();
            while (dr.Read())
            {



                if (dr.GetValue(0).ToString() == "36")
                {

                    Label4.ForeColor = System.Drawing.Color.Red;
                    CheckBox1.Checked = false;
                    CheckBox1.Enabled = false;
                    Label4.Text = "DOLU";
                }
            }
            dr.Close();
            command.CommandText = saat2;
            SqlDataReader dr2;
            dr2 = command.ExecuteReader();
            while (dr2.Read())
            {



                if (dr2.GetValue(0).ToString() == "36")
                {

                    Label5.ForeColor = System.Drawing.Color.Red;
                    CheckBox2.Checked = false;
                    CheckBox2.Enabled = false;
                    Label5.Text = "DOLU";
                }
            }
            dr2.Close();
            command.CommandText = saat3;
            SqlDataReader dr3;
            dr3 = command.ExecuteReader();
            while (dr3.Read())
            {



                if (dr3.GetValue(0).ToString() == "36")
                {


                    CheckBox3.Checked = false;
                    CheckBox3.Enabled = false;
                    Label6.ForeColor = System.Drawing.Color.Red;
                    Label5.Text = "DOLU";

                }
            }
            dr3.Close();
            baglanti.Close();
            int saat = DateTime.Now.Hour;
            if (saat >= 12 && ObiletGuncelle.gtarih == DateTime.Now.ToLongDateString())
            {
                CheckBox1.Checked = false;
                CheckBox1.Enabled = false;
            }
            if (saat >= 16 && ObiletGuncelle.gtarih == DateTime.Now.ToLongDateString())
            {
                CheckBox2.Checked = false;
                CheckBox2.Enabled = false;
            }
            if (saat >= 18 && ObiletGuncelle.gtarih == DateTime.Now.ToLongDateString())
            {
                CheckBox3.Checked = false;
                CheckBox3.Enabled = false;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            if (CheckBox1.Checked == true)
            {
                gsaat = "13:00";

            }
            if (CheckBox2.Checked == true)
            {
                gsaat = "17:00";

            }
            if (CheckBox3.Checked == true)
            {
                gsaat = "19:00";

            }
            if (CheckBox1.Checked == false && CheckBox2.Checked == false && CheckBox3.Checked == false)
            {
                Response.Write("<script>alert('Lütfen bir sefer seçin ! ...')</script>");
                return;
            }
            Response.Redirect("ObiletGuncelle2.aspx");
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                CheckBox2.Checked = false;
                CheckBox3.Checked = false;
            }
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                CheckBox1.Checked = false;
                CheckBox3.Checked = false;
            }
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox3.Checked == true)
            {
                CheckBox2.Checked = false;
                CheckBox1.Checked = false;
            }
        }
    }
}
