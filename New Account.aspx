<%@ Page Title="" Language="C#" MasterPageFile="~/Bank.Master" AutoEventWireup="true" CodeBehind="New Account.aspx.cs" Inherits="Bank.New_Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">


    .auto-style6 {
        width: 43%;
        height: 304px;
    }
    .auto-style7 {
        width: 390px;
        text-align: justify;
        font-size: large;
    }
    .auto-style5 {
        width: 412px;
    }
    .auto-style10 {
        width: 412px;
        text-align: left;
    }
    .auto-style4 {
        width: 390px;
        font-size: large;
    }
    .auto-style8 {
        font-size: large;
    }
    .auto-style9 {
        font-size: large;
        font-weight: bold;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" class="auto-style6">
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7"><strong>Name</strong></td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style10">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Please Enter Name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7"><strong>Password</strong></td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style10">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Please Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7"><strong>Confirm Password</strong></td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style10">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Please Enter Confirm Password" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="*Password and Confirm Password must be same" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        >
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style10">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7"><strong>Amount</strong></td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style10">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox7" ErrorMessage="*Please Enter amount while creating a new account" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7"><strong>Address</strong></td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7"><strong>Mobile No</strong></td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style10">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox6" ErrorMessage="*Please Enter proper phone number" ForeColor="Red" ValidationExpression="[6-9]{1}[0-9]{9}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8" colspan="2"><strong>
                <asp:Button ID="Button1" runat="server" CssClass="auto-style9" Text="Submit" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" CssClass="auto-style9" Text="Clear" OnClick="Button2_Click" />
                <br />
                <br />Your Account Number is...<asp:GridView ID="GridView1" runat="server" Height="52px" Width="200px">
                </asp:GridView>
                </strong></td>
        </tr>
    </table>
</asp:Content>
