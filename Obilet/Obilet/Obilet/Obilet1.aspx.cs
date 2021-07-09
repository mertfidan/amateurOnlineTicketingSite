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
    public partial class Obilet1 : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-G95B3IK\\SQLEXPRESS; Database=obilet; Integrated Security=SSPI; User ID=DESKTOP-G95B3IK\\username; Password=Password");
        internal static string saat = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Obilet.tarih;
            Label2.Text = Obilet.tarih;
            Label3.Text = Obilet.tarih;
            kalkvar1.Text = Obilet.nereden + "-" + Obilet.nereye;
            kalkvar2.Text = Obilet.nereden + "-" + Obilet.nereye;
            kalkvar3.Text = Obilet.nereden + "-" + Obilet.nereye;

            baglanti.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = baglanti;
            string saat1 = "Select Count(kalksaat) from sefer WHERE kalkvar = '" + Obilet.nereden + "_" + Obilet.nereye + "' AND kalksaat = '13:00' AND kalktar ='" + Obilet.tarih + "' ";
            string saat2 = "Select Count(kalksaat) from sefer WHERE kalkvar = '" + Obilet.nereden + "_" + Obilet.nereye + "' AND kalksaat = '17:00' AND kalktar ='" + Obilet.tarih + "'";
            string saat3 = "Select Count(kalksaat) from sefer WHERE kalkvar = '" + Obilet.nereden + "_" + Obilet.nereye + "' AND kalksaat = '19:00' AND kalktar ='" + Obilet.tarih + "'";
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

            //Label1.Text =DateTime.Now.ToLongDateString();
            int saat = DateTime.Now.Hour;
            if (saat >= 12 && Obilet.tarih == DateTime.Now.ToLongDateString())
            {
                CheckBox1.Checked = false;
                CheckBox1.Enabled = false;
            }
            if (saat >= 16 && Obilet.tarih == DateTime.Now.ToLongDateString())
            {
                CheckBox2.Checked = false;
                CheckBox2.Enabled = false;
            }
            if (saat >= 18 && Obilet.tarih == DateTime.Now.ToLongDateString())
            {
                CheckBox3.Checked = false;
                CheckBox3.Enabled = false;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                saat = "13:00";

            }
            if (CheckBox2.Checked == true)
            {
                saat = "17:00";

            }
            if (CheckBox3.Checked == true)
            {
                saat = "19:00";

            }
            if (CheckBox1.Checked == false && CheckBox2.Checked == false && CheckBox3.Checked == false)
            {
                Response.Write("<script>alert('Lütfen bir sefer seçin ! ...')</script>");
                return;
            }
            Response.Redirect("Obilet2.aspx");
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
