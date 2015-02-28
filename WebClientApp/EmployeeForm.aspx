<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeForm.aspx.cs" Inherits="WebClientApp.EmployeeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:DropDownList ID="lstename" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lstename_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>EmpNo</td>
                <td>
                    <asp:TextBox ID="eno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>EmpName</td>
                <td>
                    <asp:TextBox ID="ename" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Salary</td>
                <td>
                    <asp:TextBox ID="sal" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>DeptName</td>
                <td>
                    <asp:TextBox ID="dname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Designation</td>
                <td>
                    <asp:TextBox ID="desig" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Tax to be paid on Salary</td>
                <td>
                    <asp:TextBox ID="tax" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="msg" runat="server" Text=""></asp:Label>
                </td>
                <td>
                    <table style="width:100%;">
                        <tr>
                            <td>
                                <asp:Button ID="new" runat="server" Text="New" OnClick="new_Click" />
                            </td>
                            <td>
                                <asp:Button ID="save" runat="server" Text="Save" OnClick="save_Click" />
                            </td>
                            <td>
                                <asp:Button ID="delete" runat="server" Text="Delete" OnClick="delete_Click" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
    </div>
        <table style="width:100%;">
            <tr>
                <td>
        <asp:GridView ID="gdvemp" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" style="margin-left: 60px">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
                </td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FFF1D4" />
                        <SortedAscendingHeaderStyle BackColor="#B95C30" />
                        <SortedDescendingCellStyle BackColor="#F1E5CE" />
                        <SortedDescendingHeaderStyle BackColor="#93451F" />
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="gettax" runat="server" Text="Get Tax" OnClick="gettax_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
