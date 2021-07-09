<%@ Page Title="" Language="C#" MasterPageFile="~/ana.Master" AutoEventWireup="true" CodeBehind="Yetkili.aspx.cs" Inherits="Obilet.Yetkili"  MaintainScrollPositionOnPostback="true"%>
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
      
                    <img src="images/yetki.jpg" alt="Online bilet almanın en güvenli yolu" />
                    <br />

                   <h3> YETKİLİ GİRİŞ</h3><br />
                    <br />
<asp:Label ID="Label5" runat="server" Text="Yetkili Adı :"></asp:Label>
    <br />
                    &nbsp;&nbsp; &nbsp;<asp:TextBox ID="TextBox5" runat="server" CssClass="txtbox"></asp:TextBox>
                    &nbsp;
            

     <br />
    <br />
    <br />
    <asp:Label ID="Label10" runat="server" Text="Yetkili Şifre :"></asp:Label>
    <br />     
         <asp:TextBox ID="TextBox6" runat="server" TextMode="Password" CssClass="txtbox"></asp:TextBox>
    <br />
 <br />
    <br />

                   
                    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Giriş" CssClass="btn" />
    <br />
    <br />

    <br />
    <br />
    
                    <asp:Label ID="Label3" runat="server" Text="Yolcu adı arama :"></asp:Label>
    <br />
    

    <br />
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="txtbox"></asp:TextBox>
                <br />
    <br />
    <br />


    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Ara" CssClass="btn" Visible="False"  />

    <br />
    <br />
     <br />
     <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>


    <asp:GridView ID="GridView2" runat="server" BackColor="#DEBA84" 
                        BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                        CellSpacing="2" onselectedindexchanged="GridView2_SelectedIndexChanged" 
                        Width="600px" style="margin-top: 0px">
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <Columns>
                            <asp:CommandField SelectText="Sil" ShowSelectButton="True" />
                        </Columns>
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    </asp:GridView>
    <br />
    
    Bu sayfa Yekili giriş Sayafasıdır.

</asp:Content>
