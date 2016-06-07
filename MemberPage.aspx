<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberPage.aspx.cs" Inherits="LogIn.MemberPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        WELCOME!
    </div>
        <?php
            
            $var = $_POST['username'];
            echo "<script type="text/javascript">alert($var);</script>";
            
            ?>;
    </form>
</body>
</html>
