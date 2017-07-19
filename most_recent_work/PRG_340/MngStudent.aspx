<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MngStudent.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        #Table1 {
            height: 136px;
            width: 960px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphStudent" Runat="Server">
     Enter Student&nbsp
    <table>
                <tr>
                    <td>Student ID</td>
                    <td>First Name</td>
                    <td>Last Name</td>
                    <td>Phone Number</td>
                    <td>Email</td>
                    <td>GPA</td>
<%--                    <td>Shift</td>


                    <td>Program Code</td>--%>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="s_id" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="s_firstName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="s_lastName" runat="server"></asp:TextBox>
                    </td>
                      <td>
                        <asp:TextBox ID="s_phoneNumber" runat="server"></asp:TextBox>
                    </td>
                     <td>
                        <asp:TextBox ID="s_email" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="s_gpa" runat="server"></asp:TextBox>
                    </td>
                     </tr>
      </table>

</asp:Content>

    <asp:Content ID="Content3" ContentPlaceHolderID="cphMain" Runat="Server">

        <table ID="tblStudent">
                    <tr>
                        <td>Student ID</td>
                        <td>First Name</td>
                        <td>Last Name</td>
                        <td>Phone Number</td>
                        <td>Email</td>
                        <td>GPA</td>
                    </tr>                         
        </table>

    </asp:Content>

