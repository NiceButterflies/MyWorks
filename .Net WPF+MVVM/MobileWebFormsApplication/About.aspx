<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="MobileWebFormsApplication.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2>Statistics</h2>
        <h4>   
            <asp:RadioButton ID="OS" GroupName="RB" runat="server" Text="Количество людей, использующих определенную ОС"   /> 
            <br /><br />
             <asp:RadioButton ID="Read" GroupName="RB" runat="server" Text="Сколько людей использует телефон для чтения?" /> 
            <br /><br />
            <asp:RadioButton ID="Price" GroupName="RB" runat="server" Text="Средняя цена, которую готовы заплатить люди за новый телефон"  /> 
            <br /><br />
         
    <br />
    <asp:Label ID="Info" runat="server"></asp:Label><br />
            <asp:Label ID="Info1" runat="server"></asp:Label><br />
            <asp:Label ID="Info2" runat="server"></asp:Label><br />
            <asp:Label ID="Info3" runat="server"></asp:Label>
    <br />
    <br />
     <asp:Button ID="Statistika" runat="server" Text="Результаты" OnClick="Statistika_Click" />
    <br /></h4> 
     

      
</asp:Content>