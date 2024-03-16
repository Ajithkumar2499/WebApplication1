<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebformApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        td{
            border:1px solid;
        }
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <colgroup>
                    <col style="width:100px" />
                    <col style="width:100px" />
                </colgroup>
                <tr>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDOB" runat="server" Text="DOB"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
