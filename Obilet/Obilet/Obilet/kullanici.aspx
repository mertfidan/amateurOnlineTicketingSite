<%@ Page Title="" Language="C#" MasterPageFile="~/ana.Master" AutoEventWireup="true" CodeBehind="kullanici.aspx.cs" Inherits="Obilet.kullanici" MaintainScrollPositionOnPostback="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style type="text/css">

.txtbox {
    float:left;
        width:228px;
        padding:10px;
        height:18px;
        border:1px solid #ccc;
    
    color:#555; 
    background-color:#fff;
}
.btn{

   float:left;
   margin-left:170px;
        width:100px;
        height:40px;
        line-height:40px;
        text-align:center;
        color:#0099CC;
        background-color:#ccc;
        cursor:pointer;
        margin-top:10px;
}
.btn:hover{

   
        color:#fff;
        background-color:#0099CC;
        
}   

        </style>
    <h3>Kullanıcı Bilet Düzenleme</h3>

   
                    <br />
                    <br />
                    Kart Sahibi Adınızı Giriniz&nbsp; :
   
               
                    <br />
                    <br />

                    <asp:TextBox ID="TextBox1" runat="server" CssClass="txtbox"></asp:TextBox>
    <br />
    <br />
    <br />
                    Kredi Kartı Numaranızı Giriniz&nbsp; :
    <br />
    <br />
                
 <asp:TextBox ID="TextBox2" runat="server" MaxLength="4" CssClass="txtbox"></asp:TextBox>
    <br />
    <br />
    <br />            
     Kredi Kartı&nbsp; Şifrenizi&nbsp;&nbsp; Giriniz&nbsp;&nbsp;:
                <br />
    <br />
                  
                    <asp:TextBox ID="TextBox3" runat="server" MaxLength="4" TextMode="Password" CssClass="txtbox" ></asp:TextBox>
    <br />
    <br />
    <br />
                
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" Text="Giriş" CssClass="btn" style="text-align: center" />
    <br />
    <br />
    <br />

     <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>

    <asp:GridView ID="GridView1" runat="server" EnableModelValidation="True" 
                        onselectedindexchanged="GridView1_SelectedIndexChanged1" BackColor="White" 
                        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                        GridLines="Vertical" Width="600px">
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" SelectText="Düzenle" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                    </asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ></asp:SqlDataSource>




</asp:Content>
