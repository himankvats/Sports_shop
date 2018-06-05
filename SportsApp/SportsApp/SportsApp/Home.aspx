<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SportsApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" href="StyleSheet1.css" />
    <style type="text/css">
        .auto-style1 {
            width: 477px;
        }
        .auto-style2 {
            width: 2px;
        }
        .auto-style3 {
            width: 22px;
        }
        .auto-style4 {
            width: 464px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <header> 
        <div class="header_top">
             
           </div>
        <div class="header_bottom">
             <h1 style="text-align:center ;color:white">HighSports Inventory Search Site</h1>
        </div>
    </header>
    <div id="main">

        <br />

        <br />
    <div id="Left_content">
        <br />
        <ul>
        </ul>
         
       </div>
       <div id="right_content">
           <br />
           <h3>Search</h3>
           <table style="width:100%">
               <tr>
                   <td class="auto-style1"></td>
                   <td class="auto-style3"></td>
                   <td class="auto-style2"></td>
                   <td></td>
               </tr>
               <tr>
                   <td class="auto-style1">
                       <asp:DropDownList ID="DropDownList1" runat="server" Height="30px" Width="200px">
                           <asp:ListItem Value="ProductID">By Product ID</asp:ListItem>
                           <asp:ListItem Value="ProductName">By Product Name</asp:ListItem>
                       </asp:DropDownList>
                   </td>
                   <td class="auto-style3"></td>
                   <td class="auto-style2"></td>
                   <td></td>
               </tr>
            <tr>
                   <td class="auto-style1"><br /> 
                       <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                       <br /></td>
                   <td class="auto-style3"></td>
                   <td class="auto-style2"></td>
                   <td></td>
               </tr>
                 <tr>
                   <td class="auto-style1"></td>
                   <td class="auto-style3"></td>
                   <td class="auto-style2"></td>
                   <td></td>
               </tr>
               <tr>
                   <td class="auto-style1">
                       <asp:TextBox ID="TextBox2" runat="server" Width="400px" Height="30px"></asp:TextBox>
                   </td>
                   
                   <td colspan="1">
                       <asp:Button ID="Button1" runat="server" Text="At Store" Height="30px" OnClick="Button1_Click" Width="250px" />
                   </td>
                   <td class="auto-style4">
                       <asp:Button ID="Button2" runat="server" Text="At Warehouse" Height="30px" OnClick="Button2_Click" Width="250px" />
                   </td>
                   <td>
                       &nbsp;</td>
               </tr>
               <tr>
                   <td class="auto-style1"></td>
                   <td class="auto-style3"></td>
                   <td class="auto-style2"></td>
                   <td></td>
               </tr>
               <tr>
                   <td class="auto-style1">
                       <asp:GridView ID="GridView1" runat="server" Width="393px">
                       </asp:GridView>
                   </td>
                   <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       </td>
                   <td class="auto-style2">
                       &nbsp;</td>
                   <td></td>
               </tr>
           </table>

       </div>
    <div class="push"></div>
    </div>
    <footer class="footer"> <h5 style="text-align:center"> copyright @ HighSports Inventory Search System</h5>    
  
       </footer>
      
    </form>
</body>
</html>