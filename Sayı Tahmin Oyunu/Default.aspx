<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblHak" runat="server" Text="Kalan Hak : "></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TxSayi" runat="server"></asp:TextBox>
        <asp:Button ID="btnTahmin" runat="server" Text="Tahmin" OnClick="btnTahmin_Click"  />
        <asp:Button ID="btnRestart" runat="server" Text="Yeniden Başlat" Enabled="false" OnClick="btnRestart_Click" />
        <br />
        <br />
        <asp:Label ID="lblDurum" runat="server" Text="Label"></asp:Label>
    
        <br />
        <asp:Label ID="SonTahmin" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
