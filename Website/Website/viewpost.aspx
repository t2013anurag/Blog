<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewpost.aspx.cs" Inherits="Website.view" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View</title>
      <link rel="stylesheet" href="materialize.min.css" />
    <style>
        .row .col {
            float: left;
            box-sizing: border-box;
            padding: 0 17.75rem;
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
       <asp:ListView ID="ListView1" runat="server">
            <ItemTemplate>
                <tr runat="server">
                  <td runat="server"> 
                   <asp:Label ID="NameLabel" runat="server" />
                   <div class="row">
                    <div class="col s12 m12">
                        <div class="card blue-grey darken-1">
                                <div class="card-content white-text">
                                    <span class="card-title"><%#Eval("author") %></span>
                                    <h6 id="title1" runat="server"><%#Eval("title") %></h6>
                                    <p runat="server"><%#Eval("description") %></p><br><br>
                                </div>
                            </div>
                        </div>
                    </div>
                  </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </form>
</body>
</html>
