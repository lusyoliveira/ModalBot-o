<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<%@ Register assembly="FreeTextBox" namespace="FreeTextBoxControls" tagprefix="FTB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Você deseja salvar?<br />
        <br />
                <asp:Button ID="btnSim" runat="server" onclick="btnSim_Click" Text="Sim" 
                    ToolTip=" " />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnNao" runat="server" Text="Não" 
            onclick="btnNao_Click" />
        <br />
        <br />
        <FTB:FreeTextBox ID="FreeTextBox1" runat="server">
        </FTB:FreeTextBox>
        <br />
    
    </div>
    </form>
</body>
</html>
