<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RegistrationForm.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<body>
    <form id="formRegister" runat="server">
        <div>
            <asp:Label ID="LabelFirstName" runat="server" Text="First Name" AssociatedControlID="TextBoxFirstName" />
            <asp:TextBox ID="TextBoxFirstName" runat="server" />
            <br />
            <asp:Label ID="LabelLastName" runat="server" Text="Last Name" AssociatedControlID="TextBoxLastName" />
            <asp:TextBox ID="TextBoxLastName" runat="server" />
            <br />
            <asp:Label ID="LabelFacultyNumber" runat="server" Text="Faculty Number" AssociatedControlID="TextBoxFacultyNumber" />
            <asp:TextBox ID="TextBoxFacultyNumber" runat="server" />
            <br />
            <asp:Label ID="LabelUniversity" runat="server" AssociatedControlID="DropDownListUniversity" Text="University" />
            <asp:DropDownList ID="DropDownListUniversity" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Label ID="LabelSpeciality" runat="server" AssociatedControlID="DropDownListSpeciality" Text="Speciality" />
            <asp:DropDownList ID="DropDownListSpeciality" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Label ID="LabelCourses" runat="server" Text="Courses" />
            <asp:ListBox ID="ListBoxCourses" runat="server" SelectionMode="Multiple" />
            <br />
            <asp:Button ID="ButtonSubmit" runat="server" OnClick="ButtonSubmit_Click" Text="Submit" />

            <hr />
            <asp:Panel ID="PanelResult" runat="server" />
        </div>
    </form>
</body>
</html>
