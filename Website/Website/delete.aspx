<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="Website.viewpost"  EnableEventValidation="false"%>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Post</title>
    <link rel="stylesheet" href="materialize.min.css" />
    <style>
        .row .col {
            float: left;
            box-sizing: border-box;
            padding: 0 17.75rem;
        }
        #Label1 {
                color :#ee6e73;
                font-weight: 300;
                font-size : 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
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
    </div>
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" enableEventValidation="false" OnRowDataBound="OnRowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
               <asp:BoundField DataField="author" HeaderText="Author" ItemStyle-Width="150" />
               <asp:BoundField DataField="title" HeaderText="Title" ItemStyle-Width="150" />
               <asp:BoundField DataField="description" HeaderText="Description" ItemStyle-Width="150" />
            </Columns>
         </asp:GridView> 
        <asp:LinkButton ID="lnkDummy" runat="server"></asp:LinkButton>
    </form>
 <asp:Label ID="Label1" runat="server"></asp:Label>
</body>
</html>
