<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginWebFrom.aspx.cs" Inherits="LabAss5.LoginWebFrom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCaption" runat="server" Text="Please Log On" Font-Bold="True" Font-Italic="True"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label><asp:TextBox runat="server" ID="txtUsername"></asp:TextBox><asp:RequiredFieldValidator runat="server" ControlToValidate="txtUsername" ErrorMessage="Invaild Username"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label><asp:TextBox runat="server" ID="txtPassword"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="Invalid Password" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Sumbit" OnClick="btnSumbit" /><asp:GridView runat="server" DataSourceID="SqlDataSource1" ID="GridView1" OnSelectedIndexChanged="Unnamed3_SelectedIndexChanged" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName"></asp:BoundField>
                    <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password"></asp:BoundField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource runat="server" ConnectionString="<%$ ConnectionStrings:SimpleDatabseConnectionString %>" SelectCommand="SELECT [UserName], [Password] FROM [Logon]" ID="SqlDataSource1"></asp:SqlDataSource>
        </div>
        
    </form>
</body>
</html>
