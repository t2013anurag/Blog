<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createpost.aspx.cs" Inherits="Website.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Post</title>
     <link rel="stylesheet" href="materialize.min.css" />
    <style>
        #form1 {
            padding : 7%;
        }
        textarea {
            height : 12rem;
        }
     
    </style>
</head>
<body>
     <nav>
        <div class="nav-wrapper">
          <a href="#" class="brand-logo">My Blog</a>
          <ul id="nav-mobile" class="right hide-on-med-and-down">
            <li><a href="login.aspx">Login</a></li>
            <li><a href="createpost.aspx">Create</a></li>
            <li><a href="viewpost.aspx">View</a></li>
            <li><a href="delete.aspx">Delete</a></li>
          </ul>
        </div>
    </nav>
    <form id="form1" runat="server">
    <div>  
        <asp:Label ID="Label4" runat="server"></asp:Label>  
    </div>
        <asp:Label ID="Label1" runat="server" Text="Your Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Title"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
            <textarea id="TextArea1" runat="server" cols="20" name="S1" rows="7"></textarea></p>
        <p>

        <asp:Button ID="Button1" runat="server" CssClass="waves-effect waves-light btn" OnClick="Button1_Click" Text="Create Blog" />
        </p>
    </form>
    </body>
</html>
