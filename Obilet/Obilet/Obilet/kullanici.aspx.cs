using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System;
using System.Collections;
using System.Linq;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace Obilet
{
    public partial class kullanici : System.Web.UI.Page
        
    {
        internal static string id = "";
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-G95B3IK\\SQLEXPRESS; Database=obilet; Integrated Security=SSPI; User ID=DESKTOP-G95B3IK\\username; Password=Password");
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GridViewRow satir = GridView1.SelectedRow;
            string a = satir.Cells[0].Text.ToString();
            //Label1.Text = Session["id"].ToString();
            id = Convert.ToString(GridView1.SelectedRow.Cells[1].Text);
            Label1.Text = Convert.ToString(GridView1.SelectedRow.Cells[5].Text);
            string ilktarih = Label1.Text;
            IFormatProvider kultur = new System.Globalization.CultureInfo("tr-TR", true);
            DateTime date1 = DateTime.Parse(ilktarih, kultur, System.Globalization.DateTimeStyles.AssumeLocal);
            Label2.Text = date1.ToShortDateString();

            if (date1.Date < DateTime.Now.Date)
            {
                Response.Write("<script>alert('Tarihi geçmiş bilet ile işlem yapılamaz...')</script>");
                return;
            }


            Response.Redirect("ObiletGuncelle.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (TextBox1.Text == "admin" && TextBox2.Text == "1234" && TextBox3.Text == "")
            {
               
                
                GridView1.Visible = false;


                SqlCommand comm1 = new SqlCommand("SELECT id AS BiletNo, yolcuadi AS Yolcu_ADI,kalkvar AS KALKIS_VARIS,koltukno AS KOLTUK, kalktar AS KALKIS_TARIHI, kalksaat AS SAAT FROM sefer ORDER BY id DESC", baglanti);
                DataTable tabloo1 = new DataTable();
                SqlDataAdapter adp1 = new SqlDataAdapter();


                comm1.Connection = baglanti;

                baglanti.Open();

                SqlDataReader dr1 = comm1.ExecuteReader();

              



                baglanti.Close();


            }
            else
            {
                
                
               
                GridView1.Visible = true;
                SqlCommand comm = new SqlCommand("SELECT id AS BiletNo, yolcuadi AS Yolcu_ADI,kalkvar AS KALKIS_VARIS,koltukno AS KOLTUK, kalktar AS KALKIS_TARIHI, kalksaat AS SAAT FROM sefer WHERE kartsahibiadi='" + TextBox1.Text + "' AND kartno='" + TextBox2.Text + "' AND kartsifre='" + TextBox3.Text + "' ORDER BY id DESC", baglanti);
                DataTable tabloo = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter();


                comm.Connection = baglanti;

                baglanti.Open();

                SqlDataReader dr = comm.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();



                baglanti.Close();

            }
        }
    }
}