<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP_TemperatureConversion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label3" runat="server" Text="Celsius and Fahrenheit Converter" BackColor="#0099FF" BorderColor="#003366" BorderStyle="Dotted" Font-Underline="True" ForeColor="#FFFF99" Height="41px" Width="425px"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Enter Celsius Temperature:"></asp:Label>


            <asp:TextBox ID="tb_c1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter Fahrenheit Temperature:"></asp:Label>


            <asp:TextBox ID="tb_fhnt1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Convert" runat="server" Text="Convert Cels to Fahr" OnClick="Convert_Click" />
            
            <asp:Button ID="Convert2" runat="server" Text="Convert Fahr to Cels" OnClick="Convert2_Click" />
            <br />
        </div>
    </form>
</body>
</html>
