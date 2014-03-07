<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebRole1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.1.0/css/bootstrap.min.css">
    <meta charset="utf-8">
    <title>Search request</title>
    <script type="text/javascript">


    </script>
    <script src="http://code.jquery.com/ui/1.9.2/jquery-ui.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="row">
        <div class="col-lg-6 col-lg-offset-3">
            <div class="input-group">
                <input type="text" class="form-control" name="input" id="input" value="" />
                <span class="input-group-btn">
                    <button class="btn btn-default" type="button" onclick="testJson()">Go!</button>
                </span>
            </div>
        </div>
    </div>
    </form>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
    <script src="//netdna.bootstrapcdn.com/bootstrap/3.1.0/js/bootstrap.min.js"></script>
</body>
</html>
