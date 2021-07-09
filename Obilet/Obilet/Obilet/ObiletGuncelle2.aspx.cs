using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Obilet
{
    public partial class ObiletGuncelle2 : System.Web.UI.Page
    {
        internal static string gyolcuadi = "";
        internal static string gcinsiyet = "";
        internal static string gkoltukno = "";
        internal static string gkalkvar = "";
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-G95B3IK\\SQLEXPRESS; Database=obilet; Integrated Security=SSPI; User ID=DESKTOP-G95B3IK\\username; Password=Password");
        protected void Page_Load(object sender, EventArgs e)
        {

            CheckBox1.AutoPostBack = true;
            CheckBox2.AutoPostBack = true;
            CheckBox3.AutoPostBack = true;
            CheckBox4.AutoPostBack = true;
            CheckBox5.AutoPostBack = true;
            CheckBox6.AutoPostBack = true;
            CheckBox7.AutoPostBack = true;
            CheckBox8.AutoPostBack = true;
            CheckBox9.AutoPostBack = true;
            CheckBox10.AutoPostBack = true;
            CheckBox11.AutoPostBack = true;
            CheckBox12.AutoPostBack = true;
            CheckBox13.AutoPostBack = true;
            CheckBox14.AutoPostBack = true;
            CheckBox15.AutoPostBack = true;
            CheckBox16.AutoPostBack = true;
            CheckBox17.AutoPostBack = true;
            CheckBox18.AutoPostBack = true;
            CheckBox19.AutoPostBack = true;
            CheckBox20.AutoPostBack = true;
            CheckBox21.AutoPostBack = true;
            CheckBox22.AutoPostBack = true;
            CheckBox23.AutoPostBack = true;
            CheckBox24.AutoPostBack = true;
            CheckBox25.AutoPostBack = true;
            CheckBox26.AutoPostBack = true;
            CheckBox27.AutoPostBack = true;
            CheckBox28.AutoPostBack = true;
            CheckBox29.AutoPostBack = true;
            CheckBox30.AutoPostBack = true;
            CheckBox31.AutoPostBack = true;
            CheckBox32.AutoPostBack = true;
            CheckBox33.AutoPostBack = true;
            CheckBox34.AutoPostBack = true;
            CheckBox35.AutoPostBack = true;
            CheckBox36.AutoPostBack = true;
            ///////////////////////////////////////////////////////////////

            baglanti.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = baglanti;
            string bak = "Select koltukno from sefer WHERE kalkvar = '" + ObiletGuncelle.gnereden + "_" + ObiletGuncelle.gnereye + "' AND kalksaat='" + ObiletGuncelle1.gsaat + "' AND kalktar='" + ObiletGuncelle.gtarih + "'";
            command.CommandText = bak;
            SqlDataReader verioku;
            verioku = command.ExecuteReader();

            while (verioku.Read())
            {
                ListBox1.Items.Add(verioku.GetValue(0).ToString());


            }
            for (int i = 0; i < ListBox1.Items.Count; i++)
            {
                if (CheckBox1.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox1.Enabled = false;

                }

                if (CheckBox2.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox2.Enabled = false;

                }
                if (CheckBox3.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox3.Enabled = false;

                }
                if (CheckBox4.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox4.Enabled = false;

                }

                if (CheckBox5.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox5.Enabled = false;

                }
                if (CheckBox6.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox6.Enabled = false;

                }
                if (CheckBox7.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox7.Enabled = false;

                }

                if (CheckBox8.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox8.Enabled = false;

                }
                if (CheckBox9.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox9.Enabled = false;

                }
                if (CheckBox10.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox10.Enabled = false;

                }

                if (CheckBox11.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox11.Enabled = false;

                }
                if (CheckBox12.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox12.Enabled = false;

                }
                if (CheckBox13.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox13.Enabled = false;

                }

                if (CheckBox14.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox14.Enabled = false;

                }
                if (CheckBox15.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox15.Enabled = false;

                }
                if (CheckBox16.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox16.Enabled = false;

                }
                if (CheckBox17.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox17.Enabled = false;

                }
                if (CheckBox18.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox18.Enabled = false;

                }
                if (CheckBox19.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox19.Enabled = false;

                }
                if (CheckBox20.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox20.Enabled = false;

                }
                if (CheckBox21.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox21.Enabled = false;

                }
                if (CheckBox22.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox22.Enabled = false;

                }
                if (CheckBox23.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox23.Enabled = false;

                }
                if (CheckBox24.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox24.Enabled = false;

                }
                if (CheckBox25.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox25.Enabled = false;

                }
                if (CheckBox26.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox26.Enabled = false;

                }
                if (CheckBox27.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox27.Enabled = false;

                }
                if (CheckBox28.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox28.Enabled = false;

                }
                if (CheckBox29.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox29.Enabled = false;

                }
                if (CheckBox30.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox30.Enabled = false;

                }
                if (CheckBox31.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox31.Enabled = false;

                }
                if (CheckBox32.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox32.Enabled = false;

                }
                if (CheckBox33.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox33.Enabled = false;

                }
                if (CheckBox34.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox34.Enabled = false;

                }
                if (CheckBox35.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox35.Enabled = false;

                }
                if (CheckBox36.ClientID.Remove(0, 8) == ListBox1.Items[i].ToString())
                {
                    CheckBox36.Enabled = false;

                }

            }

            verioku.Close();
            baglanti.Close();





        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Label2.Text=Sab1.id;
            //Int32 id;
            //id = Int32.Parse(Label2.Text);
            gyolcuadi = TextBox1.Text;
            gcinsiyet = DropDownList1.SelectedItem.ToString();
            //Label1.Text = cinsiyet;

            gkalkvar = ObiletGuncelle.gnereden + "_" + ObiletGuncelle.gnereye;

            if (CheckBox1.Checked == true)
            {
                gkoltukno = CheckBox1.ClientID.Remove(0, 8);
                CheckBox1.Checked = false;
                CheckBox1.Enabled = false;
            }
            if (CheckBox2.Checked == true)
            {
                gkoltukno = CheckBox2.ClientID.Remove(0, 8);
                CheckBox2.Checked = false;
                CheckBox2.Enabled = false;
            }
            if (CheckBox3.Checked == true)
            {
                gkoltukno = CheckBox3.ClientID.Remove(0, 8);
                CheckBox3.Checked = false;
                CheckBox3.Enabled = false;
            }
            if (CheckBox4.Checked == true)
            {
                gkoltukno = CheckBox4.ClientID.Remove(0, 8);
                CheckBox4.Checked = false;
                CheckBox4.Enabled = false;
            }
            if (CheckBox5.Checked == true)
            {
                gkoltukno = CheckBox5.ClientID.Remove(0, 8);
                CheckBox5.Checked = false;
                CheckBox5.Enabled = false;
            }
            if (CheckBox6.Checked == true)
            {
                gkoltukno = CheckBox6.ClientID.Remove(0, 8);
                CheckBox6.Checked = false;
                CheckBox6.Enabled = false;
            }
            if (CheckBox7.Checked == true)
            {
                gkoltukno = CheckBox7.ClientID.Remove(0, 8);
                CheckBox7.Checked = false;
                CheckBox7.Enabled = false;
            }
            if (CheckBox8.Checked == true)
            {
                gkoltukno = CheckBox8.ClientID.Remove(0, 8);
                CheckBox8.Checked = false;
                CheckBox8.Enabled = false;
            }
            if (CheckBox9.Checked == true)
            {
                gkoltukno = CheckBox9.ClientID.Remove(0, 8);
                CheckBox9.Checked = false;
                CheckBox9.Enabled = false;
            }
            if (CheckBox10.Checked == true)
            {
                gkoltukno = CheckBox10.ClientID.Remove(0, 8);
                CheckBox10.Checked = false;
                CheckBox10.Enabled = false;
            }
            if (CheckBox11.Checked == true)
            {
                gkoltukno = CheckBox11.ClientID.Remove(0, 8);
                CheckBox11.Checked = false;
                CheckBox11.Enabled = false;
            }
            if (CheckBox12.Checked == true)
            {
                gkoltukno = CheckBox12.ClientID.Remove(0, 8);
                CheckBox12.Checked = false;
                CheckBox12.Enabled = false;
            }
            if (CheckBox13.Checked == true)
            {
                gkoltukno = CheckBox13.ClientID.Remove(0, 8);
                CheckBox13.Checked = false;
                CheckBox13.Enabled = false;
            }
            if (CheckBox14.Checked == true)
            {
                gkoltukno = CheckBox14.ClientID.Remove(0, 8);
                CheckBox14.Checked = false;
                CheckBox14.Enabled = false;
            }
            if (CheckBox15.Checked == true)
            {
                gkoltukno = CheckBox15.ClientID.Remove(0, 8);
                CheckBox15.Checked = false;
                CheckBox15.Enabled = false;
            }
            if (CheckBox16.Checked == true)
            {
                gkoltukno = CheckBox16.ClientID.Remove(0, 8);
                CheckBox16.Checked = false;
                CheckBox16.Enabled = false;
            }
            if (CheckBox17.Checked == true)
            {
                gkoltukno = CheckBox17.ClientID.Remove(0, 8);
                CheckBox17.Checked = false;
                CheckBox17.Enabled = false;
            }
            if (CheckBox18.Checked == true)
            {
                gkoltukno = CheckBox18.ClientID.Remove(0, 8);
                CheckBox18.Checked = false;
                CheckBox18.Enabled = false;
            }
            if (CheckBox19.Checked == true)
            {
                gkoltukno = CheckBox19.ClientID.Remove(0, 8);
                CheckBox19.Checked = false;
                CheckBox19.Enabled = false;
            }
            if (CheckBox20.Checked == true)
            {
                gkoltukno = CheckBox20.ClientID.Remove(0, 8);
                CheckBox20.Checked = false;
                CheckBox20.Enabled = false;
            }
            if (CheckBox21.Checked == true)
            {
                gkoltukno = CheckBox21.ClientID.Remove(0, 8);
                CheckBox21.Checked = false;
                CheckBox21.Enabled = false;
            }
            if (CheckBox22.Checked == true)
            {
                gkoltukno = CheckBox22.ClientID.Remove(0, 8);
                CheckBox22.Checked = false;
                CheckBox22.Enabled = false;
            }
            if (CheckBox23.Checked == true)
            {
                gkoltukno = CheckBox23.ClientID.Remove(0, 8);
                CheckBox23.Checked = false;
                CheckBox23.Enabled = false;
            }
            if (CheckBox24.Checked == true)
            {
                gkoltukno = CheckBox24.ClientID.Remove(0, 8);
                CheckBox24.Checked = false;
                CheckBox24.Enabled = false;
            }
            if (CheckBox25.Checked == true)
            {
                gkoltukno = CheckBox25.ClientID.Remove(0, 8);
                CheckBox25.Checked = false;
                CheckBox25.Enabled = false;
            }
            if (CheckBox26.Checked == true)
            {
                gkoltukno = CheckBox26.ClientID.Remove(0, 8);
                CheckBox26.Checked = false;
                CheckBox26.Enabled = false;
            }
            if (CheckBox27.Checked == true)
            {
                gkoltukno = CheckBox27.ClientID.Remove(0, 8);
                CheckBox27.Checked = false;
                CheckBox27.Enabled = false;
            }
            if (CheckBox28.Checked == true)
            {
                gkoltukno = CheckBox28.ClientID.Remove(0, 8);
                CheckBox28.Checked = false;
                CheckBox28.Enabled = false;
            }
            if (CheckBox29.Checked == true)
            {
                gkoltukno = CheckBox29.ClientID.Remove(0, 8);
                CheckBox29.Checked = false;
                CheckBox29.Enabled = false;
            }
            if (CheckBox30.Checked == true)
            {
                gkoltukno = CheckBox30.ClientID.Remove(0, 8);
                CheckBox30.Checked = false;
                CheckBox30.Enabled = false;
            }
            if (CheckBox31.Checked == true)
            {
                gkoltukno = CheckBox31.ClientID.Remove(0, 8);
                CheckBox31.Checked = false;
                CheckBox31.Enabled = false;
            }
            if (CheckBox32.Checked == true)
            {
                gkoltukno = CheckBox32.ClientID.Remove(0, 8);
                CheckBox32.Checked = false;
                CheckBox32.Enabled = false;
            }
            if (CheckBox33.Checked == true)
            {
                gkoltukno = CheckBox33.ClientID.Remove(0, 8);
                CheckBox33.Checked = false;
                CheckBox33.Enabled = false;
            }
            if (CheckBox34.Checked == true)
            {
                gkoltukno = CheckBox34.ClientID.Remove(0, 8);
                CheckBox34.Checked = false;
                CheckBox34.Enabled = false;
            }
            if (CheckBox35.Checked == true)
            {
                gkoltukno = CheckBox35.ClientID.Remove(0, 8);
                CheckBox35.Checked = false;
                CheckBox35.Enabled = false;
            }
            if (CheckBox36.Checked == true)
            {
                gkoltukno = CheckBox36.ClientID.Remove(0, 8);
                CheckBox36.Checked = false;
                CheckBox36.Enabled = false;
            }
            //Label1.Text = koltukno;



            if (gyolcuadi == "")
            {
                Response.Write("<script>alert('YOLCU ADI GİRİN ...')</script>");
                return;
            }
            if (gcinsiyet == "")
            {
                Response.Write("<script>alert('CİNSİYETİNİZİ GİRİN...')</script>");
                return;
            }



            if (gkoltukno == "")
            {
                Response.Write("<script>alert('BİR KOLTUK SEÇİN ...')</script>");
                return;
            }




            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            baglanti.Open();

            SqlCommand command = new SqlCommand();

            DateTime a = new DateTime(int.Parse(ObiletGuncelle.gyil), int.Parse(ObiletGuncelle.gay), int.Parse(ObiletGuncelle.ggun));
            var sqlFormattedDate = a.Date.ToString("yyyy-MM-dd");
            //DataTable tablo = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            command.Connection = baglanti;
            string varmi1 = "Select Count(kalksaat) from sefer WHERE kalkvar = '" + ObiletGuncelle.gnereden + "_" + ObiletGuncelle.gnereye + "' AND kalksaat = '13:00' AND kalktar ='" + ObiletGuncelle.gtarih + "' ";
            string varmi2 = "Select Count(kalksaat) from sefer WHERE kalkvar = '" + ObiletGuncelle.gnereden + "_" + ObiletGuncelle.gnereye + "' AND kalksaat = '17:00' AND kalktar ='" + ObiletGuncelle.gtarih + "'";
            string varmi3 = "Select Count(kalksaat) from sefer WHERE kalkvar = '" + ObiletGuncelle.gnereden + "_" + ObiletGuncelle.gnereye + "' AND kalksaat = '19:00' AND kalktar ='" + ObiletGuncelle.gtarih + "'";
            //string bak = "Select COUNT(kalkvar) from sefer WHERE kalkvar = '"+online.nereden+"_"+online.nereye+"' AND kalksaat= ";
            //string varmi = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME=" + online.nereden + "_" + online.nereye + "1"+"";
            //command.CommandText = varmi;
            //adp.SelectCommand = command;
            //adp.Fill(tablo);
            //command.CommandText = varmi;

            //SqlCommand komut = new SqlCommand("SELECT @@ROWCOUNT FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME=" + online.nereden + "_" + online.nereye + "1" + "", baglanti);
            int biletno = int.Parse(kullanici.id);
            if (ObiletGuncelle1.gsaat == "13:00")
            {

                command.CommandText = varmi1;
                SqlDataReader dr;
                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Label1.Text = dr.GetValue(0).ToString();
                    int tur = int.Parse(Label1.Text);
                    dr.Close();

                    if (tur < 37)
                    {
                        command.CommandText = "UPDATE sefer SET yolcuadi='" + gyolcuadi + "',kalkvar='" + gkalkvar + "',cinsiyet='" + gcinsiyet + "', koltukno='" + gkoltukno + "',kalktar='" + ObiletGuncelle.gtarih + "',kalksaat='" + ObiletGuncelle1.gsaat + "' WHERE id=" + biletno + "";
                        command.ExecuteNonQuery();
                        break;

                    }
                    else
                    {

                        break;
                    }




                }


                //command.CommandText = "INSERT INTO sefer (yolcuadi,kalkvar,cinsiyet,yolcusayi,koltukno,kalktar,kalksaat,kartsahibiadi,kartno,kartsifre) VALUES ('" + yolcuadi + "','"+kalkvar+"','" + cinsiyet + "','" + online.yolcusayisi + "','" + koltukno + "','" + online.tarih + "','" + online1.saat + "','" + kartsahibi + "','" + kartno + "','" + kartsifre + "')";
                //command.ExecuteNonQuery();


            }
            if (ObiletGuncelle1.gsaat == "17:00")
            {

                command.CommandText = varmi2;
                SqlDataReader dr;
                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Label1.Text = dr.GetValue(0).ToString();
                    int tur = int.Parse(Label1.Text);
                    dr.Close();

                    if (tur < 37)
                    {
                        command.CommandText = "UPDATE sefer SET yolcuadi='" + gyolcuadi + "',kalkvar='" + gkalkvar + "',cinsiyet='" + gcinsiyet + "', koltukno='" + gkoltukno + "',kalktar='" + ObiletGuncelle.gtarih + "',kalksaat='" + ObiletGuncelle1.gsaat + "' WHERE id=" + biletno + "";
                        command.ExecuteNonQuery();
                        break;

                    }
                    else
                    {

                        break;
                    }




                }


            }



            if (ObiletGuncelle1.gsaat == "19:00")
            {
                command.CommandText = varmi3;
                SqlDataReader dr;
                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Label1.Text = dr.GetValue(0).ToString();
                    int tur = int.Parse(Label1.Text);
                    dr.Close();

                    if (tur < 37)
                    {
                        command.CommandText = "UPDATE sefer SET yolcuadi='" + gyolcuadi + "',kalkvar='" + gkalkvar + "',cinsiyet='" + gcinsiyet + "', koltukno='" + gkoltukno + "',kalktar='" + ObiletGuncelle.gtarih + "',kalksaat='" + ObiletGuncelle1.gsaat + "' WHERE id=" + biletno + "";
                        command.ExecuteNonQuery();
                        break;

                    }
                    else
                    {

                        break;
                    }




                }
            }


            baglanti.Close();
            Response.Redirect("BiletGuncelle.aspx");


        }
    }
}