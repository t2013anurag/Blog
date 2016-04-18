<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Website.WebForm2" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
     <link rel="stylesheet" href="materialize.min.css" />
    <style>
        .row {
                padding: 16%;
        }
        #Button1 {
                left: 417px;
                margin-top: 50px;
        }
        #Label1 {
                color :#ee6e73;
                font-weight: 300;
                font-size : 26px;
        }
    </style>
    <script type="text/javascript" src="materialize.min.js"></script>
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
    <div class="row col s12 m6">
        <form id="form1" runat="server">
            <div>
                <asp:Label ID="Label1" runat="server"></asp:Label>   
            </div>
            <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>   
            <p>
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <asp:Button ID="Button1" runat="server" Text="Login" CssClass="waves-effect waves-light btn" OnClick="Button1_Click" />
        </form>
    </div>
</body>
</html>
