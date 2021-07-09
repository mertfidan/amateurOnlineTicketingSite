<%@ Page Title="" Language="C#" MasterPageFile="~/ana.Master" AutoEventWireup="true" CodeBehind="ObiletGuncelle1.aspx.cs" Inherits="Obilet.ObiletGuncelle1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <link href="style.css" rel="stylesheet" />
    <style type="text/css">
        .txtbox {
    float:inherit;
        width:120px;
        padding:10px;
        height:18px;
        border:1px solid #ccc;
    
    color:#555; 
    background-color:#fff;
}
.btn{

   float:right;
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
        .style11
        {
            width: 100%;
            height: 195px;
        }
        .style14
        {
            width: 333px;
        }
        .style18
        {
            width: 333px;
            height: 55px;
        }
        .style19
        {
            height: 55px;
        }
        .style22
        {
            width: 333px;
            height: 56px;
        }
        .style23
        {
            height: 56px;
        }
        .style24
        {
            width: 299px;
        }
        .style25
        {
            width: 299px;
            height: 55px;
        }
        .style26
        {
            width: 299px;
            height: 56px;
        }
        .style27
        {
            width: 338px;
        }
        .style28
        {
            width: 338px;
            height: 55px;
        }
        .style29
        {
            width: 338px;
            height: 56px;
        }
    </style>


    
    
    <br />
    
    <table class="style11">
        <tr>
            <td class="style24">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                TARİH-SAAT</td>
            <td class="style27">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                KALKIŞ-VARIŞ</td>
            <td class="style14">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                NORMAL FİYAT</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                İNTERNET FİYATI</td>
        </tr>
        <tr>
            <td class="style25">
            &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
&nbsp;&nbsp;
                <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" 
                    oncheckedchanged="CheckBox1_CheckedChanged" />
                &nbsp;&nbsp; 13:00<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td class="style28">
            &nbsp;<asp:Label ID="kalkvar1" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="style18">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Text="45 TL"></asp:Label>
            </td>
            <td class="style19">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label7" runat="server" Text="25 TL"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style26">
            &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server"></asp:Label>
                <br />
&nbsp;&nbsp;
                <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" 
                    oncheckedchanged="CheckBox2_CheckedChanged" />
&nbsp;&nbsp;&nbsp; 17:00<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td class="style29">
            &nbsp;<asp:Label ID="kalkvar2" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="style22">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" Text="45 TL"></asp:Label>
            </td>
            <td class="style23">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label8" runat="server" Text="25 TL"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style26">
                &nbsp;&nbsp;&nbsp;
                &nbsp;<asp:Label ID="Label3" runat="server"></asp:Label>
                <br />
&nbsp;&nbsp;
                <asp:CheckBox ID="CheckBox3" runat="server" AutoPostBack="True" 
                    oncheckedchanged="CheckBox3_CheckedChanged" />
&nbsp;&nbsp;&nbsp; 19:00<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="style29">
                &nbsp;<asp:Label ID="kalkvar3" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="style22">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label6" runat="server" Text="45 TL"></asp:Label>
            </td>
            <td class="style23">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label9" runat="server" Text="25 TL"></asp:Label>
            </td>
        </tr>
    </table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Devam" Width="87px" cssclass="btn"/>

    
</asp:Content>
