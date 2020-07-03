<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ToolBar.aspx.cs" Inherits="BookStore.WebForms.ToolBar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="utf-8" />
    <title>Book Store</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"/>
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
</head>
<body>
    <nav class="navbar">  
        <div class="container-fluid">  
            <div class="navbar-header">  
                 <asp:Image CssClass="img1" ImageUrl="/Images/menu.png" onclick="openSideNav()" runat="server"/>
                <asp:Image CssClass="img" ImageUrl="/Images/Book.png" runat="server"/>
                <div class="navbar-brand">Book Store</div>  
            </div>  

            <div class="nav">  
                <div class="active">Register</div>  
                <div >Login</div>  
            </div>  
        </div>  
    </nav>  

     <div id="side-bar" class="side-nav">  
                        <ul>  
                            <li>  
                                <a href="#">Home</a>  
                            </li>  
                            <li>  
                                <a href="#">About</a>  
                            </li>  
                            <li>  
                                <a href="#">Contacts</a>  
                            </li>  
                            <li>  
                                <a href="#">Help</a>  
                            </li>  
                        </ul>  
                    </div>  
     <div id="body-content"> Body Content here </div>
     
</body>
</html>


<script type="text/javascript">
    function openSideNav() {
        var sideBarDisplay = document.getElementById("side-bar").style.width;
        if (sideBarDisplay == "250px") {
            document.getElementById("side-bar").style.width = "0px";
            document.getElementById("body-content").style.marginLeft = "0px";
        } else {
            document.getElementById("side-bar").style.width = "250px";
            document.getElementById("body-content").style.marginLeft = "250px";
        }
    }

</script>



 <style>
     .side-nav {
         height: 100%;
         position: fixed;
         width: 0px;
         top: 48px;
         left: 0;
         bottom: 0; 
         background-color: #d3d3d3;
         transition: 0.6s;
     }
     .side-nav ul {
         padding: 0;
         list-style: none;
         margin: 0;
     }    

     .side-nav ul li {
          background-color: grey;
          cursor: pointer;
          border-radius: 2px;
          margin: 2px;
          padding: 5px 0px;
          text-align: center;       
     }        

     .side-nav ul li:hover {
          background-color: #008080;
     }

     .side-nav ul li a {
          text-decoration: none;
          color: #f9f9f9;
     }

     #body-content {
         position: absolute;
         top: 58px;
         transition: margin-left 0.6s;
     }

     .container-fluid
     {
         background-color:aqua;
         height: 3em;
     }
     .navbar
     {
         padding:0px;
     }
     .nav
     {
         display: flex;
         flex-direction: initial;
         padding-right: 30px;
     }
     .active {
         padding-right: 2em;
     }
     .img {
         height: 3em;
         width: 3em;
     }
     .img1 {
         height: 23px;
         width: 26px;
         margin-right:20px;
     }
     .navbar-brand{
         padding-left: 10px;
     }
 </style>