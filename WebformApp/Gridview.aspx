<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gridview.aspx.cs" Inherits="WebformApp.Gridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <script type="text/javascript">
function basicPopup() 
{
    popupWindow = window.open("https://localhost:44326/WebForm1.aspx",'popUpWindow', 'height=300,width=600,left=100,top=30');
}
    </script>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblb" Text="Name" runat="server"></asp:Label>
            <asp:GridView ID="grdview" runat="server" AutoGenerateColumns="false" DataKeyNames="ID" OnRowEditing="grdview_RowEditing" OnRowUpdating="grdview_RowUpdating" OnRowDeleting="grdview_RowDeleting" OnRowCancelingEdit="grdview_RowCancelingEdit" AllowPaging="true" PageSize="5" OnPageIndexChanging="grdview_PageIndexChanging">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Age" HeaderText="Age" />
                    <asp:BoundField DataField="Department" HeaderText="Department" />
                    <asp:CommandField ShowEditButton="true" ShowDeleteButton="true" />
                   
                </Columns>
            </asp:GridView>
            <asp:Button ID="btnAddNew" runat="server" Text="Add New" OnClick="btnAddNew_Click" />
            <asp:Button ID="Button2" runat="server" Text="Popup" OnClientClick="basicPopup();return false;" />
        </div>
    </form>
</body>
</html>
