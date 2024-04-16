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
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script> 

    <script type="text/javascript">
        $(document).ready(function () {
            $('#btnSave').click(function () {
                var Name = $('#txtName').val();
                var Age = $('#txtAge').val();
                var dept = $('#ddl').val();

                if (Name == "" || Name == null) {
                    alert("Enter your Name");
                    return false;
                }
                if (Age == "" || Age == null) {
                    alert("Enter your Age");
                    return false;
                }
                if (dept == "" || dept == null) {
                    alert("Enter your dept");
                    return false;
                }                
            });
        });
    </script>
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
                        <asp:Label ID="lblAge" runat="server" Text="Age"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDept" runat="server" Text="Department"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddl" runat="server">
                            <asp:ListItem Value="0">--</asp:ListItem>
                            <asp:ListItem Value="1">Dev</asp:ListItem>
                            <asp:ListItem Value="2">HR</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right">
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                    </td>
                </tr>
            </table>
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
        </div>
    </form>
</body>
</html>
