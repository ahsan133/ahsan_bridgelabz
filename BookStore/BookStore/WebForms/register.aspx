<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="BookStore.WebForms.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="utf-8" />
    <title>Register</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"/>
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
</head>
<body style="background-image: url('/Images/background.jpg'); 
    width: 100%;  background-repeat:no-repeat; background-size:100% 125%, cover;">

      <nav class="navbar">  
        <div class="container-fluid">   
            <div class="navbar-header">  
                
                <asp:Image CssClass="img" ImageUrl="/Images/Book.png" runat="server"/>
                <div class="navbar-brand">Book Store</div>  
            </div>  

            <div class="nav">   
                <div onclick="login()" class="active">Login</div>  
            </div>  
        </div>  
    </nav> 

    <form id="form1" runat="server" >
      
        <div class="userInfo" id="displayReg">
             <asp:Panel ID="pan" runat="server" CssClass="pannel" >
                 <h4 class="heading">Register:</h4>
            <div class="name"> 
            <asp:TextBox ID="FName" class="textBox" placeholder="First Name" runat="server"></asp:TextBox>
            <asp:TextBox ID="LName" class="textBox" placeholder="Last Name" runat="server"></asp:TextBox>
             </div>

            <asp:TextBox ID="Email" class="textBox" placeholder="Email" runat="server"></asp:TextBox>
   
            <asp:TextBox ID="Password" class="textBox" placeholder="Password" runat="server"></asp:TextBox>

            <asp:Button ID="btn" class="btn" Text="Register" runat="server" />
            </asp:Panel>
        </div>
       
    </form>
</body>
</html>

<script type="text/javascript">
    $('#btn').click(function () {
        var data = {
            FirstName: $('#FName').val(),
            LastName: $('#LName').val(),
            Email: $('#Email').val(),
            Password: $('#Password').val()
        };
        $.ajax({
            type: "POST",
            url: "https://localhost:44341/Account/Register",
            data: JSON.stringify(data),
            contentType: "application/json; charset=utf-8",
            dataType: "Json",
            processData: true,
            success: function (data) {
                window.location.href = "https://localhost:44341/WebForms/Login.aspx";
            },
            error: function (data) {
               alert("error occured");
            }
        });
        return false;   
    });

    function login() {
        window.location.href = "https://localhost:44341/WebForms/Login.aspx";
    }
    </script>

<style>
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
     }

     .active{
         cursor: pointer;
     }

     .active:hover{
         color:blue;
     }

    .heading {
        display: flex;
        justify-content: center;
        font-weight: 400;
        margin-top: 5px;
    }
    .img {
        height: 3em;
        width: 3em;
    }

    .navbar-brand {
        padding-left: 10px;
    }

    .userInfo {
        display: grid;
        justify-content: center;
        margin-top: 5em;
    }
    .pannel {
        display: grid;
        justify-content: center;
        align-items: center;
        border-width: 1px;
        border-style: Solid;
        width: 25em;
        height: 25em;
        border-color: lightgray;
        border-radius: 5px;
    }
    .textBox {
        border-radius: 4px;
        border: 0.8px solid;
        height: 2.5em;
        padding-left: 4px;
        border-color: lightgray;
        outline:none;
    }
    .btn {
        border: 2px solid;
        width: 8em;
        border-color: lightslategrey;
        background-color: lightblue;
        outline: none;
    }
 </style>
