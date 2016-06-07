<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LogIn.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style>
        div.banner {
            border: 5px solid black;
            padding: 50px;
            margin: 30px;
        
        }

    </style>

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script src="http://ajax.googleapis.com/ajax/libs/angularjs/1.4.8/angular.min.js"></script>
    <div class="banner" style="text-align:center"> INSERT BANNER HERE </div>
    <div style="text-align:center" ng-app="app" ng-controller="controller">
      <p style="text-align:center"> username : <input type="text" id="user" ng-model="username" placeholder="Enter Username"></p>
        <p style="text-align:center"> password : <input type="password" id="pass" ng-model="password" placeholder=""></p>
        <button style="text-align:center" ng-click="logIn('MemberPage.aspx')" > Log In</button>
        <p style="text-align:center">{{ username }} </p>
            <p style="text-align:center"> Welcome to {{ title }} </p>
    </div>
    <script src="scripts/controller.js"></script>
</body>
</html>
